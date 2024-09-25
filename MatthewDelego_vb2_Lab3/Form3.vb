Imports System.IO

Public Class WordScrambleGame
    Inherits Form

    Private user As String
    Private wordBank As New List(Of String)()
    Private currentWord As String
    Private scrambledWord As String
    Private triesLeft As Integer
    Public Property OwnerForm As Form1

    ' Constructor
    Public Sub New(passedUserName As String, mainForm As Form1)
        ' This call is required by the designer.
        InitializeComponent()
        ' Set the user's name passed from Form1.
        user = passedUserName
        ' Save the reference to Form1.
        OwnerForm = mainForm
        ' Load words from the file into the word bank.
        LoadWordsFromFile()
    End Sub
    Private Sub LoadWordsFromFile()
        Try
            ' Path to the file on my pc. needs to be updated for users
            Dim theFileName = Path.Combine("C:\Users\matth\Downloads", "words.txt")
            If File.Exists(theFileName) Then
                Using stringFileReader As StreamReader = File.OpenText(theFileName)
                    Dim stringInputLine As String = stringFileReader.ReadLine()
                    Do Until stringInputLine Is Nothing
                        wordBank.Add(stringInputLine)
                        stringInputLine = stringFileReader.ReadLine()
                    Loop
                End Using
            Else
                MessageBox.Show("File not found: " & theFileName)
            End If
        Catch ex As Exception
            MessageBox.Show("There was an error reading the word bank file: " & ex.Message)
        End Try
    End Sub

    Private Sub StartNewGame()
        ' Reset the tries left
        triesLeft = 7 ' Or as many tries as you want to give the user
        lblTriesleft.Text = $"Tries Left: {triesLeft}"

        ' Before calling ScrambleWord, ensure there's a valid word to scramble.
        If wordBank IsNot Nothing AndAlso wordBank.Count > 0 Then
            currentWord = GetRandomWordFromBank()
            scrambledWord = ScrambleWord(currentWord)
            lblScrambledWord.Text = scrambledWord
        Else
            MessageBox.Show("The word bank is not initialized or is empty.")
        End If

        ' Clear the user input and missed words list
        txtUserGuess.Clear()

    End Sub

    Private Function GetRandomWordFromBank() As String
        ' Rreturn a random word or Nothing if the list is empty
        If wordBank.Count > 0 Then
            Dim rng As New Random()
            Return wordBank(rng.Next(wordBank.Count))
        Else
            Return Nothing
        End If
    End Function
    Private Sub WordScrambleGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Update label, with the user's name.
        lblStatus.Text = user
        StartNewGame() ' Start a new game when the form loads
        ' HIdden label
        AddHandler lblAdminSolution.MouseClick, AddressOf lblAdminSolution_MouseClick
    End Sub

    Private Function ScrambleWord(word As String) As String
        ' Convert the word to a character array
        Dim charArray As Char() = word.ToCharArray()
        ' Initialize the random number generator
        Dim rng As New Random()

        ' Go through the array and swap each character with another character at a random index
        For i As Integer = 0 To charArray.Length - 1
            ' Select a random index
            Dim randomIndex As Integer = rng.Next(charArray.Length)
            ' Swap the characters
            Dim temp As Char = charArray(i)
            charArray(i) = charArray(randomIndex)
            charArray(randomIndex) = temp
        Next

        ' Return the scrambled word as a new string
        Return New String(charArray)
    End Function

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

    ' Event handler for "About" menu item.
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' "About"  
        MessageBox.Show("Word Games Lab3 Herzing College" & Environment.NewLine &
                        "Created by Matthew Delego" & Environment.NewLine &
                        "Welcome, " & user, "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Event handler for "End Game" menu.
    Private Sub EndGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndGameToolStripMenuItem.Click
        ' Clear missed words list before closing the application
        lstMissedWords.Items.Clear()
        ' Close the entire application
        Application.Exit()
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        StartNewGame() ' Restart the game
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Check if the user's guess is not empty
        If String.IsNullOrWhiteSpace(txtUserGuess.Text) Then
            MessageBox.Show("Please enter a guess.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if the length of the user's guess matches the current word
        If txtUserGuess.Text.Length <> currentWord.Length Then
            MessageBox.Show($"The word has {currentWord.Length} characters, but you entered {txtUserGuess.Text.Length}.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Now check if the guess is correct
        If txtUserGuess.Text.Equals(currentWord, StringComparison.OrdinalIgnoreCase) Then
            ' Correct guess, start a new game
            MessageBox.Show("Correct! Starting new game.")
            StartNewGame()
        Else
            ' Incorrect guess, update tries left and add to missed words
            triesLeft -= 1
            lblTriesleft.Text = $"Tries Left: {triesLeft}"
            If triesLeft <= 0 Then
                lstMissedWords.Items.Add(currentWord)
                MessageBox.Show($"Incorrect! The correct word was: {currentWord}. Starting new game.")
                StartNewGame()
            End If
        End If
    End Sub


    Private Sub lblAdminSolution_MouseClick(sender As Object, e As MouseEventArgs) Handles lblAdminSolution.MouseClick
        ' Define the "secret" area as a rectangle, the top-right corner of the label
        Dim secretArea As New Rectangle(lblAdminSolution.Width - 50, 0, 50, lblAdminSolution.Height)

        ' Check if the click was within the secret area
        If secretArea.Contains(e.Location) Then
            ' The click was within the secret area, show the solution
            lblAdminSolution.Text = $"Solution: {currentWord}"
        Else
            ' The click was outside the secret area, clear the solution or take no action
            lblAdminSolution.Text = String.Empty
        End If
    End Sub


End Class
