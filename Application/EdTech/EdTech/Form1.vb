Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub



    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub textIDNumber_MouseEnter(sender As Object, e As EventArgs) Handles textIDNumber.MouseEnter
        Dim colorText As Color
        colorText = Color.FromArgb(54, 60, 72)
        If textIDNumber.Text = "ID Number" Then
            textIDNumber.Text = ""
            textIDNumber.ForeColor = colorText
        End If
    End Sub

    Private Sub textIDNumber_MouseLeave(sender As Object, e As EventArgs) Handles textIDNumber.MouseLeave
        Dim colorHint As Color
        colorHint = Color.FromArgb(118, 132, 158)
        If textIDNumber.Text = "" Then
            textIDNumber.Text = "ID Number"
            textIDNumber.ForeColor = colorHint
        End If
    End Sub


    Private Sub txtPassword_MouseEnter(sender As Object, e As EventArgs) Handles txtPassword.MouseEnter
        Dim colorText As Color
        colorText = Color.FromArgb(54, 60, 72)
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
            txtPassword.PasswordChar = "*"
            txtPassword.ForeColor = colorText
        End If
    End Sub

    Private Sub txtPassword_MouseLeave(sender As Object, e As EventArgs) Handles txtPassword.MouseLeave
        Dim colorHint As Color
        colorHint = Color.FromArgb(118, 132, 158)
        If txtPassword.Text = "" Then
            txtPassword.Text = "Password"
            txtPassword.PasswordChar = ""
            txtPassword.ForeColor = colorHint
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Hide()
        Dim Form2 As New Form2
        Form2.Show()
    End Sub
End Class
