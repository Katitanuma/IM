<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmParametrosDEI
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmParametrosDEI))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GBDatos = New DevExpress.XtraEditors.GroupControl()
        Me.DteLimite = New DevExpress.XtraEditors.DateEdit()
        Me.TxtNumeroF = New DevExpress.XtraEditors.TextEdit()
        Me.TxtRango1 = New DevExpress.XtraEditors.TextEdit()
        Me.TxtCAI = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.BtnModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtRango2 = New DevExpress.XtraEditors.TextEdit()
        CType(Me.GBDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBDatos.SuspendLayout()
        CType(Me.DteLimite.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DteLimite.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNumeroF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRango1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCAI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRango2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelControl1.Location = New System.Drawing.Point(158, 25)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(260, 43)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Configuración DEI"
        '
        'GBDatos
        '
        Me.GBDatos.Controls.Add(Me.TxtRango2)
        Me.GBDatos.Controls.Add(Me.LabelControl5)
        Me.GBDatos.Controls.Add(Me.DteLimite)
        Me.GBDatos.Controls.Add(Me.TxtNumeroF)
        Me.GBDatos.Controls.Add(Me.TxtRango1)
        Me.GBDatos.Controls.Add(Me.TxtCAI)
        Me.GBDatos.Controls.Add(Me.LabelControl4)
        Me.GBDatos.Controls.Add(Me.LabelControl3)
        Me.GBDatos.Controls.Add(Me.LabelControl2)
        Me.GBDatos.Controls.Add(Me.LabelControl15)
        Me.GBDatos.Location = New System.Drawing.Point(29, 88)
        Me.GBDatos.Name = "GBDatos"
        Me.GBDatos.Size = New System.Drawing.Size(528, 267)
        Me.GBDatos.TabIndex = 2
        Me.GBDatos.Text = "Datos DEI"
        '
        'DteLimite
        '
        Me.DteLimite.EditValue = Nothing
        Me.DteLimite.Location = New System.Drawing.Point(189, 199)
        Me.DteLimite.Name = "DteLimite"
        Me.DteLimite.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DteLimite.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DteLimite.Size = New System.Drawing.Size(175, 20)
        Me.DteLimite.TabIndex = 9
        '
        'TxtNumeroF
        '
        Me.TxtNumeroF.Location = New System.Drawing.Point(189, 143)
        Me.TxtNumeroF.Name = "TxtNumeroF"
        Me.TxtNumeroF.Properties.Mask.EditMask = "\d?\d?\d?-\d?\d?\d?-\d?\d?"
        Me.TxtNumeroF.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
        Me.TxtNumeroF.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxtNumeroF.Size = New System.Drawing.Size(175, 20)
        Me.TxtNumeroF.TabIndex = 8
        '
        'TxtRango1
        '
        Me.TxtRango1.Location = New System.Drawing.Point(189, 93)
        Me.TxtRango1.Name = "TxtRango1"
        Me.TxtRango1.Properties.Mask.EditMask = "\d?\d?\d?-\d?\d?\d?-\d?\d?-\d?\d?\d?\d?\d?\d?\d?\d? "
        Me.TxtRango1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
        Me.TxtRango1.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxtRango1.Size = New System.Drawing.Size(160, 20)
        Me.TxtRango1.TabIndex = 7
        '
        'TxtCAI
        '
        Me.TxtCAI.Location = New System.Drawing.Point(189, 43)
        Me.TxtCAI.Name = "TxtCAI"
        Me.TxtCAI.Properties.Mask.EditMask = "xxxx-xxxx-xxxx-xx"
        Me.TxtCAI.Size = New System.Drawing.Size(334, 20)
        Me.TxtCAI.TabIndex = 6
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Location = New System.Drawing.Point(19, 201)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(154, 19)
        Me.LabelControl4.TabIndex = 5
        Me.LabelControl4.Text = "Fecha Limite de Emisión"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Location = New System.Drawing.Point(50, 146)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(123, 19)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Número de Factura"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Location = New System.Drawing.Point(62, 92)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(111, 19)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Rango Autorizado"
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl15.Location = New System.Drawing.Point(148, 42)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(25, 19)
        Me.LabelControl15.TabIndex = 2
        Me.LabelControl15.Text = "CAI"
        '
        'BtnModificar
        '
        Me.BtnModificar.Image = CType(resources.GetObject("BtnModificar.Image"), System.Drawing.Image)
        Me.BtnModificar.Location = New System.Drawing.Point(236, 372)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(120, 37)
        Me.BtnModificar.TabIndex = 3
        Me.BtnModificar.Text = "Modificar"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.Location = New System.Drawing.Point(236, 372)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(120, 37)
        Me.BtnGuardar.TabIndex = 4
        Me.BtnGuardar.Text = "Guardar"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl5.Location = New System.Drawing.Point(355, 92)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(11, 19)
        Me.LabelControl5.TabIndex = 10
        Me.LabelControl5.Text = "al"
        '
        'TxtRango2
        '
        Me.TxtRango2.Location = New System.Drawing.Point(372, 93)
        Me.TxtRango2.Name = "TxtRango2"
        Me.TxtRango2.Properties.Mask.EditMask = " \d?\d?\d?\d?\d?\d?\d?\d?"
        Me.TxtRango2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
        Me.TxtRango2.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxtRango2.Size = New System.Drawing.Size(151, 20)
        Me.TxtRango2.TabIndex = 11
        '
        'FrmParametrosDEI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 434)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.GBDatos)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmParametrosDEI"
        Me.Text = "FrmParametrosDEI"
        CType(Me.GBDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBDatos.ResumeLayout(False)
        Me.GBDatos.PerformLayout()
        CType(Me.DteLimite.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DteLimite.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNumeroF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRango1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCAI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRango2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GBDatos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DteLimite As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TxtNumeroF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtRango1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtCAI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtRango2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
End Class
