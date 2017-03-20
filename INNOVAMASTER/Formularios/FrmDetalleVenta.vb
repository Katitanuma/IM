﻿Imports System.Data.SqlClient
Public Class FrmDetalleVenta
    Dim Conec As New Conexion
    Dim cmd As SqlCommand

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDetalle.CellEndEdit
        Dim column As Integer = DgvDetalle.CurrentCell.ColumnIndex
        If column = 1 Then
            Try
                If DgvDetalle.Rows(e.RowIndex).Cells(1).Value <> Nothing Then

                    Conec.Conectarse()
                    Dim c As String = DgvDetalle.Rows(e.RowIndex).Cells(1).Value.ToString
                    Dim c2 As String() = c.Split("__")
                    DgvDetalle.Rows(e.RowIndex).Cells(1).Value = c2(0).ToString

                    Dim dr As SqlDataReader
                    cmd = New SqlCommand("Select Descripcion,Gravado,Gravado,PrecioUnitario, PrecioMayorista, Existencia, Estado from Producto Where IdProducto='" & DgvDetalle.Rows(e.RowIndex).Cells(1).Value & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Conec.Con
                    dr = cmd.ExecuteReader

                    If dr.Read Then
                        If dr.GetValue(6).ToString = "Activo" Then
                            DgvDetalle.Rows(e.RowIndex).Cells(2).Value = dr(0).ToString

                            Dim ex As Integer
                            ex = CInt(dr.GetValue(5)) - 5
                            If ex = 0 Then
                                MsgBox("No hay existencia de ese producto", MsgBoxStyle.Critical)
                                DgvDetalle.Rows.Remove(DgvDetalle.CurrentRow)
                                LlenarTextBox()
                            Else
                                DgvDetalle.Rows(e.RowIndex).Cells(3).Value = 1
                                If LblFormaVenta.Text = "Mayoreo" Then
                                    DgvDetalle.Rows(e.RowIndex).Cells(4).Value = FormatCurrency(CDbl(dr(4)))
                                Else
                                    DgvDetalle.Rows(e.RowIndex).Cells(4).Value = FormatCurrency(CDbl(dr(3)))
                                End If

                                DgvDetalle.Rows(e.RowIndex).Cells(5).Value = 0
                                DgvDetalle.Rows(e.RowIndex).Cells(6).Value = FormatCurrency(0)
                                DgvDetalle.Rows(e.RowIndex).Cells(7).Value = FormatCurrency(CDbl(dr.GetValue(1)), 2)
                                DgvDetalle.Rows(e.RowIndex).Cells(8).Value = FormatCurrency((DgvDetalle.Rows(e.RowIndex).Cells(3).Value) * CDbl(DgvDetalle.Rows(e.RowIndex).Cells(4).Value), 2)
                            End If
                        Else
                            MsgBox("El estado del producto está inactivo", MsgBoxStyle.Exclamation)
                            DgvDetalle.Rows.Remove(DgvDetalle.CurrentRow)
                            LlenarTextBox()

                        End If

                    Else
                        MsgBox("Producto no registrado", MsgBoxStyle.Information)

                    End If
                Else
                    MsgBox("Debe ingresar el código del producto", MsgBoxStyle.Information)
                    DgvDetalle.Rows(e.RowIndex).Cells(1).Selected = True

                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Conec.Desconectarse()
            End Try
        ElseIf column = 3 Then
            Conec.Conectarse()
            Dim dr2 As SqlDataReader

            cmd = New SqlCommand("Select Gravado from Producto Where IdProducto='" & DgvDetalle.Rows(e.RowIndex).Cells(1).Value & "'")
            cmd.CommandType = CommandType.Text
            cmd.Connection = Conec.Con
            dr2 = cmd.ExecuteReader
            If dr2.Read() Then
                DgvDetalle.Rows(e.RowIndex).Cells(7).Value = FormatCurrency(CDbl(DgvDetalle.Rows(e.RowIndex).Cells(3).Value) * CDbl(dr2.GetValue(0)), 2)
            End If


            DgvDetalle.Rows(e.RowIndex).Cells(8).Value = FormatCurrency(CDbl(DgvDetalle.Rows(e.RowIndex).Cells(3).Value) * CDbl(DgvDetalle.Rows(e.RowIndex).Cells(4).Value), 2)
            If DgvDetalle.CurrentRow.Cells(3).Value = Nothing Or DgvDetalle.CurrentRow.Cells(3).Value = 0 Then
                DgvDetalle.Rows(e.RowIndex).Cells(3).Value = 1

            End If
            Conec.Conectarse()
            Dim dr As SqlDataReader
            cmd = New SqlCommand("Select Existencia from Producto Where IdProducto='" & DgvDetalle.Rows(e.RowIndex).Cells(1).Value & "'", Conec.Con)
            cmd.CommandType = CommandType.Text
            dr = cmd.ExecuteReader
            Dim existencia, existencia2 As Integer

            If dr.Read Then
                existencia = CInt(dr.GetValue(0)) - 5
                existencia2 = CInt(dr.GetValue(0)) - 10
                If DgvDetalle.Rows(e.RowIndex).Cells(3).Value > existencia Then
                    MsgBox("Se sobrepasa de la existencia estimada. Existencia= " + Str(existencia), MsgBoxStyle.Critical)
                    DgvDetalle.Rows(e.RowIndex).Cells(3).Value = existencia

                ElseIf DgvDetalle.Rows(e.RowIndex).Cells(3).Value > existencia2 Then

                    MsgBox("Advertencia. Hay poca existencia", MsgBoxStyle.Information)
                    DgvDetalle.Rows(e.RowIndex).Cells(3).Value = DgvDetalle.Rows(e.RowIndex).Cells(3).Value
                Else
                    DgvDetalle.Rows(e.RowIndex).Cells(3).Value = DgvDetalle.Rows(e.RowIndex).Cells(3).Value
                End If

            End If
            dr.Close()

            DgvDetalle.Rows(e.RowIndex).Cells(8).Value = FormatCurrency(CDbl(DgvDetalle.Rows(e.RowIndex).Cells(3).Value) * CDbl(DgvDetalle.Rows(e.RowIndex).Cells(4).Value), 2)
            DgvDetalle.Rows(e.RowIndex).Cells(7).Value = FormatCurrency(CDbl(DgvDetalle.Rows(e.RowIndex).Cells(3).Value) * CDbl(dr2.GetValue(0)), 2)
            dr2.Close()
            DgvDetalle.Rows(e.RowIndex).Cells(6).Value = FormatCurrency((DgvDetalle.Rows(e.RowIndex).Cells(5).Value / 100) * DgvDetalle.CurrentRow.Cells(8).Value)
        ElseIf column = 5 Then
            If DgvDetalle.CurrentRow.Cells(5).Value = Nothing Then
                DgvDetalle.Rows(e.RowIndex).Cells(5).Value = 0
            End If
            DgvDetalle.Rows(e.RowIndex).Cells(6).Value = FormatCurrency((DgvDetalle.Rows(e.RowIndex).Cells(5).Value / 100) * DgvDetalle.CurrentRow.Cells(8).Value)

        ElseIf column = 6 Then
            If DgvDetalle.CurrentRow.Cells(6).Value = Nothing Then
                DgvDetalle.Rows(e.RowIndex).Cells(6).Value = FormatCurrency(0)
            End If
            DgvDetalle.Rows(e.RowIndex).Cells(5).Value = FormatNumber(((DgvDetalle.CurrentRow.Cells(6).Value / DgvDetalle.CurrentRow.Cells(8).Value) * 100), 2)
            DgvDetalle.Rows(e.RowIndex).Cells(6).Value = FormatCurrency(DgvDetalle.Rows(e.RowIndex).Cells(6).Value)


        End If
        LlenarTextBox()

    End Sub
    Private Sub DataGridView1_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DgvDetalle.EditingControlShowing
        Dim column As Integer = DgvDetalle.CurrentCell.ColumnIndex
        If column = 1 Then
            Dim autoText As TextBox = TryCast(e.Control, TextBox)
            If autoText IsNot Nothing Then
                autoText.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
                Dim DataCollection As New AutoCompleteStringCollection()
                addItems(DataCollection)
                autoText.AutoCompleteCustomSource = DataCollection
            End If
        Else
            Dim autoText As TextBox = TryCast(e.Control, TextBox)
            autoText.AutoCompleteMode = AutoCompleteMode.None
        End If



    End Sub
    Public Sub addItems(ByVal col As AutoCompleteStringCollection)
        Try
            Conec.Conectarse()

            Dim dr As SqlDataReader
            cmd = New SqlCommand("Select  IdProducto+'__'+ Descripcion from Producto")
            cmd.CommandType = CommandType.Text
            cmd.Connection = Conec.Con
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    col.Add(Convert.ToString(dr(0)))
                End While

            End If
            dr.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conec.Desconectarse()
        End Try
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDetalle.CellContentClick
        If e.ColumnIndex = 0 Then
            If (DgvDetalle.CurrentRow.Cells(1).Value <> Nothing Or (DgvDetalle.CurrentRow.Cells(2).Value <> Nothing)) Then
                If ((DgvDetalle.CurrentRow.Cells(1) IsNot Nothing)) Then
                    DgvDetalle.Rows.Remove(DgvDetalle.CurrentRow)
                    LlenarTextBox()

                End If
            End If
        End If

    End Sub
    Private Sub LlenarTextBox()
        TxtTotal.Clear()
        TxtTotal.Text = 0
        TxtSubtotal.Clear()
        TxtSubtotal.Text = 0
        TxtDescuento.Clear()
        TxtDescuento.Text = 0
        TxtImpuesto.Clear()
        TxtImpuesto.Text = 0

        Dim a, b, c, d As Double
        For Each Fila As DataGridViewRow In DgvDetalle.Rows
            a += CDbl(Fila.Cells(8).Value)
            b += CDbl(Fila.Cells(7).Value)
            c += CDbl(Fila.Cells(6).Value)

        Next
        TxtSubtotal.Text = FormatCurrency(a, 2)
        If RdbPorcentaje.Checked = True Then
            Dim q, w As Double
            If TxtP.Text = Nothing Then
                q = 0
            Else

                q = CDbl(TxtP.Text)
            End If

            w = CDbl(TxtSubtotal.Text)
            TxtDescuentoExtra.Value = (q / 100) * w
        End If

        If TxtDescuentoExtra.Text = Nothing Then
            d = 0
        Else
            d = CDbl(TxtDescuentoExtra.Text)
        End If


        TxtDescuento.Text = FormatCurrency(c + d, 2)
        TxtTotal.Text = FormatCurrency((a + b) - (c + d), 2)
        TxtImpuesto.Text = FormatCurrency(b, 2)



    End Sub

    Private Sub TxtDescuentoExtra_EditValueChanged(sender As Object, e As EventArgs) Handles TxtDescuentoExtra.EditValueChanged
        LlenarTextBox()
    End Sub

    Private Sub RdbPorcentaje_CheckedChanged(sender As Object, e As EventArgs) Handles RdbPorcentaje.CheckedChanged
        If RdbPorcentaje.Checked = True Then
            TxtP.Visible = True
            LblP.Visible = True
            TxtDescuentoExtra.Enabled = False
            TxtDescuentoExtra.Text = 0
        Else
            TxtP.Visible = False
            LblP.Visible = False
            TxtDescuentoExtra.Enabled = True
            TxtDescuentoExtra.Text = 0
        End If
    End Sub

    Private Sub TxtP_TextChanged(sender As Object, e As EventArgs) Handles TxtP.TextChanged
        Dim a, b As Double
        If TxtP.Text = Nothing Then
            a = 0
        Else

            a = CDbl(TxtP.Text)
        End If

        b = CDbl(TxtSubtotal.Text)
        TxtDescuentoExtra.Value = (a / 100) * b

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnFacturar.Click
        If DgvDetalle.RowCount = 1 Then
            MsgBox("Ingresar al menos un producto para facturar la venta", MsgBoxStyle.Information, "INNOVAMASTER")

        Else
            Conec.Conectarse()
            For Each fila As DataGridViewRow In DgvDetalle.Rows
                Try
                    If fila.Cells(1).Value <> Nothing Then
                        cmd = New SqlCommand("InsertarDetalleVenta", Conec.Con)
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.AddWithValue("@IdVenta", LblCodigoVenta.Text.ToString)
                        cmd.Parameters.AddWithValue("@IdProducto", fila.Cells(1).Value.ToString)
                        cmd.Parameters.AddWithValue("@Cantidad", CDbl(fila.Cells(3).Value))
                        cmd.Parameters.AddWithValue("@Precio", CDbl(fila.Cells(4).Value))
                        cmd.Parameters.AddWithValue("@DescuentoProducto", CDbl(fila.Cells(6).Value))
                        cmd.Parameters.AddWithValue("@Impuesto", CDbl(fila.Cells(7).Value))
                        cmd.ExecuteNonQuery()

                        cmd = New SqlCommand("ReducirInventario", Conec.Con)
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.AddWithValue("@IdProducto", fila.Cells(1).Value.ToString)
                        cmd.Parameters.AddWithValue("@Cantidad", CDbl(fila.Cells(3).Value))
                        cmd.ExecuteNonQuery()
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


            Next

            Try
                cmd = New SqlCommand("ActualizarDescuentoExtra", Conec.Con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@IdVenta", LblCodigoVenta.Text.ToString)
                If TxtDescuentoExtra.Value = Nothing Then
                    cmd.Parameters.AddWithValue("@DescuentoExtra", CDbl(0))
                Else
                    cmd.Parameters.AddWithValue("@DescuentoExtra", CDbl(TxtDescuentoExtra.Value))
                End If

                cmd.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MsgBox("Productos facturados con éxito, Vamos a Imprimir la Factura", MsgBoxStyle.Information)
            FrmFactura.MdiParent = MenuPrincipal
            FrmFactura.Dock = DockStyle.Fill
            FrmFactura.Show()



        End If
    End Sub

    Private Sub FrmDetalleVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvDetalle.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken

    End Sub
End Class