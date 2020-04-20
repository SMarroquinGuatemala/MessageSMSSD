Imports System.Net
Imports System.IO
Imports System.Configuration
'Imports Microsoft.Office.Interop

Public Module ModSanDiego
   Public Usuario As String
   Public Computadora As String
   Public Servidor As String
   Public AppName As String
   Public Version As String
   Public RowFound As DataRow
   Public xTableDefault As DataTable
   Public xRowDefault As DataRow
   Private Accesos As New MessageSmsSdBLL.ClsFunciones
   Public NumeroDeEmpleado As String = String.Empty
   Public Remotepath As String = "\\..\Sistema_SanDiego_Update\SMSSanDiego\"
   Public ReadOnly startup As String = Application.StartupPath

   Public Function AutoUpdate() As Boolean
      Dim Ip As String = String.Empty

      For i As Integer = 0 To Dns.GetHostEntry(Dns.GetHostName()).AddressList.Count - 1
         If InStr(Dns.GetHostEntry(Dns.GetHostName()).AddressList.GetValue(i).ToString, ".") > 0 Then
            If Split(Dns.GetHostEntry(Dns.GetHostName()).AddressList.GetValue(i).ToString, ".").Length > 3 Then
               Ip = Split(Dns.GetHostEntry(Dns.GetHostName()).AddressList.GetValue(i).ToString, ".")(2)
            End If
            Exit For
         End If
      Next
      If String.IsNullOrEmpty(Ip) Then Ip = "2"

      'Ip = Split(Dns.GetHostEntry(Dns.GetHostName()).AddressList.GetValue(1).ToString, ".")(2)
      If CInt(Ip) = 1 Then
         Remotepath = Replace(Remotepath, "..", "NETSDFCA1")
      ElseIf CInt(Ip) >= 24 And CInt(Ip) <= 32 Then
         Remotepath = Replace(Remotepath, "..", "NETTRFCA1")
      Else
         Remotepath = Replace(Remotepath, "..", "NETSDGUA1")
      End If
      Const Key As String = "&*Dave*#@!"
      If InStr(Microsoft.VisualBasic.Command(), Key) > 0 Then
         For Each dFile As String In Directory.GetFiles(startup, "*.old*", SearchOption.TopDirectoryOnly)
            Try
               File.Delete(dFile)
            Catch ex As Exception
               'F_Error(ex, , False)
            End Try
         Next
         Return False
      Else
         Try
            If CheckDirectory(Remotepath) Then
               System.Diagnostics.Process.Start( _
                       Application.StartupPath & "\" & My.Application.Info.AssemblyName.ToArray, Key)
               Return True
            End If
            Return False
         Catch ex As Exception
            MsgBox("Aviso no se pudo actualizar su aplicacion." & vbCr & _
                "Por favor consulte a soporte." & vbCr & ex.Message, _
                MsgBoxStyle.Critical)
            Return False
         End Try
      End If
   End Function

   Public Function CheckDirectory(ByVal Dir As String) As Boolean
      Try
         CheckDirectory = False
         Dim myWebClient As New System.Net.WebClient
         Dim LocalDirectory As String = Application.StartupPath & "\" & Replace(Dir, Remotepath, "")
         For Each sDirectory As String In Directory.GetDirectories(Dir, "*.*", SearchOption.TopDirectoryOnly)
            CheckDirectory(sDirectory)
         Next sDirectory

         For Each sFichero As String In Directory.GetFiles(Dir, "*.*", SearchOption.TopDirectoryOnly)
            Dim archivo As New FileInfo(sFichero)

            If File.Exists(LocalDirectory & "\" & archivo.Name.ToString) Then
               Dim Archivolocal As New FileInfo(LocalDirectory & "\" & archivo.Name.ToString)

               If archivo.LastWriteTime > Archivolocal.LastWriteTime Then
                  If Archivolocal.IsReadOnly Then Archivolocal.IsReadOnly = False
                  If UCase(archivo.Extension.ToString) = ".EXE" Then
                     File.Move(LocalDirectory & "\" & Archivolocal.Name.ToString, _
                         LocalDirectory & "\" & Now.TimeOfDay.TotalMilliseconds & ".old")
                  End If

                  If UCase(Right(archivo.Name.ToString, 2)) <> UCase("db") Then myWebClient.DownloadFile(Dir & "\" & archivo.Name.ToString, _
                            LocalDirectory & "\" & archivo.Name.ToString)

                  CheckDirectory = True
               End If
            Else
               CheckDirectory = True
               CrearDirectorio(LocalDirectory)
               myWebClient.DownloadFile(Dir & "\" & archivo.Name.ToString, _
               LocalDirectory & "\" & archivo.Name.ToString)
            End If
         Next

      Catch ex As Exception
         Throw
      End Try
   End Function

   Public Sub CrearDirectorio(ByVal El_Path As String)
      Try
         Dim Array_Dir As Object
         Dim Sub_Dir As String
         If El_Path = vbNullString Then Exit Sub

         Array_Dir = Split(El_Path, "\")
         El_Path = vbNullString

         For i As Integer = LBound(Array_Dir) To UBound(Array_Dir)
            Sub_Dir = Array_Dir(i)
            If Sub_Dir <> vbNullString Then
               El_Path = El_Path & Sub_Dir & "\"
               If (Sub_Dir.Substring(Sub_Dir.Length - 1, 1)) <> ":" Then
                  If Dir(El_Path, vbDirectory) = vbNullString Then Call MkDir(El_Path)
               End If
            End If
         Next
      Catch ex As Exception
         Throw
      End Try
   End Sub

   Public Sub Login()
      Usuario = Environment.UserDomainName & "\" & Environment.UserName
      Computadora = Environment.MachineName
      Servidor = Accesos.Servidor
      AppName = Application.ProductName
      Version = Application.ProductVersion
      NumeroDeEmpleado = Accesos.GetNumeroDeEmpleado(Usuario)
      If Trim(NumeroDeEmpleado) = "" Then
         MsgBox("No se pudo determinar su codigo de empleado", vbCritical, "Mensaje De Sistema")
         End
      End If
   End Sub

   Public Enum ModosDeTecleo
      Grabar = 1
      Modificar = 2
   End Enum

   Public Function RequieredFields(ByVal Control As UserWindowsControlLibrary.ComboBoxSD) As Boolean
      If String.IsNullOrEmpty(Control.SelectedValue) Then
         MsgBox("El Campo " & StrConv(Control.Name.ToUpper.Replace(Control.GetType.Name.ToUpper.ToString, "").ToUpper.Replace("CBO", "").Replace("TXT", ""), _
                                                  VbStrConv.ProperCase) & " es requerido para este proceso", MsgBoxStyle.Information, "Mensaje Del Sistema")
         Control.Focus()
         Return False
      Else
         Return True
      End If
   End Function

   Public Function RequieredFields(ByVal Control As UserWindowsControlLibrary.TextBoxSD) As Boolean
      If String.IsNullOrEmpty(Control.Text) Then
         MsgBox("El Campo " & StrConv(Control.Name.ToUpper.Replace(Control.GetType.Name.ToUpper.ToString, "").ToUpper.Replace("CBO", "").Replace("TXT", ""), _
                                                  VbStrConv.ProperCase) & " es requerido para este proceso", MsgBoxStyle.Information, "Mensaje Del Sistema")
         Control.Focus()
         Return False
      Else
         Return True
      End If
   End Function

   Public Function RequieredFields(ByVal Control As UserWindowsControlLibrary.MaskedTextBoxSD) As Boolean
      If String.IsNullOrEmpty(Control.ToString) Then
         MsgBox("El Campo " & StrConv(Control.Name.ToUpper.Replace(Control.GetType.Name.ToUpper.ToString, "").ToUpper.Replace("CBO", "").Replace("TXT", ""), _
                                                  VbStrConv.ProperCase) & " es requerido para este proceso", MsgBoxStyle.Information, "Mensaje Del Sistema")
         Control.Focus()
         Return False
      Else
         Return True
      End If
   End Function

   Public Function RequieredFields(ByVal Contenedor As Control, Optional ByVal DisplayMessage As Control = Nothing) As Boolean
      For Each c As Control In Contenedor.Controls
         If TypeOf c Is UserWindowsControlLibrary.TextBoxSD Or TypeOf c Is UserWindowsControlLibrary.MaskedTextBoxSD Or TypeOf c Is UserWindowsControlLibrary.ComboBoxSD Then
            If c.BackColor = Color.LemonChiffon Then
               If (Len(Trim(c.Text)) = 0 Or c.Text = "-Todos-") AndAlso Not TypeOf c Is UserWindowsControlLibrary.MaskedTextBoxSD Then
                  If DisplayMessage IsNot Nothing Then
                     DisplayMessage.Text = "El Campo " & StrConv(c.Name.ToUpper.Replace(c.GetType.Name.ToUpper.ToString, "").ToUpper.Replace("CBO", "").Replace("TXT", ""), _
                                                                 VbStrConv.ProperCase) & " es requerido para este proceso"
                  Else
                     MsgBox("El Campo " & StrConv(c.Name.ToUpper.Replace(c.GetType.Name.ToUpper.ToString, "").ToUpper.Replace("CBO", "").Replace("TXT", ""), _
                                                  VbStrConv.ProperCase) & " es requerido para este proceso", MsgBoxStyle.Information, "Mensaje Del Sistema")
                  End If
                  c.Focus()
                  Return False
               ElseIf c.Text = "  /  /" Then
                  If DisplayMessage IsNot Nothing Then
                     DisplayMessage.Text = "El Campo " & StrConv(c.Name.ToUpper.Replace(c.GetType.Name.ToUpper.ToString, "").ToUpper.Replace("CBO", ""), _
                                                                 VbStrConv.ProperCase) & " es requerido para este proceso"
                  Else
                     MsgBox("El Campo " & StrConv(c.Name.ToUpper.Replace(c.GetType.Name.ToUpper.ToString, "").ToUpper.Replace("CBO", "").Replace("TXT", ""), _
                                                  VbStrConv.ProperCase) & " es requerido para este proceso", MsgBoxStyle.Information, "Mensaje Del Sistema")
                  End If
                  c.Focus()
                  Return False
               End If
            End If
         Else
            RequieredFields(c, DisplayMessage)
         End If
      Next
      Return True
   End Function

   Public Sub limpiarControles(ByVal contenedor As Control)
      Try
         For Each C As Control In contenedor.Controls
            If TypeOf C Is TextBox Then C.Text = ""
            If TypeOf C Is UserWindowsControlLibrary.TextBoxSD Then C.Text = ""
            If TypeOf C Is ComboBox Then C.Text = ""
            If TypeOf C Is UserWindowsControlLibrary.ComboBoxSD Then C.Text = ""
            If TypeOf C Is UserWindowsControlLibrary.MaskedTextBoxSD Then C.Text = ""
            If TypeOf C Is CheckBox Then CType(C, CheckBox).Checked = False
            If TypeOf C Is RadioButton Then CType(C, RadioButton).Checked = False
            If TypeOf C Is ListBox Then CType(C, ListBox).DataSource = Nothing
            If TypeOf C Is RichTextBox Then C.Text = ""
            If TypeOf C Is TableLayoutPanel Then limpiarControles(C)
            If TypeOf C Is GroupBox Then limpiarControles(C)
            If TypeOf C Is Panel Then limpiarControles(C)
            If TypeOf C Is TabControl Then limpiarControles(C)
            If TypeOf C Is SplitContainer Then limpiarControles(C)
            If TypeOf C Is DataGridView Then CType(C, DataGridView).Rows.Clear()
         Next
      Catch ex As Exception
         Throw
      End Try
   End Sub

   Public Sub DeshabilitaMenuContextual(ByVal MenuContextual As ContextMenuStrip)
      Dim Menu As New ContextMenuStrip
      Menu = MenuContextual
      For Each item In Menu.Items
         If item.GetType.Name = "ToolStripMenuItem" Then item.Enabled = False
      Next
   End Sub


   Public Function ExportGrd(ByVal grd As DataGridView, Optional ByVal grd2 As DataGridView = Nothing) As Boolean
      If grd.Rows.Count = 0 Then
         MsgBox("No existen datos que exportar a Excel, verificar que el grid tenga datos", vbInformation, "Mensaje Del Sistema")
         Return False
         Exit Function
      End If
      Dim exApp As New Excel.Application
      Dim exlibro As Excel.Workbook
      Dim exhoja As Excel.Worksheet

      Dim i As Integer = 0
      Dim Col As Integer = 0
      Dim fila As Integer = 0
      Try
         'Añadimos el Libro al programa, y la hoja al libro
         exlibro = exApp.Workbooks.Add
         exhoja = exlibro.Worksheets.Add()

         ' ¿Cuantas columnas y cuantas filas?
         Dim NCol As Integer = grd.ColumnCount
         Dim NRow As Integer = grd.RowCount

         'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
         For i = 1 To NCol
            exhoja.Cells.Item(1, i) = grd.Columns(i - 1).Name.ToString
            'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
         Next

         For fila = 0 To NRow - 1
            For Col = 0 To NCol - 1
               exhoja.Cells.Item(fila + 2, Col + 1).NumberFormat = "@"
               exhoja.Cells.Item(fila + 2, Col + 1) = grd.Rows(fila).Cells(Col).Value
            Next
         Next

         'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
         exhoja.Rows.Item(1).Font.Bold = 1
         exhoja.Rows.Item(1).HorizontalAlignment = 3
         exhoja.Columns.AutoFit()
         '----------Grd2----------
         If Not grd2 Is Nothing Then
            Dim Ncol2 As Integer = grd2.ColumnCount
            Dim NRow2 As Integer = grd2.RowCount
            For x As Integer = 1 To Ncol2
               exhoja.Cells.Item(fila + 4, x) = grd2.Columns(x - 1).Name.ToString
            Next
            exhoja.Rows.Item(fila + 4).Font.Bold = 1
            exhoja.Rows.Item(fila + 4).HorizontalAlignment = 3
            exhoja.Columns.AutoFit()
            For fila2 As Integer = 0 To NRow2 - 1
               For col2 As Integer = 0 To Ncol2 - 1
                  exhoja.Cells.Item(fila + 6 + fila2, col2 + 1) = grd2.Rows(fila2).Cells(col2).Value
               Next
            Next
         End If
         exApp.Application.Visible = True
         exhoja = Nothing
         exlibro = Nothing
         exApp = Nothing
      Catch ex As Exception
         Throw (ex)
      End Try
      Return True
   End Function

   Public Sub F_Error(ex As Exception)
      Try
         ErroLog(ex)
      Catch err As Exception
         Throw
      End Try
   End Sub

   Private Sub ErroLog(ByVal Err As Exception)
      Try
         Using Fs As FileStream = New FileStream("Error.log", FileMode.Append), Log As StreamWriter = New StreamWriter(Fs)
            Log.WriteLine(Space(3) & Date.Now.ToString & Space(3) & Environment.UserDomainName & "\" & Environment.UserName & Space(3) & Environment.MachineName & Space(3) & Err.Message)
            Log.WriteLine()
         End Using
         Throw New Exception("Se a generado un error en la aplicacion, comunicarse con el departamento de TI: " & Err.Message)
      Catch ex As Exception
         MsgBox(ex.Message)
      End Try
   End Sub

   Public Function FindItem(ByVal ItemToFind As String, Optional ByVal FindString As String = "", Optional ByVal Maximize As Boolean = False) As String
      Try
         If String.IsNullOrEmpty(ItemToFind) Then Return Nothing
         Dim sqlQuery As String = String.Empty, xTable As New DataTable, RowFilter As String = String.Empty
         RowFound = Nothing
         'Seleccionamos un query Predefinido
         Select Case UCase(ItemToFind)
            Case "Empleados".ToUpper
               xTable = Accesos.GetEmpleados
         End Select

         'Si tenemos un query lo consultamos en una tabla
         If xTable Is Nothing Then Return Nothing

         'Instanciamos una vista de esa tabla
         Dim vwFiltro As New DataView(xTable)
         'Armamos un filtro para cualquier columna de la tabla
         If Not String.IsNullOrEmpty(FindString) Then
            For i As Integer = 0 To xTable.Columns.Count - 1
               ' RowFilter &= xTable.Columns(i).ColumnName & "=" & Send(FindString)
               If InStr(xTable.Columns(i).DataType.ToString, "Int") > 0 And IsNumeric(FindString) Then
                  RowFilter &= xTable.Columns(i).ColumnName & "= '" & FindString & "'"
               ElseIf InStr(xTable.Columns(i).DataType.ToString, "String") > 0 Then
                  RowFilter &= xTable.Columns(i).ColumnName & " like '%" & FindString & "%'"
               ElseIf InStr(xTable.Columns(i).DataType.ToString, "Decimal") > 0 Then
                  RowFilter &= xTable.Columns(i).ColumnName & "='" & FindString & "'"
               ElseIf InStr(xTable.Columns(i).DataType.ToString, "Date") > 0 Then
                  RowFilter &= xTable.Columns(i).ColumnName & "= " & ("#" & FindString & "#")
               End If
               If i <> xTable.Columns.Count - 1 And Not String.IsNullOrEmpty(RowFilter) Then RowFilter &= " or "
            Next i
         End If
         'Asignamos el filtro a la vista para que muestre las ocurrencias encontradas 
         vwFiltro.RowFilter = RowFilter

         'si encontramos exactamente un registro devolvemos la row
         If vwFiltro.Count = 1 Then
            RowFound = vwFiltro(0).Row
            Return RowFound.Item(0).ToString
         Else
            'Si no existe  ningun registro que coincide eliminamos el filtro para que nos muestre todo el resultado del query
            If vwFiltro.Count < 1 Then vwFiltro.RowFilter = ""
            Dim Lov As New FrmLov
            Lov.Filter = FindString
            Lov.vwFiltro = vwFiltro
            If Maximize Then Lov.WindowState = FormWindowState.Maximized Else Lov.WindowState = FormWindowState.Normal
            Lov.ShowDialog()
            If RowFound IsNot Nothing Then Return RowFound.Item(0).ToString Else Return ""
         End If
         Return Nothing
      Catch ex As Exception
         Throw
      End Try
   End Function

End Module
