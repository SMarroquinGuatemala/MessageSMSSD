Public Class ClsGruposDeEnvio
   Private db As New DataBaseSD.DataBaseSD.DataBaseSD

   Public Function Buscar(ByVal Nombre As String, ByVal Descripcion As String, Optional ByVal IsGroup As Boolean = False) As DataTable
      Buscar = Nothing
      Try
         XsqlDefault = String.Empty
         If Not IsGroup Then
            XsqlDefault = "select IdGrupo,Nombre,Descripcion from DbTi.dbo.TblSmsGruposDeEnvio WHERE 1=1 "
         Else
            XsqlDefault = "SELECT IdGrupo,Nombre,1 AS IsGroup FROM DbTI.dbo.TblSMSGruposDeEnvio  WHERE 1=1 "
         End If
         If Not String.IsNullOrEmpty(Nombre) Then XsqlDefault &= " AND Nombre LIKE '%" & Nombre & "%'"
         If Not String.IsNullOrEmpty(Descripcion) Then XsqlDefault &= " AND Descripcion LIKE '%" & Descripcion & "%'"
         Return db.ExecuteDataSet(db.GetSqlStringCommand(XsqlDefault)).Tables(0)
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Public Sub GrabarModificar(ByVal IdGrupo As String, ByVal Nombre As String, ByVal Descripcion As String)
      Try
         db.ExecuteNonQuery("DbTi.dbo.UpIUSmsGruposDeEnvios", IdGrupo, Nombre, Descripcion)
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Public Function Eliminar(ByVal IdGrupo As String) As Boolean
      Eliminar = Nothing
      Try
         Dim count As Integer
         XsqlDefault = String.Empty
         XsqlDefault = "select Count(1) from DbTi.dbo.TblSMSGruposDeEnvioTelefonos where idgrupo = " & IdGrupo
         count = db.ExecuteScalar(db.GetSqlStringCommand(XsqlDefault))
         If count > 0 Then
            Return False
         Else
            XsqlDefault = String.Empty
            XsqlDefault = "DELETE FROM DbTi.dbo.TblSmsGruposDeEnvio WHERE idgrupo = " & IdGrupo
            db.ExecuteNonQuery(db.GetSqlStringCommand(XsqlDefault))
            Return True
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Function

End Class
