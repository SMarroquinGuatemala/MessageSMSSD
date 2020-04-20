Public Class ClsTelefonosPersonal
   Private db As New DataBaseSD.DataBaseSD.DataBaseSD

   Public Function Buscar(ByVal Telefono As String, ByVal NumeroDeEmpleado As String, ByVal Nombre As String, Optional ByVal Activo As Boolean = False) As DataTable
      Buscar = Nothing
      Try
         XsqlDefault = String.Empty
         XsqlDefault = "SELECT Telefono,NumeroDeEmpleado,Nombre,Observaciones,Activo FROM DbTI.dbo.TblSMSTelefonosPersonal WHERE 1=1"
         If Not String.IsNullOrEmpty(Telefono) Then XsqlDefault &= " AND Telefono = '" & Telefono & "'"
         If Not String.IsNullOrEmpty(NumeroDeEmpleado) Then XsqlDefault &= " AND NumeroDeEmpleado = '" & NumeroDeEmpleado & "'"
         If Not String.IsNullOrEmpty(Nombre) Then XsqlDefault &= " AND Nombre LIKE '%" & Nombre & "%'"
         If Activo Then XsqlDefault &= " AND Activo = 1"
         Return db.ExecuteDataSet(db.GetSqlStringCommand(XsqlDefault)).Tables(0)
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Public Function GrabarModificar(ByVal Telefono As String, ByVal NumeroDeEmpleado As String, ByVal Nombre As String, ByVal Observaciones As String, ByVal Activo As Boolean)
      GrabarModificar = Nothing
      Try
         db.ExecuteNonQuery("UpIUSmsTelefonosPersonal", Telefono, NumeroDeEmpleado, Nombre, Observaciones, Activo)
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Public Function Eliminar(ByVal Telefono As String) As Boolean
      Eliminar = Nothing
      Try
         Dim count As Integer = 0
         XsqlDefault = String.Empty
         XsqlDefault = "SELECT COUNT(1) FROM DbTi.dbo.TblSmsGruposDeEnvioTelefonos WHERE Telefono = " & Telefono
         count = db.ExecuteScalar(db.GetSqlStringCommand(XsqlDefault))
         If count = 0 Then
            XsqlDefault = String.Empty
            XsqlDefault = "SELECT COUNT(1) FROM DbTi.dbo.TblSmsHistorialDeEnvio WHERE Telefono = " & Telefono
            count = db.ExecuteScalar(db.GetSqlStringCommand(XsqlDefault))
         End If
         If count > 0 Then
            Return False
         Else
            XsqlDefault = String.Empty
            XsqlDefault = "DELETE From DbTi.dbo.TblSmsTelefonosPersonal WHERE Telefono = " & Telefono
            db.ExecuteNonQuery(db.GetSqlStringCommand(XsqlDefault))
            Return True
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Function

End Class
