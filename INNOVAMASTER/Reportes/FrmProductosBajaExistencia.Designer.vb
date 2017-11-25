<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProductosBajaExistencia
    Inherits DevExpress.XtraEditors.XtraForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProductosBajaExistencia))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GCPrincipal = New DevExpress.XtraGrid.GridControl()
        Me.DgvProducto = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.stock
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(142, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 51)
        Me.PictureBox2.TabIndex = 72
        Me.PictureBox2.TabStop = False
        '
<<<<<<< HEAD
        'GCPrincipal
        '
        Me.GCPrincipal.Location = New System.Drawing.Point(28, 82)
        Me.GCPrincipal.MainView = Me.DgvProductos
        Me.GCPrincipal.Name = "GCPrincipal"
        Me.GCPrincipal.Size = New System.Drawing.Size(717, 283)
        Me.GCPrincipal.TabIndex = 135
        Me.GCPrincipal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvProductos})
        '
        'DgvProductos
        '
        Me.DgvProductos.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProductos.Appearance.Empty.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProductos.Appearance.Empty.Options.UseBackColor = True
        Me.DgvProductos.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvProductos.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvProductos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.DgvProductos.Appearance.FocusedCell.Options.UseBackColor = True
        Me.DgvProductos.Appearance.FocusedCell.Options.UseFont = True
        Me.DgvProductos.Appearance.FocusedCell.Options.UseForeColor = True
        Me.DgvProductos.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvProductos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DgvProductos.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.DgvProductos.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.DgvProductos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvProductos.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvProductos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.DgvProductos.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.DgvProductos.Appearance.HideSelectionRow.Options.UseFont = True
        Me.DgvProductos.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.DgvProductos.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvProductos.Appearance.HorzLine.Options.UseBackColor = True
        Me.DgvProductos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProductos.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvProductos.Appearance.Row.Options.UseBackColor = True
        Me.DgvProductos.Appearance.Row.Options.UseFont = True
        Me.DgvProductos.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvProductos.Appearance.VertLine.Options.UseBackColor = True
        Me.DgvProductos.ColumnPanelRowHeight = 26
        Me.DgvProductos.GridControl = Me.GCPrincipal
        Me.DgvProductos.Name = "DgvProductos"
        Me.DgvProductos.OptionsBehavior.AllowIncrementalSearch = True
        Me.DgvProductos.OptionsBehavior.Editable = False
        Me.DgvProductos.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.DgvProductos.OptionsFind.AlwaysVisible = True
        Me.DgvProductos.OptionsFind.FindNullPrompt = "Introduzca modelo a buscar..."
        Me.DgvProductos.OptionsView.EnableAppearanceEvenRow = True
        Me.DgvProductos.OptionsView.EnableAppearanceOddRow = True
        Me.DgvProductos.OptionsView.ShowGroupPanel = False
        Me.DgvProductos.RowHeight = 22
        '
=======
>>>>>>> 5d90c99b49e6b1de030b410c7eaf851946a7feb3
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(43, 374)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton5.TabIndex = 155
        Me.SimpleButton5.Text = "Actualizar Datos"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(214, 374)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton4.TabIndex = 154
        Me.SimpleButton4.Text = "Exportar PDF"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(385, 374)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton2.TabIndex = 153
        Me.SimpleButton2.Text = "Exportar Excel"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(556, 374)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton1.TabIndex = 152
        Me.SimpleButton1.Text = "Vista Previa"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelControl1.Location = New System.Drawing.Point(191, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(402, 43)
        Me.LabelControl1.TabIndex = 156
        Me.LabelControl1.Text = "Productos con baja Existencia"
        '
        'GCPrincipal
        '
        Me.GCPrincipal.Location = New System.Drawing.Point(12, 85)
        Me.GCPrincipal.MainView = Me.DgvProducto
        Me.GCPrincipal.Name = "GCPrincipal"
        Me.GCPrincipal.Size = New System.Drawing.Size(709, 265)
        Me.GCPrincipal.TabIndex = 157
        Me.GCPrincipal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvProducto})
        '
        'DgvProducto
        '
        Me.DgvProducto.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProducto.Appearance.Empty.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProducto.Appearance.Empty.Options.UseBackColor = True
        Me.DgvProducto.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvProducto.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvProducto.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.DgvProducto.Appearance.FocusedCell.Options.UseBackColor = True
        Me.DgvProducto.Appearance.FocusedCell.Options.UseFont = True
        Me.DgvProducto.Appearance.FocusedCell.Options.UseForeColor = True
        Me.DgvProducto.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvProducto.Appearance.FocusedRow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvProducto.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DgvProducto.Appearance.FocusedRow.Options.UseFont = True
        Me.DgvProducto.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.DgvProducto.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.DgvProducto.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvProducto.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvProducto.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.DgvProducto.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.DgvProducto.Appearance.HideSelectionRow.Options.UseFont = True
        Me.DgvProducto.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.DgvProducto.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvProducto.Appearance.HorzLine.Options.UseBackColor = True
        Me.DgvProducto.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProducto.Appearance.Row.Options.UseBackColor = True
        Me.DgvProducto.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProducto.Appearance.RowSeparator.Options.UseBackColor = True
        Me.DgvProducto.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvProducto.Appearance.VertLine.Options.UseBackColor = True
        Me.DgvProducto.ColumnPanelRowHeight = 26
        Me.DgvProducto.GridControl = Me.GCPrincipal
        Me.DgvProducto.Name = "DgvProducto"
        Me.DgvProducto.OptionsBehavior.AllowIncrementalSearch = True
        Me.DgvProducto.OptionsBehavior.AutoSelectAllInEditor = False
        Me.DgvProducto.OptionsBehavior.Editable = False
        Me.DgvProducto.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.DgvProducto.OptionsFind.AlwaysVisible = True
        Me.DgvProducto.OptionsFind.FindNullPrompt = "Introduzca municipio a buscar..."
        Me.DgvProducto.OptionsView.EnableAppearanceEvenRow = True
        Me.DgvProducto.OptionsView.EnableAppearanceOddRow = True
        Me.DgvProducto.OptionsView.ShowGroupPanel = False
        Me.DgvProducto.RowHeight = 22
        '
        'FrmProductosBajaExistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 431)
        Me.Controls.Add(Me.GCPrincipal)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmProductosBajaExistencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GCPrincipal As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvProducto As DevExpress.XtraGrid.Views.Grid.GridView
End Class
