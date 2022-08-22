Imports Sistema.Datos
Imports Sistema.Entidades
Public Class NegocioArticulo
    Public Function Listar() As DataTable

        Try
            Dim Datos As New DatosArticulo  'instancia
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
            Dim Datos As New DatosArticulo  'instancia
            Dim Tabla As DataTable
            Tabla = Datos.Buscar(Valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function BuscarVenta(Valor As String) As DataTable
        Try
            Dim Datos As New DatosArticulo  'instancia
            Dim Tabla As DataTable
            Tabla = Datos.BuscarVenta(Valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function BuscarArticulo(Valor As String) As Articulo
        Try
            Dim Datos As New DatosArticulo  'instancia
            Dim Tabla As DataTable
            Dim Art As New Articulo
            Tabla = Datos.BuscarArticulo(Valor)
            If (Tabla.Rows.Count > 0) Then
                Art.IdArticulo = Tabla.Rows(0).Item(0).ToString
                Art.Codigo = Tabla.Rows(0).Item(1).ToString
                Art.Nombre = Tabla.Rows(0).Item(2).ToString
                Art.PrecioVenta = Tabla.Rows(0).Item(3).ToString
                Art.Stock = Tabla.Rows(0).Item(4).ToString
                Return Art
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function BuscarArticuloVenta(Valor As String) As Articulo
        Try
            Dim Datos As New DatosArticulo  'instancia
            Dim Tabla As DataTable
            Dim Art As New Articulo
            Tabla = Datos.BuscarArticuloVenta(Valor)
            If (Tabla.Rows.Count > 0) Then
                Art.IdArticulo = Tabla.Rows(0).Item(0).ToString
                Art.Codigo = Tabla.Rows(0).Item(1).ToString
                Art.Nombre = Tabla.Rows(0).Item(2).ToString
                Art.PrecioVenta = Tabla.Rows(0).Item(3).ToString
                Art.Stock = Tabla.Rows(0).Item(4).ToString
                Return Art
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function Insertar(ObjArticulo As Articulo) As Boolean
        Try
            Dim Datos As New DatosArticulo
            Datos.Insertar(ObjArticulo)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Actualizar(ObjArticulo As Articulo) As Boolean
        Try
            Dim Datos As New DatosArticulo
            Datos.Actualizar(ObjArticulo)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Eliminar(Id As Integer) As Boolean
        Try
            Dim Datos As New DatosArticulo
            Datos.Eliminar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Activar(Id As Integer) As Boolean
        Try
            Dim Datos As New DatosArticulo
            Datos.Activar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Desactivar(Id As Integer) As Boolean
        Try
            Dim Datos As New DatosArticulo
            Datos.Desactivar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
