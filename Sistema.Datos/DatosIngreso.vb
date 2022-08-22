Imports Sistema.Entidades
Imports System.Data.SqlClient

Public Class DatosIngreso
    Inherits Conexion 'heredamos la conexión

    Public Function Listar() As DataTable

        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim cmd As New SqlCommand("ingreso_listar", MyBase.conn)
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
            Dim cmd As New SqlCommand("ingreso_buscar", MyBase.conn)
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

    Public Function ListarDetalle(Id As Integer) As DataTable

        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim cmd As New SqlCommand("ingreso_listar_detalle", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@idingreso", SqlDbType.Int).Value = Id 'cadena que se pasa para buscar
            MyBase.conn.Open()
            Resultado = cmd.ExecuteReader
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Anular(Id As Integer)
        Try

            Dim cmd As New SqlCommand("ingreso_anular", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@idingreso", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            cmd.ExecuteNonQuery()
            MyBase.conn.Close()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Insertar(ObjIngreso As Ingresos, Det As DataTable)
        Try

            Dim cmd As New SqlCommand("ingreso_insertar", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@idingreso", SqlDbType.Int).Value = ObjIngreso.IdIngreso
            cmd.Parameters("@idingreso").Direction = ParameterDirection.Output
            cmd.Parameters.Add("@idproveedor", SqlDbType.Int).Value = ObjIngreso.IdProveedor
            cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = ObjIngreso.IdUsuario
            cmd.Parameters.Add("@tipo_comprobante", SqlDbType.VarChar).Value = ObjIngreso.TipoComprobante
            cmd.Parameters.Add("@serie_comprobante", SqlDbType.VarChar).Value = ObjIngreso.SerieComprobante
            cmd.Parameters.Add("@num_comprobante", SqlDbType.VarChar).Value = ObjIngreso.NumComprobante
            cmd.Parameters.Add("@impuesto", SqlDbType.Decimal).Value = ObjIngreso.Impuesto
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = ObjIngreso.Total

            'datos del detalle

            cmd.Parameters.Add("@detalle", SqlDbType.Structured).Value = Det


            MyBase.conn.Open()
            cmd.ExecuteNonQuery()
            MyBase.conn.Close()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Sub Eliminar(Id As Integer)
        Try

            Dim cmd As New SqlCommand("ingreso_eliminar", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@idingreso", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            cmd.ExecuteNonQuery()
            MyBase.conn.Close()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub





End Class
