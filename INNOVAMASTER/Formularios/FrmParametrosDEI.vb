Imports DevExpress.XtraEditors
Imports System.Data.SqlClient

Public Class FrmParametrosDEI

    Private Sub FrmParametrosDEI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtCAI.EditValue = My.Settings.CAI
        TxtRango1.EditValue = My.Settings.R1
        TxtRango2.EditValue = My.Settings.R2
        If My.Settings.FL.ToString <> Nothing Then
            DteLimite.EditValue = CDate(My.Settings.FL)
        End If
        ISV.EditValue = My.Settings.ISV.ToString

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        My.Settings.CAI = TxtCAI.EditValue
        My.Settings.R1 = TxtRango1.EditValue
        My.Settings.R2 = TxtRango2.EditValue
        My.Settings.FL = DteLimite.EditValue
        My.Settings.ISV = ISV.EditValue
        My.Settings.Save()
        ActualizarISV(My.Settings.ISV)


    End Sub

    Private Sub TxtCAI_EditValueChanged(sender As Object, e As EventArgs) Handles TxtCAI.EditValueChanged, TxtRango1.EditValueChanged, TxtRango2.EditValueChanged, DteLimite.EditValueChanged, ISV.EditValueChanged
        If (TxtCAI.EditValue <> Nothing And TxtRango1.EditValue <> Nothing And TxtRango2.EditValue <> Nothing And DteLimite.EditValue <> Nothing And ISV.EditValue <> Nothing) Then
            BtnGuardar.Enabled = True
        Else
            BtnGuardar.Enabled = False
        End If
    End Sub

    Private Sub ActualizarISV(ByVal ISV As Double)
        Dim cmd As New SqlCommand
        Dim con As New Conexion
        Try
            con.Conectarse()
            cmd = New SqlCommand("UPDATE Producto SET Gravado = PrecioUnitario * " & CDbl(ISV) & "
                                  WHERE Gravado > 0")
            cmd.CommandType = CommandType.Text
            cmd.Connection = con.Con

            cmd.ExecuteNonQuery()
            XtraMessageBox.Show("Parámetros almacenados con exito")
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
End Class