Public Class FrmParametrosDEI
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        GBDatos.Enabled = True
        BtnModificar.Visible = False

    End Sub

    Private Sub FrmParametrosDEI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GBDatos.Enabled = False
    End Sub
End Class