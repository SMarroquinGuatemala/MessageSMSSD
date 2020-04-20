Public Class FrmPlantillas
   Private Modo As ModosDeTecleo = ModosDeTecleo.Grabar
   Private db As New MessageSmsSdBLL.ClsPlantillas

   Private Sub FrmPlantillas_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
      If e.KeyCode = Keys.Escape Then Close()
   End Sub

   Private Sub FrmPlantillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Icon = My.Resources.Icon
   End Sub

   Private Sub CmdGrabar_Click(sender As Object, e As EventArgs) Handles CmdGrabar.Click
      Try
         If RequieredFields(Panel1) Then
            db.GrabarModificar(TxtCodigo.Text, TxtCuerpoDelMensaje.Text)
            If Modo = ModosDeTecleo.Grabar Then
               MsgBox("Registro grabado correctamente....", MsgBoxStyle.Information, "Mensaje Del Sistema")
            Else
               MsgBox("Registro Modificado correctamente....", MsgBoxStyle.Information, "Mensaje Del Sistema")
            End If
            CmdBuscar_Click(sender, e)
            CmdCancelar_Click(sender, e)
         End If
      Catch ex As Exception
         F_Error(ex)
      End Try
   End Sub

   Private Sub CmdCancelar_Click(sender As Object, e As EventArgs) Handles CmdCancelar.Click
      limpiarControles(Panel1)
      Modo = ModosDeTecleo.Grabar : CmdGrabar.Image = My.Resources.Save : TxtCuerpoDelMensaje.Focus()
   End Sub

   Private Sub CmdBuscar_Click(sender As Object, e As EventArgs) Handles CmdBuscar.Click
      Try
         Cursor = Cursors.WaitCursor
         GrdDatos.DataSource = db.Buscar(TxtCodigo.Text, TxtCuerpoDelMensaje.Text)
      Catch ex As Exception
         F_Error(ex)
      Finally
         Cursor = Cursors.Default
      End Try
   End Sub

   Private Sub CmdExportar_Click(sender As Object, e As EventArgs) Handles CmdExportar.Click
      Try
         Cursor = Cursors.WaitCursor
         ExportGrd(GrdDatos)
      Catch ex As Exception
         F_Error(ex)
      Finally
         Cursor = Cursors.Default
      End Try
   End Sub

   Private Sub GrdDatos_MouseDown(sender As Object, e As MouseEventArgs) Handles GrdDatos.MouseDown
      DeshabilitaMenuContextual(MnuMenu)
      If e.Button = Windows.Forms.MouseButtons.Right AndAlso GrdDatos.SelectedRows.Count = 1 Then
         MnuBorrar.Enabled = True
      End If
   End Sub

   Private Sub GrdDatos_KeyDown(sender As Object, e As KeyEventArgs) Handles GrdDatos.KeyDown
      If GrdDatos.SelectedRows.Count = 1 AndAlso e.KeyCode = Keys.Delete Then
         MnuBorrar_Click(sender, (New System.EventArgs))
      End If
   End Sub

   Private Sub GrdDatos_DoubleClick(sender As Object, e As EventArgs) Handles GrdDatos.DoubleClick
      Try
         If GrdDatos.SelectedRows.Count = 1 Then
            TxtCodigo.Text = GrdDatos.SelectedRows.Item(0).Cells("Codigo").Value.ToString
            TxtCuerpoDelMensaje.Text = GrdDatos.SelectedRows.Item(0).Cells("Nombre").Value.ToString
            Modo = ModosDeTecleo.Modificar : CmdGrabar.Image = My.Resources.Update
         End If
      Catch ex As Exception
         F_Error(ex)
      End Try
   End Sub

   Private Sub MnuBorrar_Click(sender As Object, e As EventArgs) Handles MnuBorrar.Click
      If MsgBox("Desea eliminar la plantilla: " & GrdDatos.SelectedRows.Item(0).Cells("Codigo").Value.ToString, MsgBoxStyle.Question + MsgBoxStyle.YesNo,
                 "Mensaje Del Sistema") = MsgBoxResult.Yes Then
         If db.Eliminar(GrdDatos.SelectedRows.Item(0).Cells("Codigo").Value.ToString) Then
            MsgBox("Registro eliminado correctamente....", MsgBoxStyle.Information, "Mensaje Del Sistema")
            CmdBuscar_Click(sender, e)
         End If
      End If
   End Sub


End Class