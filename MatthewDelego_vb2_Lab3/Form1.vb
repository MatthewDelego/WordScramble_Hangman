Public Class Form1

    Private userName As String = String.Empty

    ' Parameterless constructor for startup
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Initialize userName to an empty string or a default value
        UpdateStatusBarWithUserName()
    End Sub

    ' Method to update the userName and status bar
    Public Sub SetUserName(ByVal name As String)
        userName = name
        UpdateStatusBarWithUserName()
        ' Enable the game buttons when a user name is set
        btnScrambleGame.Enabled = True
        btnHangManGame.Enabled = True
    End Sub

    Private Sub UpdateStatusBarWithUserName()
        If String.IsNullOrEmpty(userName) Then
            lblStatus.Text = "No registered user. Please select login from the menu to play."
        Else
            lblStatus.Text = "Welcome, " & userName
        End If
    End Sub

    ' This event is triggered when the form loads.
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable the game buttons initially
        btnScrambleGame.Enabled = False
        btnHangManGame.Enabled = False
    End Sub

    ' Event handler for "About" menu item.
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        If String.IsNullOrEmpty(userName) Then
            MessageBox.Show("No registered user. Please select login.", "User Not Registered", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' This message box will display both the information about the game and the user's name
            MessageBox.Show("Word Games Lab3 Herzing College" & Environment.NewLine &
                        "Created by Matthew Delego" & Environment.NewLine &
                        "Welcome, " & userName, "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    ' Event handler for "End Game" menu item.
    Private Sub EndGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndGameToolStripMenuItem.Click
        ' This will close the application.
        Application.Exit()
    End Sub

    ' Event handler for "New User" menu item.
    Private Sub NewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewUserToolStripMenuItem.Click
        Dim loginForm As New LoginForm()
        loginForm.SetOwnerForm(Me)
        loginForm.Show()
        Me.Hide() ' Optionally hide this form
    End Sub

    Private Sub btnScrambleGame_Click(sender As Object, e As EventArgs) Handles btnScrambleGame.Click
        ' Pass both the username and a reference to this instance of Form1
        Dim wordScrambleGameForm As New WordScrambleGame(userName, Me)
        wordScrambleGameForm.Show()
    End Sub

    Private Sub btnHangManGame_Click(sender As Object, e As EventArgs) Handles btnHangManGame.Click
        ' Open the Hangman Game form and pass the userName to it.
        Dim hangmanGameForm As New HangManGame(userName, Me) ' Make sure this constructor exists in HangmanGame.
        hangmanGameForm.Show()
    End Sub
End Class
