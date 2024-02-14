<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orders
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Orders))
        Me.lbl_your_order = New System.Windows.Forms.Label()
        Me.btn_add_to_bill = New System.Windows.Forms.Button()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.lbl_qty = New System.Windows.Forms.Label()
        Me.lbl_mng_items = New System.Windows.Forms.Label()
        Me.cmb_cat = New System.Windows.Forms.ComboBox()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.lbl_place_order = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.btn_vieworder = New System.Windows.Forms.Button()
        Me.lbl_logout = New System.Windows.Forms.Label()
        Me.grid_orders = New System.Windows.Forms.DataGridView()
        Me.grid_view_order = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.grid_orders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_view_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_your_order
        '
        Me.lbl_your_order.AutoSize = True
        Me.lbl_your_order.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_your_order.ForeColor = System.Drawing.Color.Blue
        Me.lbl_your_order.Location = New System.Drawing.Point(352, 254)
        Me.lbl_your_order.Name = "lbl_your_order"
        Me.lbl_your_order.Size = New System.Drawing.Size(111, 24)
        Me.lbl_your_order.TabIndex = 15
        Me.lbl_your_order.Text = "Your Order"
        '
        'btn_add_to_bill
        '
        Me.btn_add_to_bill.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_to_bill.ForeColor = System.Drawing.Color.Blue
        Me.btn_add_to_bill.Location = New System.Drawing.Point(647, 212)
        Me.btn_add_to_bill.Name = "btn_add_to_bill"
        Me.btn_add_to_bill.Size = New System.Drawing.Size(109, 29)
        Me.btn_add_to_bill.TabIndex = 17
        Me.btn_add_to_bill.Text = "Add To Bill"
        Me.btn_add_to_bill.UseVisualStyleBackColor = True
        '
        'txt_qty
        '
        Me.txt_qty.Location = New System.Drawing.Point(486, 221)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(122, 20)
        Me.txt_qty.TabIndex = 11
        '
        'lbl_qty
        '
        Me.lbl_qty.AutoSize = True
        Me.lbl_qty.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qty.ForeColor = System.Drawing.Color.Blue
        Me.lbl_qty.Location = New System.Drawing.Point(380, 212)
        Me.lbl_qty.Name = "lbl_qty"
        Me.lbl_qty.Size = New System.Drawing.Size(88, 24)
        Me.lbl_qty.TabIndex = 10
        Me.lbl_qty.Text = "Quantity"
        '
        'lbl_mng_items
        '
        Me.lbl_mng_items.AutoSize = True
        Me.lbl_mng_items.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mng_items.ForeColor = System.Drawing.Color.Red
        Me.lbl_mng_items.Location = New System.Drawing.Point(300, 24)
        Me.lbl_mng_items.Name = "lbl_mng_items"
        Me.lbl_mng_items.Size = New System.Drawing.Size(137, 24)
        Me.lbl_mng_items.TabIndex = 10
        Me.lbl_mng_items.Text = "Manage Items"
        '
        'cmb_cat
        '
        Me.cmb_cat.FormattingEnabled = True
        Me.cmb_cat.Location = New System.Drawing.Point(17, 50)
        Me.cmb_cat.Name = "cmb_cat"
        Me.cmb_cat.Size = New System.Drawing.Size(132, 21)
        Me.cmb_cat.TabIndex = 16
        '
        'btn_refresh
        '
        Me.btn_refresh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.ForeColor = System.Drawing.Color.Blue
        Me.btn_refresh.Location = New System.Drawing.Point(155, 50)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(118, 24)
        Me.btn_refresh.TabIndex = 18
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'lbl_place_order
        '
        Me.lbl_place_order.AutoSize = True
        Me.lbl_place_order.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_place_order.ForeColor = System.Drawing.Color.Blue
        Me.lbl_place_order.Location = New System.Drawing.Point(564, 50)
        Me.lbl_place_order.Name = "lbl_place_order"
        Me.lbl_place_order.Size = New System.Drawing.Size(90, 24)
        Me.lbl_place_order.TabIndex = 19
        Me.lbl_place_order.Text = "Item List"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.Blue
        Me.lbl_total.Location = New System.Drawing.Point(352, 420)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(55, 24)
        Me.lbl_total.TabIndex = 22
        Me.lbl_total.Text = "Total"
        '
        'btn_print
        '
        Me.btn_print.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.ForeColor = System.Drawing.Color.Blue
        Me.btn_print.Location = New System.Drawing.Point(220, 415)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(91, 32)
        Me.btn_print.TabIndex = 22
        Me.btn_print.Text = "Print"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'btn_vieworder
        '
        Me.btn_vieworder.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vieworder.ForeColor = System.Drawing.Color.Blue
        Me.btn_vieworder.Location = New System.Drawing.Point(456, 412)
        Me.btn_vieworder.Name = "btn_vieworder"
        Me.btn_vieworder.Size = New System.Drawing.Size(117, 32)
        Me.btn_vieworder.TabIndex = 23
        Me.btn_vieworder.Text = "View Order"
        Me.btn_vieworder.UseVisualStyleBackColor = True
        '
        'lbl_logout
        '
        Me.lbl_logout.AutoSize = True
        Me.lbl_logout.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_logout.ForeColor = System.Drawing.Color.Blue
        Me.lbl_logout.Location = New System.Drawing.Point(13, 420)
        Me.lbl_logout.Name = "lbl_logout"
        Me.lbl_logout.Size = New System.Drawing.Size(100, 24)
        Me.lbl_logout.TabIndex = 24
        Me.lbl_logout.Text = "LOGOUT"
        '
        'grid_orders
        '
        Me.grid_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_orders.Location = New System.Drawing.Point(328, 87)
        Me.grid_orders.Name = "grid_orders"
        Me.grid_orders.Size = New System.Drawing.Size(490, 112)
        Me.grid_orders.TabIndex = 25
        '
        'grid_view_order
        '
        Me.grid_view_order.ColumnHeadersHeight = 30
        Me.grid_view_order.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.grid_view_order.Location = New System.Drawing.Point(37, 278)
        Me.grid_view_order.Name = "grid_view_order"
        Me.grid_view_order.Size = New System.Drawing.Size(781, 131)
        Me.grid_view_order.TabIndex = 26
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Product"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Quantity"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Price"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Total"
        Me.Column5.Name = "Column5"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 450)
        Me.Controls.Add(Me.grid_view_order)
        Me.Controls.Add(Me.grid_orders)
        Me.Controls.Add(Me.lbl_logout)
        Me.Controls.Add(Me.btn_vieworder)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.btn_add_to_bill)
        Me.Controls.Add(Me.lbl_place_order)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.cmb_cat)
        Me.Controls.Add(Me.txt_qty)
        Me.Controls.Add(Me.lbl_your_order)
        Me.Controls.Add(Me.lbl_qty)
        Me.Controls.Add(Me.lbl_mng_items)
        Me.Name = "Orders"
        Me.Text = "Orders"
        CType(Me.grid_orders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_view_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_your_order As Label
    Friend WithEvents btn_add_to_bill As Button
    Friend WithEvents txt_qty As TextBox
    Friend WithEvents lbl_qty As Label
    Friend WithEvents lbl_mng_items As Label
    Friend WithEvents cmb_cat As ComboBox
    Friend WithEvents btn_refresh As Button
    Friend WithEvents lbl_place_order As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents btn_print As Button
    Friend WithEvents btn_vieworder As Button
    Friend WithEvents lbl_logout As Label
    Friend WithEvents grid_orders As DataGridView
    Friend WithEvents grid_view_order As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
