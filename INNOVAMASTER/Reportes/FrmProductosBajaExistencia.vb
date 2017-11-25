Imports System.Data.SqlClient
Public Class FrmProductosBajaExistencia
    Dim conec As New Conexion
    Private Sub FrmProductosBajaExistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt As New DataTable
        Try
            conec.Conectarse()
            Dim da As New SqlDataAdapter("Sp_ProductosBajaExistencia", conec.Con)
            da.Fill(dt)
            GCPrincipal.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conec.Desconectarse()
        End Try


    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click

        Dim dt As New DataTable
        Try
            conec.Conectarse()
            Dim da As New SqlDataAdapter("Sp_ProductosBajaExistencia", conec.Con)
            da.Fill(dt)
            GCPrincipal.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conec.Desconectarse()
        End Try

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Exportar_a_PDF(GCPrincipal, Me.Text)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Exportar_a_Excel(GCPrincipal, Me.Text)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GCPrincipal.ShowPrintPreview()

    End Sub
End Class