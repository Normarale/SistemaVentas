Public Class FrmUsuarios

#Region "Formato gridView"
    Public Sub Formato()
        DgvListado.Columns(0).Visible = False
        DgvListado.Columns(2).Visible = False
        DgvListado.Columns(0).Width = 100
        DgvListado.Columns(1).Width = 80
        DgvListado.Columns(3).Width = 120
        DgvListado.Columns(4).Width = 120
        DgvListado.Columns(5).Width = 100
        DgvListado.Columns(6).Width = 100
        DgvListado.Columns(7).Width = 120
        DgvListado.Columns(8).Width = 100
        DgvListado.Columns(9).Width = 120
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
            Dim NegUsuario As New Negocio.NegocioUsuario
            DgvListado.DataSource = NegUsuario.Listar()
            LblTotalregistros.Text = "Total de registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Buscar()
        Try
            Dim NegUsuario As New Negocio.NegocioUsuario
            Dim Valor As String
            Valor = TxtBusca.Text
            DgvListado.DataSource = NegUsuario.Buscar(Valor)
            Me.Formato()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Limpiar()
        BtnGrabar.Visible = True
        BtnActualizar.Visible = False
        TxtClave.Text = ""
        TxtNombre.Text = ""
        TxtNumDocumento.Text = ""
        TxtDireccion.Text = ""
        TxtNumDocumento.Text = ""
        TxtTelefono.Text = ""
        TxtId.Text = ""
        TxtEmail.Text = ""
        TxtClave.Text = ""
        CmbRol.SelectedIndex = -1
        CmbTipo.SelectedIndex = -1
    End Sub

    Private Sub CargarRol()
        Try
            Dim NegRol As New Negocio.NegocioRol
            CmbRol.DataSource = NegRol.Listar()
            CmbRol.ValueMember = "idrol"
            CmbRol.DisplayMember = "nombre"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarRol()
        Me.Listar()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.Buscar()
    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
        Try
            If (Me.ValidateChildren = True And CmbRol.Text <> "" And TxtNombre.Text <> "" And TxtEmail.Text <> "" And TxtClave.Text <> "") Then
                Dim ObjUsuario As New Entidades.Usuario
                Dim NegUsuario As New Negocio.NegocioUsuario
                ObjUsuario.IdRol = CmbRol.SelectedValue
                ObjUsuario.Nombre = TxtNombre.Text
                ObjUsuario.TipoDocumento = CmbTipo.Text
                ObjUsuario.Direccion = TxtDireccion.Text
                ObjUsuario.Telefono = TxtTelefono.Text
                ObjUsuario.Email = TxtEmail.Text
                ObjUsuario.Clave = TxtClave.Text
                ObjUsuario.NumDocumento = TxtNumDocumento.Text
                If (NegUsuario.Insertar(ObjUsuario)) Then
                    MsgBox("El Usuario se grabó correctamente", MsgBoxStyle.Information, "Datos Ingresados")

                    Me.Listar()
                Else
                    MsgBox("No se pudo registrar el Usuario", MsgBoxStyle.Critical, "ERROR..")
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

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            If (Me.ValidateChildren = True And CmbRol.Text <> "" And TxtNombre.Text <> "" And TxtEmail.Text <> "" And TxtId.Text <> "") Then
                Dim ObjUsuario As New Entidades.Usuario
                Dim NegUsuario As New Negocio.NegocioUsuario
                ObjUsuario.IdUsuario = TxtId.Text
                ObjUsuario.IdRol = CmbRol.SelectedValue
                ObjUsuario.Nombre = TxtNombre.Text
                ObjUsuario.TipoDocumento = CmbTipo.Text
                ObjUsuario.Direccion = TxtDireccion.Text
                ObjUsuario.Telefono = TxtTelefono.Text
                ObjUsuario.Email = TxtEmail.Text
                ObjUsuario.Clave = TxtClave.Text
                ObjUsuario.NumDocumento = TxtNumDocumento.Text
                If (NegUsuario.Actualizar(ObjUsuario)) Then
                    MsgBox("El Usuario se actualizó correctamente", MsgBoxStyle.Information, "Datos Actualizados")

                    Me.Listar()
                Else
                    MsgBox("No se pudo actualizar el Usuario", MsgBoxStyle.Critical, "ERROR..")
                End If

            Else
                MsgBox("Complete los datos ...", MsgBoxStyle.Exclamation, "COMPLETAR...")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub DgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellDoubleClick
        Try
            TxtId.Text = DgvListado.Item("ID", DgvListado.CurrentRow.Index).Value
            CmbRol.Text = DgvListado.Item("Rol", DgvListado.CurrentRow.Index).Value
            TxtNombre.Text = DgvListado.Item("Nombre", DgvListado.CurrentRow.Index).Value
            CmbTipo.Text = DgvListado.Item("Tipo_Documento", DgvListado.CurrentRow.Index).Value
            TxtNumDocumento.Text = DgvListado.Item("Num_Documento", DgvListado.CurrentRow.Index).Value
            TxtDireccion.Text = DgvListado.Item("Direccion", DgvListado.CurrentRow.Index).Value
            TxtTelefono.Text = DgvListado.Item("Telefono", DgvListado.CurrentRow.Index).Value
            TxtEmail.Text = DgvListado.Item("Email", DgvListado.CurrentRow.Index).Value
            BtnActualizar.Visible = True
            BtnGrabar.Visible = False
            TabGeneral.SelectedIndex = 1
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
        If (DgvListado.Item("Seleccionar", DgvListado.CurrentRow.Index)).Value Then
            If (MsgBox("Está seguro de Eliminar los Registros seleccionados?...", vbYesNo + vbQuestion, "Acciones...") = vbYes) Then
                Try

                    Dim NegUsuario As New Negocio.NegocioUsuario
                    For Each row As DataGridViewRow In DgvListado.Rows
                        Dim Marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                        If Marcado Then
                            Dim NumeroId As Integer = Convert.ToInt32(row.Cells("ID").Value)

                            NegUsuario.Eliminar(NumeroId)

                        End If
                    Next
                    Me.Listar()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Else
            MsgBox("Debe Seleccionar el/los Registros a Eliminar...")
        End If

    End Sub

    Private Sub BtnActivar_Click(sender As Object, e As EventArgs) Handles BtnActivar.Click
        If (DgvListado.Item("Seleccionar", DgvListado.CurrentRow.Index)).Value Then
            If (MsgBox("Está seguro de Activar los Registros seleccionados?...", vbYesNo + vbQuestion, "Activar...") = vbYes) Then
                Try
                    Dim NegUsuario As New Negocio.NegocioUsuario
                    For Each row As DataGridViewRow In DgvListado.Rows
                        Dim Marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                        If Marcado Then
                            Dim NumeroId As Integer = Convert.ToInt32(row.Cells("ID").Value)
                            NegUsuario.Activar(NumeroId)
                        End If
                    Next
                    Me.Listar()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Else
            MsgBox("Debe seleccionar los Registros a Activar...")
        End if
    End Sub

    Private Sub BtnDesactivar_Click(sender As Object, e As EventArgs) Handles BtnDesactivar.Click
        If (DgvListado.Item("Seleccionar", DgvListado.CurrentRow.Index)).Value Then
            If (MsgBox("Está seguro de Desactivar los Registros seleccionados?...", vbYesNo + vbQuestion, "Activar...") = vbYes) Then
                Try

                    Dim NegUsuario As New Negocio.NegocioUsuario
                    For Each row As DataGridViewRow In DgvListado.Rows
                        Dim Marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                        If Marcado Then
                            Dim NumeroId As Integer = Convert.ToInt32(row.Cells("ID").Value)
                            NegUsuario.Desactivar(NumeroId)
                        End If
                    Next
                    Me.Listar()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Else
            MsgBox("Debe seleccionar el/los registros a desactivar...")
        End If
    End Sub


End Class