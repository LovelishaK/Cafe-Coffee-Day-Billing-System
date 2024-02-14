<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Items
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
        Me.lbl_mng_items = New System.Windows.Forms.Label()
        Me.lbl_mng_name = New System.Windows.Forms.Label()
        Me.btn_add_cat = New System.Windows.Forms.Button()
        Me.txt_mng_name = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.cmb_cat = New System.Windows.Forms.ComboBox()
        Me.lbl_cat = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.lbl_qty = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_itemlist = New System.Windows.Forms.Label()
        Me.lbl_logout = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.grid_items = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.grid_items, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_mng_items
        '
        Me.lbl_mng_items.AutoSize = True
        Me.lbl_mng_items.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mng_items.ForeColor = System.Drawing.Color.Red
        Me.lbl_mng_items.Location = New System.Drawing.Point(342, 9)
        Me.lbl_mng_items.Name = "lbl_mng_items"
        Me.lbl_mng_items.Size = New System.Drawing.Size(137, 24)
        Me.lbl_mng_items.TabIndex = 2
        Me.lbl_mng_items.Text = "Manage Items"
        '
        'lbl_mng_name
        '
        Me.lbl_mng_name.AutoSize = True
        Me.lbl_mng_name.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mng_name.ForeColor = System.Drawing.Color.Blue
        Me.lbl_mng_name.Location = New System.Drawing.Point(55, 59)
        Me.lbl_mng_name.Name = "lbl_mng_name"
        Me.lbl_mng_name.Size = New System.Drawing.Size(70, 24)
        Me.lbl_mng_name.TabIndex = 3
        Me.lbl_mng_name.Text = "Name:"
        '
        'btn_add_cat
        '
        Me.btn_add_cat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_cat.ForeColor = System.Drawing.Color.Blue
        Me.btn_add_cat.Location = New System.Drawing.Point(306, 59)
        Me.btn_add_cat.Name = "btn_add_cat"
        Me.btn_add_cat.Size = New System.Drawing.Size(139, 32)
        Me.btn_add_cat.TabIndex = 6
        Me.btn_add_cat.Text = "Add Category"
        Me.btn_add_cat.UseVisualStyleBackColor = True
        '
        'txt_mng_name
        '
        Me.txt_mng_name.Location = New System.Drawing.Point(150, 64)
        Me.txt_mng_name.Name = "txt_mng_name"
        Me.txt_mng_name.Size = New System.Drawing.Size(122, 20)
        Me.txt_mng_name.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_reset)
        Me.Panel1.Controls.Add(Me.btn_del)
        Me.Panel1.Controls.Add(Me.btn_edit)
        Me.Panel1.Controls.Add(Me.btn_add)
        Me.Panel1.Controls.Add(Me.cmb_cat)
        Me.Panel1.Controls.Add(Me.lbl_cat)
        Me.Panel1.Controls.Add(Me.txt_price)
        Me.Panel1.Controls.Add(Me.lbl_price)
        Me.Panel1.Controls.Add(Me.txt_qty)
        Me.Panel1.Controls.Add(Me.lbl_qty)
        Me.Panel1.Controls.Add(Me.txt_name)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(59, 97)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(780, 141)
        Me.Panel1.TabIndex = 8
        '
        'btn_reset
        '
        Me.btn_reset.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset.ForeColor = System.Drawing.Color.Blue
        Me.btn_reset.Location = New System.Drawing.Point(498, 109)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(84, 29)
        Me.btn_reset.TabIndex = 18
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'btn_del
        '
        Me.btn_del.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_del.ForeColor = System.Drawing.Color.Blue
        Me.btn_del.Location = New System.Drawing.Point(367, 109)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(84, 29)
        Me.btn_del.TabIndex = 17
        Me.btn_del.Text = "Delete"
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ForeColor = System.Drawing.Color.Blue
        Me.btn_edit.Location = New System.Drawing.Point(230, 109)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(84, 29)
        Me.btn_edit.TabIndex = 16
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.Blue
        Me.btn_add.Location = New System.Drawing.Point(109, 109)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(84, 29)
        Me.btn_add.TabIndex = 9
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'cmb_cat
        '
        Me.cmb_cat.FormattingEnabled = True
        Me.cmb_cat.Location = New System.Drawing.Point(212, 60)
        Me.cmb_cat.Name = "cmb_cat"
        Me.cmb_cat.Size = New System.Drawing.Size(121, 21)
        Me.cmb_cat.TabIndex = 15
        '
        'lbl_cat
        '
        Me.lbl_cat.AutoSize = True
        Me.lbl_cat.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cat.ForeColor = System.Drawing.Color.Blue
        Me.lbl_cat.Location = New System.Drawing.Point(208, 17)
        Me.lbl_cat.Name = "lbl_cat"
        Me.lbl_cat.Size = New System.Drawing.Size(106, 24)
        Me.lbl_cat.TabIndex = 14
        Me.lbl_cat.Text = "Categories"
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(398, 60)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(122, 20)
        Me.txt_price.TabIndex = 13
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.ForeColor = System.Drawing.Color.Blue
        Me.lbl_price.Location = New System.Drawing.Point(394, 17)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(57, 24)
        Me.lbl_price.TabIndex = 12
        Me.lbl_price.Text = "Price"
        '
        'txt_qty
        '
        Me.txt_qty.Location = New System.Drawing.Point(596, 60)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(122, 20)
        Me.txt_qty.TabIndex = 11
        '
        'lbl_qty
        '
        Me.lbl_qty.AutoSize = True
        Me.lbl_qty.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qty.ForeColor = System.Drawing.Color.Blue
        Me.lbl_qty.Location = New System.Drawing.Point(592, 17)
        Me.lbl_qty.Name = "lbl_qty"
        Me.lbl_qty.Size = New System.Drawing.Size(88, 24)
        Me.lbl_qty.TabIndex = 10
        Me.lbl_qty.Text = "Quantity"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(29, 61)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(122, 20)
        Me.txt_name.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(25, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Name:"
        '
        'lbl_itemlist
        '
        Me.lbl_itemlist.AutoSize = True
        Me.lbl_itemlist.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_itemlist.ForeColor = System.Drawing.Color.Blue
        Me.lbl_itemlist.Location = New System.Drawing.Point(366, 250)
        Me.lbl_itemlist.Name = "lbl_itemlist"
        Me.lbl_itemlist.Size = New System.Drawing.Size(90, 24)
        Me.lbl_itemlist.TabIndex = 9
        Me.lbl_itemlist.Text = "Item List"
        '
        'lbl_logout
        '
        Me.lbl_logout.AutoSize = True
        Me.lbl_logout.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_logout.ForeColor = System.Drawing.Color.Blue
        Me.lbl_logout.Location = New System.Drawing.Point(12, 398)
        Me.lbl_logout.Name = "lbl_logout"
        Me.lbl_logout.Size = New System.Drawing.Size(100, 24)
        Me.lbl_logout.TabIndex = 10
        Me.lbl_logout.Text = "LOGOUT"
        '
        'BackgroundWorker2
        '
        '
        'grid_items
        '
        Me.grid_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_items.GridColor = System.Drawing.Color.Violet
        Me.grid_items.Location = New System.Drawing.Point(118, 293)
        Me.grid_items.Name = "grid_items"
        Me.grid_items.Size = New System.Drawing.Size(721, 129)
        Me.grid_items.TabIndex = 12
        '
        'Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 431)
        Me.Controls.Add(Me.grid_items)
        Me.Controls.Add(Me.lbl_logout)
        Me.Controls.Add(Me.lbl_itemlist)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_mng_name)
        Me.Controls.Add(Me.btn_add_cat)
        Me.Controls.Add(Me.lbl_mng_name)
        Me.Controls.Add(Me.lbl_mng_items)
        Me.Name = "Items"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grid_items, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_mng_items As Label
    Friend WithEvents lbl_mng_name As Label
    Friend WithEvents btn_add_cat As Button
    Friend WithEvents txt_mng_name As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_cat As ComboBox
    Friend WithEvents lbl_cat As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents lbl_price As Label
    Friend WithEvents txt_qty As TextBox
    Friend WithEvents lbl_qty As Label
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_del As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents lbl_itemlist As Label
    Friend WithEvents lbl_logout As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_reset As Button
    Friend WithEvents grid_items As DataGridView
End Class
