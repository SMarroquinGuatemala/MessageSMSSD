Public Class ClsPlantillas
   Private db As New DataBaseSD.DataBaseSD.DataBaseSD

   Public Function Buscar(ByVal IdPlantilla As String, ByVal Mensaje As String) As DataTable
      Buscar = Nothing
      Try
         XsqlDefault = String.Empty
         XsqlDefault = "SELECT idPlantilla,CuerpoDeMensaje  FROM DbTI.dbo.TblSMSPlantillas WHERE 1=1"
         Return db.ExecuteDataSet(db.GetSqlStringCommand(XsqlDefault)).Tables(0)
      Catch ex As Exception
         Throw
      End Try
   End Function

   Public Function GrabarModificar(ByVal Plantilla As String, ByVal Mensaje As String)
      GrabarModificar = Nothing
      Try
         db.ExecuteNonQuery("DbTi.dbo.UpIUSmsPlantillas", Plantilla, Mensaje)
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Public Function Eliminar(ByVal Plantilla As String) As Boolean
      Eliminar = Nothing
      Try
         XsqlDefault = String.Empty
         XsqlDefault = "DELETE FROM DbTI.dbo.TblSMSPlantillas WHERE idPlantilla = " & Plantilla
         db.ExecuteNonQuery(db.GetSqlStringCommand(XsqlDefault))
         Return True
      Catch ex As Exception
         Throw
      End Try
   End Function

End Class
