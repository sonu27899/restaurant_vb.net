Imports System.Data
Imports System.Data.OleDb
Public Class signup
    Dim cnn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim dt As DataTable
    Dim i As Integer = 0
    Dim f As Integer = 0
    Private Sub getdata()
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Monil\csaproject\rest.accdb"
        cmd.Connection = cnn
        cmd.CommandText = "select * from signup_tbl"
        da.SelectCommand = cmd
        da.Fill(ds)
        dt = ds.Tables(0)
    End Sub
    Private Sub filldata(ByVal q As String)
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Monil\csaproject\rest.accdb"
        cmd.Connection = cnn
        cmd.CommandText = q
        cnn.Open()
        cmd.ExecuteNonQuery()
        cnn.Close()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter Your Full Name")
            TextBox1.Focus()
        ElseIf TextBox2.Text = "" Then
            MsgBox("Enter Your User Name")
            TextBox2.Focus()
        ElseIf TextBox7.Text = "" Then
            MsgBox("Enter Your Email ID")
            TextBox7.Focus()
        ElseIf TextBox8.Text = "" Then
            MsgBox("Enter Your Mobile Nmber")
            TextBox8.Focus()
        ElseIf TextBox9.Text = "" Then
            MsgBox("Enter Your Password")
            TextBox9.Focus()
        ElseIf TextBox10.Text = "" Then
            MsgBox("Enter Your Confirm Password")
            TextBox10.Focus()
        ElseIf TextBox9.Text <> TextBox10.Text Then
            MsgBox("Password Mismatch")
            TextBox9.Focus()
        Else
            ds.Clear()
            getdata()
            For i = 0 To dt.Rows.Count - 1
                If TextBox2.Text = dt.Rows(i)(1) Then
                    f = 1
                End If
            Next
            If f = 1 Then
                MsgBox("User name exist..")
            Else
                filldata("insert into signup_tbl values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox7.Text & "'," & TextBox8.Text & ",'" & TextBox9.Text & "','" & TextBox10.Text & "')")
                MsgBox("added")
                ' display(i)
                loginpage.Show()
                Me.Hide()

            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox9.UseSystemPasswordChar = True Then
            TextBox9.UseSystemPasswordChar = False
        Else
            TextBox9.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox10.UseSystemPasswordChar = True Then
            TextBox10.UseSystemPasswordChar = False
        Else
            TextBox10.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If ((e.KeyChar >= "0" And e.KeyChar <= "9")) Then e.Handled() = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class