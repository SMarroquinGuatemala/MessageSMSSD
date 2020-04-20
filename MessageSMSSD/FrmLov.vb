﻿Public Class FrmLov
   Private _vwFiltro As New DataView

   Public Property vwFiltro As DataView
      Get
         Return _vwFiltro
      End Get
      Set(ByVal value As DataView)
         _vwFiltro = value
      End Set
   End Property

   Public Property Filter As String
      Get
         Return txtFiltro.Text
      End Get
      Set(ByVal value As String)
         txtFiltro.Text = value
      End Set
   End Property

   Private Sub FrmLov_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Try
         Dim ancho As Integer
         If Not (vwFiltro) Is Nothing Then
            grdConsulta.DataSource = vwFiltro
            For i As Integer = 0 To grdConsulta.Columns.Count - 1
               grdConsulta.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            Next
            For x As Integer = 0 To grdConsulta.Columns.Count - 1
               ancho = ancho + grdConsulta.Columns(x).Width
            Next
            If ancho < 500 Then
               Me.Width = 500
            Else
               Me.Width = ancho + 92
            End If
            Left = (Screen.PrimaryScreen.WorkingArea.Width - Width) / 2
            Top = (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2
         End If
      Catch ex As Exception
         F_Error(ex)
      End Try
   End Sub

   Private Sub txtFiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFiltro.TextChanged
      Try
         Dim RowFilter As String = String.Empty, AddOr As Boolean = False
         If Len(TxtFiltro.Text) > 1 And Not vwFiltro.Table Is Nothing Then
            'Armamos un filtro para cualquier columna de la tabla
            For i As Integer = 0 To vwFiltro.Table.Columns.Count - 1
               AddOr = False
               ' RowFilter &= xTable.Columns(i).ColumnName & "=" & Send(FindString)
               If vwFiltro.Table.Columns(i).DataType.ToString <> "System.Boolean" Then
                  If InStr(vwFiltro.Table.Columns(i).DataType.ToString, "Int") > 0 And IsNumeric(If(String.IsNullOrEmpty(TxtFiltro.Text), TxtFiltro.Text, "0")) Then
                     RowFilter &= vwFiltro.Table.Columns(i).ColumnName & "='" & TxtFiltro.Text & "'"
                     AddOr = True
                  ElseIf InStr(vwFiltro.Table.Columns(i).DataType.ToString, "String") > 0 Then
                     RowFilter &= vwFiltro.Table.Columns(i).ColumnName & " like '%" & TxtFiltro.Text & "%'"
                     AddOr = True
                  End If
                  If (i <> vwFiltro.Table.Columns.Count - 1 And Not String.IsNullOrEmpty(RowFilter)) And AddOr Then RowFilter &= " or "
               End If
            Next i
         Else
            RowFilter = ""
         End If
         If Not String.IsNullOrEmpty(RowFilter) Then
            If Trim(Mid(RowFilter, Len(RowFilter) - 3)) = "or" Then RowFilter = Mid(RowFilter, 1, Len(RowFilter) - 3)
         End If
         vwFiltro.RowFilter = RowFilter
         grdConsulta.Refresh()
      Catch ex As Exception
         F_Error(ex)
      End Try
   End Sub

   Private Sub grdConsulta_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdConsulta.CellDoubleClick
      SeleccionarRow()
   End Sub

   Sub SeleccionarRow()
      Try
         If grdConsulta.SelectedRows.Count > 0 Then
            RowFound = vwFiltro(grdConsulta.SelectedRows(0).Index).Row
         Else
            RowFound = Nothing
         End If
         Me.Dispose()
         Me.Close()
      Catch ex As Exception
         F_Error(ex)
      End Try
   End Sub

   Private Sub grdConsulta_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdConsulta.KeyUp
      If e.KeyCode = Keys.Enter Then SeleccionarRow()
   End Sub

End Class