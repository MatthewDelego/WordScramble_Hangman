<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HangManGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HangManGame))
        lblStatus = New Label()
        lblAdminSolution = New Label()
        btnSubmit = New Button()
        btnRestart = New Button()
        lblUsedLetters = New Label()
        lblLettersUsed = New Label()
        MenuStrip2 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewUserToolStripMenuItem = New ToolStripMenuItem()
        EndGameToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        AboutUserToolStripMenuItem = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        txtBoxUserEntry = New TextBox()
        lblCharacters = New Label()
        lblWord = New Label()
        lblTriesleft = New Label()
        lblInstructions = New Label()
        MenuStrip2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.BorderStyle = BorderStyle.FixedSingle
        lblStatus.Font = New Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblStatus.Location = New Point(255, 73)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(2, 32)
        lblStatus.TabIndex = 4
        ' 
        ' lblAdminSolution
        ' 
        lblAdminSolution.BackColor = Color.Transparent
        lblAdminSolution.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAdminSolution.Location = New Point(17, 563)
        lblAdminSolution.Name = "lblAdminSolution"
        lblAdminSolution.Size = New Size(239, 37)
        lblAdminSolution.TabIndex = 10
        lblAdminSolution.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(31, 381)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(201, 48)
        btnSubmit.TabIndex = 11
        btnSubmit.Text = "SUBMIT"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' btnRestart
        ' 
        btnRestart.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRestart.Location = New Point(591, 525)
        btnRestart.Name = "btnRestart"
        btnRestart.Size = New Size(197, 75)
        btnRestart.TabIndex = 12
        btnRestart.Text = "Restart"
        btnRestart.UseVisualStyleBackColor = True
        ' 
        ' lblUsedLetters
        ' 
        lblUsedLetters.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsedLetters.Location = New Point(40, 441)
        lblUsedLetters.Name = "lblUsedLetters"
        lblUsedLetters.Size = New Size(173, 31)
        lblUsedLetters.TabIndex = 13
        lblUsedLetters.Text = "Used Letters"
        lblUsedLetters.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblLettersUsed
        ' 
        lblLettersUsed.BorderStyle = BorderStyle.FixedSingle
        lblLettersUsed.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLettersUsed.Location = New Point(17, 487)
        lblLettersUsed.Name = "lblLettersUsed"
        lblLettersUsed.Size = New Size(353, 63)
        lblLettersUsed.TabIndex = 14
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, AboutToolStripMenuItem})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Size = New Size(800, 24)
        MenuStrip2.TabIndex = 15
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
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(517, 124)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(271, 314)
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' txtBoxUserEntry
        ' 
        txtBoxUserEntry.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtBoxUserEntry.Location = New Point(79, 346)
        txtBoxUserEntry.Name = "txtBoxUserEntry"
        txtBoxUserEntry.Size = New Size(91, 29)
        txtBoxUserEntry.TabIndex = 17
        ' 
        ' lblCharacters
        ' 
        lblCharacters.BorderStyle = BorderStyle.FixedSingle
        lblCharacters.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCharacters.Location = New Point(31, 221)
        lblCharacters.Name = "lblCharacters"
        lblCharacters.Size = New Size(201, 64)
        lblCharacters.TabIndex = 18
        lblCharacters.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblWord
        ' 
        lblWord.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWord.Location = New Point(50, 178)
        lblWord.Name = "lblWord"
        lblWord.Size = New Size(163, 34)
        lblWord.TabIndex = 19
        lblWord.Text = "Word Characters"
        lblWord.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTriesleft
        ' 
        lblTriesleft.BorderStyle = BorderStyle.FixedSingle
        lblTriesleft.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTriesleft.Location = New Point(31, 124)
        lblTriesleft.Name = "lblTriesleft"
        lblTriesleft.Size = New Size(201, 37)
        lblTriesleft.TabIndex = 20
        lblTriesleft.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblInstructions
        ' 
        lblInstructions.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInstructions.Location = New Point(31, 296)
        lblInstructions.Name = "lblInstructions"
        lblInstructions.Size = New Size(201, 32)
        lblInstructions.TabIndex = 21
        lblInstructions.Text = "Please Enter A Letter"
        lblInstructions.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' HangManGame
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 609)
        Controls.Add(lblInstructions)
        Controls.Add(lblTriesleft)
        Controls.Add(lblWord)
        Controls.Add(lblCharacters)
        Controls.Add(txtBoxUserEntry)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip2)
        Controls.Add(lblLettersUsed)
        Controls.Add(lblUsedLetters)
        Controls.Add(btnRestart)
        Controls.Add(btnSubmit)
        Controls.Add(lblAdminSolution)
        Controls.Add(lblStatus)
        DoubleBuffered = True
        Name = "HangManGame"
        Text = "Hangman Game"
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblStatus As Label
    Friend WithEvents lblAdminSolution As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnRestart As Button
    Friend WithEvents lblUsedLetters As Label
    Friend WithEvents lblLettersUsed As Label
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EndGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtBoxUserEntry As TextBox
    Friend WithEvents lblCharacters As Label
    Friend WithEvents lblWord As Label
    Friend WithEvents lblTriesleft As Label
    Friend WithEvents lblInstructions As Label
End Class
