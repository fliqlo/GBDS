Public Class Form1
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click

        Dim username As String
        Dim password As String

        username = "gbds"
        password = "gbds@123"

        If userNameTxt.Text = username And passwordTxt.Text = password Then
            MsgBox("Login successfully")
            Me.Hide()
        Else
            MsgBox("Login failed")
            userNameTxt.Text = ""
            passwordTxt.Text = ""
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class
