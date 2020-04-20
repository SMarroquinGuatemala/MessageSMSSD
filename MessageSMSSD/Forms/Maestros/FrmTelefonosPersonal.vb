Public Class FrmTelefonosPersonal
   Private Modo As ModosDeTecleo = ModosDeTecleo.Grabar
   Private db As New MessageSmsSdBLL.ClsTelefonosPersonal

   Private Sub FrmTelefonosPersonal_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
      If e.KeyCode = Keys.Escape Then Close()
   End Sub

   Private Sub FrmTelefonosPersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Icon = My.Resources.Icon
   End Sub

   Private Sub CmdGrabar_Click(sender As Object, e As EventArgs) Handles CmdGrabar.Click
      Try
         If RequieredFields(Panel1) Then
                db.GrabarModificar(TxtTelefono.Text, TxtNumeroEmpleado.Text, TxtNombre.Text, TxtObservaciones.Text, ChkActivo.CheckState)
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
        ChkActivo.Checked = True
        Modo = ModosDeTecleo.Grabar : CmdGrabar.Image = My.Resources.Save : TxtTelefono.Focus()
        TxtTelefono.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Obligatorio
    End Sub

    Private Sub CmdBuscar_Click(sender As Object, e As EventArgs) Handles CmdBuscar.Click
        Try
            Cursor = Cursors.WaitCursor
            GrdDatos.DataSource = db.Buscar(TxtTelefono.Text, TxtNumeroEmpleado.Text, TxtNombre.Text)
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
                TxtTelefono.Text = GrdDatos.SelectedRows.Item(0).Cells("Telefono").Value.ToString
                TxtTelefono.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Desplieque
                TxtNumeroEmpleado.Text = GrdDatos.SelectedRows.Item(0).Cells("NumeroDeEmpleado").Value.ToString
                TxtNombre.Text = GrdDatos.SelectedRows.Item(0).Cells("Nombre").Value.ToString
                TxtObservaciones.Text = GrdDatos.SelectedRows.Item(0).Cells("Observaciones").Value.ToString
                ChkActivo.Checked = GrdDatos.SelectedRows.Item(0).Cells("Activo").Value
                Modo = ModosDeTecleo.Modificar : CmdGrabar.Image = My.Resources.Update
            End If
        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub

    Private Sub MnuBorrar_Click(sender As Object, e As EventArgs) Handles MnuBorrar.Click
        If MsgBox("Desea eliminar el No de telefono: " & GrdDatos.SelectedRows.Item(0).Cells("Telefono").Value.ToString,
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Mensaje Del Sistema") = MsgBoxResult.Yes Then
            If db.Eliminar(GrdDatos.SelectedRows.Item(0).Cells("Telefono").Value.ToString) Then
                MsgBox("Registro eliminado correctamente....", MsgBoxStyle.Information, "Mensaje Del Sistema")
                CmdBuscar_Click(sender, e)
            Else
                MsgBox("El telefono: " & GrdDatos.SelectedRows.Item(0).Cells("Telefono").Value.ToString & _
                       " pertenece a un grupo o tiene historial de envios....", MsgBoxStyle.Information, "Mensaje Del Sistema")
            End If
        End If
    End Sub

   Private Sub TxtNumeroEmpleado_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtNumeroEmpleado.Validating
      Try
         If Not String.IsNullOrEmpty(TxtNumeroEmpleado.Text) Then
            FindItem("Empleados", TxtNumeroEmpleado.Text)
            If RowFound IsNot Nothing Then
               TxtNumeroEmpleado.Text = RowFound.Item(0)
               TxtNombre.Text = RowFound.Item(1) & " " & RowFound.Item(2)
            End If
         End If
      Catch ex As Exception
         F_Error(ex)
      End Try
   End Sub

    Private Sub TxtTelefono_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtTelefono.Validating
        If Not Trim(TxtTelefono.Text) = "" AndAlso Len(TxtTelefono.Text) <> 8 Then
            MsgBox("Numero Invalido")
            e.Cancel = True
        End If
    End Sub
End Class