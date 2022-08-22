Imports Sistema.Datos
Imports Sistema.Entidades


Public Class NegocioPersona
    Public Function Listar() As DataTable

        Try
            Dim Datos As New DatosPersona  'instancia
            Dim Tabla As DataTable
            Tabla = Datos.Listar()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function ListarProveedor() As DataTable

        Try
            Dim Datos As New DatosPersona  'instancia
            Dim Tabla As DataTable
            Tabla = Datos.ListarProveedor
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function ListarCliente() As DataTable

        Try
            Dim Datos As New DatosPersona  'instancia
            Dim Tabla As DataTable
            Tabla = Datos.ListarCliente
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Buscar(Valor As String) As DataTable
        Try
            Dim Datos As New DatosPersona  'instancia
            Dim Tabla As DataTable
            Tabla = Datos.Buscar(Valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function BuscarProveedor(Valor As String) As DataTable
        Try
            Dim Datos As New DatosPersona  'instancia
            Dim Tabla As DataTable
            Tabla = Datos.BuscarProveedor(Valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function BuscarCliente(Valor As String) As DataTable
        Try
            Dim Datos As New DatosPersona  'instancia
            Dim Tabla As DataTable
            Tabla = Datos.BuscarCliente(Valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function Insertar(ObjPersona As Persona) As Boolean
        Try
            Dim Datos As New DatosPersona
            Datos.Insertar(ObjPersona)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Actualizar(ObjPersona As Persona) As Boolean
        Try
            Dim Datos As New DatosPersona
            Datos.Actualizar(ObjPersona)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Eliminar(Id As Integer) As Boolean
        Try
            Dim Datos As New DatosPersona
            Datos.Eliminar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
