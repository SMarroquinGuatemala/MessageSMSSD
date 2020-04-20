<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTelefonoPorGrupo
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
      Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTelefonoPorGrupo))
      Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
      Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
      Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
      Me.GrdContactos = New System.Windows.Forms.DataGridView()
      Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.GrdAsignados = New System.Windows.Forms.DataGridView()
      Me.TelefonoAsignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.NombreAsignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
      Me.PicRemove = New System.Windows.Forms.PictureBox()
      Me.PicAdd = New System.Windows.Forms.PictureBox()
      Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.CboGrupos = New UserWindowsControlLibrary.ComboBoxSD()
      Me.CmdBuscar = New System.Windows.Forms.Button()
      Me.TTMensaje = New System.Windows.Forms.ToolTip(Me.components)
      Me.TableLayoutPanel1.SuspendLayout()
      Me.TableLayoutPanel3.SuspendLayout()
      Me.TableLayoutPanel2.SuspendLayout()
      CType(Me.GrdContactos, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.GrdAsignados, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UltraGroupBox3.SuspendLayout()
      CType(Me.PicRemove, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PicAdd, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UltraGroupBox1.SuspendLayout()
      CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UltraGroupBox2.SuspendLayout()
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
      Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
      Me.TableLayoutPanel1.Controls.Add(Me.UltraGroupBox2, 0, 0)
      Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
      Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
      Me.TableLayoutPanel1.RowCount = 2
      Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
      Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
      Me.TableLayoutPanel1.Size = New System.Drawing.Size(757, 436)
      Me.TableLayoutPanel1.TabIndex = 0
      '
      'TableLayoutPanel3
      '
      Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(237, Byte), Integer))
      Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
      Me.TableLayoutPanel3.ColumnCount = 1
      Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
      Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel2, 0, 1)
      Me.TableLayoutPanel3.Controls.Add(Me.UltraGroupBox1, 0, 0)
      Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
      Me.TableLayoutPanel3.Location = New System.Drawing.Point(4, 64)
      Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
      Me.TableLayoutPanel3.RowCount = 2
      Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
      Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 325.0!))
      Me.TableLayoutPanel3.Size = New System.Drawing.Size(749, 368)
      Me.TableLayoutPanel3.TabIndex = 2
      '
      'TableLayoutPanel2
      '
      Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
      Me.TableLayoutPanel2.ColumnCount = 3
      Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
      Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83.0!))
      Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
      Me.TableLayoutPanel2.Controls.Add(Me.GrdContactos, 2, 0)
      Me.TableLayoutPanel2.Controls.Add(Me.GrdAsignados, 0, 0)
      Me.TableLayoutPanel2.Controls.Add(Me.UltraGroupBox3, 1, 0)
      Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
      Me.TableLayoutPanel2.Location = New System.Drawing.Point(5, 44)
      Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
      Me.TableLayoutPanel2.RowCount = 1
      Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
      Me.TableLayoutPanel2.Size = New System.Drawing.Size(739, 319)
      Me.TableLayoutPanel2.TabIndex = 3
      '
      'GrdContactos
      '
      Me.GrdContactos.AllowUserToAddRows = False
      Me.GrdContactos.AllowUserToDeleteRows = False
      DataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue
      Me.GrdContactos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
      Me.GrdContactos.BackgroundColor = System.Drawing.Color.White
      Me.GrdContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.GrdContactos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Telefono, Me.Nombre})
      Me.GrdContactos.Dock = System.Windows.Forms.DockStyle.Fill
      Me.GrdContactos.Location = New System.Drawing.Point(415, 4)
      Me.GrdContactos.Name = "GrdContactos"
      Me.GrdContactos.ReadOnly = True
      Me.GrdContactos.RowHeadersWidth = 10
      Me.GrdContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.GrdContactos.Size = New System.Drawing.Size(320, 311)
      Me.GrdContactos.TabIndex = 2
      '
      'Telefono
      '
      Me.Telefono.DataPropertyName = "Telefono"
      Me.Telefono.HeaderText = "Telefono"
      Me.Telefono.Name = "Telefono"
      Me.Telefono.ReadOnly = True
      Me.Telefono.Width = 60
      '
      'Nombre
      '
      Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
      Me.Nombre.DataPropertyName = "Nombre"
      Me.Nombre.HeaderText = "Nombre"
      Me.Nombre.Name = "Nombre"
      Me.Nombre.ReadOnly = True
      '
      'GrdAsignados
      '
      Me.GrdAsignados.AllowUserToAddRows = False
      Me.GrdAsignados.AllowUserToDeleteRows = False
      DataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue
      Me.GrdAsignados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
      Me.GrdAsignados.BackgroundColor = System.Drawing.Color.White
      Me.GrdAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.GrdAsignados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TelefonoAsignado, Me.NombreAsignado})
      Me.GrdAsignados.Dock = System.Windows.Forms.DockStyle.Fill
      Me.GrdAsignados.Location = New System.Drawing.Point(4, 4)
      Me.GrdAsignados.Name = "GrdAsignados"
      Me.GrdAsignados.ReadOnly = True
      Me.GrdAsignados.RowHeadersWidth = 10
      Me.GrdAsignados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.GrdAsignados.Size = New System.Drawing.Size(320, 311)
      Me.GrdAsignados.TabIndex = 1
      '
      'TelefonoAsignado
      '
      Me.TelefonoAsignado.DataPropertyName = "Telefono"
      Me.TelefonoAsignado.HeaderText = "Telefono"
      Me.TelefonoAsignado.Name = "TelefonoAsignado"
      Me.TelefonoAsignado.ReadOnly = True
      Me.TelefonoAsignado.Width = 60
      '
      'NombreAsignado
      '
      Me.NombreAsignado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
      Me.NombreAsignado.DataPropertyName = "Nombre"
      Me.NombreAsignado.HeaderText = "Nombre"
      Me.NombreAsignado.Name = "NombreAsignado"
      Me.NombreAsignado.ReadOnly = True
      '
      'UltraGroupBox3
      '
      Me.UltraGroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.UltraGroupBox3.Controls.Add(Me.PicRemove)
      Me.UltraGroupBox3.Controls.Add(Me.PicAdd)
      Me.UltraGroupBox3.Location = New System.Drawing.Point(331, 4)
      Me.UltraGroupBox3.Name = "UltraGroupBox3"
      Me.UltraGroupBox3.Size = New System.Drawing.Size(77, 311)
      Me.UltraGroupBox3.TabIndex = 0
      Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
      '
      'PicRemove
      '
      Me.PicRemove.BackColor = System.Drawing.Color.Transparent
      Me.PicRemove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.PicRemove.Cursor = System.Windows.Forms.Cursors.Hand
      Me.PicRemove.Image = Global.MessageSMSSD.My.Resources.Resources.ArrowRightBlack
      Me.PicRemove.Location = New System.Drawing.Point(6, 150)
      Me.PicRemove.Name = "PicRemove"
      Me.PicRemove.Size = New System.Drawing.Size(65, 65)
      Me.PicRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
      Me.PicRemove.TabIndex = 2
      Me.PicRemove.TabStop = False
      Me.TTMensaje.SetToolTip(Me.PicRemove, "Remueve los contactos del grupo seleccionado")
      '
      'PicAdd
      '
      Me.PicAdd.BackColor = System.Drawing.Color.Transparent
      Me.PicAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.PicAdd.Cursor = System.Windows.Forms.Cursors.Hand
      Me.PicAdd.Image = Global.MessageSMSSD.My.Resources.Resources.ArrowLeftBlack
      Me.PicAdd.Location = New System.Drawing.Point(6, 79)
      Me.PicAdd.Name = "PicAdd"
      Me.PicAdd.Size = New System.Drawing.Size(65, 65)
      Me.PicAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
      Me.PicAdd.TabIndex = 2
      Me.PicAdd.TabStop = False
      Me.TTMensaje.SetToolTip(Me.PicAdd, "Agregar contactos al grupo seleccionado")
      '
      'UltraGroupBox1
      '
      Me.UltraGroupBox1.Controls.Add(Me.Label3)
      Me.UltraGroupBox1.Controls.Add(Me.Label2)
      Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.UltraGroupBox1.Location = New System.Drawing.Point(5, 5)
      Me.UltraGroupBox1.Name = "UltraGroupBox1"
      Me.UltraGroupBox1.Size = New System.Drawing.Size(739, 31)
      Me.UltraGroupBox1.TabIndex = 4
      Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.Label3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(415, 5)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(320, 23)
      Me.Label3.TabIndex = 0
      Me.Label3.Text = "Contactos No Asignados"
      Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(5, 5)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(319, 23)
      Me.Label2.TabIndex = 0
      Me.Label2.Text = "Contactos Asignados"
      Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
      '
      'UltraGroupBox2
      '
      Me.UltraGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.UltraGroupBox2.Controls.Add(Me.Label1)
      Me.UltraGroupBox2.Controls.Add(Me.CboGrupos)
      Me.UltraGroupBox2.Controls.Add(Me.CmdBuscar)
      Me.UltraGroupBox2.Location = New System.Drawing.Point(4, 4)
      Me.UltraGroupBox2.Name = "UltraGroupBox2"
      Me.UltraGroupBox2.Size = New System.Drawing.Size(749, 53)
      Me.UltraGroupBox2.TabIndex = 3
      Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Location = New System.Drawing.Point(7, 10)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(36, 13)
      Me.Label1.TabIndex = 11
      Me.Label1.Text = "Grupo"
      '
      'CboGrupos
      '
      Me.CboGrupos.AddAll = False
      Me.CboGrupos.AlternativeQuery = Nothing
      Me.CboGrupos.BackColor = System.Drawing.Color.LemonChiffon
      Me.CboGrupos.ColumnDisplay = "Nombre"
      Me.CboGrupos.ColumnValue = "IdGrupo"
      Me.CboGrupos.Conditions = Nothing
      Me.CboGrupos.DataBase = "DbTi"
      Me.CboGrupos.DisplayMember = "Descripcion"
      Me.CboGrupos.FormattingEnabled = True
      Me.CboGrupos.Location = New System.Drawing.Point(9, 26)
      Me.CboGrupos.Name = "CboGrupos"
      Me.CboGrupos.NumberOfZeros = 0
      Me.CboGrupos.Objects = UserWindowsControlLibrary.ComboBoxSD.TypeObjects.Table
      Me.CboGrupos.Size = New System.Drawing.Size(235, 21)
      Me.CboGrupos.TabEnter = True
      Me.CboGrupos.TabIndex = 0
      Me.CboGrupos.Table = "TblSmSgruposDeEnvio"
      Me.CboGrupos.TypeField = UserWindowsControlLibrary.ComboBoxSD.TiposDeCampo.Obligatorio
      Me.CboGrupos.User = Nothing
      Me.CboGrupos.ValidField = False
      Me.CboGrupos.ValueMember = "Codigo"
      '
      'CmdBuscar
      '
      Me.CmdBuscar.Image = Global.MessageSMSSD.My.Resources.Resources.Search
      Me.CmdBuscar.Location = New System.Drawing.Point(700, 10)
      Me.CmdBuscar.Name = "CmdBuscar"
      Me.CmdBuscar.Size = New System.Drawing.Size(40, 40)
      Me.CmdBuscar.TabIndex = 1
      Me.TTMensaje.SetToolTip(Me.CmdBuscar, "Realiza una busqueda por Grupo")
      Me.CmdBuscar.UseVisualStyleBackColor = True
      '
      'TTMensaje
      '
      Me.TTMensaje.BackColor = System.Drawing.SystemColors.InactiveBorder
      Me.TTMensaje.IsBalloon = True
      Me.TTMensaje.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
      Me.TTMensaje.ToolTipTitle = "Información:"
      '
      'FrmTelefonoPorGrupo
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.White
      Me.ClientSize = New System.Drawing.Size(764, 442)
      Me.Controls.Add(Me.TableLayoutPanel1)
      Me.ForeColor = System.Drawing.SystemColors.ControlText
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.Name = "FrmTelefonoPorGrupo"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "FrmTelefonoPorGrupo"
      Me.TableLayoutPanel1.ResumeLayout(False)
      Me.TableLayoutPanel3.ResumeLayout(False)
      Me.TableLayoutPanel2.ResumeLayout(False)
      CType(Me.GrdContactos, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.GrdAsignados, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UltraGroupBox3.ResumeLayout(False)
      CType(Me.PicRemove, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PicAdd, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UltraGroupBox1.ResumeLayout(False)
      CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UltraGroupBox2.ResumeLayout(False)
      Me.UltraGroupBox2.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
   Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
   Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
   Friend WithEvents TTMensaje As System.Windows.Forms.ToolTip
   Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents CboGrupos As UserWindowsControlLibrary.ComboBoxSD
   Friend WithEvents CmdBuscar As System.Windows.Forms.Button
   Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
   Friend WithEvents GrdAsignados As System.Windows.Forms.DataGridView
   Friend WithEvents GrdContactos As System.Windows.Forms.DataGridView
   Friend WithEvents PicAdd As System.Windows.Forms.PictureBox
   Friend WithEvents PicRemove As System.Windows.Forms.PictureBox
   Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents TelefonoAsignado As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents NombreAsignado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
