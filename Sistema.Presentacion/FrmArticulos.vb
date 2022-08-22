Imports System.IO

Public Class FrmArticulos
    Private RutaOrigen As String
    Private RutaDestino As String
    Private Directorio As String = "C:\CURSOS\CURSOS 2022\Udemy\SISTEMA DE VENTAS\Image\"


#Region "Formato gridView"
    Public Sub Formato()
        DgvListado.Columns(0).Visible = False
        DgvListado.Columns(2).Visible = False
        DgvListado.Columns(0).Width = 100
        DgvListado.Columns(1).Width = 100
        DgvListado.Columns(3).Width = 100
        DgvListado.Columns(4).Width = 100
        DgvListado.Columns(5).Width = 150
        DgvListado.Columns(6).Width = 100
        DgvListado.Columns(7).Width = 100
        DgvListado.Columns(8).Width = 200
        DgvListado.Columns(9).Width = 100
        DgvListado.Columns(10).Width = 100

        DgvListado.Columns.Item("Seleccionar").Visible = False
        BtnEliminar.Visible = False
        BtnActivar.Visible = False
        BtnDesactivar.Visible = False
        ChkSeleccionar.CheckState = False
    End Sub
#End Region

    Private Sub Listar()
        Try
            Dim NegArticulo As New Negocio.NegocioArticulo
            DgvListado.DataSource = NegArticulo.Listar()
            LblTotalregistros.Text = "Total de registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Buscar()
        Try
            Dim Negcategoria As New Negocio.NegocioCategoria
            Dim Valor As String
            Valor = TxtBusca.Text
            DgvListado.DataSource = Negcategoria.Buscar(Valor)
            Me.Formato()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Limpiar()
        BtnGrabar.Visible = True
        BtnActualizar.Visible = False
        TxtCodigo.Text = ""
        TxtNombre.Text = ""
        TxtPrecio.Text = ""
        TxtStock.Text = ""
        TxtDescripcion.Text = ""
        TxtImagen.Text = ""
        PicImagen.Image = Nothing
        TxtId.Text = ""
        CmbCategoria.SelectedIndex = -1
        RutaOrigen = ""
    End Sub

    Private Sub CargarCategoria()
        Try
            Dim Neg As New Negocio.NegocioCategoria
            CmbCategoria.DataSource = Neg.Seleccionar
            CmbCategoria.ValueMember = "idcategoria"
            CmbCategoria.DisplayMember = "nombre"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




    Private Sub FrmArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CargarCategoria()
        Me.Listar()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.Buscar()
    End Sub

    Private Sub BtnCargarImagen_Click(sender As Object, e As EventArgs) Handles BtnCargarImagen.Click
        Dim file As New OpenFileDialog 'Instancia de OpenfileDialog
        file.Filter = "Image Files (*.JPG, *.JPEG, *.JPE, *.PNG, *.JFIF) | *.JPG; *.JPEG; *.PNG; *.JFIF"
        If file.ShowDialog() = DialogResult.OK Then
            PicImagen.Image = Image.FromFile(file.FileName)
            RutaOrigen = file.FileName
            TxtImagen.Text = file.FileName.Substring(file.FileName.LastIndexOf("\") + 1)
        End If

    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
        Try
            If (Me.ValidateChildren = True And CmbCategoria.Text <> "" And TxtNombre.Text <> "" And TxtStock.Text <> "" And TxtPrecio.Text <> "") Then
                Dim ObjArticulo As New Entidades.Articulo
                Dim NegArticulo As New Negocio.NegocioArticulo
                ObjArticulo.IdCategoria = CmbCategoria.SelectedValue
                ObjArticulo.Codigo = TxtCodigo.Text
                ObjArticulo.Nombre = TxtNombre.Text
                ObjArticulo.Stock = TxtStock.Text
                ObjArticulo.PrecioVenta = TxtPrecio.Text
                ObjArticulo.Descripcion = TxtDescripcion.Text
                ObjArticulo.Imagen = TxtImagen.Text
                If (NegArticulo.Insertar(ObjArticulo)) Then
                    MsgBox("El Artículo se grabó correctamente", MsgBoxStyle.Information, "Datos Ingresados")
                    If TxtImagen.Text <> "" Then
                        RutaDestino = Directorio & TxtImagen.Text
                        FileCopy(RutaOrigen, RutaDestino)
                    End If
                    Me.Listar()
                Else
                    MsgBox("No se pudo registrar el artículo", MsgBoxStyle.Critical, "ERROR..")
                End If

            Else
                MsgBox("Complete los datos ...", MsgBoxStyle.Exclamation, "COMPLETAR...")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Limpiar()
        TabGeneral.SelectedIndex = 0
    End Sub

    Private Sub DgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellDoubleClick
        Try
            TxtId.Text = DgvListado.Item("ID", DgvListado.CurrentRow.Index).Value
            CmbCategoria.Text = DgvListado.Item("Categoria", DgvListado.CurrentRow.Index).Value
            TxtCodigo.Text = DgvListado.Item("Codigo", DgvListado.CurrentRow.Index).Value
            TxtNombre.Text = DgvListado.Item("Nombre", DgvListado.CurrentRow.Index).Value
            TxtPrecio.Text = DgvListado.Item("Precio_venta", DgvListado.CurrentRow.Index).Value
            TxtStock.Text = DgvListado.Item("Stock", DgvListado.CurrentRow.Index).Value
            TxtDescripcion.Text = DgvListado.Item("Descripcion", DgvListado.CurrentRow.Index).Value
            Dim imagen As String
            imagen = DgvListado.Item("Imagen", DgvListado.CurrentRow.Index).Value
            If (imagen <> "") Then
                PicImagen.Image = Image.FromFile(Directorio & imagen)
                TxtImagen.Text = imagen
            Else
                PicImagen.Image = Nothing
                TxtImagen.Text = ""
            End If
            BtnActualizar.Visible = True
            BtnGrabar.Visible = False
            TabGeneral.SelectedIndex = 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            If (Me.ValidateChildren = True And TxtId.Text <> "" And CmbCategoria.Text <> "" And TxtNombre.Text <> "" And TxtStock.Text <> "" And TxtPrecio.Text <> "") Then
                Dim ObjArticulo As New Entidades.Articulo
                Dim NegArticulo As New Negocio.NegocioArticulo
                ObjArticulo.IdArticulo = TxtId.Text
                ObjArticulo.IdCategoria = CmbCategoria.SelectedValue
                ObjArticulo.Codigo = TxtCodigo.Text
                ObjArticulo.Nombre = TxtNombre.Text
                ObjArticulo.Stock = TxtStock.Text
                ObjArticulo.PrecioVenta = TxtPrecio.Text
                ObjArticulo.Descripcion = TxtDescripcion.Text
                ObjArticulo.Imagen = TxtImagen.Text
                If (NegArticulo.Actualizar(ObjArticulo)) Then
                    MsgBox("El Artículo se actualizó correctamente", MsgBoxStyle.Information, "Datos Ingresados")
                    If (TxtImagen.Text <> "" And RutaOrigen <> "") Then
                        RutaDestino = Directorio & TxtImagen.Text
                        FileCopy(RutaOrigen, RutaDestino)
                    End If
                    Me.Listar()
                Else
                    MsgBox("No se pudo actualizar el artículo", MsgBoxStyle.Critical, "ERROR..")
                End If

            Else
                MsgBox("Complete los datos ...", MsgBoxStyle.Exclamation, "COMPLETAR...")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DgvListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellContentClick
        If e.ColumnIndex = DgvListado.Columns.Item("Seleccionar").Index Then
            Dim checkcell As DataGridViewCheckBoxCell = DgvListado.Rows(e.RowIndex).Cells("Seleccionar")
            checkcell.Value = Not checkcell.Value
        End If
    End Sub

    Private Sub ChkSeleccionar_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSeleccionar.CheckedChanged
        If ChkSeleccionar.CheckState = CheckState.Checked Then
            DgvListado.Columns.Item("Seleccionar").Visible = True
            BtnEliminar.Visible = True
            BtnActivar.Visible = True
            BtnDesactivar.Visible = True
        Else
            DgvListado.Columns.Item("Seleccionar").Visible = False
            BtnEliminar.Visible = False
            BtnActivar.Visible = False
            BtnDesactivar.Visible = False
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If (MsgBox("Está seguro de Eliminar los Registros seleccionados?...", vbYesNo + vbQuestion, "Acciones...") = vbYes) Then
            Try
                Dim NegArticulo As New Negocio.NegocioArticulo
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim Marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If Marcado Then
                        Dim NumeroId As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        Dim Imagen As String = Convert.ToString(row.Cells("Imagen").Value)

                        NegArticulo.Eliminar(NumeroId)
                        File.Delete(Directorio & Imagen)
                    End If
                Next
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnActivar_Click(sender As Object, e As EventArgs) Handles BtnActivar.Click
        If (MsgBox("Está seguro de Activar los Registros seleccionados?...", vbYesNo + vbQuestion, "Activar...") = vbYes) Then
            Try
                Dim NegArticulo As New Negocio.NegocioArticulo
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim Marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If Marcado Then
                        Dim NumeroId As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        NegArticulo.Activar(NumeroId)
                    End If
                Next
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnDesactivar_Click(sender As Object, e As EventArgs) Handles BtnDesactivar.Click
        If (MsgBox("Está seguro de Desactivar los Registros seleccionados?...", vbYesNo + vbQuestion, "Activar...") = vbYes) Then
            Try
                Dim NegArticulo As New Negocio.NegocioArticulo
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim Marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If Marcado Then
                        Dim NumeroId As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        NegArticulo.Desactivar(NumeroId)
                    End If
                Next
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        FrmReporteArticulos.ShowDialog()
    End Sub
End Class