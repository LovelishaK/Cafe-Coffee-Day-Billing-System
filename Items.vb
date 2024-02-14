Imports System.Data.SqlClient
Public Class Items
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Cafe\CafeVb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCategory()
        DisplayItem()
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork

    End Sub

    Private Sub lbl_logout_Click(sender As Object, e As EventArgs) Handles lbl_logout.Click
        Dim obj = New frm_login
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub btn_add_cat_Click(sender As Object, e As EventArgs) Handles btn_add_cat.Click
        Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Cafe\CafeVb.mdf;Integrated Security=True;Connect Timeout=30")
        If txt_mng_name.Text = "" Then
            MessageBox.Show("Enter Category")
        Else
            con.open()
            Dim query = "insert into CategoryTable  values('" & txt_mng_name.Text & " ')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Category added")
            con.close()
            txt_mng_name.Text = ""
            FillCategory()
        End If

    End Sub

    Private Sub Reset()
        txt_name.Text = ""
        cmb_cat.SelectedIndex = 0
        txt_qty.Text = ""
        txt_price.Text = ""
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
    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        Reset()
    End Sub
    Private Sub DisplayItem()
        con.Open()
        Dim query = "select * from ItemTable"
        Dim cmd = New SqlCommand(query, con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        grid_items.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If cmb_cat.SelectedIndex = -1 Or txt_name.Text = "" Or txt_price.Text = "" Or txt_qty.Text = "" Then
            MessageBox.Show("Missing Information")
        Else
            con.open()
            Dim query = "insert into ItemTable values('" & txt_name.Text & "','" & cmb_cat.Text & "'," & txt_price.Text & "," & txt_qty.Text & ")"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added")
            con.close()
            Reset()
            DisplayItem()
        End If
    End Sub
    Dim key = 0
    Private Sub grid_items_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_items.CellContentClick
        Dim row As DataGridViewRow = grid_items.Rows(e.RowIndex)
        txt_name.Text = row.Cells(1).Value.ToString
        cmb_cat.SelectedValue = row.Cells(2).Value.ToString
        txt_price.Text = row.Cells(3).Value.ToString
        txt_qty.Text = row.Cells(4).Value.ToString
        If txt_name.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        If key = 0 Then
            MessageBox.Show("Select the Item to Delete")
        Else
            con.open()
            Dim query = "delete from ItemTable where itemID=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item Deleted")
            con.close()
            Reset()
            DisplayItem()
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If cmb_cat.SelectedIndex = -1 Or txt_name.Text = "" Or txt_price.Text = "" Or txt_qty.Text = "" Then
            MessageBox.Show("Missing Information")
        Else
            Try
                con.open()
                Dim query = "update ItemTable set itemName='" & txt_name.Text & "',itemCat='" & cmb_cat.Text & "',itemPrice=" & txt_price.Text & ",itemQty=" & txt_qty.Text & " where itemID=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Item Edited")
                con.close()
                Reset()
                DisplayItem()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class