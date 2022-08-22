Public Class FrmCategoria
#Region "Formato gridView"
    Public Sub Formato()
        DgvListadoCategoria.Columns(0).Visible = False
        DgvListadoCategoria.Columns(0).Width = 100
        DgvListadoCategoria.Columns(1).Width = 100
        DgvListadoCategoria.Columns(2).Width = 150
        DgvListadoCategoria.Columns(3).Width = 400
        DgvListadoCategoria.Columns(4).Width = 100
        DgvListadoCategoria.Columns.Item("Seleccionar").Visible = False
        BtnEliminar.Visible = False
        BtnActivar.Visible = False
        BtnDesactivar.Visible = False
        ChkSeleccionar.CheckState = False
    End Sub
#End Region

    Private Sub Listar()
        Try
            Dim Negcategoria As New Negocio.NegocioCategoria
            DgvListadoCategoria.DataSource = negCategoria.Listar()
            LblTotalregistros.Text = "Total de registros: " & DgvListadoCategoria.DataSource.Rows.Count
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
            Valor = TxtBuscaCategoria.Text
            DgvListadoCategoria.DataSource = Negcategoria.Buscar(Valor)
            Me.Formato()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Limpiar()
        BtnGrabar.Visible = True
        BtnActualizar.Visible = False
        TxtNombre.Text = ""
        TxtDescripcion.Text = ""
        TxtId.Text = ""
    End Sub


    Private Sub FrmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()

    End Sub

    Private Sub BtnBuscaCategoria_Click(sender As Object, e As EventArgs) Handles BtnBuscaCategoria.Click
        Me.Buscar()

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Limpiar()
        TabGeneral.SelectedIndex = 0

    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
        If Me.ValidateChildren = True And TxtNombre.Text <> "" Then
            Dim ObjCategorias As New Entidades.Categoria
            Dim Negcategoria As New Negocio.NegocioCategoria
            ObjCategorias.Nombre = TxtNombre.Text
            ObjCategorias.Descripcion = TxtDescripcion.Text
            If (Negcategoria.Insertar(ObjCategorias)) Then
                MsgBox("La Categoría se grabó correctamente", MsgBoxStyle.Information, "Datos Ingresados")
                Me.Listar()
            Else
                MsgBox("No se pudo registrar la categoría", MsgBoxStyle.Critical, "ERROR..")
            End If

        Else
            MsgBox("Complete los datos ...", MsgBoxStyle.Exclamation, "COMPLETAR...")
        End If
    End Sub


    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If Me.ValidateChildren = True And TxtId.Text <> "" And TxtNombre.Text <> "" Then
            Dim ObjCategorias As New Entidades.Categoria
            Dim Negcategoria As New Negocio.NegocioCategoria
            ObjCategorias.IdCategoria = TxtId.Text
            ObjCategorias.Nombre = TxtNombre.Text
            ObjCategorias.Descripcion = TxtDescripcion.Text
            If (Negcategoria.Actualizar(ObjCategorias)) Then
                MsgBox("La Categoría se actualizó correctamente", MsgBoxStyle.Information, "Datos Actualizados")
                Me.Listar()
                TabGeneral.SelectedIndex = 0
            Else
                MsgBox("No se pudo actualizar la categoría", MsgBoxStyle.Critical, "ERROR..")
            End If

        Else
            MsgBox("Complete los datos ...", MsgBoxStyle.Exclamation, "COMPLETAR...")
        End If
    End Sub



    Private Sub TxtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el Nombre de la Categoría")
        End If
    End Sub

    Private Sub DgvListadoCategoria_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListadoCategoria.CellDoubleClick
        TxtId.Text = DgvListadoCategoria.Item("ID", DgvListadoCategoria.CurrentRow.Index).Value
        TxtNombre.Text = DgvListadoCategoria.Item("Nombre", DgvListadoCategoria.CurrentRow.Index).Value
        TxtDescripcion.Text = DgvListadoCategoria.Item("Descripcion", DgvListadoCategoria.CurrentRow.Index).Value
        BtnActualizar.Visible = True
        BtnGrabar.Visible = False
        TabGeneral.SelectedIndex = 1
    End Sub

    Private Sub ChkSeleccionar_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSeleccionar.CheckedChanged
        If ChkSeleccionar.CheckState = CheckState.Checked Then
            DgvListadoCategoria.Columns.Item("Seleccionar").Visible = True
            BtnEliminar.Visible = True
            BtnActivar.Visible = True
            BtnDesactivar.Visible = True
        Else
            DgvListadoCategoria.Columns.Item("Seleccionar").Visible = False
            BtnEliminar.Visible = False
            BtnActivar.Visible = False
            BtnDesactivar.Visible = False
        End If
    End Sub

    Private Sub DgvListadoCategoria_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListadoCategoria.CellContentClick
        If e.ColumnIndex = DgvListadoCategoria.Columns.Item("Seleccionar").Index Then
            Dim checkcell As DataGridViewCheckBoxCell = DgvListadoCategoria.Rows(e.RowIndex).Cells("Seleccionar")
            checkcell.Value = Not checkcell.Value
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If (MsgBox("Está seguro de Eliminar los Registros seleccionados?...", vbYesNo + vbQuestion, "Acciones...") = vbYes) Then
            Try
                Dim NegCategoria As New Negocio.NegocioCategoria
                For Each row As DataGridViewRow In DgvListadoCategoria.Rows
                    Dim Marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If Marcado Then
                        Dim NumeroId As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        NegCategoria.Eliminar(NumeroId)
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
                Dim NegCategoria As New Negocio.NegocioCategoria
                For Each row As DataGridViewRow In DgvListadoCategoria.Rows
                    Dim Marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If Marcado Then
                        Dim NumeroId As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        NegCategoria.Activar(NumeroId)
                    End If
                Next
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnDesactivar_Click(sender As Object, e As EventArgs) Handles BtnDesactivar.Click
        If (MsgBox("Está seguro de Desactivar los Registros seleccionados?...", vbYesNo + vbQuestion, "Desactivar...") = vbYes) Then
            Try
                Dim NegCategoria As New Negocio.NegocioCategoria
                For Each row As DataGridViewRow In DgvListadoCategoria.Rows
                    Dim Marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If Marcado Then
                        Dim NumeroId As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        NegCategoria.Desactivar(NumeroId)
                    End If
                Next
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class