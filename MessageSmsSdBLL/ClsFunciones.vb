Public Class ClsFunciones
   Private db As New DataBaseSD.DataBaseSD.DataBaseSD
   Dim xTable As DataTable

   Public ReadOnly Property Servidor As String
      Get
         Return db.Server.ToUpper
      End Get
   End Property

   Public Function GetEmpleados(Optional ByVal NumeroEmpleado As String = Nothing) As DataTable
      Try
         XsqlDefault = String.Empty
         XsqlDefault = "SELECT RTRIM(NumeroDeEmpleado) as NumeroDeEmpleado,Nombres,Apellidos FROM DbRecursosHumanos.dbo.tblpersonal WHERE fechadeegreso IS NULL "
         If Not String.IsNullOrEmpty(NumeroEmpleado) Then XsqlDefault &= " AND NumeroDeEmpleado = '" & NumeroEmpleado & "'"
         Return db.ExecuteDataSet(db.GetSqlStringCommand(XsqlDefault)).Tables(0)
      Catch ex As Exception
         Throw
      End Try
    End Function
    Public Function GetNumeroDeEmpleado(Optional ByVal Usuario As String = Nothing) As String
        Try
            XsqlDefault = String.Empty
            XsqlDefault = "SELECT NumeroDeEmpleadoFinca FROM DbContabilidad.dbo.TblSecUsuarios WHERE Usuario =  '" & (Usuario) & "'"
            Return db.ExecuteScalar(New SqlClient.SqlCommand(XsqlDefault))
        Catch ex As Exception
            Throw
        End Try
    End Function
    Function ExtraeCampoJSON(ByVal Cadena As String, ByVal xCampo As String) As String
        Try
            Dim lectura As String = String.Empty
            xCampo = UCase(xCampo)
            Cadena = UCase(Cadena)
            If Not Trim(Cadena) = "" AndAlso InStr(Cadena, xCampo) > 0 Then
                lectura = (Mid(Cadena, InStr(Cadena, xCampo)))
                lectura = Replace(lectura, "}", ",")
                lectura = Mid(lectura, 1, InStr(lectura, ",") - 1)
                lectura = Replace(lectura, """", "")
                If InStr(lectura, ":") > 0 Then
                    If InStr(lectura, UCase("Fecha")) > 0 Then
                        lectura = Mid(lectura, InStr(lectura, ":") + 1)
                        Return lectura
                    Else
                        Return Split(lectura, ":")(1)
                    End If

                Else
                    Return ""
                End If
            Else
                Return ""
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Class
