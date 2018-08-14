Imports System.Data
Imports System.Data.OleDb
Public Class backup
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
    Private Sub clearAll()
        txtprice.Clear()
        txtprice.Clear()
        txtprname.Clear()
    End Sub
    Private Sub btnfoodicon_Click(sender As Object, e As EventArgs) Handles btnfoodicon.Click
        btnfoodpanel.Height = btnfoodicon.Height
        btnfoodpanel.Top = btnfoodicon.Top
        btnfoodpanel.Visible = True
        btndrinkpanel.Visible = False
        btndessertpanel.Visible = False
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        foodpanel.Visible = True
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
        pizza.Visible = False
        burger.Visible = False
        Sandwich.Visible = False
        cakepasteries.Visible = False
        cupcakes.Visible = False
        waffels.Visible = False
        icecream.Visible = False
        softdrinks.Visible = False
        shakes.Visible = False
        juice.Visible = False
        coffee.Visible = False
        tea.Visible = False
        Rice.Visible = False
        indianveg.Visible = False
        pizza.Visible = False
        chinese.Visible = False
        dosa.Visible = False
        cupcakes.Visible = False
    End Sub

    Private Sub btndrinkicon_Click(sender As Object, e As EventArgs) Handles btndrinkicon.Click
        btndrinkpanel.Height = btndrinkicon.Height
        btndrinkpanel.Top = btndrinkicon.Top
        btndrinkpanel.Visible = True
        btnfoodpanel.Visible = False
        btndessertpanel.Visible = False
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        foodpanel.Visible = False
        drinkpanel.Visible = True
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
        pizza.Visible = False
        burger.Visible = False
        Sandwich.Visible = False
        cakepasteries.Visible = False
        cupcakes.Visible = False
        waffels.Visible = False
        icecream.Visible = False
        softdrinks.Visible = False
        shakes.Visible = False
        juice.Visible = False
        coffee.Visible = False
        tea.Visible = False
        Rice.Visible = False
        indianveg.Visible = False
        pizza.Visible = False
        chinese.Visible = False
        dosa.Visible = False
        cupcakes.Visible = False
    End Sub

    Private Sub btndesserticon_Click(sender As Object, e As EventArgs) Handles btndesserticon.Click
        btndessertpanel.Height = btndesserticon.Height
        btndessertpanel.Top = btndesserticon.Top
        btndessertpanel.Visible = True
        btnfoodpanel.Visible = False
        btndrinkpanel.Visible = False
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        foodpanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = True
        cartpanel.Visible = False
        contacus.Visible = False
        pizza.Visible = False
        burger.Visible = False
        Sandwich.Visible = False
        cakepasteries.Visible = False
        cupcakes.Visible = False
        waffels.Visible = False
        icecream.Visible = False
        softdrinks.Visible = False
        shakes.Visible = False
        juice.Visible = False
        coffee.Visible = False
        tea.Visible = False
        Rice.Visible = False
        indianveg.Visible = False
        pizza.Visible = False
        chinese.Visible = False
        dosa.Visible = False
        cupcakes.Visible = False
    End Sub

    Private Sub btncarticon_Click(sender As Object, e As EventArgs) Handles btncarticon.Click
        btncartpanel.Height = btncarticon.Height
        btncartpanel.Top = btncarticon.Top
        btncartpanel.Visible = True
        btnfoodpanel.Visible = False
        btndrinkpanel.Visible = False
        btndessertpanel.Visible = False
        btncntuspanel.Visible = False
        foodpanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = True
        contacus.Visible = False
        pizza.Visible = False
        burger.Visible = False
        Sandwich.Visible = False
        cakepasteries.Visible = False
        cupcakes.Visible = False
        waffels.Visible = False
        icecream.Visible = False
        softdrinks.Visible = False
        shakes.Visible = False
        juice.Visible = False
        coffee.Visible = False
        tea.Visible = False
        Rice.Visible = False
        indianveg.Visible = False
        pizza.Visible = False
        chinese.Visible = False
        dosa.Visible = False
        cupcakes.Visible = False
    End Sub

    Private Sub btncontacticon_Click(sender As Object, e As EventArgs) Handles btncontacticon.Click
        btncntuspanel.Height = btncontacticon.Height
        btncntuspanel.Top = btncontacticon.Top
        btncntuspanel.Visible = True
        btndrinkpanel.Visible = False
        btndessertpanel.Visible = False
        btncartpanel.Visible = False
        btnfoodpanel.Visible = False
        foodpanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = True
    End Sub

    Private Sub backup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnfoodpanel.Visible = True
        foodpanel.Visible = True
        btndrinkpanel.Visible = False
        btndessertpanel.Visible = False
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
        pizza.Visible = False
        burger.Visible = False
        Sandwich.Visible = False
        cakepasteries.Visible = False
        cupcakes.Visible = False
        waffels.Visible = False
        icecream.Visible = False
        softdrinks.Visible = False
        shakes.Visible = False
        juice.Visible = False
        coffee.Visible = False
        tea.Visible = False
        Rice.Visible = False
        indianveg.Visible = False
        pizza.Visible = False
        chinese.Visible = False
        dosa.Visible = False
        cupcakes.Visible = False
        filldata("delete * from cart_tbl")
        main.Button1.Visible = True

    End Sub

    Private Sub btnpizza_Click(sender As Object, e As EventArgs)
        pizza.Visible = True
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = False
        chinese.Visible = False
        indianveg.Visible = False
        Sandwich.Visible = False
        Rice.Visible = False
        tea.Visible = False
        coffee.Visible = False
        juice.Visible = False
        shakes.Visible = False
        softdrinks.Visible = False
        icecream.Visible = False
        waffels.Visible = False
        cupcakes.Visible = False
        cakepasteries.Visible = False
        btnfoodpanel.Visible = True
        btndrinkpanel.Visible = False
        btndessertpanel.Visible = False
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
        cupcakes.Visible = False
    End Sub

    Private Sub btnburgur_Click(sender As Object, e As EventArgs) Handles btnburgur.Click
        pizza.Visible = False
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = True
        dosa.Visible = False
        chinese.Visible = False
        indianveg.Visible = False
        Sandwich.Visible = False
        Rice.Visible = False
        tea.Visible = False
        coffee.Visible = False
        juice.Visible = False
        shakes.Visible = False
        softdrinks.Visible = False
        icecream.Visible = False
        waffels.Visible = False
        cupcakes.Visible = False
        cakepasteries.Visible = False
        btnfoodpanel.Visible = True
        btndrinkpanel.Visible = False
        btndessertpanel.Visible = False
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
        cupcakes.Visible = False
    End Sub

    Private Sub btndosa_Click(sender As Object, e As EventArgs) Handles btndosa.Click
        pizza.Visible = False
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = True
        chinese.Visible = False
        indianveg.Visible = False
        Sandwich.Visible = False
        Rice.Visible = False
        tea.Visible = False
        coffee.Visible = False
        juice.Visible = False
        shakes.Visible = False
        softdrinks.Visible = False
        icecream.Visible = False
        waffels.Visible = False
        cupcakes.Visible = False
        cakepasteries.Visible = False
        btnfoodpanel.Visible = True
        btndrinkpanel.Visible = False
        btndessertpanel.Visible = False
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
        cupcakes.Visible = False
    End Sub

    Private Sub btnchinese_Click(sender As Object, e As EventArgs) Handles btnchinese.Click
        pizza.Visible = False
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = False
        chinese.Visible = True
        indianveg.Visible = False
        Sandwich.Visible = False
        Rice.Visible = False
        tea.Visible = False
        coffee.Visible = False
        juice.Visible = False
        shakes.Visible = False
        softdrinks.Visible = False
        icecream.Visible = False
        waffels.Visible = False
        cupcakes.Visible = False
        cakepasteries.Visible = False
        btnfoodpanel.Visible = True
        btndrinkpanel.Visible = False
        btndessertpanel.Visible = False
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
        cupcakes.Visible = False
    End Sub

    Private Sub btnindveg_Click(sender As Object, e As EventArgs) Handles btnindveg.Click
        pizza.Visible = False
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = False
        chinese.Visible = False
        indianveg.Visible = True
        Sandwich.Visible = False
        Rice.Visible = False
        tea.Visible = False
        coffee.Visible = False
        juice.Visible = False
        shakes.Visible = False
        softdrinks.Visible = False
        icecream.Visible = False
        waffels.Visible = False
        cupcakes.Visible = False
        cakepasteries.Visible = False
        btnfoodpanel.Visible = True
        btndrinkpanel.Visible = False
        btndessertpanel.Visible = False
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
        cupcakes.Visible = False
    End Sub

    Private Sub btnsandwich_Click(sender As Object, e As EventArgs) Handles btnsandwich.Click
        pizza.Visible = False
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = False
        chinese.Visible = False
        indianveg.Visible = False
        Sandwich.Visible = True
        Rice.Visible = False
        tea.Visible = False
        coffee.Visible = False
        juice.Visible = False
        shakes.Visible = False
        softdrinks.Visible = False
        icecream.Visible = False
        waffels.Visible = False
        cupcakes.Visible = False
        cakepasteries.Visible = False
        btnfoodpanel.Visible = True
        btndrinkpanel.Visible = False
        btndessertpanel.Visible = False
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
        cupcakes.Visible = False
    End Sub

    Private Sub btnrice_Click(sender As Object, e As EventArgs) Handles btnrice.Click
        pizza.Visible = False
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = False
        chinese.Visible = False
        indianveg.Visible = False
        Sandwich.Visible = False
        Rice.Visible = True
        tea.Visible = False
        coffee.Visible = False
        juice.Visible = False
        shakes.Visible = False
        softdrinks.Visible = False
        icecream.Visible = False
        waffels.Visible = False
        cupcakes.Visible = False
        cakepasteries.Visible = False
        btnfoodpanel.Visible = True
        btndrinkpanel.Visible = False
        btndessertpanel.Visible = False
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
        cupcakes.Visible = False
    End Sub

    Private Sub btntea_Click(sender As Object, e As EventArgs)
        pizza.Visible = False
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = False
        chinese.Visible = False
        indianveg.Visible = False
        Sandwich.Visible = False
        Rice.Visible = False
        tea.Visible = True
        coffee.Visible = False
        juice.Visible = False
        shakes.Visible = False
        softdrinks.Visible = False
        icecream.Visible = False
        waffels.Visible = False
        cupcakes.Visible = False
        cakepasteries.Visible = False
        btnfoodpanel.Visible = False
        btndrinkpanel.Visible = True
        btndessertpanel.Visible = False
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
        cupcakes.Visible = False
    End Sub

    Private Sub btncoffee_Click(sender As Object, e As EventArgs)
        pizza.Visible = False
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = False
        chinese.Visible = False
        indianveg.Visible = False
        Sandwich.Visible = False
        Rice.Visible = False
        tea.Visible = False
        coffee.Visible = True
        juice.Visible = False
        shakes.Visible = False
        softdrinks.Visible = False
        icecream.Visible = False
        waffels.Visible = False
        cupcakes.Visible = False
        cakepasteries.Visible = False
        btnfoodpanel.Visible = False
        btndrinkpanel.Visible = True
        btndessertpanel.Visible = False
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
        cupcakes.Visible = False
    End Sub

    Private Sub btnjuice_Click(sender As Object, e As EventArgs)
        pizza.Visible = False
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = False
        chinese.Visible = False
        indianveg.Visible = False
        Sandwich.Visible = False
        Rice.Visible = False
        tea.Visible = False
        coffee.Visible = False
        juice.Visible = True
        shakes.Visible = False
        softdrinks.Visible = False
        icecream.Visible = False
        waffels.Visible = False
        cupcakes.Visible = False
        cakepasteries.Visible = False
        btnfoodpanel.Visible = False
        btndrinkpanel.Visible = True
        btndessertpanel.Visible = False
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
        cupcakes.Visible = False
    End Sub

    Private Sub btnshakes_Click(sender As Object, e As EventArgs)
        pizza.Visible = False
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = False
        chinese.Visible = False
        indianveg.Visible = False
        Sandwich.Visible = False
        Rice.Visible = False
        tea.Visible = False
        coffee.Visible = False
        juice.Visible = False
        shakes.Visible = True
        softdrinks.Visible = False
        icecream.Visible = False
        waffels.Visible = False
        cupcakes.Visible = False
        cakepasteries.Visible = False
        btnfoodpanel.Visible = False
        btndrinkpanel.Visible = True
        btndessertpanel.Visible = False
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
        cupcakes.Visible = False
    End Sub

    Private Sub btnsoftdrink_Click(sender As Object, e As EventArgs)
        pizza.Visible = False
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = False
        chinese.Visible = False
        indianveg.Visible = False
        Sandwich.Visible = False
        Rice.Visible = False
        tea.Visible = False
        coffee.Visible = False
        juice.Visible = False
        shakes.Visible = False
        softdrinks.Visible = True
        icecream.Visible = False
        waffels.Visible = False
        cupcakes.Visible = False
        cakepasteries.Visible = False
        btnfoodpanel.Visible = False
        btndrinkpanel.Visible = True
        btndessertpanel.Visible = False
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
        cupcakes.Visible = False
    End Sub

    Private Sub btnwaffels_Click(sender As Object, e As EventArgs)
        pizza.Visible = False
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = False
        chinese.Visible = False
        indianveg.Visible = False
        Sandwich.Visible = False
        Rice.Visible = False
        tea.Visible = False
        coffee.Visible = False
        juice.Visible = False
        shakes.Visible = False
        softdrinks.Visible = False
        icecream.Visible = False
        waffels.Visible = True
        cupcakes.Visible = False
        cakepasteries.Visible = False
        btnfoodpanel.Visible = False
        btndrinkpanel.Visible = False
        btndessertpanel.Visible = True
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
        cupcakes.Visible = False
    End Sub

    Private Sub btncupcakes_Click(sender As Object, e As EventArgs)
        pizza.Visible = False
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = False
        chinese.Visible = False
        indianveg.Visible = False
        Sandwich.Visible = False
        Rice.Visible = False
        tea.Visible = False
        coffee.Visible = False
        juice.Visible = False
        shakes.Visible = False
        softdrinks.Visible = False
        icecream.Visible = False
        waffels.Visible = False
        cupcakes.Visible = False
        cakepasteries.Visible = False
        btnfoodpanel.Visible = False
        btndrinkpanel.Visible = False
        btndessertpanel.Visible = True
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
        cupcakes.Visible = True
    End Sub

    Private Sub btncake_Click(sender As Object, e As EventArgs)
        pizza.Visible = False
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = False
        chinese.Visible = False
        indianveg.Visible = False
        Sandwich.Visible = False
        Rice.Visible = False
        tea.Visible = False
        coffee.Visible = False
        juice.Visible = False
        shakes.Visible = False
        softdrinks.Visible = False
        icecream.Visible = False
        waffels.Visible = False
        cupcakes.Visible = False
        cakepasteries.Visible = True
        btnfoodpanel.Visible = False
        btndrinkpanel.Visible = False
        btndessertpanel.Visible = True
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
        cupcakes.Visible = False
    End Sub

    Private Sub btnicecream_Click(sender As Object, e As EventArgs)
        pizza.Visible = False
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = False
        chinese.Visible = False
        indianveg.Visible = False
        Sandwich.Visible = False
        Rice.Visible = False
        tea.Visible = False
        coffee.Visible = False
        juice.Visible = False
        shakes.Visible = False
        softdrinks.Visible = False

        icecream.Visible = True
        waffels.Visible = False
        cupcakes.Visible = False
        cakepasteries.Visible = False
        btnfoodpanel.Visible = False
        btndrinkpanel.Visible = False
        btndessertpanel.Visible = True
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
        cupcakes.Visible = False
    End Sub

    Private Sub Button107_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button107.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button107.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button107.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button107.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button107.Text & "'," & 1 & "," & 150 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button107.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button107.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button12.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button12.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button12.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button12.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button12.Text & "'," & 1 & "," & 150 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button12.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button12.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button13.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button13.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button13.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button13.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button13.Text & "'," & 1 & "," & 150 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button13.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button13.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button21.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button21.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button21.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button21.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button21.Text & "'," & 1 & "," & 150 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button21.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button21.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button20.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button20.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button20.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button20.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button20.Text & "'," & 1 & "," & 250 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button20.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button20.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button19.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button19.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button19.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button19.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button19.Text & "'," & 1 & "," & 250 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button19.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button19.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button18.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button18.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button18.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button18.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button18.Text & "'," & 1 & "," & 250 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button18.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button18.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If

    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button26.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button26.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button26.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button26.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button26.Text & "'," & 1 & "," & 250 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button26.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button26.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button27.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button27.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button27.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button27.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button27.Text & "'," & 1 & "," & 250 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button27.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button27.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If

    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button28.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button28.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button28.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button28.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button28.Text & "'," & 1 & "," & 250 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button28.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button28.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If

    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button30.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button30.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button30.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button30.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button30.Text & "'," & 1 & "," & 250 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button30.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button30.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If

    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button31.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button31.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button31.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button31.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button31.Text & "'," & 1 & "," & 250 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button31.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button31.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If

    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button33.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button33.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button33.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button33.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button33.Text & "'," & 1 & "," & 250 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button33.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button33.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button34.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button34.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button34.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button34.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button34.Text & "'," & 1 & "," & 250 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button34.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button34.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button36.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button36.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button36.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button36.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button36.Text & "'," & 1 & "," & 250 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button36.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button36.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button38.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button38.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button38.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button38.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button38.Text & "'," & 1 & "," & 250 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button38.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button38.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button17.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button17.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button17.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button17.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button17.Text & "'," & 1 & "," & 250 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button17.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button17.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button23.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button23.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button23.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button23.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button23.Text & "'," & 1 & "," & 350 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button23.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button23.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button24.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button24.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button24.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button24.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button24.Text & "'," & 1 & "," & 350 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button24.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button24.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button25.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button25.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button25.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button25.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button25.Text & "'," & 1 & "," & 350 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button2.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button25.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button146_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button146.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button146.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button146.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button146.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button146.Text & "'," & 1 & "," & 350 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button146.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button146.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button71_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button71.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button71.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button71.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button71.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button71.Text & "'," & 1 & "," & 350 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button71.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button71.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button68_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button68.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button68.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button68.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button68.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button68.Text & "'," & 1 & "," & 350 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button68.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button68.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button141_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button141.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button141.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button141.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button141.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button141.Text & "'," & 1 & "," & 350 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button141.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button141.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button47.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button47.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button47.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button47.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button47.Text & "'," & 1 & "," & 350 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button47.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button47.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If

    End Sub




    Private Sub Button44_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button44.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button44.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button44.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button44.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button44.Text & "'," & 1 & "," & 350 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button44.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button44.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If

    End Sub
    Private Sub Button116_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button116.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button116.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button116.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button116.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button116.Text & "'," & 1 & "," & 350 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button116.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button116.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button113_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button113.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button113.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button113.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button113.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button113.Text & "'," & 1 & "," & 70 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button113.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button113.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button114_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button114.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button114.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button114.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button114.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button114.Text & "'," & 1 & "," & 70 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button114.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button114.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button115_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button115.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button115.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button115.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button115.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button115.Text & "'," & 1 & "," & 70 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button115.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button115.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button111_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button111.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button111.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button111.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button111.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button111.Text & "'," & 1 & "," & 70 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button111.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button111.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button123_Click(sender As Object, e As EventArgs) Handles Button123.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button123.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button123.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button123.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button123.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button123.Text & "'," & 1 & "," & 70 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button123.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button123.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button122_Click(sender As Object, e As EventArgs) Handles Button122.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button122.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button122.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button122.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button122.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button122.Text & "'," & 1 & "," & 70 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button122.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button122.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button121_Click(sender As Object, e As EventArgs) Handles Button121.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button121.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button121.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button121.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button121.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button121.Text & "'," & 1 & "," & 70 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button121.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button121.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button125_Click(sender As Object, e As EventArgs) Handles Button125.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button125.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button125.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button125.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button125.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button125.Text & "'," & 1 & "," & 70 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button125.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button125.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button124_Click(sender As Object, e As EventArgs) Handles Button124.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button124.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button124.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button124.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button124.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button124.Text & "'," & 1 & "," & 70 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button124.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button124.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button119_Click(sender As Object, e As EventArgs) Handles Button119.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button119.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button119.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button119.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button119.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button119.Text & "'," & 1 & "," & 70 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button119.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button119.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button120_Click(sender As Object, e As EventArgs) Handles Button120.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button120.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button120.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button120.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button120.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button120.Text & "'," & 1 & "," & 70 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button120.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button120.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button126_Click(sender As Object, e As EventArgs) Handles Button126.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button126.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button126.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button126.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button126.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button126.Text & "'," & 1 & "," & 70 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button126.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button126.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button77_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button77.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button77.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button77.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button77.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button77.Text & "'," & 1 & "," & 70 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button77.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button77.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button14.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button14.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button14.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button14.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button14.Text & "'," & 1 & "," & 170 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button14.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button14.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button15.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button15.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button15.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button15.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button15.Text & "'," & 1 & "," & 170 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button15.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button15.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button16.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button16.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button16.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button16.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button16.Text & "'," & 1 & "," & 170 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button16.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button16.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button48.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button48.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button48.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button48.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button48.Text & "'," & 1 & "," & 170 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button48.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button48.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button76_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button76.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button76.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button76.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button76.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button76.Text & "'," & 1 & "," & 170 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button76.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button76.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button22.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button22.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button22.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button22.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button22.Text & "'," & 1 & "," & 170 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button22.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button22.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button134_Click(sender As Object, e As EventArgs) Handles Button134.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button134.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button134.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button134.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button134.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button134.Text & "'," & 1 & "," & 170 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button134.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button134.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button35.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button35.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button35.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button35.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button35.Text & "'," & 1 & "," & 170 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button35.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button35.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button10.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button10.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button10.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button10.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button10.Text & "'," & 1 & "," & 170 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button10.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button10.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button9.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button9.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button9.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button9.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button9.Text & "'," & 1 & "," & 170 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button9.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button9.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button135_Click(sender As Object, e As EventArgs) Handles Button135.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button135.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button135.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button135.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button135.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button135.Text & "'," & 1 & "," & 170 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button135.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button135.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button32.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button32.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button32.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button32.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button32.Text & "'," & 1 & "," & 240 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button32.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button32.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button11.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button11.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button11.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button11.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button11.Text & "'," & 1 & "," & 240 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button11.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button11.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button8.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button8.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button8.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button8.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button8.Text & "'," & 1 & "," & 240 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button8.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button8.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button7.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button7.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button7.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button7.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button7.Text & "'," & 1 & "," & 240 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button7.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button7.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button6.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button6.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button6.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button6.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button6.Text & "'," & 1 & "," & 240 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button6.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button6.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button3.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button3.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button3.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button3.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button3.Text & "'," & 1 & "," & 240 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button3.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button3.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button4.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button4.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button4.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button4.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button4.Text & "'," & 1 & "," & 240 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button4.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button4.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button5.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button5.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button5.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button5.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button5.Text & "'," & 1 & "," & 240 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button5.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button5.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub btnp_Click(sender As Object, e As EventArgs) Handles btnp.Click
        pizza.Visible = True
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = False
        chinese.Visible = False
        indianveg.Visible = False
        Sandwich.Visible = False
        Rice.Visible = False
        tea.Visible = False
        coffee.Visible = False
        juice.Visible = False
        shakes.Visible = False
        softdrinks.Visible = False
        icecream.Visible = False
        waffels.Visible = False
        cupcakes.Visible = False
        cakepasteries.Visible = False
        btnfoodpanel.Visible = True
        btndrinkpanel.Visible = False
        btndessertpanel.Visible = False
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
    End Sub

    Private Sub btnt_Click(sender As Object, e As EventArgs)
        pizza.Visible = False
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = False
        chinese.Visible = False
        indianveg.Visible = False
        Sandwich.Visible = False
        Rice.Visible = False
        tea.Visible = True
        coffee.Visible = False
        juice.Visible = False
        shakes.Visible = False
        softdrinks.Visible = False
        icecream.Visible = False
        waffels.Visible = False
        cupcakes.Visible = False
        cakepasteries.Visible = False
        btnfoodpanel.Visible = False
        btndrinkpanel.Visible = True
        btndessertpanel.Visible = False
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
    End Sub

    Private Sub btnw_Click(sender As Object, e As EventArgs)
        pizza.Visible = False
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = False
        chinese.Visible = False
        indianveg.Visible = False
        Sandwich.Visible = False
        Rice.Visible = False
        tea.Visible = False
        coffee.Visible = False
        juice.Visible = False
        shakes.Visible = False
        softdrinks.Visible = False
        icecream.Visible = False
        waffels.Visible = True
        cupcakes.Visible = False
        cakepasteries.Visible = False
        btnfoodpanel.Visible = False
        btndrinkpanel.Visible = False
        btndessertpanel.Visible = True
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
    End Sub

    Private Sub btncc_Click(sender As Object, e As EventArgs)
        pizza.Visible = False
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = False
        chinese.Visible = False
        indianveg.Visible = False
        Sandwich.Visible = False
        Rice.Visible = False
        tea.Visible = False
        coffee.Visible = False
        juice.Visible = False
        shakes.Visible = False
        softdrinks.Visible = False
        icecream.Visible = False
        waffels.Visible = False
        cupcakes.Visible = True
        cakepasteries.Visible = False
        btnfoodpanel.Visible = False
        btndrinkpanel.Visible = False
        btndessertpanel.Visible = False
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
    End Sub

    Private Sub btncp_Click(sender As Object, e As EventArgs)
        pizza.Visible = False
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = False
        chinese.Visible = False
        indianveg.Visible = False
        Sandwich.Visible = False
        Rice.Visible = False
        tea.Visible = False
        coffee.Visible = False
        juice.Visible = False
        shakes.Visible = False
        softdrinks.Visible = False
        icecream.Visible = False
        waffels.Visible = False
        cupcakes.Visible = False
        cakepasteries.Visible = True
        btnfoodpanel.Visible = False
        btndrinkpanel.Visible = False
        btndessertpanel.Visible = False
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
    End Sub

    Private Sub btnice_Click(sender As Object, e As EventArgs)
        pizza.Visible = False
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = False
        chinese.Visible = False
        indianveg.Visible = False
        Sandwich.Visible = False
        Rice.Visible = False
        tea.Visible = False
        coffee.Visible = False
        juice.Visible = False
        shakes.Visible = False
        softdrinks.Visible = False
        icecream.Visible = True
        waffels.Visible = False
        cupcakes.Visible = False
        cakepasteries.Visible = False
        btnfoodpanel.Visible = False
        btndrinkpanel.Visible = False
        btndessertpanel.Visible = False
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
    End Sub

    Private Sub btncoffee_Click_1(sender As Object, e As EventArgs) Handles btncoffee.Click
        pizza.Visible = False
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = False
        chinese.Visible = False
        indianveg.Visible = False
        Sandwich.Visible = False
        Rice.Visible = False
        tea.Visible = False
        coffee.Visible = True
        juice.Visible = False
        shakes.Visible = False
        softdrinks.Visible = False
        icecream.Visible = False
        waffels.Visible = False
        cupcakes.Visible = False
        cakepasteries.Visible = False
        btnfoodpanel.Visible = False
        btndrinkpanel.Visible = True
        btndessertpanel.Visible = False
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
    End Sub

    Private Sub btnjuice_Click_1(sender As Object, e As EventArgs) Handles btnjuice.Click
        pizza.Visible = False
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = False
        chinese.Visible = False
        indianveg.Visible = False
        Sandwich.Visible = False
        Rice.Visible = False
        tea.Visible = False
        coffee.Visible = False
        juice.Visible = True
        shakes.Visible = False
        softdrinks.Visible = False
        icecream.Visible = False
        waffels.Visible = False
        cupcakes.Visible = False
        cakepasteries.Visible = False
        btnfoodpanel.Visible = False
        btndrinkpanel.Visible = True
        btndessertpanel.Visible = False
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
    End Sub

    Private Sub btnshakes_Click_1(sender As Object, e As EventArgs) Handles btnshakes.Click
        pizza.Visible = False
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = False
        chinese.Visible = False
        indianveg.Visible = False
        Sandwich.Visible = False
        Rice.Visible = False
        tea.Visible = False
        coffee.Visible = False
        juice.Visible = False
        shakes.Visible = True
        softdrinks.Visible = False
        icecream.Visible = False
        waffels.Visible = False
        cupcakes.Visible = False
        cakepasteries.Visible = False
        btnfoodpanel.Visible = False
        btndrinkpanel.Visible = True
        btndessertpanel.Visible = False
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
    End Sub

    Private Sub btnsoftdrink_Click_1(sender As Object, e As EventArgs) Handles btnsoftdrink.Click
        pizza.Visible = False
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = False
        chinese.Visible = False
        indianveg.Visible = False
        Sandwich.Visible = False
        Rice.Visible = False
        tea.Visible = False
        coffee.Visible = False
        juice.Visible = False
        shakes.Visible = False
        softdrinks.Visible = True
        icecream.Visible = False
        waffels.Visible = False
        cupcakes.Visible = False
        cakepasteries.Visible = False
        btnfoodpanel.Visible = False
        btndrinkpanel.Visible = True
        btndessertpanel.Visible = False
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
    End Sub

    Private Sub btnt_Click_1(sender As Object, e As EventArgs) Handles btnt.Click
        pizza.Visible = False
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = False
        chinese.Visible = False
        indianveg.Visible = False
        Sandwich.Visible = False
        Rice.Visible = False
        tea.Visible = True
        coffee.Visible = False
        juice.Visible = False
        shakes.Visible = False
        softdrinks.Visible = False
        icecream.Visible = False
        waffels.Visible = False
        cupcakes.Visible = False
        cakepasteries.Visible = False
        btnfoodpanel.Visible = False
        btndrinkpanel.Visible = True
        btndessertpanel.Visible = False
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
    End Sub

    Private Sub btncp_Click_1(sender As Object, e As EventArgs) Handles btncp.Click
        pizza.Visible = False
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = False
        chinese.Visible = False
        indianveg.Visible = False
        Sandwich.Visible = False
        Rice.Visible = False
        tea.Visible = False
        coffee.Visible = False
        juice.Visible = False
        shakes.Visible = False
        softdrinks.Visible = False
        icecream.Visible = False
        waffels.Visible = False
        cupcakes.Visible = False
        cakepasteries.Visible = True
        btnfoodpanel.Visible = False
        btndrinkpanel.Visible = False
        btndessertpanel.Visible = True
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
    End Sub

    Private Sub btnw_Click_1(sender As Object, e As EventArgs) Handles btnw.Click
        pizza.Visible = False
        waffels.Visible = True
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = False
        chinese.Visible = False
        indianveg.Visible = False
        Sandwich.Visible = False
        Rice.Visible = False
        tea.Visible = False
        coffee.Visible = False
        juice.Visible = False
        shakes.Visible = False
        softdrinks.Visible = False
        icecream.Visible = False
        cupcakes.Visible = False
        cakepasteries.Visible = False
        btnfoodpanel.Visible = False
        btndrinkpanel.Visible = False
        btndessertpanel.Visible = True
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
    End Sub

    Private Sub btncc_Click_1(sender As Object, e As EventArgs) Handles btncc.Click
        pizza.Visible = False
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = False
        chinese.Visible = False
        indianveg.Visible = False
        Sandwich.Visible = False
        Rice.Visible = False
        tea.Visible = False
        coffee.Visible = False
        juice.Visible = False
        shakes.Visible = False
        softdrinks.Visible = False
        icecream.Visible = False
        waffels.Visible = False
        cupcakes.Visible = True
        cakepasteries.Visible = False
        btnfoodpanel.Visible = False
        btndrinkpanel.Visible = False
        btndessertpanel.Visible = True
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
    End Sub

    Private Sub btnice_Click_1(sender As Object, e As EventArgs) Handles btnice.Click
        pizza.Visible = False
        foodpanel.Visible = False
        dessertpanel.Visible = False
        drinkpanel.Visible = False
        burger.Visible = False
        dosa.Visible = False
        chinese.Visible = False
        indianveg.Visible = False
        Sandwich.Visible = False
        Rice.Visible = False
        tea.Visible = False
        coffee.Visible = False
        juice.Visible = False
        shakes.Visible = False
        softdrinks.Visible = False
        icecream.Visible = True
        waffels.Visible = False
        cupcakes.Visible = False
        cakepasteries.Visible = False
        btnfoodpanel.Visible = False
        btndrinkpanel.Visible = False
        btndessertpanel.Visible = True
        btncartpanel.Visible = False
        btncntuspanel.Visible = False
        drinkpanel.Visible = False
        dessertpanel.Visible = False
        cartpanel.Visible = False
        contacus.Visible = False
    End Sub

    Private Sub Button112_Click(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button112.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button112.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button112.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button112.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button112.Text & "'," & 1 & "," & 240 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button112.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button112.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button62.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button62.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button62.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button62.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button62.Text & "'," & 1 & "," & 240 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button62.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button62.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button65_Click(sender As Object, e As EventArgs) Handles Button65.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button65.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button65.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button65.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button65.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button65.Text & "'," & 1 & "," & 240 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button65.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button65.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button66_Click(sender As Object, e As EventArgs) Handles Button66.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button66.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button66.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button66.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button66.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button66.Text & "'," & 1 & "," & 80 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button66.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button66.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button69_Click(sender As Object, e As EventArgs) Handles Button69.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button69.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button69.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button69.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button69.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button69.Text & "'," & 1 & "," & 80 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button69.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button69.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button67_Click(sender As Object, e As EventArgs) Handles Button67.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button67.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button67.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button67.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button67.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button67.Text & "'," & 1 & "," & 80 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button67.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button67.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button39.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button39.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button39.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button39.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button39.Text & "'," & 1 & "," & 80 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button39.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button39.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button40.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button40.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button40.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button40.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button40.Text & "'," & 1 & "," & 80 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button40.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button40.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button41.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button41.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button41.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button41.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button41.Text & "'," & 1 & "," & 80 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button41.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button41.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button42.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button42.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button42.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button42.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button42.Text & "'," & 1 & "," & 80 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button42.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button42.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button49.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button49.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button49.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button49.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button49.Text & "'," & 1 & "," & 80 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button49.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button49.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button26_Click_1(sender As Object, e As EventArgs) Handles Button26.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button26.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button26.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button26.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button26.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button26.Text & "'," & 1 & "," & 80 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button26.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button26.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button27_Click_1(sender As Object, e As EventArgs) Handles Button27.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button27.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button27.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button27.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button27.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button27.Text & "'," & 1 & "," & 80 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button27.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button27.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button28_Click_1(sender As Object, e As EventArgs) Handles Button28.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button28.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button28.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button28.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button28.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button28.Text & "'," & 1 & "," & 80 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button28.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button28.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button30_Click_1(sender As Object, e As EventArgs) Handles Button30.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button30.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button30.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button30.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button30.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button30.Text & "'," & 1 & "," & 80 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button30.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button30.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button31_Click_1(sender As Object, e As EventArgs) Handles Button31.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button31.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button31.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button31.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button31.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button31.Text & "'," & 1 & "," & 80 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button31.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button31.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button146_Click_1(sender As Object, e As EventArgs) Handles Button146.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button146.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button146.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button146.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button146.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button146.Text & "'," & 1 & "," & 80 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button146.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button146.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button71_Click_1(sender As Object, e As EventArgs) Handles Button71.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button71.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button71.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button71.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button71.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button71.Text & "'," & 1 & "," & 80 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button71.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button71.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button68_Click_1(sender As Object, e As EventArgs) Handles Button68.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button68.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button68.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button68.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button68.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button68.Text & "'," & 1 & "," & 80 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button68.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button68.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button61_Click(sender As Object, e As EventArgs) Handles Button61.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button61.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button61.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button61.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button61.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button61.Text & "'," & 1 & "," & 80 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button61.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button61.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button60_Click(sender As Object, e As EventArgs) Handles Button60.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button60.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button60.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button60.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button60.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button60.Text & "'," & 1 & "," & 80 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button60.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button60.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button141_Click_1(sender As Object, e As EventArgs) Handles Button141.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button141.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button141.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button141.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button141.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button141.Text & "'," & 1 & "," & 90 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button141.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button141.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button64_Click(sender As Object, e As EventArgs) Handles Button64.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button64.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button64.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button64.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button64.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button64.Text & "'," & 1 & "," & 90 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button64.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button64.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button63_Click(sender As Object, e As EventArgs) Handles Button63.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button63.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button63.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button63.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button63.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button63.Text & "'," & 1 & "," & 90 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button63.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button63.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button59_Click(sender As Object, e As EventArgs) Handles Button59.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button59.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button59.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button59.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button59.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button59.Text & "'," & 1 & "," & 90 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button59.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button59.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Button56.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button56.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button56.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button56.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button56.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button56.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button56.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button56.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button57_Click(sender As Object, e As EventArgs) Handles Button57.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button57.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button57.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button57.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button57.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button57.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button57.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button57.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button58_Click(sender As Object, e As EventArgs) Handles Button58.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button58.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button58.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button58.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button58.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button58.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button58.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button58.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button55.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button55.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button55.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button55.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button55.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button55.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button55.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button50.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button50.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button50.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button50.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button50.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button50.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button50.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button51.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button51.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button51.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button51.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button51.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button51.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button51.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button52.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button52.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button52.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button52.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button52.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button52.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button52.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button53.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button53.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button53.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button53.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button53.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button53.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button53.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button54.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button54.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button54.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button54.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button54.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button54.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button54.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button17_Click_1(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button17.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button17.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button17.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button17.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button17.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button17.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button17.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button23_Click_1(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button23.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button23.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button23.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button23.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button23.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button23.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button23.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button24_Click_1(sender As Object, e As EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button24.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button24.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button24.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button24.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button24.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button24.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button24.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button47_Click_1(sender As Object, e As EventArgs) Handles Button47.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button47.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button47.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button47.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button47.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button47.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button47.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button47.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button43.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button43.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button43.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button43.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button43.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button43.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button43.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button46.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button46.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button46.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button46.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button46.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button46.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button46.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button44_Click_1(sender As Object, e As EventArgs) Handles Button44.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button44.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button44.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button44.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button44.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button44.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button44.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button44.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button45.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button45.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button45.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button45.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button45.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button45.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button45.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub



    Private Sub Button75_Click(sender As Object, e As EventArgs)

        Dim pa As Integer
        ds.Clear()

        getdata("select * from cart_tbl where product_name='" & txtprname.Text & "'")

        filldata("update cart_tbl set qty=" & txtqty.Text & " where product_name='" & txtprname.Text & "'")
        pa = CInt(txtqty.Text * txtprice.Text)
        filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & txtprname.Text & "'")
        ds.Clear()
        getdata("select * from cart_tbl")


    End Sub

    Private Sub Button78_Click(sender As Object, e As EventArgs)
        Dim pa As Integer
        ds.Clear()

        getdata("select * from cart_tbl where product_name='" & txtprname.Text & "'")

        filldata("update cart_tbl set qty=" & txtqty.Text & " where product_name='" & txtprname.Text & "'")
        pa = CInt(txtqty.Text * txtprice.Text)
        filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & txtprname.Text & "'")
        ds.Clear()
        getdata("select * from cart_tbl")

    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs)
        txtprname.Text = DataGridView1.SelectedRows(0).Cells(0).Value
        txtprice.Text = DataGridView1.SelectedRows(0).Cells(2).Value
        txtqty.Text = DataGridView1.SelectedRows(0).Cells(1).Value

    End Sub

    Private Sub Button107_Click_1(sender As Object, e As EventArgs) Handles Button107.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button107.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button107.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button107.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button107.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button107.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button107.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button107.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If

    End Sub

    Private Sub Button103_Click(sender As Object, e As EventArgs) Handles Button103.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button103.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button103.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button103.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button103.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button103.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button103.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button103.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button1.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button1.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button1.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button1.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button1.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button1.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button1.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button2.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button2.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button2.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button2.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button2.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button2.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button2.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If

    End Sub

    Private Sub Button105_Click(sender As Object, e As EventArgs) Handles Button105.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button105.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button105.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button105.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button105.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button105.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button105.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button105.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If

    End Sub

    Private Sub Button108_Click(sender As Object, e As EventArgs) Handles Button108.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button108.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button108.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button108.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button108.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button108.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button108.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button108.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If

    End Sub

    Private Sub Button109_Click(sender As Object, e As EventArgs) Handles Button109.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button109.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button109.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button109.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button109.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button109.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button109.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button109.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If

    End Sub

    Private Sub Button77_Click_1(sender As Object, e As EventArgs) Handles Button77.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button77.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button77.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button77.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button77.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button77.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button77.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button77.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button14_Click_1(sender As Object, e As EventArgs) Handles Button14.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button14.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button14.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button14.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button14.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button14.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button14.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button14.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button15_Click_1(sender As Object, e As EventArgs) Handles Button15.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button15.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button15.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button15.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button15.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button15.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button15.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button15.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button16_Click_1(sender As Object, e As EventArgs) Handles Button16.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button16.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button16.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button16.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button16.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button16.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button16.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button16.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button48_Click_1(sender As Object, e As EventArgs) Handles Button48.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button48.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button48.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button48.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button48.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button48.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button48.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button48.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button76_Click_1(sender As Object, e As EventArgs) Handles Button76.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button76.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button76.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button76.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button76.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button76.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button76.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button76.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button116_Click_1(sender As Object, e As EventArgs) Handles Button116.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button116.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button116.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button116.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button116.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button116.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button116.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button116.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button113_Click_1(sender As Object, e As EventArgs) Handles Button113.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button113.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button113.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button113.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button113.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button113.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button113.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button113.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button114_Click_1(sender As Object, e As EventArgs) Handles Button114.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button114.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button114.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button114.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button114.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button114.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button114.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button114.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button115_Click_1(sender As Object, e As EventArgs) Handles Button115.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button115.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button115.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button115.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button115.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button115.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button115.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button115.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button111_Click_1(sender As Object, e As EventArgs) Handles Button111.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button111.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button111.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button111.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button111.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button111.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button111.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button111.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button17_Click_2(sender As Object, e As EventArgs) Handles Button17.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button17.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button17.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button17.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button17.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button17.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button17.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button17.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button23_Click_2(sender As Object, e As EventArgs) Handles Button23.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button23.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button23.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button23.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button23.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button23.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button23.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button23.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button24_Click_2(sender As Object, e As EventArgs) Handles Button24.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button24.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button24.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button24.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button24.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button24.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button24.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button24.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button25_Click_1(sender As Object, e As EventArgs) Handles Button25.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button25.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button25.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button25.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button25.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button25.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button2.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button25.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button75_Click_1(sender As Object, e As EventArgs) Handles Button75.Click
        Dim total As Integer = 0
        Dim i As Integer
        For i = 0 To dt.Rows.Count - 1
            total += dt.Rows(i)(3)
        Next
        bill.Tag = total
        Me.Close()
        bill.Show()
    End Sub

    Private Sub Button78_Click_1(sender As Object, e As EventArgs) Handles Button78.Click

        Dim pa As Integer
        ds.Clear()

        getdata("select * from cart_tbl where product_name='" & txtprname.Text & "'")

        filldata("update cart_tbl set qty=" & txtqty.Text & " where product_name='" & txtprname.Text & "'")
        pa = CInt(txtqty.Text * txtprice.Text)
        filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & txtprname.Text & "'")
        ds.Clear()
        getdata("select * from cart_tbl")


    End Sub

    Private Sub DataGridView1_MouseClick_1(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        txtprname.Text = DataGridView1.SelectedRows(0).Cells(0).Value
        txtprice.Text = DataGridView1.SelectedRows(0).Cells(2).Value
        txtqty.Text = DataGridView1.SelectedRows(0).Cells(1).Value

    End Sub

    Private Sub Button79_Click(sender As Object, e As EventArgs) Handles Button79.Click
        ds.Clear()
        filldata("delete * from cart_tbl where product_name='" & txtprname.Text & "'")
        getdata("select * from cart_tbl")
    End Sub

    Private Sub Button33_Click_1(sender As Object, e As EventArgs) Handles Button33.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button33.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button33.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button33.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button33.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button33.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button33.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button33.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button34_Click_1(sender As Object, e As EventArgs) Handles Button34.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button34.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button34.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button34.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button34.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button34.Text & "'," & 1 & "," & 50 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button34.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button34.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button36_Click_1(sender As Object, e As EventArgs) Handles Button36.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button36.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button36.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button36.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button36.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button36.Text & "'," & 1 & "," & 150 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button36.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button36.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button38_Click_1(sender As Object, e As EventArgs) Handles Button38.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button38.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button38.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button38.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button38.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button38.Text & "'," & 1 & "," & 150 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button38.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button38.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button70_Click(sender As Object, e As EventArgs) Handles Button70.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button70.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button70.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button70.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button70.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button70.Text & "'," & 1 & "," & 150 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button70.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button70.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button72_Click(sender As Object, e As EventArgs) Handles Button72.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button72.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button72.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button72.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button72.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button72.Text & "'," & 1 & "," & 150 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button72.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button72.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button73_Click(sender As Object, e As EventArgs) Handles Button73.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button73.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button73.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button73.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button73.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button73.Text & "'," & 1 & "," & 150 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button73.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button73.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub Button74_Click(sender As Object, e As EventArgs) Handles Button74.Click
        Dim res As MsgBoxResult
        res = MsgBox("Do you want to Add this Item in Cart ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question)
        Dim pa, a As Integer
        If res = MsgBoxResult.Yes Then
            ds.Clear()
            getdata("select * from cart_tbl where product_name='" & Button74.Text & "'")
            If dt.Rows.Count = 1 Then
                a = dt.Rows(0)(1) + 1
                filldata("update cart_tbl set qty=" & a & " where product_name='" & Button74.Text & "'")
                ds.Clear()

                getdata("select * from cart_tbl where product_name='" & Button74.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button74.Text & "'")

            Else
                filldata("insert into cart_tbl values('" & Button74.Text & "'," & 1 & "," & 150 & "," & 0 & ")")
                getdata("select * from cart_tbl where product_name='" & Button74.Text & "'")

                pa = dt.Rows(0)(1) * dt.Rows(0)(2)

                filldata("update cart_tbl set payebal_tbl=" & pa & " where product_name='" & Button74.Text & "'")

            End If


            MsgBox("Your Item is Added into Cart")
            ds.Clear()
            getdata("select * from cart_tbl")
            DataGridView1.DataSource = dt


        Else
            MsgBox("This item is not added to the cart")
        End If
    End Sub

    Private Sub paneltitle_Paint(sender As Object, e As PaintEventArgs) Handles paneltitle.Paint

    End Sub
End Class