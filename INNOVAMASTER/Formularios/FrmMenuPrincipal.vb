﻿Imports System.ComponentModel
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraEditors
Imports System.Data.SqlClient

Public Class FrmMenuPrincipal
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        FrmFacturacionVenta.MdiParent = Me
        FrmFacturacionVenta.Focus()
        FrmFacturacionVenta.Show()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        FrmVenta.MdiParent = Me
        FrmVenta.Focus()
        FrmVenta.Show()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        ReporteVentas.Show()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        FrmCliente.MdiParent = Me
        FrmCliente.Focus()
        FrmCliente.Show()
        FrmCliente.Focus()
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        ReporteClientes.Show()
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        FrmEmpleado.MdiParent = Me
        FrmEmpleado.Focus()
        FrmEmpleado.Show()
    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        frmCargo.MdiParent = Me
        frmCargo.Focus()
        frmCargo.Show()
    End Sub

    Private Sub BarButtonItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        FrmProfesiones.MdiParent = Me
        FrmProfesiones.Focus()
        FrmProfesiones.Show()
    End Sub

    Private Sub BarButtonItem9_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        FrmUsuario.MdiParent = Me
        FrmUsuario.Focus()
        FrmUsuario.Show()
    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        FrmPermisos.MdiParent = Me
        FrmPermisos.Focus()
        FrmPermisos.Show()
    End Sub

    Private Sub BarButtonItem11_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        FrmProducto.MdiParent = Me
        FrmProducto.Focus()
        FrmProducto.Show()
    End Sub

    Private Sub BarButtonItem12_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        FrmCategoria.MdiParent = Me
        FrmCategoria.Focus()
        FrmCategoria.Show()
    End Sub

    Private Sub BarButtonItem13_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        FrmMarca.MdiParent = Me
        FrmMarca.Focus()
        FrmMarca.Show()
    End Sub

    Private Sub BarButtonItem14_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        FrmModelo.MdiParent = Me
        FrmModelo.Focus()
        FrmModelo.Show()
    End Sub

    Private Sub BarButtonItem15_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        ReporteProductos.Show()
    End Sub

    Private Sub BarButtonItem16_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        FrmPExistencia.Location = New Point(285, 220)
        FrmPExistencia.ShowDialog()
        FrmPExistencia.Focus()
    End Sub

    Private Sub BarButtonItem17_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        FrmCompras.MdiParent = Me
        FrmCompras.Focus()
        FrmCompras.Show()
    End Sub

    Private Sub BarButtonItem18_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        ReporteCompras.Show()
    End Sub

    Private Sub BarButtonItem19_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        FrmPedidos.MdiParent = Me
        FrmPedidos.Focus()
        FrmPedidos.Show()
    End Sub

    Private Sub BarButtonItem20_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem20.ItemClick
        ReportePedido.Show()
    End Sub

    Private Sub BarButtonItem21_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        FrmProveedor.MdiParent = Me
        FrmProveedor.Focus()
        FrmProveedor.Show()
    End Sub

    Private Sub BarButtonItem22_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem22.ItemClick
        FrmPais.MdiParent = Me
        FrmPais.Show()
        FrmPais.Focus()
    End Sub

    Private Sub BarButtonItem23_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem23.ItemClick
        FrmDepartamento.MdiParent = Me
        FrmDepartamento.Show()
        FrmDepartamento.Focus()
    End Sub

    Private Sub BarButtonItem24_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem24.ItemClick
        FrmMunicipio.MdiParent = Me
        FrmMunicipio.Focus()
        FrmMunicipio.Show()
    End Sub

    Private Sub BarButtonItem25_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem25.ItemClick
        FrmConfiguracion.ShowDialog()
    End Sub

    Private Sub BarButtonItem27_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem27.ItemClick
        FrmBackup.ShowDialog()
    End Sub

    Private Sub BarButtonItem28_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem28.ItemClick
        FrmLogAuditoria.Show()
    End Sub

    Private Sub BarButtonItem30_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem30.ItemClick
        FrmLogin.Show()
        FrmLogin.TxtUsuario.Text = Nothing
        FrmLogin.TxtContrasena.Clear()
        FrmLogin.ChkVer.Checked = False
        FrmLogin.TxtUsuario.Focus()
        Me.Hide()
    End Sub

    Private Sub FrmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableMdiFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        SkinHelper.InitSkinGallery(SkinRibbonGalleryBarItem1, True)

        'Me.LookAndFeel.SkinName = "Office 2007 Silver"
        'Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Silver"

        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Principal")

        If My.Settings.Tema <> Nothing Then
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = My.Settings.Tema
        End If

        FrmPExistencia.Location = New Point(285, 220)
        FrmPExistencia.ShowDialog()
        FrmPExistencia.Focus()
    End Sub

    Private Sub FrmMenuPrincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If EstaAbierto(FrmDetalleVenta) Then
            FrmDetalleVenta.Button1.PerformClick()
            e.Cancel = True
        ElseIf EstaAbierto(FrmCompras) Then
            FrmCompras.Button1.PerformClick()
            e.Cancel = True
        ElseIf EstaAbierto(FrmPedidos) Then
            FrmPedidos.Button1.PerformClick()
            e.Cancel = True
        ElseIf XtraMessageBox.Show("¿Desea Salir del Sistema?", "INNOVAMASTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then
            e.Cancel = True
        Else
            My.Settings.Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
            My.Settings.Save()
            Application.Exit()
        End If
    End Sub


    Public Function EstaAbierto(ByVal Myform As Form)
        Dim objForm As Form
        Dim blnAbierto As Boolean = False
        blnAbierto = False
        For Each objForm In My.Application.OpenForms
            If (Trim(objForm.Name) = Trim(Myform.Name)) Then
                blnAbierto = True
            End If
        Next
        Return blnAbierto
    End Function

    Private Sub XtraTabbedMdiManager1_PageAdded(sender As Object, e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles XtraTabbedMdiManager1.PageAdded, XtraTabbedMdiManager1.PageRemoved
        If XtraTabbedMdiManager1.Pages.Count = 0 Then
            pcFondo.Visible = True
        Else
            pcFondo.Visible = False
        End If
    End Sub

    Private Sub BarButtonItem29_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem29.ItemClick
        Acerca_de_InnovaMaster.Show()
    End Sub

    Private Sub BarButtonItem32_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem32.ItemClick
        My.Settings.Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        My.Settings.Save()
        Application.Exit()
    End Sub

    Private Sub BarButtonItem31_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem31.ItemClick
        FrmConfiguracion.ShowDialog()
    End Sub

    Private Sub BarButtonItem33_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem33.ItemClick
        MostrarPermisosDenegados(CInt(LblIdUsuario.Text))
        MostrarPermisosPermitidos(CInt(LblIdUsuario.Text))
    End Sub
    Private Sub MostrarPermisosDenegados(ByVal IdUsuario As Integer)
        Dim conec As New Conexion
        Try

            conec.Conectarse()
            Dim cmd As New SqlCommand
            Dim dr As SqlClient.SqlDataReader
            Conec.Conectarse()
            cmd = New SqlCommand("SP_MostraPermisosDenegados")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Conec.Con

            cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = IdUsuario

            dr = cmd.ExecuteReader

            While dr.Read()
                If dr.GetValue(2).ToString = "VENTAS" Then
                    PagVentas.Enabled = False

                End If
                If dr.GetValue(2).ToString = "CLIENTES" Then
                    PagClientes.Enabled = False

                End If
                If dr.GetValue(2).ToString = "EMPLEADOS" Then
                    PagEmpleados.Enabled = False

                End If
                If dr.GetValue(2).ToString = "USUARIOS" Then
                    PagUsuarios.Enabled = False

                End If
                If dr.GetValue(2).ToString = "PRODUCTOS" Then
                    PagProductos.Enabled = False

                End If
                If dr.GetValue(2).ToString = "COMPRAS" Then
                    PagCompras.Enabled = False

                End If
                If dr.GetValue(2).ToString = "PEDIDOS" Then
                    PagPedidos.Enabled = False

                End If
                If dr.GetValue(2).ToString = "PROVEEDORES" Then
                    PagProveedores.Enabled = False

                End If
                If dr.GetValue(2).ToString = "UBICACIÓN" Then
                    PagUbicacion.Enabled = False

                End If
                If dr.GetValue(2).ToString = "CONFIGURACIÓN" Then
                    PagConfiguracion.Enabled = False

                End If
                If dr.GetValue(2).ToString = "AUDITORÍA" Then
                    PagAuditoria.Enabled = False

                End If

            End While

        Catch ex As Exception
            XtraMessageBox.Show(ex.ToString)
        Finally
            Conec.Desconectarse()
        End Try
    End Sub

    Private Sub MostrarPermisosPermitidos(ByVal IdUsuario As Integer)
        Dim conec As New Conexion
        Try

            conec.Conectarse()
            Dim cmd As New SqlCommand
            Dim dr As SqlClient.SqlDataReader
            conec.Conectarse()
            cmd = New SqlCommand("SP_MostraPermisosPermitidos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conec.Con

            cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = IdUsuario

            dr = cmd.ExecuteReader

            While dr.Read()
                If dr.GetValue(2).ToString = "VENTAS" Then
                    PagVentas.Enabled = True

                End If
                If dr.GetValue(2).ToString = "CLIENTES" Then
                    PagClientes.Enabled = True

                End If
                If dr.GetValue(2).ToString = "EMPLEADOS" Then
                    PagEmpleados.Enabled = True

                End If
                If dr.GetValue(2).ToString = "USUARIOS" Then
                    PagUsuarios.Enabled = True

                End If
                If dr.GetValue(2).ToString = "PRODUCTOS" Then
                    PagProductos.Enabled = True

                End If
                If dr.GetValue(2).ToString = "COMPRAS" Then
                    PagCompras.Enabled = True

                End If
                If dr.GetValue(2).ToString = "PEDIDOS" Then
                    PagPedidos.Enabled = True

                End If
                If dr.GetValue(2).ToString = "PROVEEDORES" Then
                    PagProveedores.Enabled = True

                End If
                If dr.GetValue(2).ToString = "UBICACIÓN" Then
                    PagUbicacion.Enabled = True

                End If
                If dr.GetValue(2).ToString = "CONFIGURACIÓN" Then
                    PagConfiguracion.Enabled = True

                End If
                If dr.GetValue(2).ToString = "AUDITORÍA" Then
                    PagAuditoria.Enabled = True

                End If

            End While

        Catch ex As Exception
            XtraMessageBox.Show(ex.ToString)
        Finally
            conec.Desconectarse()
        End Try
    End Sub
End Class