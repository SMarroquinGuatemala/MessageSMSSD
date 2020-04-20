<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTelefonosPersonal
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GrdDatos = New System.Windows.Forms.DataGridView()
        Me.MnuMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MnuBorrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtTelefono = New UserWindowsControlLibrary.TextBoxSD()
        Me.TxtNumeroEmpleado = New UserWindowsControlLibrary.TextBoxSD()
        Me.CmdExportar = New System.Windows.Forms.Button()
        Me.CmdCancelar = New System.Windows.Forms.Button()
        Me.CmdGrabar = New System.Windows.Forms.Button()
        Me.CmdBuscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtObservaciones = New UserWindowsControlLibrary.TextBoxSD()
        Me.TxtNombre = New UserWindowsControlLibrary.TextBoxSD()
        Me.TTMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.ChkActivo = New System.Windows.Forms.CheckBox()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroDeEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.GrdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MnuMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
              Or System.Windows.Forms.AnchorStyles.Left) _
              Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GrdDatos, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1057, 431)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GrdDatos
        '
        Me.GrdDatos.AllowUserToAddRows = False
        Me.GrdDatos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.GrdDatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GrdDatos.BackgroundColor = System.Drawing.Color.White
        Me.GrdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Telefono, Me.NumeroDeEmpleado, Me.Nombre, Me.Observaciones, Me.Activo})
        Me.GrdDatos.ContextMenuStrip = Me.MnuMenu
        Me.GrdDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdDatos.Location = New System.Drawing.Point(4, 58)
        Me.GrdDatos.MultiSelect = False
        Me.GrdDatos.Name = "GrdDatos"
        Me.GrdDatos.ReadOnly = True
        Me.GrdDatos.RowHeadersWidth = 10
        Me.GrdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrdDatos.Size = New System.Drawing.Size(1049, 369)
        Me.GrdDatos.TabIndex = 0
        '
        'MnuMenu
        '
        Me.MnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuBorrar})
        Me.MnuMenu.Name = "MnuMenu"
        Me.MnuMenu.Size = New System.Drawing.Size(107, 26)
        '
        'MnuBorrar
        '
        Me.MnuBorrar.Name = "MnuBorrar"
        Me.MnuBorrar.Size = New System.Drawing.Size(106, 22)
        Me.MnuBorrar.Text = "Borrar"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ChkActivo)
        Me.Panel1.Controls.Add(Me.TxtTelefono)
        Me.Panel1.Controls.Add(Me.TxtNumeroEmpleado)
        Me.Panel1.Controls.Add(Me.CmdExportar)
        Me.Panel1.Controls.Add(Me.CmdCancelar)
        Me.Panel1.Controls.Add(Me.CmdGrabar)
        Me.Panel1.Controls.Add(Me.CmdBuscar)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtObservaciones)
        Me.Panel1.Controls.Add(Me.TxtNombre)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1049, 47)
        Me.Panel1.TabIndex = 0
        '
        'TxtTelefono
        '
        Me.TxtTelefono.BackColor = System.Drawing.Color.LemonChiffon
        Me.TxtTelefono.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputNumber
        Me.TxtTelefono.Location = New System.Drawing.Point(5, 21)
        Me.TxtTelefono.MaxLength = 10
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.NumberDecimal = 0
        Me.TxtTelefono.Size = New System.Drawing.Size(76, 20)
        Me.TxtTelefono.TabEnter = True
        Me.TxtTelefono.TabIndex = 0
        Me.TxtTelefono.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Obligatorio
        Me.TxtTelefono.ValidField = False
        '
        'TxtNumeroEmpleado
        '
        Me.TxtNumeroEmpleado.BackColor = System.Drawing.Color.LightGray
        Me.TxtNumeroEmpleado.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
        Me.TxtNumeroEmpleado.Location = New System.Drawing.Point(87, 21)
        Me.TxtNumeroEmpleado.MaxLength = 7
        Me.TxtNumeroEmpleado.Name = "TxtNumeroEmpleado"
        Me.TxtNumeroEmpleado.NumberDecimal = 0
        Me.TxtNumeroEmpleado.Size = New System.Drawing.Size(71, 20)
        Me.TxtNumeroEmpleado.TabEnter = True
        Me.TxtNumeroEmpleado.TabIndex = 1
        Me.TxtNumeroEmpleado.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Opcional
        Me.TxtNumeroEmpleado.ValidField = False
        '
        'CmdExportar
        '
        Me.CmdExportar.Image = Global.MessageSMSSD.My.Resources.Resources.Excel
        Me.CmdExportar.Location = New System.Drawing.Point(1005, 1)
        Me.CmdExportar.Name = "CmdExportar"
        Me.CmdExportar.Size = New System.Drawing.Size(40, 40)
        Me.CmdExportar.TabIndex = 7
        Me.TTMensaje.SetToolTip(Me.CmdExportar, "Exporta los datos mostrados en pantalla a una hoja de Excel.")
        Me.CmdExportar.UseVisualStyleBackColor = True
        '
        'CmdCancelar
        '
        Me.CmdCancelar.Image = Global.MessageSMSSD.My.Resources.Resources.Cancel
        Me.CmdCancelar.Location = New System.Drawing.Point(913, 1)
        Me.CmdCancelar.Name = "CmdCancelar"
        Me.CmdCancelar.Size = New System.Drawing.Size(40, 40)
        Me.CmdCancelar.TabIndex = 5
        Me.TTMensaje.SetToolTip(Me.CmdCancelar, "Cancela la grabacion y/o modificacion")
        Me.CmdCancelar.UseVisualStyleBackColor = True
        '
        'CmdGrabar
        '
        Me.CmdGrabar.Image = Global.MessageSMSSD.My.Resources.Resources.Save
        Me.CmdGrabar.Location = New System.Drawing.Point(867, 1)
        Me.CmdGrabar.Name = "CmdGrabar"
        Me.CmdGrabar.Size = New System.Drawing.Size(40, 40)
        Me.CmdGrabar.TabIndex = 4
        Me.TTMensaje.SetToolTip(Me.CmdGrabar, "Graba y/o Modifica el Registro ingresado")
        Me.CmdGrabar.UseVisualStyleBackColor = True
        '
        'CmdBuscar
        '
        Me.CmdBuscar.Image = Global.MessageSMSSD.My.Resources.Resources.Search
        Me.CmdBuscar.Location = New System.Drawing.Point(959, 1)
        Me.CmdBuscar.Name = "CmdBuscar"
        Me.CmdBuscar.Size = New System.Drawing.Size(40, 40)
        Me.CmdBuscar.TabIndex = 6
        Me.TTMensaje.SetToolTip(Me.CmdBuscar, "Realiza una busqueda personalizada")
        Me.CmdBuscar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(443, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Observaciones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(84, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "No. Empleado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Telefono"
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.BackColor = System.Drawing.Color.LightGray
        Me.TxtObservaciones.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
        Me.TxtObservaciones.Location = New System.Drawing.Point(446, 21)
        Me.TxtObservaciones.MaxLength = 100
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.NumberDecimal = 0
        Me.TxtObservaciones.Size = New System.Drawing.Size(300, 20)
        Me.TxtObservaciones.TabEnter = True
        Me.TxtObservaciones.TabIndex = 3
        Me.TxtObservaciones.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Opcional
        Me.TxtObservaciones.ValidField = False
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.LemonChiffon
        Me.TxtNombre.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
        Me.TxtNombre.Location = New System.Drawing.Point(164, 21)
        Me.TxtNombre.MaxLength = 150
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.NumberDecimal = 0
        Me.TxtNombre.Size = New System.Drawing.Size(276, 20)
        Me.TxtNombre.TabEnter = True
        Me.TxtNombre.TabIndex = 2
        Me.TxtNombre.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Obligatorio
        Me.TxtNombre.ValidField = False
        '
        'TTMensaje
        '
        Me.TTMensaje.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TTMensaje.IsBalloon = True
        Me.TTMensaje.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.TTMensaje.ToolTipTitle = "Información:"
        '
        'ChkActivo
        '
        Me.ChkActivo.AutoSize = True
        Me.ChkActivo.Checked = True
        Me.ChkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkActivo.Location = New System.Drawing.Point(753, 21)
        Me.ChkActivo.Name = "ChkActivo"
        Me.ChkActivo.Size = New System.Drawing.Size(56, 17)
        Me.ChkActivo.TabIndex = 8
        Me.ChkActivo.Text = "Activo"
        Me.ChkActivo.UseVisualStyleBackColor = True
        '
        'Telefono
        '
        Me.Telefono.DataPropertyName = "Telefono"
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        Me.Telefono.Width = 70
        '
        'NumeroDeEmpleado
        '
        Me.NumeroDeEmpleado.DataPropertyName = "NumeroDeEmpleado"
        Me.NumeroDeEmpleado.HeaderText = "No De Empleado"
        Me.NumeroDeEmpleado.Name = "NumeroDeEmpleado"
        Me.NumeroDeEmpleado.ReadOnly = True
        Me.NumeroDeEmpleado.Width = 70
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Observaciones
        '
        Me.Observaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Observaciones.DataPropertyName = "Observaciones"
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.ReadOnly = True
        '
        'Activo
        '
        Me.Activo.DataPropertyName = "Activo"
        Me.Activo.HeaderText = "Activo"
        Me.Activo.Name = "Activo"
        Me.Activo.ReadOnly = True
        '
        'FrmTelefonosPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1063, 437)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmTelefonosPersonal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTelefonosPersonal"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.GrdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MnuMenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GrdDatos As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtObservaciones As UserWindowsControlLibrary.TextBoxSD
    Friend WithEvents TxtNombre As UserWindowsControlLibrary.TextBoxSD
    Friend WithEvents TxtNumeroEmpleado As UserWindowsControlLibrary.TextBoxSD
    Friend WithEvents TxtTelefono As UserWindowsControlLibrary.TextBoxSD
    Friend WithEvents TTMensaje As System.Windows.Forms.ToolTip
    Friend WithEvents MnuMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MnuBorrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CmdExportar As System.Windows.Forms.Button
    Friend WithEvents CmdCancelar As System.Windows.Forms.Button
    Friend WithEvents CmdGrabar As System.Windows.Forms.Button
    Friend WithEvents CmdBuscar As System.Windows.Forms.Button
    Friend WithEvents ChkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroDeEmpleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Activo As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
