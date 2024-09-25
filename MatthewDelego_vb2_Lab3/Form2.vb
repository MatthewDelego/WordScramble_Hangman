Public Class LoginForm

    Private ownerForm As Form1

    ' Call this from Form1 to pass a reference to itself
    Public Sub SetOwnerForm(form As Form1)
        ownerForm = form
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Check if the name is not empty
        If Not String.IsNullOrWhiteSpace(txtName.Text) Then
            ' Set the username in the owner form
            If ownerForm IsNot Nothing Then
                ownerForm.SetUserName(txtName.Text)
                ownerForm.Show()
                Me.Close()
            End If
        Else
            MessageBox.Show("Please enter your name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class

