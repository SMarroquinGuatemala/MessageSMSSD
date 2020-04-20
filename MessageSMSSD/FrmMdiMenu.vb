Public Class FrmMdiMenu

   Private Sub FrmMdiMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

  

            Icon = My.Resources.Icon
            Login()
            txtServer.Text = Servidor
            txtComputer.Text = Computadora
            txtUserName.Text = Usuario.ToUpper
            txtApplication.Text = AppName
            lblVersion.Text = System.String.Format(lblVersion.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
            If Not My.Settings.TipoUsuario = "Des@rrollo" Then
                If AutoUpdate() Then
                    Dispose()
                    Application.Exit()
                End If
            End If
            Dim frm As New FrmEnvioSms
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("Cargando aplicacion: " & ex.Message, MsgBoxStyle.Information, "Mensaje Del Sistema")
        End Try
   End Sub

   Private Sub TmrEstado_Tick(sender As System.Object, e As System.EventArgs) Handles TmrEstado.Tick
      If My.Computer.Keyboard.NumLock Then
         LblNumLock.Enabled = True
      Else
         LblNumLock.Enabled = False
      End If
      If My.Computer.Keyboard.CapsLock Then
         LblCapsLock.Enabled = True
      Else
         LblCapsLock.Enabled = False
      End If
   End Sub

   Private Sub MnuMenuPrincipal_ToolClick(sender As Object, e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles MnuMenuPrincipal.ToolClick
      Try
         Select Case e.Tool.Key
            Case "MnuGruposDeEnvio"
               Dim frm As New FrmGruposDeEnvio
               frm.ShowDialog()
            Case "MnuTelefonosPersonal"
               Dim frm As New FrmTelefonosPersonal
               frm.ShowDialog()
            Case "MnuPlantillasSms"
               Dim frm As New FrmPlantillas
               frm.ShowDialog()
            Case "MnuTelefonosGrupo"
               Dim frm As New FrmTelefonoPorGrupo
               frm.ShowDialog()
            Case "MnuNuevoMensaje"
               Dim frm As New FrmEnvioSms
               'frm.MdiParent = Me
               frm.ShowDialog()
               'frm.WindowState = FormWindowState.Maximized
         End Select
      Catch ex As Exception
         F_Error(ex)
      End Try
   End Sub

    Private Sub _FrmTipoMantto_Toolbars_Dock_Area_Top_Click(sender As Object, e As EventArgs) Handles _FrmTipoMantto_Toolbars_Dock_Area_Top.Click

    End Sub
End Class
