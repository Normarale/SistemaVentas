Imports Sistema.Datos
Imports Sistema.Entidades


Public Class NegocioCategoria
    Public Function Listar() As DataTable

        Try
            Dim Datos As New DatosCategoria  'instancia
            Dim Tabla As DataTable
            Tabla = Datos.Listar()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function Buscar(Valor As String) As DataTable
        Try
            Dim Datos As New DatosCategoria  'instancia
            Dim Tabla As DataTable
            Tabla = Datos.Buscar(Valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Seleccionar() As DataTable

        Try
            Dim Datos As New DatosCategoria  'instancia
            Dim Tabla As DataTable
            Tabla = Datos.Seleccionar()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Insertar(ObjCategoria As Categoria) As Boolean
        Try
            Dim Datos As New DatosCategoria
            Datos.Insertar(ObjCategoria)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Actualizar(ObjCategoria As Categoria) As Boolean
        Try
            Dim Datos As New DatosCategoria
            Datos.Actualizar(ObjCategoria)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Eliminar(Id As Integer) As Boolean
        Try
            Dim Datos As New DatosCategoria
            Datos.Eliminar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Activar(Id As Integer) As Boolean
        Try
            Dim Datos As New DatosCategoria
            Datos.Activar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Desactivar(Id As Integer) As Boolean
        Try
            Dim Datos As New DatosCategoria
            Datos.Desactivar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class
