Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Windows.Win32

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbProductos.Items.Clear()
        cmbProductos.Items.Add("Anillo de Oro")
        cmbProductos.Items.Add("Reloj de Gala")
        cmbProductos.Items.Add("Collar Esmeralda")

        cmbProductos.SelectedIndex = 0 ' Seleccionar el primero por defecto
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCarrito.CellContentClick

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblTotal.Click
        Dim total As Decimal = 0

        ' Recorrer cada fila de la tabla y sumar la columna del subtotal (Columna índice 3)
        For Each fila As DataGridViewRow In dgvCarrito.Rows
            total += CDec(fila.Cells(3).Value)
        Next

        lblTotal.Text = "TOTAL: Q. " & total.ToString("N2")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picFoto.Click

    End Sub

    Private Sub cmbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductos.SelectedIndexChanged
        Select Case cmbProductos.SelectedIndex
            Case 0
                lblPrecio.Text = "1250.00"
                ' picFoto.Image = Image.FromFile("C:\imagenes\anillo.jpg") ' Descomenta si tienes imágenes en tu PC
            Case 1
                lblPrecio.Text = "2400.00"
                ' picFoto.Image = Image.FromFile("C:\imagenes\reloj.jpg")
            Case 2
                lblPrecio.Text = "3100.00"
                ' picFoto.Image = Image.FromFile("C:\imagenes\collar.jpg")
        End Select
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nombre As String = cmbProductos.SelectedItem.ToString()
        Dim precio As Decimal = CDec(lblPrecio.Text)
        Dim cantidad As Integer = CInt(numCantidad.Value)
        Dim subtotal As Decimal = precio * cantidad

        dgvCarrito.Rows.Add(nombre, "Q. " & precio, cantidad, subtotal)

        ' === AQUÍ LLAMAS A LA RUTINA ===
        CalcularTotal()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvCarrito.SelectedRows.Count > 0 Then
            dgvCarrito.Rows.Remove(dgvCarrito.SelectedRows(0))

            ' === AQUÍ TAMBIÉN LA LLAMAS ===
            CalcularTotal()
        Else
            MessageBox.Show("Selecciona una fila de la tabla para eliminar.")
        End If
    End Sub

    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click
        ' 1. Validar que la tabla tenga productos cargados
        If dgvCarrito.Rows.Count = 0 OrElse (dgvCarrito.Rows.Count = 1 AndAlso dgvCarrito.Rows(0).IsNewRow) Then
            MessageBox.Show("El carrito está vacío. Agrega productos primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim factura As String = "=== FACTURA DE COMPRA ===" & vbCrLf & vbCrLf

        ' 2. Recorrer la tabla e ignorar la fila vacía de edición
        For Each fila As DataGridViewRow In dgvCarrito.Rows
            If Not fila.IsNewRow AndAlso fila.Cells(0).Value IsNot Nothing Then
                Dim prod As String = fila.Cells(0).Value.ToString()
                Dim cant As String = fila.Cells(2).Value.ToString()
                Dim subt As String = fila.Cells(3).Value.ToString()

                factura &= prod & " (x" & cant & ") = Q. " & subt & vbCrLf
            End If
        Next

        factura &= vbCrLf & "----------------------------" & vbCrLf
        factura &= lblTotal.Text & vbCrLf
        factura &= "¡Gracias por su compra!"

        ' 3. Mostrar la ventana emergente con la factura
        MessageBox.Show(factura, "Factura Generada", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' 4. Limpiar la tabla y reiniciar el total
        dgvCarrito.Rows.Clear()
        lblTotal.Text = "TOTAL: Q. 0.00"

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub CalcularTotal_TextChanged(sender As Object, e As EventArgs) Handles lblTotal.TextChanged

    End Sub

    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub

    Private Sub CalcularTotal()
        Dim total As Decimal = 0

        ' Suma los valores de la columna Subtotal (Columna 3) de cada fila
        For Each fila As DataGridViewRow In dgvCarrito.Rows
            total += CDec(fila.Cells(3).Value)
        Next

        ' Asigna el resultado al Label (revisa llevar el signo = y la propiedad .Text)
        lblTotal.Text = "TOTAL: Q. " & total.ToString("N2")
    End Sub
End Class