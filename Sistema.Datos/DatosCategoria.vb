Imports Sistema.Entidades
Imports System.Data.SqlClient


Public Class DatosCategoria
    Inherits Conexion 'heredamos la conexión

    Public Function Listar() As DataTable

        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim cmd As New SqlCommand("categoria_listar", MyBase.conn)
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
            Dim cmd As New SqlCommand("categoria_buscar", MyBase.conn)
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

    Public Function Seleccionar() As DataTable

        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim cmd As New SqlCommand("categoria_seleccionar", MyBase.conn)
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



    Public Sub Insertar(ObjCategoria As Categoria)
        Try

            Dim cmd As New SqlCommand("categoria_insertar", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = ObjCategoria.Nombre
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = ObjCategoria.Descripcion
            MyBase.conn.Open()
            cmd.ExecuteNonQuery()
            MyBase.conn.Close()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Actualizar(ObjCategoria As Categoria)
        Try

            Dim cmd As New SqlCommand("categoria_actualizar", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@idcategoria", SqlDbType.Int).Value = ObjCategoria.IdCategoria
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = ObjCategoria.Nombre
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = ObjCategoria.Descripcion
            MyBase.conn.Open()
            cmd.ExecuteNonQuery()
            MyBase.conn.Close()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar(Id As Integer)
        Try

            Dim cmd As New SqlCommand("categoria_eliminar", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            cmd.ExecuteNonQuery()
            MyBase.conn.Close()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Activar(Id As Integer)
        Try

            Dim cmd As New SqlCommand("categoria_activar", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            cmd.ExecuteNonQuery()
            MyBase.conn.Close()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Sub Desactivar(Id As Integer)
        Try

            Dim cmd As New SqlCommand("categoria_desactivar", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            cmd.ExecuteNonQuery()
            MyBase.conn.Close()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
