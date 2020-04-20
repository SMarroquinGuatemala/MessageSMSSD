<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPlantillas
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
      Me.TTMensaje = New System.Windows.Forms.ToolTip(Me.components)
      Me.CmdExportar = New System.Windows.Forms.Button()
      Me.CmdCancelar = New System.Windows.Forms.Button()
      Me.CmdGrabar = New System.Windows.Forms.Button()
      Me.CmdBuscar = New System.Windows.Forms.Button()
      Me.MnuMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
      Me.MnuBorrar = New System.Windows.Forms.ToolStripMenuItem()
      Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
      Me.GrdDatos = New System.Windows.Forms.DataGridView()
      Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.Panel1 = New System.Windows.Forms.Panel()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.TxtCuerpoDelMensaje = New UserWindowsControlLibrary.TextBoxSD()
      Me.TxtCodigo = New UserWindowsControlLibrary.TextBoxSD()
      Me.MnuMenu.SuspendLayout()
      Me.TableLayoutPanel1.SuspendLayout()
      CType(Me.GrdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.Panel1.SuspendLayout()
      Me.SuspendLayout()
      '
      'TTMensaje
      '
      Me.TTMensaje.BackColor = System.Drawing.SystemColors.InactiveBorder
      Me.TTMensaje.IsBalloon = True
      Me.TTMensaje.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
      Me.TTMensaje.ToolTipTitle = "Información:"
      '
      'CmdExportar
      '
      Me.CmdExportar.Image = Global.MessageSMSSD.My.Resources.Resources.Excel
      Me.CmdExportar.Location = New System.Drawing.Point(578, 4)
      Me.CmdExportar.Name = "CmdExportar"
      Me.CmdExportar.Size = New System.Drawing.Size(40, 40)
      Me.CmdExportar.TabIndex = 6
      Me.TTMensaje.SetToolTip(Me.CmdExportar, "Exporta los datos mostrados en pantalla a una hoja de Excel.")
      Me.CmdExportar.UseVisualStyleBackColor = True
      '
      'CmdCancelar
      '
      Me.CmdCancelar.Image = Global.MessageSMSSD.My.Resources.Resources.Cancel
      Me.CmdCancelar.Location = New System.Drawing.Point(486, 4)
      Me.CmdCancelar.Name = "CmdCancelar"
      Me.CmdCancelar.Size = New System.Drawing.Size(40, 40)
      Me.CmdCancelar.TabIndex = 4
      Me.TTMensaje.SetToolTip(Me.CmdCancelar, "Cancela la grabacion y/o modificacion")
      Me.CmdCancelar.UseVisualStyleBackColor = True
      '
      'CmdGrabar
      '
      Me.CmdGrabar.Image = Global.MessageSMSSD.My.Resources.Resources.Save
      Me.CmdGrabar.Location = New System.Drawing.Point(440, 4)
      Me.CmdGrabar.Name = "CmdGrabar"
      Me.CmdGrabar.Size = New System.Drawing.Size(40, 40)
      Me.CmdGrabar.TabIndex = 3
      Me.TTMensaje.SetToolTip(Me.CmdGrabar, "Graba y/o Modifica el Registro ingresado")
      Me.CmdGrabar.UseVisualStyleBackColor = True
      '
      'CmdBuscar
      '
      Me.CmdBuscar.Image = Global.MessageSMSSD.My.Resources.Resources.Search
      Me.CmdBuscar.Location = New System.Drawing.Point(532, 4)
      Me.CmdBuscar.Name = "CmdBuscar"
      Me.CmdBuscar.Size = New System.Drawing.Size(40, 40)
      Me.CmdBuscar.TabIndex = 5
      Me.TTMensaje.SetToolTip(Me.CmdBuscar, "Realiza una busqueda personalizada")
      Me.CmdBuscar.UseVisualStyleBackColor = True
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
      Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
      Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
      Me.TableLayoutPanel1.Size = New System.Drawing.Size(630, 405)
      Me.TableLayoutPanel1.TabIndex = 1
      '
      'GrdDatos
      '
      Me.GrdDatos.AllowUserToAddRows = False
      Me.GrdDatos.AllowUserToDeleteRows = False
      DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
      Me.GrdDatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
      Me.GrdDatos.BackgroundColor = System.Drawing.Color.White
      Me.GrdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.GrdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Nombre})
      Me.GrdDatos.ContextMenuStrip = Me.MnuMenu
      Me.GrdDatos.Dock = System.Windows.Forms.DockStyle.Fill
      Me.GrdDatos.Location = New System.Drawing.Point(4, 59)
      Me.GrdDatos.MultiSelect = False
      Me.GrdDatos.Name = "GrdDatos"
      Me.GrdDatos.ReadOnly = True
      Me.GrdDatos.RowHeadersWidth = 10
      Me.GrdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.GrdDatos.Size = New System.Drawing.Size(622, 342)
      Me.GrdDatos.TabIndex = 0
      '
      'Codigo
      '
      Me.Codigo.DataPropertyName = "IdPlantilla"
      Me.Codigo.HeaderText = "Codigo"
      Me.Codigo.Name = "Codigo"
      Me.Codigo.ReadOnly = True
      Me.Codigo.Width = 50
      '
      'Nombre
      '
      Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
      Me.Nombre.DataPropertyName = "CuerpoDeMensaje"
      Me.Nombre.HeaderText = "Cuerpo del Mensaje"
      Me.Nombre.Name = "Nombre"
      Me.Nombre.ReadOnly = True
      '
      'Panel1
      '
      Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.Panel1.Controls.Add(Me.Label2)
      Me.Panel1.Controls.Add(Me.Label1)
      Me.Panel1.Controls.Add(Me.TxtCuerpoDelMensaje)
      Me.Panel1.Controls.Add(Me.TxtCodigo)
      Me.Panel1.Controls.Add(Me.CmdExportar)
      Me.Panel1.Controls.Add(Me.CmdCancelar)
      Me.Panel1.Controls.Add(Me.CmdGrabar)
      Me.Panel1.Controls.Add(Me.CmdBuscar)
      Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.Panel1.Location = New System.Drawing.Point(4, 4)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(622, 48)
      Me.Panel1.TabIndex = 0
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(47, 5)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(103, 13)
      Me.Label2.TabIndex = 2
      Me.Label2.Text = "Cuerpo Del Mensaje"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(4, 5)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(40, 13)
      Me.Label1.TabIndex = 2
      Me.Label1.Text = "Codigo"
      '
      'TxtCuerpoDelMensaje
      '
      Me.TxtCuerpoDelMensaje.BackColor = System.Drawing.Color.LemonChiffon
      Me.TxtCuerpoDelMensaje.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
      Me.TxtCuerpoDelMensaje.Location = New System.Drawing.Point(50, 21)
      Me.TxtCuerpoDelMensaje.MaxLength = 150
      Me.TxtCuerpoDelMensaje.Name = "TxtCuerpoDelMensaje"
      Me.TxtCuerpoDelMensaje.NumberDecimal = 0
      Me.TxtCuerpoDelMensaje.Size = New System.Drawing.Size(384, 20)
      Me.TxtCuerpoDelMensaje.TabEnter = True
      Me.TxtCuerpoDelMensaje.TabIndex = 2
      Me.TxtCuerpoDelMensaje.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Obligatorio
      Me.TxtCuerpoDelMensaje.ValidField = False
      '
      'TxtCodigo
      '
      Me.TxtCodigo.BackColor = System.Drawing.Color.LightGreen
      Me.TxtCodigo.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
      Me.TxtCodigo.Location = New System.Drawing.Point(5, 21)
      Me.TxtCodigo.Name = "TxtCodigo"
      Me.TxtCodigo.NumberDecimal = 0
      Me.TxtCodigo.Size = New System.Drawing.Size(39, 20)
      Me.TxtCodigo.TabEnter = True
      Me.TxtCodigo.TabIndex = 0
      Me.TxtCodigo.TabStop = False
      Me.TxtCodigo.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Desplieque
      Me.TxtCodigo.ValidField = False
      '
      'FrmPlantillas
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.White
      Me.ClientSize = New System.Drawing.Size(636, 410)
      Me.Controls.Add(Me.TableLayoutPanel1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.Name = "FrmPlantillas"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "FrmPlantillas"
      Me.MnuMenu.ResumeLayout(False)
      Me.TableLayoutPanel1.ResumeLayout(False)
      CType(Me.GrdDatos, System.ComponentModel.ISupportInitialize).EndInit()
      Me.Panel1.ResumeLayout(False)
      Me.Panel1.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents TTMensaje As System.Windows.Forms.ToolTip
   Friend WithEvents MnuMenu As System.Windows.Forms.ContextMenuStrip
   Friend WithEvents MnuBorrar As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
   Friend WithEvents GrdDatos As System.Windows.Forms.DataGridView
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents TxtCuerpoDelMensaje As UserWindowsControlLibrary.TextBoxSD
   Friend WithEvents TxtCodigo As UserWindowsControlLibrary.TextBoxSD
   Friend WithEvents CmdExportar As System.Windows.Forms.Button
   Friend WithEvents CmdCancelar As System.Windows.Forms.Button
   Friend WithEvents CmdGrabar As System.Windows.Forms.Button
   Friend WithEvents CmdBuscar As System.Windows.Forms.Button
   Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
