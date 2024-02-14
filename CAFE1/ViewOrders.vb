Imports System.Data.SqlClient
Public Class ViewOrders
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Cafe\CafeVb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub DisplayBill()
        con.Open()
        Dim query = "select * from OrderTable"
        Dim cmd = New SqlCommand(query, con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        grid_orders.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Private Sub ViewOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBill()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim obj = New Orders
        obj.Show()
        Me.Hide()
    End Sub
End Class