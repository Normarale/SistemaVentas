Imports System.Data.SqlClient
Imports Sistema.Entidades
Public Class DatosArticulo

    Inherits Conexion 'heredamos la conexión



    Public Function Listar() As DataTable

        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim cmd As New SqlCommand("articulo_listar", MyBase.conn)
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
            Dim cmd As New SqlCommand("articulo_buscar", MyBase.conn)
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


    Public Function BuscarVenta(Valor As String) As DataTable

        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim cmd As New SqlCommand("articulo_buscar_venta", MyBase.conn)
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

    Public Function BuscarArticulo(Valor As String) As DataTable

        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim cmd As New SqlCommand("articulo_buscar_codigo", MyBase.conn)
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


    Public Function BuscarArticuloVenta(Valor As String) As DataTable

        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim cmd As New SqlCommand("articulo_buscar_codigo_venta", MyBase.conn)
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

    Public Sub Insertar(ObjArticulo As Articulo)
        Try

            Dim cmd As New SqlCommand("articulo_insertar", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@idcategoria", SqlDbType.Int).Value = ObjArticulo.IdCategoria
            cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = ObjArticulo.Codigo
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = ObjArticulo.Nombre
            cmd.Parameters.Add("@precio_venta", SqlDbType.Decimal).Value = ObjArticulo.PrecioVenta
            cmd.Parameters.Add("@stock", SqlDbType.Int).Value = ObjArticulo.Stock
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = ObjArticulo.Descripcion
            cmd.Parameters.Add("@imagen", SqlDbType.VarChar).Value = ObjArticulo.Imagen

            MyBase.conn.Open()
            cmd.ExecuteNonQuery()
            MyBase.conn.Close()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Actualizar(ObjArticulo As Articulo)
        Try

            Dim cmd As New SqlCommand("articulo_actualizar", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("idarticulo", SqlDbType.Int).Value = ObjArticulo.IdArticulo
            cmd.Parameters.Add("@idcategoria", SqlDbType.Int).Value = ObjArticulo.IdCategoria
            cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = ObjArticulo.Codigo
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = ObjArticulo.Nombre
            cmd.Parameters.Add("@precio_venta", SqlDbType.Decimal).Value = ObjArticulo.PrecioVenta
            cmd.Parameters.Add("@stock", SqlDbType.Int).Value = ObjArticulo.Stock
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = ObjArticulo.Descripcion
            cmd.Parameters.Add("@imagen", SqlDbType.VarChar).Value = ObjArticulo.Imagen
            MyBase.conn.Open()
            cmd.ExecuteNonQuery()
            MyBase.conn.Close()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar(Id As Integer)
        Try

            Dim cmd As New SqlCommand("articulo_eliminar", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@idarticulo", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            cmd.ExecuteNonQuery()
            MyBase.conn.Close()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Activar(Id As Integer)
        Try

            Dim cmd As New SqlCommand("articulo_activar", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@idarticulo", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            cmd.ExecuteNonQuery()
            MyBase.conn.Close()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Sub Desactivar(Id As Integer)
        Try

            Dim cmd As New SqlCommand("articulo_desactivar", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@idarticulo", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            cmd.ExecuteNonQuery()
            MyBase.conn.Close()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
