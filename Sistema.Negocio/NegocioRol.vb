Imports Sistema.Datos

Public Class NegocioRol

    Public Function Listar() As DataTable

        Try
            Dim Datos As New DatosRol  'instancia
            Dim Tabla As DataTable
            Tabla = Datos.Listar()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


End Class
