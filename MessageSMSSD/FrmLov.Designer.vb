<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLov
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
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
      Me.GroupBox1 = New System.Windows.Forms.GroupBox()
      Me.TxtFiltro = New UserWindowsControlLibrary.TextBoxSD()
      Me.GrdConsulta = New System.Windows.Forms.DataGridView()
      Me.TableLayoutPanel1.SuspendLayout()
      Me.GroupBox1.SuspendLayout()
      CType(Me.GrdConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
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
      Me.TableLayoutPanel1.Controls.Add(Me.GrdConsulta, 0, 1)
      Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
      Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
      Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
      Me.TableLayoutPanel1.RowCount = 2
      Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
      Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
      Me.TableLayoutPanel1.Size = New System.Drawing.Size(302, 476)
      Me.TableLayoutPanel1.TabIndex = 0
      '
      'GroupBox1
      '
      Me.GroupBox1.Controls.Add(Me.TxtFiltro)
      Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(294, 44)
      Me.GroupBox1.TabIndex = 0
      Me.GroupBox1.TabStop = False
      Me.GroupBox1.Text = "Buscar"
      '
      'TxtFiltro
      '
      Me.TxtFiltro.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
      Me.TxtFiltro.Location = New System.Drawing.Point(6, 19)
      Me.TxtFiltro.Name = "TxtFiltro"
      Me.TxtFiltro.NumberDecimal = 0
      Me.TxtFiltro.Size = New System.Drawing.Size(259, 20)
      Me.TxtFiltro.TabEnter = True
      Me.TxtFiltro.TabIndex = 0
      Me.TxtFiltro.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Personalizado
      Me.TxtFiltro.ValidField = False
      '
      'GrdConsulta
      '
      Me.GrdConsulta.AllowUserToAddRows = False
      Me.GrdConsulta.AllowUserToDeleteRows = False
      DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
      Me.GrdConsulta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
      Me.GrdConsulta.BackgroundColor = System.Drawing.Color.White
      Me.GrdConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.GrdConsulta.Dock = System.Windows.Forms.DockStyle.Fill
      Me.GrdConsulta.Location = New System.Drawing.Point(4, 55)
      Me.GrdConsulta.MultiSelect = False
      Me.GrdConsulta.Name = "GrdConsulta"
      Me.GrdConsulta.ReadOnly = True
      Me.GrdConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.GrdConsulta.Size = New System.Drawing.Size(294, 417)
      Me.GrdConsulta.TabIndex = 1
      '
      'FrmLov
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.White
      Me.ClientSize = New System.Drawing.Size(309, 482)
      Me.Controls.Add(Me.TableLayoutPanel1)
      Me.Name = "FrmLov"
      Me.Text = "FrmLov"
      Me.TableLayoutPanel1.ResumeLayout(False)
      Me.GroupBox1.ResumeLayout(False)
      Me.GroupBox1.PerformLayout()
      CType(Me.GrdConsulta, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
   Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Friend WithEvents TxtFiltro As UserWindowsControlLibrary.TextBoxSD
   Friend WithEvents GrdConsulta As System.Windows.Forms.DataGridView
End Class
