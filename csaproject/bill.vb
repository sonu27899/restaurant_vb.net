Imports System.Data
Imports System.Data.OleDb
Public Class bill
    Dim cnn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim dt As DataTable
    Dim i As Integer = 0
    Private Sub getdata(ByRef query As String)
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Monil\csaproject\rest.accdb"
        cmd.Connection = cnn
        cmd.CommandText = query
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
    Private Sub bill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getdata("select * from cart_tbl")
        For i As Integer = 0 To dt.Rows.Count - 1
            Label3.Text += dt.Rows(i)(0) & vbNewLine
            Label4.Text += dt.Rows(i)(3) & vbNewLine

        Next
        Label5.Text = Me.Tag
        main.Button1.Visible = True
    End Sub

    Private Sub Button75_Click(sender As Object, e As EventArgs) Handles Button75.Click
        filldata("delete * from cart_tbl")
        Me.Close()

    End Sub
End Class