<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEnvioSms
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
      Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
      Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
      Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
      Me.Label9 = New System.Windows.Forms.Label()
      Me.TxtNumeroEmpleado = New UserWindowsControlLibrary.TextBoxSD()
      Me.Label6 = New System.Windows.Forms.Label()
      Me.TxtNombre = New UserWindowsControlLibrary.TextBoxSD()
      Me.LblContadorDeCaracteres = New System.Windows.Forms.Label()
      Me.CmdEnviarSms = New System.Windows.Forms.Button()
      Me.Panel4 = New System.Windows.Forms.Panel()
      Me.lblDisponibles = New System.Windows.Forms.Label()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.GrdSeleccionados = New System.Windows.Forms.DataGridView()
      Me.GrupoSeleccionado = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.TelefonoSeleccionado = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.NombreSeleccionado = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.Group = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.MnuMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
      Me.MnuBorrar = New System.Windows.Forms.ToolStripMenuItem()
      Me.TxtMensaje = New UserWindowsControlLibrary.TextBoxSD()
      Me.Panel3 = New System.Windows.Forms.Panel()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.TxtPlantillas = New UserWindowsControlLibrary.TextBoxSD()
      Me.GrdPlantillas = New System.Windows.Forms.DataGridView()
      Me.IdPlantilla = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.CuerpoDeMensaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.Panel2 = New System.Windows.Forms.Panel()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.TxtUsuarios = New UserWindowsControlLibrary.TextBoxSD()
      Me.GrdUsuarios = New System.Windows.Forms.DataGridView()
      Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.NombreUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
      Me.Panel1 = New System.Windows.Forms.Panel()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.TxtGrupos = New UserWindowsControlLibrary.TextBoxSD()
      Me.GrdGrupos = New System.Windows.Forms.DataGridView()
      Me.Grupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.NombreGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.IsGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
      Me.TxtEnviadoPorBusqueda = New UserWindowsControlLibrary.TextBoxSD()
      Me.Label8 = New System.Windows.Forms.Label()
      Me.Label7 = New System.Windows.Forms.Label()
      Me.Label5 = New System.Windows.Forms.Label()
      Me.TxtFechaFinal = New UserWindowsControlLibrary.MaskedTextBoxSD()
      Me.TxtFechaInicial = New UserWindowsControlLibrary.MaskedTextBoxSD()
      Me.CmdExportar = New System.Windows.Forms.Button()
      Me.CmdBuscar = New System.Windows.Forms.Button()
      Me.GrdHistorial = New System.Windows.Forms.DataGridView()
      Me.Correlativo = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.TelefonoBusqueda = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.CuerpoMensaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.FechaDeEnvio = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.EnviadoPor = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
      Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
      Me.LblValidoHasta = New System.Windows.Forms.Label()
      Me.UltraTabPageControl1.SuspendLayout()
      Me.Panel4.SuspendLayout()
      CType(Me.GrdSeleccionados, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.MnuMenu.SuspendLayout()
      Me.Panel3.SuspendLayout()
      CType(Me.GrdPlantillas, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.Panel2.SuspendLayout()
      CType(Me.GrdUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.Panel1.SuspendLayout()
      CType(Me.GrdGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UltraTabPageControl2.SuspendLayout()
      CType(Me.GrdHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UltraTabControl1.SuspendLayout()
      Me.SuspendLayout()
      '
      'UltraTabPageControl1
      '
      Me.UltraTabPageControl1.Controls.Add(Me.Label9)
      Me.UltraTabPageControl1.Controls.Add(Me.TxtNumeroEmpleado)
      Me.UltraTabPageControl1.Controls.Add(Me.Label6)
      Me.UltraTabPageControl1.Controls.Add(Me.TxtNombre)
      Me.UltraTabPageControl1.Controls.Add(Me.LblContadorDeCaracteres)
      Me.UltraTabPageControl1.Controls.Add(Me.CmdEnviarSms)
      Me.UltraTabPageControl1.Controls.Add(Me.Panel4)
      Me.UltraTabPageControl1.Controls.Add(Me.TxtMensaje)
      Me.UltraTabPageControl1.Controls.Add(Me.Panel3)
      Me.UltraTabPageControl1.Controls.Add(Me.Panel2)
      Me.UltraTabPageControl1.Controls.Add(Me.PictureBox1)
      Me.UltraTabPageControl1.Controls.Add(Me.Panel1)
      Me.UltraTabPageControl1.Location = New System.Drawing.Point(106, 1)
      Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
      Me.UltraTabPageControl1.Size = New System.Drawing.Size(801, 500)
      '
      'Label9
      '
      Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.Label9.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.Location = New System.Drawing.Point(274, 4)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(253, 23)
      Me.Label9.TabIndex = 11
      Me.Label9.Text = "Mensaje a enviar"
      Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'TxtNumeroEmpleado
      '
      Me.TxtNumeroEmpleado.BackColor = System.Drawing.Color.LightGreen
      Me.TxtNumeroEmpleado.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
      Me.TxtNumeroEmpleado.Location = New System.Drawing.Point(274, 131)
      Me.TxtNumeroEmpleado.MaxLength = 7
      Me.TxtNumeroEmpleado.Name = "TxtNumeroEmpleado"
      Me.TxtNumeroEmpleado.NumberDecimal = 0
      Me.TxtNumeroEmpleado.Size = New System.Drawing.Size(71, 20)
      Me.TxtNumeroEmpleado.TabEnter = True
      Me.TxtNumeroEmpleado.TabIndex = 3
      Me.TxtNumeroEmpleado.TabStop = False
      Me.TxtNumeroEmpleado.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Desplieque
      Me.TxtNumeroEmpleado.ValidField = False
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.Location = New System.Drawing.Point(271, 115)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(74, 13)
      Me.Label6.TabIndex = 9
      Me.Label6.Text = "No. Empleado"
      '
      'TxtNombre
      '
      Me.TxtNombre.BackColor = System.Drawing.Color.LightGreen
      Me.TxtNombre.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
      Me.TxtNombre.Location = New System.Drawing.Point(351, 131)
      Me.TxtNombre.MaxLength = 150
      Me.TxtNombre.Name = "TxtNombre"
      Me.TxtNombre.NumberDecimal = 0
      Me.TxtNombre.Size = New System.Drawing.Size(182, 20)
      Me.TxtNombre.TabEnter = True
      Me.TxtNombre.TabIndex = 10
      Me.TxtNombre.TabStop = False
      Me.TxtNombre.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Desplieque
      Me.TxtNombre.ValidField = False
      '
      'LblContadorDeCaracteres
      '
      Me.LblContadorDeCaracteres.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.LblContadorDeCaracteres.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.LblContadorDeCaracteres.Location = New System.Drawing.Point(282, 111)
      Me.LblContadorDeCaracteres.Name = "LblContadorDeCaracteres"
      Me.LblContadorDeCaracteres.Size = New System.Drawing.Size(253, 23)
      Me.LblContadorDeCaracteres.TabIndex = 6
      Me.LblContadorDeCaracteres.Text = "Caracteres restantes: 148"
      Me.LblContadorDeCaracteres.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'CmdEnviarSms
      '
      Me.CmdEnviarSms.BackgroundImage = Global.MessageSMSSD.My.Resources.Resources.Send_Mail
      Me.CmdEnviarSms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
      Me.CmdEnviarSms.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.CmdEnviarSms.Location = New System.Drawing.Point(351, 151)
      Me.CmdEnviarSms.Name = "CmdEnviarSms"
      Me.CmdEnviarSms.Size = New System.Drawing.Size(107, 52)
      Me.CmdEnviarSms.TabIndex = 4
      Me.CmdEnviarSms.Text = "Enviar Mensaje"
      Me.CmdEnviarSms.UseVisualStyleBackColor = True
      '
      'Panel4
      '
      Me.Panel4.Controls.Add(Me.LblValidoHasta)
      Me.Panel4.Controls.Add(Me.lblDisponibles)
      Me.Panel4.Controls.Add(Me.Label4)
      Me.Panel4.Controls.Add(Me.GrdSeleccionados)
      Me.Panel4.Location = New System.Drawing.Point(270, 202)
      Me.Panel4.Name = "Panel4"
      Me.Panel4.Size = New System.Drawing.Size(265, 296)
      Me.Panel4.TabIndex = 4
      '
      'lblDisponibles
      '
      Me.lblDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblDisponibles.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblDisponibles.ForeColor = System.Drawing.Color.Blue
      Me.lblDisponibles.Location = New System.Drawing.Point(3, 1)
      Me.lblDisponibles.Name = "lblDisponibles"
      Me.lblDisponibles.Size = New System.Drawing.Size(259, 19)
      Me.lblDisponibles.TabIndex = 6
      Me.lblDisponibles.Text = "Disponibles: XX"
      Me.lblDisponibles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label4
      '
      Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.Label4.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(4, 42)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(259, 23)
      Me.Label4.TabIndex = 5
      Me.Label4.Text = "Datos Seleccionados"
      Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'GrdSeleccionados
      '
      Me.GrdSeleccionados.AllowUserToAddRows = False
      Me.GrdSeleccionados.AllowUserToDeleteRows = False
      DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
      Me.GrdSeleccionados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
      Me.GrdSeleccionados.BackgroundColor = System.Drawing.Color.White
      Me.GrdSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.GrdSeleccionados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GrupoSeleccionado, Me.TelefonoSeleccionado, Me.NombreSeleccionado, Me.Group})
      Me.GrdSeleccionados.ContextMenuStrip = Me.MnuMenu
      Me.GrdSeleccionados.Location = New System.Drawing.Point(4, 66)
      Me.GrdSeleccionados.MultiSelect = False
      Me.GrdSeleccionados.Name = "GrdSeleccionados"
      Me.GrdSeleccionados.ReadOnly = True
      Me.GrdSeleccionados.RowHeadersWidth = 20
      Me.GrdSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.GrdSeleccionados.Size = New System.Drawing.Size(259, 226)
      Me.GrdSeleccionados.TabIndex = 2
      '
      'GrupoSeleccionado
      '
      Me.GrupoSeleccionado.HeaderText = "GrupoSeleccionado"
      Me.GrupoSeleccionado.Name = "GrupoSeleccionado"
      Me.GrupoSeleccionado.ReadOnly = True
      Me.GrupoSeleccionado.Visible = False
      '
      'TelefonoSeleccionado
      '
      Me.TelefonoSeleccionado.HeaderText = "Telefono"
      Me.TelefonoSeleccionado.Name = "TelefonoSeleccionado"
      Me.TelefonoSeleccionado.ReadOnly = True
      Me.TelefonoSeleccionado.Width = 60
      '
      'NombreSeleccionado
      '
      Me.NombreSeleccionado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
      Me.NombreSeleccionado.HeaderText = "Nombre"
      Me.NombreSeleccionado.Name = "NombreSeleccionado"
      Me.NombreSeleccionado.ReadOnly = True
      '
      'Group
      '
      Me.Group.HeaderText = "Group"
      Me.Group.Name = "Group"
      Me.Group.ReadOnly = True
      Me.Group.Visible = False
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
      'TxtMensaje
      '
      Me.TxtMensaje.BackColor = System.Drawing.Color.LemonChiffon
      Me.TxtMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.TxtMensaje.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
      Me.TxtMensaje.Location = New System.Drawing.Point(270, 30)
      Me.TxtMensaje.MaxLength = 148
      Me.TxtMensaje.Multiline = True
      Me.TxtMensaje.Name = "TxtMensaje"
      Me.TxtMensaje.NumberDecimal = 0
      Me.TxtMensaje.Size = New System.Drawing.Size(263, 78)
      Me.TxtMensaje.TabEnter = True
      Me.TxtMensaje.TabIndex = 2
      Me.TxtMensaje.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Obligatorio
      Me.TxtMensaje.ValidField = False
      '
      'Panel3
      '
      Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.Panel3.Controls.Add(Me.Label3)
      Me.Panel3.Controls.Add(Me.TxtPlantillas)
      Me.Panel3.Controls.Add(Me.GrdPlantillas)
      Me.Panel3.Location = New System.Drawing.Point(536, 2)
      Me.Panel3.Name = "Panel3"
      Me.Panel3.Size = New System.Drawing.Size(263, 243)
      Me.Panel3.TabIndex = 5
      '
      'Label3
      '
      Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.Label3.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(4, 1)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(253, 23)
      Me.Label3.TabIndex = 5
      Me.Label3.Text = "Listado De Plantillas"
      Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'TxtPlantillas
      '
      Me.TxtPlantillas.BackColor = System.Drawing.Color.LightGray
      Me.TxtPlantillas.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
      Me.TxtPlantillas.Location = New System.Drawing.Point(4, 26)
      Me.TxtPlantillas.Name = "TxtPlantillas"
      Me.TxtPlantillas.NumberDecimal = 0
      Me.TxtPlantillas.Size = New System.Drawing.Size(252, 20)
      Me.TxtPlantillas.TabEnter = True
      Me.TxtPlantillas.TabIndex = 0
      Me.TxtPlantillas.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Opcional
      Me.TxtPlantillas.ValidField = False
      '
      'GrdPlantillas
      '
      Me.GrdPlantillas.AllowUserToAddRows = False
      Me.GrdPlantillas.AllowUserToDeleteRows = False
      DataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue
      Me.GrdPlantillas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
      Me.GrdPlantillas.BackgroundColor = System.Drawing.Color.White
      Me.GrdPlantillas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.GrdPlantillas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPlantilla, Me.CuerpoDeMensaje})
      Me.GrdPlantillas.Location = New System.Drawing.Point(4, 52)
      Me.GrdPlantillas.MultiSelect = False
      Me.GrdPlantillas.Name = "GrdPlantillas"
      Me.GrdPlantillas.ReadOnly = True
      Me.GrdPlantillas.RowHeadersWidth = 20
      Me.GrdPlantillas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.GrdPlantillas.Size = New System.Drawing.Size(253, 186)
      Me.GrdPlantillas.TabIndex = 2
      '
      'IdPlantilla
      '
      Me.IdPlantilla.DataPropertyName = "IdPlantilla"
      Me.IdPlantilla.HeaderText = "IdPlantilla"
      Me.IdPlantilla.Name = "IdPlantilla"
      Me.IdPlantilla.ReadOnly = True
      Me.IdPlantilla.Visible = False
      Me.IdPlantilla.Width = 60
      '
      'CuerpoDeMensaje
      '
      Me.CuerpoDeMensaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
      Me.CuerpoDeMensaje.DataPropertyName = "CuerpoDeMensaje"
      Me.CuerpoDeMensaje.HeaderText = "Mensaje"
      Me.CuerpoDeMensaje.Name = "CuerpoDeMensaje"
      Me.CuerpoDeMensaje.ReadOnly = True
      '
      'Panel2
      '
      Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.Panel2.Controls.Add(Me.Label2)
      Me.Panel2.Controls.Add(Me.TxtUsuarios)
      Me.Panel2.Controls.Add(Me.GrdUsuarios)
      Me.Panel2.Location = New System.Drawing.Point(3, 247)
      Me.Panel2.Name = "Panel2"
      Me.Panel2.Size = New System.Drawing.Size(263, 243)
      Me.Panel2.TabIndex = 1
      '
      'Label2
      '
      Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.Label2.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(3, 1)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(253, 23)
      Me.Label2.TabIndex = 5
      Me.Label2.Text = "Listado De Usuarios"
      Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'TxtUsuarios
      '
      Me.TxtUsuarios.BackColor = System.Drawing.Color.LightGray
      Me.TxtUsuarios.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
      Me.TxtUsuarios.Location = New System.Drawing.Point(3, 26)
      Me.TxtUsuarios.Name = "TxtUsuarios"
      Me.TxtUsuarios.NumberDecimal = 0
      Me.TxtUsuarios.Size = New System.Drawing.Size(253, 20)
      Me.TxtUsuarios.TabEnter = True
      Me.TxtUsuarios.TabIndex = 0
      Me.TxtUsuarios.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Opcional
      Me.TxtUsuarios.ValidField = False
      '
      'GrdUsuarios
      '
      Me.GrdUsuarios.AllowUserToAddRows = False
      Me.GrdUsuarios.AllowUserToDeleteRows = False
      DataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue
      Me.GrdUsuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
      Me.GrdUsuarios.BackgroundColor = System.Drawing.Color.White
      Me.GrdUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.GrdUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Telefono, Me.NombreUsuario})
      Me.GrdUsuarios.Location = New System.Drawing.Point(3, 52)
      Me.GrdUsuarios.MultiSelect = False
      Me.GrdUsuarios.Name = "GrdUsuarios"
      Me.GrdUsuarios.ReadOnly = True
      Me.GrdUsuarios.RowHeadersWidth = 20
      Me.GrdUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.GrdUsuarios.Size = New System.Drawing.Size(253, 186)
      Me.GrdUsuarios.TabIndex = 2
      '
      'Telefono
      '
      Me.Telefono.DataPropertyName = "Telefono"
      Me.Telefono.HeaderText = "Telefono"
      Me.Telefono.Name = "Telefono"
      Me.Telefono.ReadOnly = True
      Me.Telefono.Width = 60
      '
      'NombreUsuario
      '
      Me.NombreUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
      Me.NombreUsuario.DataPropertyName = "Nombre"
      Me.NombreUsuario.HeaderText = "Nombre"
      Me.NombreUsuario.Name = "NombreUsuario"
      Me.NombreUsuario.ReadOnly = True
      '
      'PictureBox1
      '
      Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.PictureBox1.Image = Global.MessageSMSSD.My.Resources.Resources.SD_Front_512
      Me.PictureBox1.Location = New System.Drawing.Point(536, 234)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(263, 264)
      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
      Me.PictureBox1.TabIndex = 3
      Me.PictureBox1.TabStop = False
      '
      'Panel1
      '
      Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.Panel1.Controls.Add(Me.Label1)
      Me.Panel1.Controls.Add(Me.TxtGrupos)
      Me.Panel1.Controls.Add(Me.GrdGrupos)
      Me.Panel1.Location = New System.Drawing.Point(3, 2)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(263, 243)
      Me.Panel1.TabIndex = 0
      '
      'Label1
      '
      Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.Label1.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(3, 1)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(253, 23)
      Me.Label1.TabIndex = 4
      Me.Label1.Text = "Listado De Grupos"
      Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'TxtGrupos
      '
      Me.TxtGrupos.BackColor = System.Drawing.Color.LightGray
      Me.TxtGrupos.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
      Me.TxtGrupos.Location = New System.Drawing.Point(3, 26)
      Me.TxtGrupos.Name = "TxtGrupos"
      Me.TxtGrupos.NumberDecimal = 0
      Me.TxtGrupos.Size = New System.Drawing.Size(253, 20)
      Me.TxtGrupos.TabEnter = True
      Me.TxtGrupos.TabIndex = 0
      Me.TxtGrupos.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Opcional
      Me.TxtGrupos.ValidField = False
      '
      'GrdGrupos
      '
      Me.GrdGrupos.AllowUserToAddRows = False
      Me.GrdGrupos.AllowUserToDeleteRows = False
      DataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue
      Me.GrdGrupos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
      Me.GrdGrupos.BackgroundColor = System.Drawing.Color.White
      Me.GrdGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.GrdGrupos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Grupo, Me.NombreGrupo, Me.IsGroup})
      Me.GrdGrupos.Location = New System.Drawing.Point(3, 52)
      Me.GrdGrupos.MultiSelect = False
      Me.GrdGrupos.Name = "GrdGrupos"
      Me.GrdGrupos.ReadOnly = True
      Me.GrdGrupos.RowHeadersWidth = 20
      Me.GrdGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.GrdGrupos.Size = New System.Drawing.Size(253, 186)
      Me.GrdGrupos.TabIndex = 2
      '
      'Grupo
      '
      Me.Grupo.DataPropertyName = "IdGrupo"
      Me.Grupo.HeaderText = "Grupo"
      Me.Grupo.Name = "Grupo"
      Me.Grupo.ReadOnly = True
      Me.Grupo.Visible = False
      Me.Grupo.Width = 60
      '
      'NombreGrupo
      '
      Me.NombreGrupo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
      Me.NombreGrupo.DataPropertyName = "Nombre"
      Me.NombreGrupo.HeaderText = "Nombre"
      Me.NombreGrupo.Name = "NombreGrupo"
      Me.NombreGrupo.ReadOnly = True
      '
      'IsGroup
      '
      Me.IsGroup.DataPropertyName = "IsGroup"
      Me.IsGroup.HeaderText = "IsGroup"
      Me.IsGroup.Name = "IsGroup"
      Me.IsGroup.ReadOnly = True
      Me.IsGroup.Visible = False
      '
      'UltraTabPageControl2
      '
      Me.UltraTabPageControl2.Controls.Add(Me.TxtEnviadoPorBusqueda)
      Me.UltraTabPageControl2.Controls.Add(Me.Label8)
      Me.UltraTabPageControl2.Controls.Add(Me.Label7)
      Me.UltraTabPageControl2.Controls.Add(Me.Label5)
      Me.UltraTabPageControl2.Controls.Add(Me.TxtFechaFinal)
      Me.UltraTabPageControl2.Controls.Add(Me.TxtFechaInicial)
      Me.UltraTabPageControl2.Controls.Add(Me.CmdExportar)
      Me.UltraTabPageControl2.Controls.Add(Me.CmdBuscar)
      Me.UltraTabPageControl2.Controls.Add(Me.GrdHistorial)
      Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
      Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
      Me.UltraTabPageControl2.Size = New System.Drawing.Size(801, 500)
      '
      'TxtEnviadoPorBusqueda
      '
      Me.TxtEnviadoPorBusqueda.BackColor = System.Drawing.Color.LightGray
      Me.TxtEnviadoPorBusqueda.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
      Me.TxtEnviadoPorBusqueda.Location = New System.Drawing.Point(156, 22)
      Me.TxtEnviadoPorBusqueda.MaxLength = 7
      Me.TxtEnviadoPorBusqueda.Name = "TxtEnviadoPorBusqueda"
      Me.TxtEnviadoPorBusqueda.NumberDecimal = 0
      Me.TxtEnviadoPorBusqueda.Size = New System.Drawing.Size(71, 20)
      Me.TxtEnviadoPorBusqueda.TabEnter = True
      Me.TxtEnviadoPorBusqueda.TabIndex = 2
      Me.TxtEnviadoPorBusqueda.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Opcional
      Me.TxtEnviadoPorBusqueda.ValidField = False
      '
      'Label8
      '
      Me.Label8.AutoSize = True
      Me.Label8.Location = New System.Drawing.Point(153, 4)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(65, 13)
      Me.Label8.TabIndex = 10
      Me.Label8.Text = "Enviado Por"
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.Location = New System.Drawing.Point(77, 4)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(62, 13)
      Me.Label7.TabIndex = 10
      Me.Label7.Text = "Fecha Final"
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.Location = New System.Drawing.Point(4, 4)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(67, 13)
      Me.Label5.TabIndex = 10
      Me.Label5.Text = "Fecha Inicial"
      '
      'TxtFechaFinal
      '
      Me.TxtFechaFinal.BackColor = System.Drawing.Color.LightGray
      Me.TxtFechaFinal.Location = New System.Drawing.Point(80, 22)
      Me.TxtFechaFinal.Mask = "00/00/0000"
      Me.TxtFechaFinal.Name = "TxtFechaFinal"
      Me.TxtFechaFinal.Size = New System.Drawing.Size(70, 20)
      Me.TxtFechaFinal.TabEnter = True
      Me.TxtFechaFinal.TabIndex = 1
      Me.TxtFechaFinal.TypeField = UserWindowsControlLibrary.MaskedTextBoxSD.TiposDeCampo.Opcional
      Me.TxtFechaFinal.ValidatingType = GetType(Date)
      '
      'TxtFechaInicial
      '
      Me.TxtFechaInicial.BackColor = System.Drawing.Color.LightGray
      Me.TxtFechaInicial.Location = New System.Drawing.Point(4, 22)
      Me.TxtFechaInicial.Mask = "00/00/0000"
      Me.TxtFechaInicial.Name = "TxtFechaInicial"
      Me.TxtFechaInicial.Size = New System.Drawing.Size(70, 20)
      Me.TxtFechaInicial.TabEnter = True
      Me.TxtFechaInicial.TabIndex = 0
      Me.TxtFechaInicial.TypeField = UserWindowsControlLibrary.MaskedTextBoxSD.TiposDeCampo.Opcional
      Me.TxtFechaInicial.ValidatingType = GetType(Date)
      '
      'CmdExportar
      '
      Me.CmdExportar.Image = Global.MessageSMSSD.My.Resources.Resources.Excel
      Me.CmdExportar.Location = New System.Drawing.Point(758, 3)
      Me.CmdExportar.Name = "CmdExportar"
      Me.CmdExportar.Size = New System.Drawing.Size(40, 40)
      Me.CmdExportar.TabIndex = 4
      Me.CmdExportar.UseVisualStyleBackColor = True
      '
      'CmdBuscar
      '
      Me.CmdBuscar.Image = Global.MessageSMSSD.My.Resources.Resources.Search
      Me.CmdBuscar.Location = New System.Drawing.Point(712, 3)
      Me.CmdBuscar.Name = "CmdBuscar"
      Me.CmdBuscar.Size = New System.Drawing.Size(40, 40)
      Me.CmdBuscar.TabIndex = 3
      Me.CmdBuscar.UseVisualStyleBackColor = True
      '
      'GrdHistorial
      '
      Me.GrdHistorial.AllowUserToAddRows = False
      Me.GrdHistorial.AllowUserToDeleteRows = False
      DataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue
      Me.GrdHistorial.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
      Me.GrdHistorial.BackgroundColor = System.Drawing.Color.White
      Me.GrdHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.GrdHistorial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Correlativo, Me.TelefonoBusqueda, Me.CuerpoMensaje, Me.FechaDeEnvio, Me.EnviadoPor})
      Me.GrdHistorial.Location = New System.Drawing.Point(3, 49)
      Me.GrdHistorial.MultiSelect = False
      Me.GrdHistorial.Name = "GrdHistorial"
      Me.GrdHistorial.ReadOnly = True
      Me.GrdHistorial.RowHeadersWidth = 20
      Me.GrdHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.GrdHistorial.Size = New System.Drawing.Size(795, 448)
      Me.GrdHistorial.TabIndex = 3
      '
      'Correlativo
      '
      Me.Correlativo.DataPropertyName = "IdMensaje"
      Me.Correlativo.HeaderText = "Correlativo"
      Me.Correlativo.Name = "Correlativo"
      Me.Correlativo.ReadOnly = True
      Me.Correlativo.Width = 60
      '
      'TelefonoBusqueda
      '
      Me.TelefonoBusqueda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
      Me.TelefonoBusqueda.DataPropertyName = "Telefono"
      Me.TelefonoBusqueda.HeaderText = "Telefono"
      Me.TelefonoBusqueda.Name = "TelefonoBusqueda"
      Me.TelefonoBusqueda.ReadOnly = True
      '
      'CuerpoMensaje
      '
      Me.CuerpoMensaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
      Me.CuerpoMensaje.DataPropertyName = "CuerpoDeMensaje"
      Me.CuerpoMensaje.HeaderText = "Cuerpo Mensaje"
      Me.CuerpoMensaje.Name = "CuerpoMensaje"
      Me.CuerpoMensaje.ReadOnly = True
      '
      'FechaDeEnvio
      '
      Me.FechaDeEnvio.DataPropertyName = "FechaDeEnvio"
      Me.FechaDeEnvio.HeaderText = "Fecha De Envio"
      Me.FechaDeEnvio.Name = "FechaDeEnvio"
      Me.FechaDeEnvio.ReadOnly = True
      Me.FechaDeEnvio.Width = 130
      '
      'EnviadoPor
      '
      Me.EnviadoPor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
      Me.EnviadoPor.DataPropertyName = "EnviadoPor"
      Me.EnviadoPor.HeaderText = "Enviado Por"
      Me.EnviadoPor.Name = "EnviadoPor"
      Me.EnviadoPor.ReadOnly = True
      '
      'UltraTabControl1
      '
      Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
      Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
      Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
      Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
      Me.UltraTabControl1.Name = "UltraTabControl1"
      Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
      Me.UltraTabControl1.Size = New System.Drawing.Size(908, 502)
      Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
      Me.UltraTabControl1.TabIndex = 0
      Me.UltraTabControl1.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.LeftTop
      UltraTab1.TabPage = Me.UltraTabPageControl1
      UltraTab1.Text = "Envio de SMS"
      UltraTab2.TabPage = Me.UltraTabPageControl2
      UltraTab2.Text = "Historial de Envios"
      Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
      Me.UltraTabControl1.TextOrientation = Infragistics.Win.UltraWinTabs.TextOrientation.Horizontal
      '
      'UltraTabSharedControlsPage1
      '
      Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
      Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
      Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(801, 500)
      '
      'LblValidoHasta
      '
      Me.LblValidoHasta.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.LblValidoHasta.ForeColor = System.Drawing.Color.Blue
      Me.LblValidoHasta.Location = New System.Drawing.Point(3, 21)
      Me.LblValidoHasta.Name = "LblValidoHasta"
      Me.LblValidoHasta.Size = New System.Drawing.Size(259, 19)
      Me.LblValidoHasta.TabIndex = 6
      Me.LblValidoHasta.Text = "-"
      Me.LblValidoHasta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'FrmEnvioSms
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.White
      Me.ClientSize = New System.Drawing.Size(908, 502)
      Me.Controls.Add(Me.UltraTabControl1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.Name = "FrmEnvioSms"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "FrmEnvioSms"
      Me.UltraTabPageControl1.ResumeLayout(False)
      Me.UltraTabPageControl1.PerformLayout()
      Me.Panel4.ResumeLayout(False)
      CType(Me.GrdSeleccionados, System.ComponentModel.ISupportInitialize).EndInit()
      Me.MnuMenu.ResumeLayout(False)
      Me.Panel3.ResumeLayout(False)
      Me.Panel3.PerformLayout()
      CType(Me.GrdPlantillas, System.ComponentModel.ISupportInitialize).EndInit()
      Me.Panel2.ResumeLayout(False)
      Me.Panel2.PerformLayout()
      CType(Me.GrdUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.Panel1.ResumeLayout(False)
      Me.Panel1.PerformLayout()
      CType(Me.GrdGrupos, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UltraTabPageControl2.ResumeLayout(False)
      Me.UltraTabPageControl2.PerformLayout()
      CType(Me.GrdHistorial, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UltraTabControl1.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents GrdGrupos As System.Windows.Forms.DataGridView
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents Panel2 As System.Windows.Forms.Panel
   Friend WithEvents GrdUsuarios As System.Windows.Forms.DataGridView
   Friend WithEvents TxtGrupos As UserWindowsControlLibrary.TextBoxSD
   Friend WithEvents TxtUsuarios As UserWindowsControlLibrary.TextBoxSD
   Friend WithEvents Panel3 As System.Windows.Forms.Panel
   Friend WithEvents TxtPlantillas As UserWindowsControlLibrary.TextBoxSD
   Friend WithEvents GrdPlantillas As System.Windows.Forms.DataGridView
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents GrdSeleccionados As System.Windows.Forms.DataGridView
   Friend WithEvents LblContadorDeCaracteres As System.Windows.Forms.Label
   Friend WithEvents CmdEnviarSms As System.Windows.Forms.Button
   Friend WithEvents TxtMensaje As UserWindowsControlLibrary.TextBoxSD
   Friend WithEvents Grupo As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents NombreGrupo As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents IsGroup As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents NombreUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents IdPlantilla As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents CuerpoDeMensaje As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents MnuMenu As System.Windows.Forms.ContextMenuStrip
   Friend WithEvents MnuBorrar As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents GrupoSeleccionado As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents TelefonoSeleccionado As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents NombreSeleccionado As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents Group As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents TxtNumeroEmpleado As UserWindowsControlLibrary.TextBoxSD
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents TxtNombre As UserWindowsControlLibrary.TextBoxSD
   Friend WithEvents GrdHistorial As System.Windows.Forms.DataGridView
   Friend WithEvents CmdExportar As System.Windows.Forms.Button
   Friend WithEvents CmdBuscar As System.Windows.Forms.Button
   Friend WithEvents TxtEnviadoPorBusqueda As UserWindowsControlLibrary.TextBoxSD
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents TxtFechaFinal As UserWindowsControlLibrary.MaskedTextBoxSD
   Friend WithEvents TxtFechaInicial As UserWindowsControlLibrary.MaskedTextBoxSD
   Friend WithEvents Correlativo As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents TelefonoBusqueda As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents CuerpoMensaje As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents FechaDeEnvio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EnviadoPor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Private WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Private WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Private WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
   Friend WithEvents lblDisponibles As System.Windows.Forms.Label
   Friend WithEvents LblValidoHasta As System.Windows.Forms.Label
End Class
