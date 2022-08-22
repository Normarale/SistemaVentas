Imports System.Data.SqlClient
Imports Sistema.Entidades
Public Class DatosRol
    Inherits Conexion

    Public Function Listar() As DataTable

        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim cmd As New SqlCommand("rol_listar", MyBase.conn)
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
End Class
