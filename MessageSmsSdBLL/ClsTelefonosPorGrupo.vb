Public Class ClsTelefonosPorGrupo
   Private db As New DataBaseSD.DataBaseSD.DataBaseSD

   Public Function Buscar(ByVal Grupo As String) As DataSet
      Buscar = Nothing
      Try
         Return db.ExecuteDataSet("DbTi.dbo.UpsSmsGruposDeEnvioTelefono", Grupo)
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Public Sub Grabar(ByVal Grupo As String, ByVal Telefono As String)
      Try
         XsqlDefault = String.Empty
         XsqlDefault = "INSERT INTO DbTi.dbo.TblSMSGruposDeEnvioTelefonos (IdGrupo,Telefono) VALUES(" & Grupo & "," & Telefono & ")"
         db.ExecuteNonQuery(db.GetSqlStringCommand(XsqlDefault))
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Public Sub Eliminar(ByVal Grupo As String, ByVal Telefono As String)
      Try
         XsqlDefault = String.Empty
         XsqlDefault = "DELETE DbTi.dbo.TblSMSGruposDeEnvioTelefonos WHERE IdGrupo = " & Grupo & " AND Telefono = " & Telefono
         db.ExecuteNonQuery(db.GetSqlStringCommand(XsqlDefault))
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

End Class
