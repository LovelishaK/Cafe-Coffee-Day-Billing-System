Public Class frm_login
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim obj = Orders
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_uname.Text = "" Or txt_pass.Text = "" Then
            MessageBox.Show("Enter User Name and Password")
        ElseIf txt_uname.Text = "Admin" And txt_pass.Text = "Admin" Then
            Dim obj = New Items
            obj.Show()
            Me.Hide()
        Else
            MessageBox.Show("Wrong User Name or Password")
            txt_uname.Text = ""
            txt_pass.Text = ""
        End If
    End Sub
End Class
