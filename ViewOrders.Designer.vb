<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewOrders
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
        Me.lbl_order_list = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.grid_orders = New System.Windows.Forms.DataGridView()
        CType(Me.grid_orders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_order_list
        '
        Me.lbl_order_list.AutoSize = True
        Me.lbl_order_list.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order_list.ForeColor = System.Drawing.Color.Blue
        Me.lbl_order_list.Location = New System.Drawing.Point(328, 9)
        Me.lbl_order_list.Name = "lbl_order_list"
        Me.lbl_order_list.Size = New System.Drawing.Size(102, 24)
        Me.lbl_order_list.TabIndex = 11
        Me.lbl_order_list.Text = "Order List"
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.Blue
        Me.btn_back.Location = New System.Drawing.Point(291, 343)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(139, 32)
        Me.btn_back.TabIndex = 16
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'grid_orders
        '
        Me.grid_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_orders.Location = New System.Drawing.Point(34, 62)
        Me.grid_orders.Name = "grid_orders"
        Me.grid_orders.Size = New System.Drawing.Size(744, 257)
        Me.grid_orders.TabIndex = 26
        '
        'ViewOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grid_orders)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lbl_order_list)
        Me.Name = "ViewOrders"
        Me.Text = "ViewOrders"
        CType(Me.grid_orders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_order_list As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents grid_orders As DataGridView
End Class
