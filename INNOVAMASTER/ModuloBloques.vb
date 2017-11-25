Module ModuloBloques
    Public Tema As String
    Public Sub Exportar_a_Excel(ByRef Grilla As DevExpress.XtraGrid.GridControl, ByVal Nombre As String)
        Dim Archivo As New SaveFileDialog

        Try
            Archivo.Filter = "xls|*.xls"
            Archivo.FileName = Nombre
            Archivo.ShowDialog()
            If Archivo.FileName.Length > 0 Then

                Grilla.ExportToXls(Archivo.FileName)

                ' Lanzar excel 
                Process.Start(Archivo.FileName)

            End If

        Catch Ex As Exception
            Dim _st As New System.Diagnostics.StackTrace()
            Dim _miFuncion As String = _st.GetFrame(0).GetMethod().Name
            MessageBox.Show(Ex.Message)
        End Try
    End Sub

    Public Sub Exportar_a_PDF(ByRef Grilla As DevExpress.XtraGrid.GridControl, ByVal Nombre As String)
        Dim Archivo As New SaveFileDialog

        Try
            Archivo.Filter = "pdf|*.pdf"
            Archivo.FileName = Nombre
            Archivo.ShowDialog()
            If Archivo.FileName.Length > 0 Then

                Grilla.ExportToPdf(Archivo.FileName)

                ' Lanzar el archivo
                Process.Start(Archivo.FileName)

            End If

        Catch Ex As Exception
            Dim _st As New System.Diagnostics.StackTrace()
            Dim _miFuncion As String = _st.GetFrame(0).GetMethod().Name
            Mi.ErrorMensaje(Ex.Message, _miFuncion, Me.Name, True)
        End Try
    End Sub
End Module
