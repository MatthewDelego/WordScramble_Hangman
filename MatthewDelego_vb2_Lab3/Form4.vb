Imports System.IO

Public Class HangManGame
    Inherits Form

    Private wordBank As New List(Of String)()
    Private currentWord As String
    Private displayWord As String
    Private triesLeft As Integer = 7
    Private user As String
    Private guessedLetters As New HashSet(Of Char)()
    Private ReadOnly basePath As String = "C:\Users\matth\Downloads\HangManImage"
    Private ReadOnly hangmanImages As String() = {
    "hangman_empty",
    "hangman_string",
    "hangman_head",
    "hangman_body",
    "hangman_1_arm",
    "hangman_2_arms",
    "hangman_1_leg",
    "hangman_whole"
}
    Public Property OwnerForm As Form1

    ' Constructor that accepts the username and a reference to Form1.
    Public Sub New(passedUserName As String, mainForm As Form1)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add KeyPress event handler to txtBoxUserEntry
        AddHandler txtBoxUserEntry.KeyPress, AddressOf txtBoxUserEntry_KeyPress
        ' Set the user's name passed from Form1.
        user = passedUserName

        ' Save the reference to Form1.
        OwnerForm = mainForm
    End Sub
    Private Sub HangManGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Update the label with the user's name.
        lblStatus.Text = user
        LoadWordsFromFile()
        StartNewGame()
        ' Hidden Admin label
        AddHandler lblAdminSolution.MouseClick, AddressOf lblAdminSolution_MouseClick
    End Sub

    ' Loading from the txt file
    Private Sub LoadWordsFromFile()
        Try
            Dim theFileName = Path.Combine("C:\Users\matth\Downloads", "words.txt") ' Replace with you path to images
            If File.Exists(theFileName) Then
                wordBank = File.ReadAllLines(theFileName).ToList()
            Else
                MessageBox.Show("File not found: " & theFileName)
            End If
        Catch ex As Exception
            MessageBox.Show("There was an error reading the word bank file: " & ex.Message)
        End Try
    End Sub

    Private Sub StartNewGame()
        If wordBank.Any() Then
            Dim rnd As New Random()
            currentWord = wordBank(rnd.Next(wordBank.Count))
            ' Initialize displayWord with underscores and spaces
            displayWord = String.Join(" ", Enumerable.Repeat("_", currentWord.Length))
            lblCharacters.Text = displayWord
            triesLeft = 7
            ' Clear the guessed letters
            guessedLetters.Clear()
            ' Update the labels
            lblTriesleft.Text = $"Tries Left: {triesLeft}"
            lblLettersUsed.Text = ""
            UpdateHangmanImage()
        Else
            MessageBox.Show("Word bank is empty!")
        End If
    End Sub

    Private Sub UpdateHangmanImage()
        ' Image index is based on how many tries are left. 7 tries correspond to the first image (hangman_empty).
        Dim imageIndex As Integer = 7 - triesLeft
        ' Ensure the index is within scope of the array.
        If imageIndex < 0 OrElse imageIndex >= hangmanImages.Length Then
            imageIndex = 0 ' Default to the empty hangman if out 
        End If
        Dim imageFileName As String = Path.Combine(basePath, $"{hangmanImages(imageIndex)}.jpg")

        Try
            ' Check if the file exists before attempting to load it
            If File.Exists(imageFileName) Then
                ' Dispose the previous image if any to free resources
                If PictureBox1.Image IsNot Nothing Then
                    PictureBox1.Image.Dispose()
                End If

                ' Load the new image from the file
                PictureBox1.Image = Image.FromFile(imageFileName)
            Else
                ' If the file doesn't exist, handle it appropriately, with error handling
                MessageBox.Show("Image file not found: " & imageFileName)
            End If
        Catch ex As Exception
            ' Handle exceptions that might occur during image loading
            MessageBox.Show("There was an error loading the hangman image: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateDisplayWord(guessedLetter As Char)
        Dim wordChars = currentWord.ToCharArray()
        ' Initialize a new display array with spaces
        Dim displayChars = Enumerable.Repeat("_ ", currentWord.Length).ToArray()

        For i As Integer = 0 To currentWord.Length - 1
            If wordChars(i) = guessedLetter Then
                ' Remove the trailing space when setting the guessed letter
                displayChars(i) = guessedLetter & " "
            ElseIf displayChars(i).Trim().Length = 0 Then
                ' Keep the underscore with a trailing space for the unguessed letters
                displayChars(i) = "_ "
            Else
                ' Keep the already guessed letters with their spaces
                displayChars(i) = displayWord(i * 2) & " "
            End If
        Next

        ' Convert the array back to a string and remove the last trailing space
        displayWord = String.Concat(displayChars).TrimEnd()
        lblCharacters.Text = displayWord
    End Sub

    ' Event handler for "About" menu item.
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' "About" functionality code
        MessageBox.Show("Word Games Lab3 Herzing College" & Environment.NewLine &
                        "Created by Matthew Delego" & Environment.NewLine &
                        "Welcome, " & user, "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Event handler for "New User" menu item in WordScrambleGame form.
    Private Sub NewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewUserToolStripMenuItem.Click
        ' Create a new instance of the LoginForm.
        Dim loginForm As New LoginForm()

        ' Pass the OwnerForm which is a reference to Form1.
        loginForm.SetOwnerForm(Me.OwnerForm)

        ' Show the LoginForm and hide the WordScrambleGame form.
        loginForm.Show()
        Me.Hide()
    End Sub

    ' Event handler for "End Game" menu item.
    Private Sub EndGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndGameToolStripMenuItem.Click
        ' Close the entire application
        Application.Exit()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim guess As String = txtBoxUserEntry.Text.ToLower()

        If Not String.IsNullOrWhiteSpace(guess) AndAlso guess.Length = 1 Then
            Dim guessedLetter As Char = Convert.ToChar(guess)

            If guessedLetters.Contains(guessedLetter) Then
                MessageBox.Show("You have already guessed this letter. Try a different one.")
                txtBoxUserEntry.Clear()
                Return
            End If

            guessedLetters.Add(guessedLetter)

            If currentWord.Contains(guessedLetter) Then
                UpdateDisplayWord(guessedLetter)
            Else
                triesLeft -= 1
                UpdateHangmanImage()
            End If

            lblTriesleft.Text = $"Tries Left: {triesLeft}"
            lblLettersUsed.Text = String.Join(", ", guessedLetters)

            If displayWord.Replace(" ", "") = currentWord Then
                MessageBox.Show("Congratulations! You've guessed the word!")
                StartNewGame()
            ElseIf triesLeft <= 0 Then
                MessageBox.Show($"You've run out of tries! The word was '{currentWord}'.")
                StartNewGame()
            End If
        Else
            MessageBox.Show("Please enter a single letter.")
        End If

        txtBoxUserEntry.Clear()
    End Sub


    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        StartNewGame()
    End Sub

    Private Sub txtBoxUserEntry_KeyPress(sender As Object, e As KeyPressEventArgs)
        ' Check if the character is a letter or another control character (like backspace)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If it's not a letter or control prevent the character from being entered
            e.Handled = True
            MessageBox.Show("Please enter only letters.")
        End If
    End Sub


    Private Sub lblAdminSolution_MouseClick(sender As Object, e As MouseEventArgs) Handles lblAdminSolution.MouseClick
        ' Define the "secret" area as a rectangle, the top-right corner of the label
        Dim secretArea As New Rectangle(lblAdminSolution.Width - 50, 0, 50, lblAdminSolution.Height)

        ' Check if the click was within the secret area
        If secretArea.Contains(e.Location) Then
            ' The click was within the secret area, show the solution
            lblAdminSolution.Text = $"Solution: {currentWord} "
        Else
            ' The click was outside the secret area, clear the solution or take no action
            lblAdminSolution.Text = String.Empty
        End If
    End Sub

End Class