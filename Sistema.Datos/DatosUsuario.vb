Imports Sistema.Entidades
Imports System.Data.SqlClient


Public Class DatosUsuario

    Inherits Conexion 'heredamos la conexión

    Public Function Listar() As DataTable

        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim cmd As New SqlCommand("usuario_listar", MyBase.conn)
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
            Dim cmd As New SqlCommand("usuario_buscar", MyBase.conn)
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

    Public Function Loguear(Email As String, Clave As String ) As DataTable

        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim cmd As New SqlCommand("usuario_login", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email 'cadena que se pasa para buscar
            cmd.Parameters.Add("@Clave", SqlDbType.VarChar).Value = Clave
            MyBase.conn.Open()
            Resultado = cmd.ExecuteReader
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Insertar(ObjUsuario As Usuario)
        Try

            Dim cmd As New SqlCommand("usuario_insertar", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@idRol", SqlDbType.Int).Value = ObjUsuario.IdRol
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = ObjUsuario.Nombre
            cmd.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = ObjUsuario.TipoDocumento
            cmd.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = ObjUsuario.NumDocumento
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = ObjUsuario.Direccion
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = ObjUsuario.Telefono
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = ObjUsuario.Email
            cmd.Parameters.Add("@clave", SqlDbType.VarChar).Value = ObjUsuario.Clave

            MyBase.conn.Open()
            cmd.ExecuteNonQuery()
            MyBase.conn.Close()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Actualizar(ObjUsuario As Usuario)
        Try

            Dim cmd As New SqlCommand("usuario_actualizar", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = ObjUsuario.IdUsuario
            cmd.Parameters.Add("@idrol", SqlDbType.Int).Value = ObjUsuario.IdRol
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = ObjUsuario.Nombre
            cmd.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = ObjUsuario.TipoDocumento
            cmd.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = ObjUsuario.NumDocumento
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = ObjUsuario.Direccion
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = ObjUsuario.Telefono
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = ObjUsuario.Email
            cmd.Parameters.Add("@clave", SqlDbType.VarChar).Value = ObjUsuario.Clave
            MyBase.conn.Open()
            cmd.ExecuteNonQuery()
            MyBase.conn.Close()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar(Id As Integer)
        Try

            Dim cmd As New SqlCommand("usuario_eliminar", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            cmd.ExecuteNonQuery()
            MyBase.conn.Close()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Activar(Id As Integer)
        Try

            Dim cmd As New SqlCommand("usuario_activar", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            cmd.ExecuteNonQuery()
            MyBase.conn.Close()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Sub Desactivar(Id As Integer)
        Try

            Dim cmd As New SqlCommand("usuario_desactivar", MyBase.conn)
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
