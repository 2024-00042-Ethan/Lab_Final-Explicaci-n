<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        ArchivoToolStripMenuItem = New ToolStripMenuItem()
        InventarioToolStripMenuItem = New ToolStripMenuItem()
        AyudaToolStripMenuItem = New ToolStripMenuItem()
        Panel1 = New Panel()
        btnAgregar = New Button()
        Label7 = New Label()
        lblPrecio = New TextBox()
        numCantidad = New NumericUpDown()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        cmbProductos = New ComboBox()
        Panel2 = New Panel()
        Label8 = New Label()
        picFoto = New PictureBox()
        Panel3 = New Panel()
        Label6 = New Label()
        dgvCarrito = New DataGridView()
        Productos = New DataGridViewTextBoxColumn()
        Precio = New DataGridViewTextBoxColumn()
        Cantidad = New DataGridViewTextBoxColumn()
        Subtotal = New DataGridViewTextBoxColumn()
        Panel4 = New Panel()
        Label5 = New Label()
        btnFacturar = New Button()
        btnEliminar = New Button()
        lblTotal = New Label()
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(numCantidad, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(dgvCarrito, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem, InventarioToolStripMenuItem, AyudaToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1125, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(60, 20)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' InventarioToolStripMenuItem
        ' 
        InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        InventarioToolStripMenuItem.Size = New Size(72, 20)
        InventarioToolStripMenuItem.Text = "Inventario"
        ' 
        ' AyudaToolStripMenuItem
        ' 
        AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        AyudaToolStripMenuItem.Size = New Size(53, 20)
        AyudaToolStripMenuItem.Text = "Ayuda"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnAgregar)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(lblPrecio)
        Panel1.Controls.Add(numCantidad)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(cmbProductos)
        Panel1.Location = New Point(24, 49)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(475, 296)
        Panel1.TabIndex = 1
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        btnAgregar.Font = New Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAgregar.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        btnAgregar.Location = New Point(31, 197)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(394, 65)
        btnAgregar.TabIndex = 7
        btnAgregar.Text = "+ AGREGAR AL CARRITO"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(25, 22)
        Label7.Name = "Label7"
        Label7.Size = New Size(204, 30)
        Label7.TabIndex = 6
        Label7.Text = "PANEL SELECCIÓN"
        ' 
        ' lblPrecio
        ' 
        lblPrecio.Location = New Point(209, 137)
        lblPrecio.Name = "lblPrecio"
        lblPrecio.Size = New Size(100, 23)
        lblPrecio.TabIndex = 5
        ' 
        ' numCantidad
        ' 
        numCantidad.Location = New Point(26, 137)
        numCantidad.Name = "numCantidad"
        numCantidad.Size = New Size(120, 23)
        numCantidad.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(209, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 15)
        Label3.TabIndex = 3
        Label3.Text = "Precio Unitario:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 119)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 15)
        Label2.TabIndex = 2
        Label2.Text = "Cantidad:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(26, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 15)
        Label1.TabIndex = 1
        Label1.Text = "Productos:"
        ' 
        ' cmbProductos
        ' 
        cmbProductos.FormattingEnabled = True
        cmbProductos.Location = New Point(25, 93)
        cmbProductos.Name = "cmbProductos"
        cmbProductos.Size = New Size(121, 23)
        cmbProductos.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(picFoto)
        Panel2.Location = New Point(618, 49)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(475, 296)
        Panel2.TabIndex = 2
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(36, 22)
        Label8.Name = "Label8"
        Label8.Size = New Size(155, 30)
        Label8.TabIndex = 7
        Label8.Text = "VISTA PREVIA"
        ' 
        ' picFoto
        ' 
        picFoto.Location = New Point(36, 75)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(414, 217)
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(dgvCarrito)
        Panel3.Location = New Point(24, 351)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1069, 317)
        Panel3.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(434, 11)
        Label6.Name = "Label6"
        Label6.Size = New Size(207, 30)
        Label6.TabIndex = 5
        Label6.Text = "Carrito de compras"
        ' 
        ' dgvCarrito
        ' 
        dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCarrito.Columns.AddRange(New DataGridViewColumn() {Productos, Precio, Cantidad, Subtotal})
        dgvCarrito.Location = New Point(26, 63)
        dgvCarrito.Name = "dgvCarrito"
        dgvCarrito.Size = New Size(1018, 242)
        dgvCarrito.TabIndex = 0
        ' 
        ' Productos
        ' 
        Productos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Productos.HeaderText = "Productos"
        Productos.Name = "Productos"
        ' 
        ' Precio
        ' 
        Precio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Precio.HeaderText = "Precio Q."
        Precio.Name = "Precio"
        ' 
        ' Cantidad
        ' 
        Cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Cantidad.HeaderText = "Cantidad"
        Cantidad.Name = "Cantidad"
        ' 
        ' Subtotal
        ' 
        Subtotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Subtotal.HeaderText = "Subtotal"
        Subtotal.Name = "Subtotal"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(lblTotal)
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(btnFacturar)
        Panel4.Controls.Add(btnEliminar)
        Panel4.Location = New Point(26, 693)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1067, 277)
        Panel4.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(323, 20)
        Label5.Name = "Label5"
        Label5.Size = New Size(360, 32)
        Label5.TabIndex = 4
        Label5.Text = "PANEL DE ACCIONES Y TOTAL"
        ' 
        ' btnFacturar
        ' 
        btnFacturar.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        btnFacturar.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        btnFacturar.ForeColor = Color.White
        btnFacturar.Location = New Point(412, 90)
        btnFacturar.Name = "btnFacturar"
        btnFacturar.Size = New Size(176, 66)
        btnFacturar.TabIndex = 1
        btnFacturar.Text = "GENERAR FACTURA"
        btnFacturar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnEliminar.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEliminar.ForeColor = Color.White
        btnEliminar.Location = New Point(96, 90)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(176, 66)
        btnEliminar.TabIndex = 0
        btnEliminar.Text = "- Eliminar Item"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI Symbol", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(720, 111)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(147, 25)
        lblTotal.TabIndex = 5
        lblTotal.Text = "TOTAL: Q. 0.00"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1125, 1028)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(numCantidad, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(dgvCarrito, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbProductos As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgvCarrito As DataGridView
    Friend WithEvents Productos As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnFacturar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPrecio As TextBox
    Friend WithEvents numCantidad As NumericUpDown
    Friend WithEvents lblTotal As Label

End Class
