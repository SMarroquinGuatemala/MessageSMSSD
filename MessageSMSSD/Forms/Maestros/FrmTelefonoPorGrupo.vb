Public Class FrmTelefonoPorGrupo
   Private db As New MessageSmsSdBLL.ClsTelefonosPorGrupo

   Private Sub FrmTelefonoPorGrupo_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
      If e.KeyCode = Keys.Escape Then Close()
   End Sub

   Private Sub FrmTelefonoPorGrupo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Try
         Icon = My.Resources.Icon
         CboGrupos.Fill()
      Catch ex As Exception
         F_Error(ex)
      End Try
   End Sub

   Private Sub CmdBuscar_Click(sender As Object, e As EventArgs) Handles CmdBuscar.Click
      Try
         If RequieredFields(UltraGroupBox2) Then
            Dim ds As DataSet
            ds = db.Buscar(CboGrupos.SelectedValue)
            GrdAsignados.DataSource = ds.Tables(0)
            GrdContactos.DataSource = ds.Tables(1)
         End If
      Catch ex As Exception
         F_Error(ex)
      End Try
   End Sub

   Private Sub PicAdd_Click(sender As Object, e As EventArgs) Handles PicAdd.Click
      Try
         If RequieredFields(UltraGroupBox2) Then
            If GrdContactos.SelectedRows.Count > 0 Then
               For Each row As DataGridViewRow In GrdContactos.SelectedRows
                  db.Grabar(CboGrupos.SelectedValue, row.Cells("Telefono").Value.ToString)
               Next
               CmdBuscar_Click(sender, e)
            Else
               MsgBox("No hay registros seleccionados....", MsgBoxStyle.Information, "Mensaje Del Sistema")
            End If
         End If
      Catch ex As Exception
         F_Error(ex)
      End Try
   End Sub

   Private Sub PicRemove_Click(sender As Object, e As EventArgs) Handles PicRemove.Click
      Try
         If RequieredFields(UltraGroupBox2) Then
            If GrdAsignados.SelectedRows.Count > 0 Then
               For Each row As DataGridViewRow In GrdAsignados.SelectedRows
                  db.Eliminar(CboGrupos.SelectedValue, row.Cells("TelefonoAsignado").Value.ToString)
               Next
               CmdBuscar_Click(sender, e)
            Else
               MsgBox("No hay registros seleccionados....", MsgBoxStyle.Information, "Mensaje Del Sistema")
            End If
         End If
      Catch ex As Exception
         F_Error(ex)
      End Try
   End Sub

   Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PicAdd.MouseLeave, PicRemove.MouseLeave
      Try
         If CType(sender, PictureBox).Name = "PicAdd" Then
            sender.Image = My.Resources.ArrowLeftBlack
         Else
            sender.Image = My.Resources.ArrowRightBlack
         End If
         CType(sender, PictureBox).BackColor = Color.Transparent
      Catch ex As Exception
         F_Error(ex)
      End Try
   End Sub

   Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PicAdd.MouseEnter, PicRemove.MouseEnter
      Try
         If CType(sender, PictureBox).Name = "PicAdd" Then
            sender.Image = My.Resources.ArrowLeftWhite
         Else
            sender.Image = My.Resources.ArrowRightWhite
         End If
         CType(sender, PictureBox).BackColor = Color.Gray
      Catch ex As Exception
         F_Error(ex)
      End Try
   End Sub

   Private Sub CboGrupos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboGrupos.SelectedIndexChanged
      If Not String.IsNullOrEmpty(CboGrupos.SelectedValue) Then
         CmdBuscar_Click(sender, e)
      End If
   End Sub
End Class