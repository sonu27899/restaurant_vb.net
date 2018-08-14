Imports System.Data
Imports System.Data.OleDb
Public Class forgetpwd
    Dim cnn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim dt As DataTable
    Dim i As Integer = 0
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
    Private Sub display(ByVal i As Integer)
        txtemail.Text = dt.Rows(i)("Loginid").ToString
        txtpassword.Text = dt.Rows(i)("Password").ToString
        txtcpassword.Text = dt.Rows(i)("Confirm password").ToString
    End Sub

    Private Sub btncheck_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Dim n As String = ""


        If txtemail.Text <> "" And txtpassword.Text <> "" And txtcpassword.Text <> "" Then
            cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Monil\csaproject\rest.accdb"
            cmd.Connection = cnn
            cmd.CommandText = "select * from signup_tbl where Email_id='" & txtemail.Text & "'"
            ds.Clear()
            da.SelectCommand = cmd
            da.Fill(ds)
            dt = ds.Tables(0)
            If dt.Rows.Count > 0 Then
                n = dt.Rows(0)(2)
                If n = txtemail.Text Then
                    If txtcpassword.Text <> txtpassword.Text Then
                        MsgBox("Password mismatch")
                    Else

                        filldata("update signup_tbl set Password='" & txtpassword.Text & "',Confirm_password='" & txtcpassword.Text & "' where Email_id='" & txtemail.Text & "'")
                        MsgBox("You are succesful logged in")
                        loginpage.Tag = n
                        loginpage.Show()
                        Me.Hide()
                        txtemail.Clear()
                        txtpassword.Clear()
                    End If

                Else
                    MsgBox("Email Does Not Exist")
                End If
            Else
                MsgBox("Email Does not Exist")
            End If
        Else
            MsgBox("Enter Your Email & Password")
        End If

    End Sub

    Private Sub btncls_Click(sender As Object, e As EventArgs) Handles btncls.Click
        Me.Close()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtcpassword.Clear()
        txtemail.Clear()
        txtpassword.Clear()

    End Sub

    Private Sub forgetpwd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class