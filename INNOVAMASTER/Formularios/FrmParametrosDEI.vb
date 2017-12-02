Imports DevExpress.XtraEditors

Public Class FrmParametrosDEI

    Private Sub FrmParametrosDEI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtCAI.EditValue = My.Settings.CAI
        TxtRango1.EditValue = My.Settings.R1
        TxtRango2.EditValue = My.Settings.R2
        If My.Settings.FL.ToString <> Nothing Then
            DteLimite.EditValue = CDate(My.Settings.FL)
        End If

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        My.Settings.CAI = TxtCAI.EditValue
        My.Settings.R1 = TxtRango1.EditValue
        My.Settings.R2 = TxtRango2.EditValue
        My.Settings.FL = DteLimite.EditValue
        My.Settings.Save()
        XtraMessageBox.Show("Parámetros almacenados con exito")
    End Sub

    Private Sub TxtCAI_EditValueChanged(sender As Object, e As EventArgs) Handles TxtCAI.EditValueChanged, TxtRango1.EditValueChanged, TxtRango2.EditValueChanged, DteLimite.EditValueChanged
        If (TxtCAI.EditValue <> Nothing And TxtRango1.EditValue <> Nothing And TxtRango2.EditValue <> Nothing And DteLimite.EditValue <> Nothing) Then
            BtnGuardar.Enabled = True
        End If
    End Sub
End Class