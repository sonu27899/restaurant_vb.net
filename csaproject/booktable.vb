Public Class booktable
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter Your Full Name")
            TextBox1.Focus()
        ElseIf TextBox7.Text = "" Then
            MsgBox("Enter Your Email ID")
            TextBox7.Focus()
        ElseIf TextBox8.Text = "" Then
            MsgBox("Enter Your Mobile Nmber")
            TextBox8.Focus()
        End If
        Dim dt As Date = DateTimePicker1.Value.ToShortDateString
        ' Dim ds As Date = dt.Date

        bookcongo.Tag = dt
        bookcongo.Show()
    End Sub

    Private Sub booktable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedItem = "2"
    End Sub
End Class