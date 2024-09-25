<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        MenuStrip2 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewUserToolStripMenuItem = New ToolStripMenuItem()
        EndGameToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        AboutUserToolStripMenuItem = New ToolStripMenuItem()
        lblStatus = New Label()
        btnScrambleGame = New Button()
        btnHangManGame = New Button()
        MenuStrip2.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Location = New Point(0, 24)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "File"
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, AboutToolStripMenuItem})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Size = New Size(800, 24)
        MenuStrip2.TabIndex = 1
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
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.BorderStyle = BorderStyle.FixedSingle
        lblStatus.Font = New Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblStatus.Location = New Point(104, 89)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(2, 32)
        lblStatus.TabIndex = 2
        ' 
        ' btnScrambleGame
        ' 
        btnScrambleGame.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnScrambleGame.ForeColor = Color.Black
        btnScrambleGame.Image = CType(resources.GetObject("btnScrambleGame.Image"), Image)
        btnScrambleGame.Location = New Point(124, 230)
        btnScrambleGame.Name = "btnScrambleGame"
        btnScrambleGame.Size = New Size(243, 186)
        btnScrambleGame.TabIndex = 3
        btnScrambleGame.Text = "Word Scramble"
        btnScrambleGame.TextAlign = ContentAlignment.TopLeft
        btnScrambleGame.UseVisualStyleBackColor = True
        ' 
        ' btnHangManGame
        ' 
        btnHangManGame.BackgroundImage = CType(resources.GetObject("btnHangManGame.BackgroundImage"), Image)
        btnHangManGame.BackgroundImageLayout = ImageLayout.Stretch
        btnHangManGame.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHangManGame.Location = New Point(405, 230)
        btnHangManGame.Name = "btnHangManGame"
        btnHangManGame.Size = New Size(243, 186)
        btnHangManGame.TabIndex = 4
        btnHangManGame.Text = "Hangman"
        btnHangManGame.TextAlign = ContentAlignment.TopLeft
        btnHangManGame.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(800, 450)
        Controls.Add(btnHangManGame)
        Controls.Add(btnScrambleGame)
        Controls.Add(lblStatus)
        Controls.Add(MenuStrip1)
        Controls.Add(MenuStrip2)
        DoubleBuffered = True
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Main Menu"
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EndGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnScrambleGame As Button
    Friend WithEvents btnHangManGame As Button

End Class
