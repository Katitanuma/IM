Imports System.Data.SqlClient
Public Class FrmProductosBajaExistencia
    Dim conec As New Conexion
    Private Sub FrmProductosBajaExistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt As New DataTable
        Try
            conec.Conectarse()
            Dim da As New SqlDataAdapter("Sp_ProductosBajaExistencia", conec.Con)
            da.Fill(dt)
            DgvProductos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conec.Desconectarse()
        End Try


    End Sub
End Class