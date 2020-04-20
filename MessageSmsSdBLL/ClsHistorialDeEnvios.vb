Public Class ClsHistorialDeEnvios
   Private db As New DataBaseSD.DataBaseSD.DataBaseSD

   Public Sub InsertarHistoria(ByVal Telefono As String, CuerpoMensaje As String, EnviadoPor As String)
      Try
         db.ExecuteNonQuery("DbTi.dbo.UpInsertaSmsHistoria", Telefono, CuerpoMensaje, EnviadoPor)
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Public Function Buscar(ByVal FechaInicial As String, ByVal FechaFinal As String, ByVal EnviadoPor As String) As DataTable
      Buscar = Nothing
      Try
         XsqlDefault = String.Empty
         XsqlDefault = "SELECT IdMensaje,CONVERT(VARCHAR,a.Telefono)+'-'+b.Nombre AS Telefono,RTRIM(CuerpoDeMensaje) CuerpoDeMensaje,"
         XsqlDefault &= " FechaDeEnvio,RTRIM(EnviadoPor)+'-'+c.Nombre AS EnviadoPor  "
         XsqlDefault &= " FROM DbTI.dbo.TblSMSHistorialDeEnvio a"
         XsqlDefault &= " INNER JOIN DbTI.dbo.TblSMSTelefonosPersonal b ON a.Telefono = b.Telefono "
         XsqlDefault &= " INNER JOIN DbRecursosHumanos.dbo.TblPersonal c ON a.EnviadoPor = c.NumeroDeEmpleado "
         XsqlDefault &= " WHERE 1 = 1"
         If Not String.IsNullOrEmpty(FechaInicial) Then XsqlDefault &= " AND CONVERT(VARCHAR(10),FechaDeEnvio,103)>= '" & FechaInicial & "'"
         If Not String.IsNullOrEmpty(FechaFinal) Then XsqlDefault &= " AND CONVERT(VARCHAR(10),FechaDeEnvio,103)<= '" & FechaFinal & "'"
         If Not String.IsNullOrEmpty(EnviadoPor) Then XsqlDefault &= " AND EnviadoPor = '" & EnviadoPor & "'"
         Return db.ExecuteDataSet(db.GetSqlStringCommand(XsqlDefault)).Tables(0)
      Catch ex As Exception
         Throw ex
      End Try
    End Function

    Public Function GetDisponibles() As Integer
      GetDisponibles = Nothing
      Try
         Dim Table As DataTable
         XsqlDefault = String.Empty
         XsqlDefault = "SELECT  FechaInicial,FechaFinal,CantidadMensajes "
         XsqlDefault &= " FROM DbTi.dbo.TblSMSVigencia"
         XsqlDefault &= " WHERE CONVERT(DATE,GETDATE(),103) BETWEEN FechaInicial AND FechaFinal "
         Table = db.ExecuteDataSet(db.GetSqlStringCommand(XsqlDefault)).Tables(0)
         If Table IsNot Nothing AndAlso Table.Rows.Count = 1 Then
            Dim conteo As String = String.Empty
            XsqlDefault = String.Empty
            XsqlDefault = " Select isnull(count(1),0) FROM  DbTI.dbo.TblSMSHistorialDeEnvio " & _
                          "   WHERE CONVERT(DATE,FechaDeEnvio) >= '" & CDate(Table.Rows(0).Item("FechaInicial").ToString) & "'" & _
                          " AND CONVERT(DATE,FechaDeEnvio) <= '" & CDate(Table.Rows(0).Item("FechaFinal").ToString) & "'"
            conteo = (db.ExecuteScalar(New SqlClient.SqlCommand(XsqlDefault)))
            Return Val(Table.Rows(0).Item("CantidadMensajes").ToString) - CInt(IIf(conteo = "", "0", conteo))
         Else
            Return 0
         End If
      Catch ex As Exception
         Throw ex
      End Try
    End Function

   Public Function GetSMSValidosHasta() As Nullable(Of Date)
      Try
         Dim Table As DataTable
         XsqlDefault = String.Empty
         XsqlDefault = "SELECT  FechaInicial,FechaFinal,CantidadMensajes "
         XsqlDefault &= " FROM DbTi.dbo.TblSMSVigencia"
         XsqlDefault &= " WHERE CONVERT(DATE,GETDATE(),103) BETWEEN FechaInicial AND FechaFinal "
         Table = db.ExecuteDataSet(db.GetSqlStringCommand(XsqlDefault)).Tables(0)
         If Table IsNot Nothing AndAlso Table.Rows.Count = 1 Then
            Return CDate(Table.Rows(0).Item("FechaFinal").ToString)
         Else
            Return Nothing
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Function

End Class
