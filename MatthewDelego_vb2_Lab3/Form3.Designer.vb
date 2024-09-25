<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WordScrambleGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WordScrambleGame))
        lblStatus = New Label()
        lblScrambledWord = New Label()
        lblTriesleft = New Label()
        txtUserGuess = New TextBox()
        btnSubmit = New Button()
        btnRestart = New Button()
        lblAdminSolution = New Label()
        MenuStrip2 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewUserToolStripMenuItem = New ToolStripMenuItem()
        EndGameToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        AboutUserToolStripMenuItem = New ToolStripMenuItem()
        lstMissedWords = New ListBox()
        Label1 = New Label()
        MenuStrip2.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.BorderStyle = BorderStyle.FixedSingle
        lblStatus.Font = New Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblStatus.Location = New Point(261, 71)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(2, 32)
        lblStatus.TabIndex = 3
        ' 
        ' lblScrambledWord
        ' 
        lblScrambledWord.BorderStyle = BorderStyle.FixedSingle
        lblScrambledWord.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblScrambledWord.Location = New Point(48, 196)
        lblScrambledWord.Name = "lblScrambledWord"
        lblScrambledWord.Size = New Size(239, 37)
        lblScrambledWord.TabIndex = 4
        lblScrambledWord.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTriesleft
        ' 
        lblTriesleft.BorderStyle = BorderStyle.FixedSingle
        lblTriesleft.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTriesleft.Location = New Point(536, 153)
        lblTriesleft.Name = "lblTriesleft"
        lblTriesleft.Size = New Size(239, 37)
        lblTriesleft.TabIndex = 5
        lblTriesleft.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtUserGuess
        ' 
        txtUserGuess.BackColor = Color.AliceBlue
        txtUserGuess.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtUserGuess.Location = New Point(48, 280)
        txtUserGuess.Name = "txtUserGuess"
        txtUserGuess.Size = New Size(239, 29)
        txtUserGuess.TabIndex = 6
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmit.Location = New Point(48, 436)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(239, 73)
        btnSubmit.TabIndex = 7
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' btnRestart
        ' 
        btnRestart.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRestart.Location = New Point(536, 436)
        btnRestart.Name = "btnRestart"
        btnRestart.Size = New Size(239, 75)
        btnRestart.TabIndex = 8
        btnRestart.Text = "Restart"
        btnRestart.UseVisualStyleBackColor = True
        ' 
        ' lblAdminSolution
        ' 
        lblAdminSolution.BackColor = Color.Transparent
        lblAdminSolution.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAdminSolution.Location = New Point(556, 24)
        lblAdminSolution.Name = "lblAdminSolution"
        lblAdminSolution.Size = New Size(244, 37)
        lblAdminSolution.TabIndex = 9
        lblAdminSolution.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, AboutToolStripMenuItem})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Size = New Size(800, 24)
        MenuStrip2.TabIndex = 10
        MenuStrip2.Text = "MenuStrip2"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewUserToolStripMenuItem, EndGameToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NewUserToolStripMenuItem
        ' 
        NewUserToolStripMenuItem.Name = "NewUserToolStripMenuItem"
        NewUserToolStripMenuItem.Size = New Size(128, 22)
        NewUserToolStripMenuItem.Text = "New User"
        ' 
        ' EndGameToolStripMenuItem
        ' 
        EndGameToolStripMenuItem.Name = "EndGameToolStripMenuItem"
        EndGameToolStripMenuItem.Size = New Size(128, 22)
        EndGameToolStripMenuItem.Text = "End Game"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutUserToolStripMenuItem})
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(52, 20)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' AboutUserToolStripMenuItem
        ' 
        AboutUserToolStripMenuItem.Name = "AboutUserToolStripMenuItem"
        AboutUserToolStripMenuItem.Size = New Size(133, 22)
        AboutUserToolStripMenuItem.Text = "About User"
        ' 
        ' lstMissedWords
        ' 
        lstMissedWords.BackColor = Color.WhiteSmoke
        lstMissedWords.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstMissedWords.FormattingEnabled = True
        lstMissedWords.ItemHeight = 17
        lstMissedWords.Location = New Point(536, 207)
        lstMissedWords.Name = "lstMissedWords"
        lstMissedWords.Size = New Size(239, 208)
        lstMissedWords.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(544, 234)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 12
        ' 
        ' WordScrambleGame
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 514)
        Controls.Add(Label1)
        Controls.Add(lstMissedWords)
        Controls.Add(MenuStrip2)
        Controls.Add(lblAdminSolution)
        Controls.Add(btnRestart)
        Controls.Add(btnSubmit)
        Controls.Add(txtUserGuess)
        Controls.Add(lblTriesleft)
        Controls.Add(lblScrambledWord)
        Controls.Add(lblStatus)
        DoubleBuffered = True
        Name = "WordScrambleGame"
        Text = "Word Scramble"
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblStatus As Label
    Friend WithEvents lblScrambledWord As Label
    Friend WithEvents lblTriesleft As Label
    Friend WithEvents txtUserGuess As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnRestart As Button
    Friend WithEvents lblAdminSolution As Label
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EndGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstMissedWords As ListBox
    Friend WithEvents Label1 As Label
End Class
