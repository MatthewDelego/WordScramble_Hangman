<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        lblName = New Label()
        txtName = New TextBox()
        btnSubmit = New Button()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.BackColor = Color.Transparent
        lblName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(90, 107)
        lblName.Name = "lblName"
        lblName.Size = New Size(215, 41)
        lblName.TabIndex = 0
        lblName.Text = "Please Enter Your Name"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtName.Location = New Point(311, 107)
        txtName.Name = "txtName"
        txtName.Size = New Size(278, 29)
        txtName.TabIndex = 1
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmit.Location = New Point(458, 330)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(212, 59)
        btnSubmit.TabIndex = 2
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(btnSubmit)
        Controls.Add(txtName)
        Controls.Add(lblName)
        Name = "LoginForm"
        Text = "Login Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnSubmit As Button
End Class
