<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportesBase
    Inherits DevExpress.XtraEditors.XtraForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReportesBase))
        Me.BtnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnExportarPDF = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnExportarExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnReporte = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LblEtiqueta = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.Location = New System.Drawing.Point(14, 340)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(165, 45)
        Me.BtnActualizar.TabIndex = 134
        Me.BtnActualizar.Text = "Actualizar Datos"
        '
        'BtnExportarPDF
        '
        Me.BtnExportarPDF.Image = CType(resources.GetObject("BtnExportarPDF.Image"), System.Drawing.Image)
        Me.BtnExportarPDF.Location = New System.Drawing.Point(185, 340)
        Me.BtnExportarPDF.Name = "BtnExportarPDF"
        Me.BtnExportarPDF.Size = New System.Drawing.Size(165, 45)
        Me.BtnExportarPDF.TabIndex = 133
        Me.BtnExportarPDF.Text = "Exportar PDF"
        '
        'BtnExportarExcel
        '
        Me.BtnExportarExcel.Image = CType(resources.GetObject("BtnExportarExcel.Image"), System.Drawing.Image)
        Me.BtnExportarExcel.Location = New System.Drawing.Point(356, 340)
        Me.BtnExportarExcel.Name = "BtnExportarExcel"
        Me.BtnExportarExcel.Size = New System.Drawing.Size(165, 45)
        Me.BtnExportarExcel.TabIndex = 132
        Me.BtnExportarExcel.Text = "Exportar Excel"
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Image = CType(resources.GetObject("BtnImprimir.Image"), System.Drawing.Image)
        Me.BtnImprimir.Location = New System.Drawing.Point(527, 340)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(165, 45)
        Me.BtnImprimir.TabIndex = 131
        Me.BtnImprimir.Text = "Imprimir"
        '
        'BtnReporte
        '
        Me.BtnReporte.Image = CType(resources.GetObject("BtnReporte.Image"), System.Drawing.Image)
        Me.BtnReporte.Location = New System.Drawing.Point(698, 340)
        Me.BtnReporte.Name = "BtnReporte"
        Me.BtnReporte.Size = New System.Drawing.Size(165, 45)
        Me.BtnReporte.TabIndex = 135
        Me.BtnReporte.Text = "Reporte"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.custom_reports_256
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(300, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 51)
        Me.PictureBox2.TabIndex = 137
        Me.PictureBox2.TabStop = False
        '
        'LblEtiqueta
        '
        Me.LblEtiqueta.Appearance.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LblEtiqueta.Location = New System.Drawing.Point(356, 12)
        Me.LblEtiqueta.Name = "LblEtiqueta"
        Me.LblEtiqueta.Size = New System.Drawing.Size(104, 43)
        Me.LblEtiqueta.TabIndex = 138
        Me.LblEtiqueta.Text = "Reporte"
        '
        'FrmReportesBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 396)
        Me.Controls.Add(Me.LblEtiqueta)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BtnReporte)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnExportarPDF)
        Me.Controls.Add(Me.BtnExportarExcel)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmReportesBase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmReportesBase"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnExportarPDF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnExportarExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnReporte As DevExpress.XtraEditors.SimpleButton
    Protected WithEvents PictureBox2 As PictureBox
    Protected WithEvents LblEtiqueta As DevExpress.XtraEditors.LabelControl
End Class
