Imports System.Data.SqlClient
Public Class Orders
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Cafe\CafeVb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub lbl_logout_Click(sender As Object, e As EventArgs) Handles lbl_logout.Click
        Dim obj = New frm_login
        obj.Show()
        Me.Hide()
    End Sub
    Private Sub FillCategory()
        con.Open()
        Dim cmd = New SqlCommand("Select * from CategoryTable", con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim tbl = New DataTable
        adapter.Fill(tbl)
        cmb_cat.DataSource = tbl
        cmb_cat.DisplayMember = "catName"
        cmb_cat.ValueMember = "catName"
        con.Close()
    End Sub
    Private Sub DisplayItem()
        con.Open()
        Dim query = "select * from ItemTable"
        Dim cmd = New SqlCommand(query, con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        grid_orders.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Private Sub FilterByCategory()
        con.Open()
        Dim query = "select * from ItemTable where itemCat='" & cmb_cat.Text & "'"
        Dim cmd = New SqlCommand(query, con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        grid_orders.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Private Sub btn_add_cat_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayItem()
        FillCategory()
    End Sub
    Private Sub cmb_cat_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_cat.SelectionChangeCommitted
        FilterByCategory()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        DisplayItem()
    End Sub

    Private Sub grid_view_order_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_view_order.CellContentClick

    End Sub
    Dim prodname As String
    Dim i = 0, qty, price
    Dim gridTotal = 0
    Private Sub updateItem()
        Try
            Dim newqty = stock - Convert.ToInt32(txt_qty.Text)
            con.open()
            Dim query = "update ItemTable set itemQty=" & newqty & " where itemID=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item Edited")
            con.close()

            DisplayItem()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btn_add_to_bill_Click(sender As Object, e As EventArgs) Handles btn_add_to_bill.Click
        If key = 0 Then
            MessageBox.Show("Select an item")
        ElseIf Convert.ToInt32(txt_qty.text) > stock Then
            MessageBox.Show("No Enough Stock")
        Else
            Dim rnum As Integer = grid_view_order.Rows.Add()
            Dim total = Convert.ToInt32(txt_qty.Text) * price
            i = i + 1
            grid_view_order.Rows.Item(rnum).Cells("Column1").Value = i
            grid_view_order.Rows.Item(rnum).Cells("Column2").Value = prodname
            grid_view_order.Rows.Item(rnum).Cells("Column3").Value = txt_qty.Text
            grid_view_order.Rows.Item(rnum).Cells("Column4").Value = price
            grid_view_order.Rows.Item(rnum).Cells("Column5").Value = total
            gridTotal = gridTotal + total
            lbl_total.Text = "RS. " + Convert.ToString(gridTotal)
            updateItem()
            txt_qty.Text = ""
            key = 0
        End If
    End Sub
    Private Sub addBill()
        con.open()
        Dim query = "insert into OrderTable values('" & DateAndTime.Today.Date & "'," & gridTotal & ")"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Bill added")
        con.close()
    End Sub
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        addBill()
        PrintPreviewDialog1.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("CAFE COFFEE", New Font("Arial", 22), Brushes.BlueViolet, 335, 35)
        e.Graphics.DrawString("***YourBill***", New Font("Arial", 14), Brushes.BlueViolet, 350, 60)

        Dim bm As New Bitmap(Me.grid_orders.Width, grid_orders.Height)
        grid_orders.DrawToBitmap(bm, New Rectangle(0, 0, Me.grid_orders.Width, Me.grid_orders.Height))
        e.Graphics.DrawImage(bm, 0, 99)
        e.Graphics.DrawString("Total Amount" + gridTotal.ToString(), New Font("Arial", 15), Brushes.Crimson, 325, 580)
        e.Graphics.DrawString("**********THANKS FOR BUYING!! VISIT AGAIN!!!**********", New Font("Arial", 15), Brushes.Crimson, 130, 600)

    End Sub

    Private Sub btn_vieworder_Click(sender As Object, e As EventArgs) Handles btn_vieworder.Click
        Dim obj = New ViewOrders
        obj.Show()
        Me.Hide()
    End Sub

    Dim key = 0, stock
    Private Sub grid_orders_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grid_orders.CellMouseClick
        Dim row As DataGridViewRow = grid_orders.Rows(e.RowIndex)
        prodname = row.Cells(1).Value.ToString
        If prodname = "" Then
            key = 0
            stock = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
            stock = Convert.ToInt32(row.Cells(4).Value.ToString)
            price = Convert.ToInt32(row.Cells(3).Value.ToString)
        End If
    End Sub
End Class