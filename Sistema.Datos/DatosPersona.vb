
Imports Sistema.Entidades
Imports System.Data.SqlClient

Public Class DatosPersona
    Inherits Conexion 'heredamos la conexión

    Public Function Listar() As DataTable

        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim cmd As New SqlCommand("persona_listar", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            MyBase.conn.Open()
            Resultado = cmd.ExecuteReader
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ListarProveedor() As DataTable

        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim cmd As New SqlCommand("persona_listar_proveedores", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            MyBase.conn.Open()
            Resultado = cmd.ExecuteReader
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ListarCliente() As DataTable

        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim cmd As New SqlCommand("persona_listar_clientes", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            MyBase.conn.Open()
            Resultado = cmd.ExecuteReader
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try

    End Function


    Public Function Buscar(Valor As String) As DataTable

        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim cmd As New SqlCommand("persona_buscar", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Valor", SqlDbType.VarChar).Value = Valor 'cadena que se pasa para buscar
            MyBase.conn.Open()
            Resultado = cmd.ExecuteReader
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarProveedor(Valor As String) As DataTable

        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim cmd As New SqlCommand("persona_buscar_proveedores", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Valor", SqlDbType.VarChar).Value = Valor 'cadena que se pasa para buscar
            MyBase.conn.Open()
            Resultado = cmd.ExecuteReader
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarCliente(Valor As String) As DataTable

        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim cmd As New SqlCommand("persona_buscar_clientes", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Valor", SqlDbType.VarChar).Value = Valor 'cadena que se pasa para buscar
            MyBase.conn.Open()
            Resultado = cmd.ExecuteReader
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Insertar(ObjPersona As Persona)
        Try

            Dim cmd As New SqlCommand("persona_insertar", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@tipo_persona", SqlDbType.VarChar).Value = ObjPersona.TipoPersona
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = ObjPersona.Nombre
            cmd.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = ObjPersona.TipoDocumento
            cmd.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = ObjPersona.NumDocumento
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = ObjPersona.Direccion
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = ObjPersona.Telefono
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = ObjPersona.Email
            MyBase.conn.Open()
            cmd.ExecuteNonQuery()
            MyBase.conn.Close()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Actualizar(ObjPersona As Persona)
        Try

            Dim cmd As New SqlCommand("persona_actualizar", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@idpersona", SqlDbType.Int).Value = ObjPersona.IdPersona
            cmd.Parameters.Add("@tipo_persona", SqlDbType.VarChar).Value = ObjPersona.TipoPersona
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = ObjPersona.Nombre
            cmd.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = ObjPersona.TipoDocumento
            cmd.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = ObjPersona.NumDocumento
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = ObjPersona.Direccion
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = ObjPersona.Telefono
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = ObjPersona.Email
            MyBase.conn.Open()
            cmd.ExecuteNonQuery()
            MyBase.conn.Close()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar(Id As Integer)
        Try

            Dim cmd As New SqlCommand("persona_eliminar", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            cmd.ExecuteNonQuery()
            MyBase.conn.Close()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


End Class
