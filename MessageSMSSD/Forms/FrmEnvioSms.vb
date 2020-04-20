Public Class FrmEnvioSms
#Region "Declaracion DataView´s"
    Private DwGrupos As DataView
    Private DwUsuarios As DataView
    Private DwPlantillas As DataView
#End Region

#Region "Declaracion DataTable´s"
    Private DtUsuarios As DataTable

#End Region

    Private dbGrupos As New MessageSmsSdBLL.ClsGruposDeEnvio
    Private dbUsuarios As New MessageSmsSdBLL.ClsTelefonosPersonal
    Private dbPlantillas As New MessageSmsSdBLL.ClsPlantillas
    Private dbFunciones As New MessageSmsSdBLL.ClsFunciones
    Private dbTelefonos As New MessageSmsSdBLL.ClsTelefonosPorGrupo
    Private dbHistorialEnvios As New MessageSmsSdBLL.ClsHistorialDeEnvios
    Private MessagesSDSMS As New clsMensajes

    Private Sub FrmEnvioSms_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Close()
    End Sub

    Private Sub FrmEnvioSms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
         Icon = My.Resources.Icon
         Fill_Grids()
         TxtNumeroEmpleado.Text = NumeroDeEmpleado
         TxtNumeroEmpleado_Validating(sender, New System.ComponentModel.CancelEventArgs)
         lblDisponibles.Text = "Disponibles: " & Format(dbHistorialEnvios.GetDisponibles, "###,###")
         LblValidoHasta.Text = "Validos Hasta: " & dbHistorialEnvios.GetSMSValidosHasta()
        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub

    Private Sub Fill_Grids()
        Try
            DwGrupos = New DataView(dbGrupos.Buscar("", "", True))
            GrdGrupos.DataSource = DwGrupos
            DtUsuarios = dbUsuarios.Buscar("", "", "", True)
            DtUsuarios.Columns.RemoveAt(3) : DtUsuarios.Columns.RemoveAt(1) : DtUsuarios.Columns.RemoveAt(2)
            DwUsuarios = New DataView(DtUsuarios)
            GrdUsuarios.DataSource = DwUsuarios
            DwPlantillas = New DataView(dbPlantillas.Buscar("", ""))
            GrdPlantillas.DataSource = DwPlantillas
        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub

    Private Sub BuscarGrids(ByRef Grid As DataGridView, ByVal TxtFiltro As UserWindowsControlLibrary.TextBoxSD, ByRef VwFiltro As DataView)
        Try
            Dim RowFilter As String = String.Empty, AddOr As Boolean = False
            If Len(TxtFiltro.Text) > 1 And Not VwFiltro.Table Is Nothing Then
                'Armamos un filtro para cua lquier columna de la tabla
                For i As Integer = 0 To VwFiltro.Table.Columns.Count - 1
                    AddOr = False
                    ' RowFilter &= xTable.Columns(i).ColumnName & "=" & Send(FindString)
                    If VwFiltro.Table.Columns(i).DataType.ToString <> "System.Boolean" Then
                        If InStr(VwFiltro.Table.Columns(i).DataType.ToString, "Int") > 0 And IsNumeric(TxtFiltro.Text) Then
                            RowFilter &= VwFiltro.Table.Columns(i).ColumnName & "='" & TxtFiltro.Text & "'"
                            AddOr = True
                        ElseIf InStr(VwFiltro.Table.Columns(i).DataType.ToString, "String") > 0 Then
                            RowFilter &= VwFiltro.Table.Columns(i).ColumnName & " like '%" & TxtFiltro.Text & "%'"
                            AddOr = True
                        End If
                        If (i <> VwFiltro.Table.Columns.Count - 1 And Not String.IsNullOrEmpty(RowFilter)) And AddOr Then RowFilter &= " or "
                    End If
                Next i
            Else
                RowFilter = ""
            End If
            If Not String.IsNullOrEmpty(RowFilter) Then
                If Trim(Mid(RowFilter, Len(RowFilter) - 3)) = "or" Then RowFilter = Mid(RowFilter, 1, Len(RowFilter) - 3)
            End If
            VwFiltro.RowFilter = RowFilter
            Grid.Refresh()
        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub

    Private Sub TxtGrupos_TextChanged(sender As Object, e As EventArgs) Handles TxtGrupos.TextChanged
        Try
            BuscarGrids(GrdGrupos, TxtGrupos, DwGrupos)
        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub

    Private Sub TxtUsuarios_TextChanged(sender As Object, e As EventArgs) Handles TxtUsuarios.TextChanged
        Try
            BuscarGrids(GrdUsuarios, TxtUsuarios, DwUsuarios)
        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub

    Private Sub TxtPlantillas_TextChanged(sender As Object, e As EventArgs) Handles TxtPlantillas.TextChanged
        Try
            BuscarGrids(GrdPlantillas, TxtPlantillas, DwPlantillas)
        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub

    Private Sub TxtMensaje_TextChanged(sender As Object, e As EventArgs) Handles TxtMensaje.TextChanged
        Try
            If Not String.IsNullOrEmpty(TxtMensaje.Text) Then
                LblContadorDeCaracteres.Text = "Caracteres restantes: " & TxtMensaje.MaxLength - TxtMensaje.Text.Length
                If (TxtMensaje.MaxLength - TxtMensaje.Text.Length) = 0 Then
                    LblContadorDeCaracteres.ForeColor = Color.Red
                Else
                    LblContadorDeCaracteres.ForeColor = Color.FromArgb(0, 102, 204)
                End If
            Else
                LblContadorDeCaracteres.Text = "Caracteres restantes: 148"
                LblContadorDeCaracteres.ForeColor = Color.FromArgb(0, 102, 204)
            End If
        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub

    Private Sub GrdGrupos_DoubleClick(sender As Object, e As EventArgs) Handles GrdGrupos.DoubleClick
        Try
            If GrdGrupos.SelectedRows.Count = 1 Then
                If Not GrdSeleccionados.Rows.Cast(Of DataGridViewRow).Any(Function(x) _
                   CStr(x.Cells("NombreSeleccionado").Value.ToString.Trim).Equals(GrdGrupos.SelectedRows.Item(0).Cells("NombreGrupo").Value.ToString)) Then
                    GrdSeleccionados.Rows.Add(GrdGrupos.SelectedRows.Item(0).Cells("Grupo").Value.ToString, "",
                                              GrdGrupos.SelectedRows.Item(0).Cells("NombreGrupo").Value.ToString,
                                              GrdGrupos.SelectedRows.Item(0).Cells("IsGroup").Value.ToString)
                Else
                    MsgBox("El grupo: " & GrdGrupos.SelectedRows.Item(0).Cells("NombreGrupo").Value.ToString & " ya se encuentra seleccionado....",
                           MsgBoxStyle.Information, "Mensaje Del Sistema")
                End If
            End If
        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub

    Private Sub GrdUsuarios_DoubleClick(sender As Object, e As EventArgs) Handles GrdUsuarios.DoubleClick
        Try
            If GrdUsuarios.SelectedRows.Count = 1 Then
                If Not GrdSeleccionados.Rows.Cast(Of DataGridViewRow).Any(Function(x) _
                   CStr(x.Cells("TelefonoSeleccionado").Value.ToString.Trim).Equals(GrdUsuarios.SelectedRows.Item(0).Cells("Telefono").Value.ToString)) Then
                    GrdSeleccionados.Rows.Add("", GrdUsuarios.SelectedRows.Item(0).Cells("Telefono").Value.ToString,
                                              GrdUsuarios.SelectedRows.Item(0).Cells("NombreUsuario").Value.ToString,
                                              "")
                Else
                    MsgBox("El Telefono de: " & GrdUsuarios.SelectedRows.Item(0).Cells("NombreUsuario").Value.ToString & " ya se encuentra seleccionado....",
                           MsgBoxStyle.Information, "Mensaje Del Sistema")
                End If
            End If
        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub

    Private Sub GrdSeleccionados_MouseDown(sender As Object, e As MouseEventArgs) Handles GrdSeleccionados.MouseDown
        Try
            DeshabilitaMenuContextual(MnuMenu)
            If e.Button = Windows.Forms.MouseButtons.Right AndAlso GrdSeleccionados.SelectedRows.Count = 1 Then
                MnuBorrar.Enabled = True
            End If
        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub

    Private Sub GrdSeleccionados_KeyDown(sender As Object, e As KeyEventArgs) Handles GrdSeleccionados.KeyDown
        If e.KeyCode = Keys.Delete AndAlso GrdSeleccionados.SelectedRows.Count = 1 Then Borrar()
    End Sub

    Private Sub MnuBorrar_Click(sender As Object, e As EventArgs) Handles MnuBorrar.Click
        Borrar()
    End Sub

    Private Sub Borrar()
        Try
            Dim Mensaje As String = "Desea eliminar el telefono de: "
            If GrdSeleccionados.SelectedRows.Item(0).Cells("Group").Value.ToString = "1" Then Mensaje = "Desea eliminar el grupo: "
            If MsgBox(Mensaje & GrdSeleccionados.SelectedRows.Item(0).Cells("NombreSeleccionado").Value.ToString,
                      MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Mensaje Del Sistema") = MsgBoxResult.Yes Then
                GrdSeleccionados.Rows.RemoveAt(GrdSeleccionados.SelectedRows.Item(0).Cells(0).RowIndex)
            End If
        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub

    Private Sub GrdPlantillas_DoubleClick(sender As Object, e As EventArgs) Handles GrdPlantillas.DoubleClick
        Try
            If GrdPlantillas.SelectedRows.Count = 1 Then
                If (TxtMensaje.MaxLength - TxtMensaje.Text.Length) < GrdPlantillas.SelectedRows.Item(0).Cells("CuerpoDeMensaje").Value.ToString.Length Then
                    MsgBox("El espacio disponible en el mensaje no es suficiente para la plantilla seleccionada....", MsgBoxStyle.Information, "Mensaje Del Sistema")
                Else
                    TxtMensaje.Text &= GrdPlantillas.SelectedRows.Item(0).Cells("CuerpoDeMensaje").Value.ToString
                End If
            End If
        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub

    Private Sub TxtNumeroEmpleado_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtNumeroEmpleado.Validating
        Try
            If Not String.IsNullOrEmpty(TxtNumeroEmpleado.Text) Then
                xTableDefault = dbFunciones.GetEmpleados(TxtNumeroEmpleado.Text)
                If xTableDefault IsNot Nothing AndAlso xTableDefault.Rows.Count > 0 Then
                    TxtNombre.Text = xTableDefault.Rows(0).Item(1).ToString
                Else
                    MsgBox("El número de empleado ingresado es invalido ó no se encuentra activo, Verique....", MsgBoxStyle.Information, "Mensaje Del Sistema")
                    e.Cancel = True : TxtNombre.Clear()
                End If
            End If
        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub

    Private Sub CmdEnviarSms_Click(sender As Object, e As EventArgs) Handles CmdEnviarSms.Click
        Try

            Dim DtTelefonos As New DataTable, RowPhones As DataRow
            DtTelefonos.Columns.Add("Telefono", GetType(String))
            If Not RequieredFields(TxtMensaje) Then Return
            If Not RequieredFields(TxtNumeroEmpleado) Then Return
            If MsgBox("¿Desea enviar el mensaje a los destinatarios seleccionados?", vbYesNo, "MensajeDeSistema") = vbNo Then
                Exit Sub
            End If
            Me.Cursor = Cursors.WaitCursor

            If GrdSeleccionados.RowCount = 0 Then MsgBox("No hay registros seleccionados para enviar el Mensaje....", MsgBoxStyle.Information, "Mensaje Del Sistema") : Return
            For Each row As DataGridViewRow In GrdSeleccionados.Rows
                If row.Cells("Group").Value.ToString = "1" Then
                    xTableDefault = dbTelefonos.Buscar(row.Cells("GrupoSeleccionado").Value.ToString).Tables(0)
                    For Each RowTelefono As DataRow In xTableDefault.Rows
                        If Not DtTelefonos.Select("Telefono = " & RowTelefono.Item("Telefono").ToString).Length > 0 Then
                            RowPhones = DtTelefonos.NewRow
                            RowPhones.Item(0) = RowTelefono.Item("Telefono").ToString
                            DtTelefonos.Rows.Add(RowPhones)
                        End If
                    Next
                Else
                    If Not DtTelefonos.Select("Telefono = " & row.Cells("TelefonoSeleccionado").Value.ToString).Length > 0 Then
                        RowPhones = DtTelefonos.NewRow
                        RowPhones.Item(0) = row.Cells("TelefonoSeleccionado").Value.ToString
                        DtTelefonos.Rows.Add(RowPhones)
                    End If
                End If
            Next
            For Each rowNumbers As DataRow In DtTelefonos.Rows
                'TODO: Codigo Para enviar los Mensajes de texto aqui.
                Dim sendsms As New wsSMSMasivosAPI.SMSMasivosAPISoapClient
            If (sendsms.EnviarSMS("SANDIEGO", My.Settings.PasswordSMS, rowNumbers.Item("Telefono").ToString, TxtMensaje.Text, False)) = "OK" Then
               dbHistorialEnvios.InsertarHistoria(rowNumbers.Item("Telefono").ToString, TxtMensaje.Text, TxtNumeroEmpleado.Text)
            Else
               MsgBox("Problema al enviar el mensaje a: " & rowNumbers.Item("Telefono").ToString & ". No se envió.", vbInformation, "Mensaje De Sistema")
            End If

                'If dbFunciones.ExtraeCampoJSON(MessagesSDSMS.SendSMS(rowNumbers.Item("Telefono").ToString, TxtMensaje.Text, , "CMyCI TR"), "ReturnCode") = "25" Then
                '    dbHistorialEnvios.InsertarHistoria(rowNumbers.Item("Telefono").ToString, TxtMensaje.Text, TxtNumeroEmpleado.Text)
                'Else
                '    MsgBox("Problema al enviar el mensaje a: " & rowNumbers.Item("Telefono").ToString & ". No se envió.", vbInformation, "Mensaje De Sistema")
                'End If
            Next
            GrdSeleccionados.Rows.Clear()
            TxtMensaje.Clear() : TxtMensaje.Focus()
            MsgBox("Mensajes enviados....", MsgBoxStyle.Information, "Mensaje Del Sistema")
            lblDisponibles.Text = "Disponibles: " & Format(dbHistorialEnvios.GetDisponibles, "###,###")
        Catch ex As Exception
            F_Error(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CmdBuscar_Click(sender As Object, e As EventArgs) Handles CmdBuscar.Click
        Try
            GrdHistorial.DataSource = dbHistorialEnvios.Buscar(TxtFechaInicial.ToString, TxtFechaFinal.ToString, TxtEnviadoPorBusqueda.Text)
        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub

    Private Sub CmdExportar_Click(sender As Object, e As EventArgs) Handles CmdExportar.Click
        Try
            Cursor = Cursors.WaitCursor
            ExportGrd(GrdHistorial)
        Catch ex As Exception
            F_Error(ex)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub


End Class