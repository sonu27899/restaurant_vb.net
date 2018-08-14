Public Class main
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        loginpage.Close()
        signup.Close()
        loginpage.Show()
        demo1.Close()
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        demo1.MdiParent = Me
        demo1.Show()
        Button1.Visible = False


    End Sub

    Private Sub btnsignup_Click(sender As Object, e As EventArgs) Handles btnsignup.Click
        signup.Show()
        loginpage.Close()
        demo1.Close()
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        demo1.Show()
        signup.Close()
        loginpage.Close()
    End Sub

    Private Sub btnorderonline_Click(sender As Object, e As EventArgs) Handles btnorderonline.Click
        loginpage.Close()
        backup.Close()
        backup.Show()
        loginpage.Show()
        signup.Close()
        demo1.Close()
    End Sub

    Private Sub btnbooktable_Click(sender As Object, e As EventArgs) Handles btnbooktable.Click
        'loginpage.Close()
        booktable.Show()
        'loginpage.Show()
        backup.Close()
        signup.Close()
        demo1.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ms As DialogResult
        ms = MessageBox.Show("Logout ??", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If ms = DialogResult.OK Then
            demo1.Show()
        End If
        Button1.Visible = False
    End Sub
End Class
