Public Class FrmCliente
#Region "Formato gridView"
    Public Sub Formato()
        DgvListado.Columns(0).Visible = False
        DgvListado.Columns(0).Width = 100
        DgvListado.Columns(1).Width = 80
        DgvListado.Columns(2).Width = 120
        DgvListado.Columns(3).Width = 120
        DgvListado.Columns(4).Width = 100
        DgvListado.Columns(5).Width = 100
        DgvListado.Columns(6).Width = 120
        DgvListado.Columns(7).Width = 100
        DgvListado.Columns(8).Width = 120


        DgvListado.Columns.Item("Seleccionar").Visible = False
        BtnEliminar.Visible = False
        BtnActivar.Visible = False
        BtnDesactivar.Visible = False
        ChkSeleccionar.CheckState = False
    End Sub
#End Region

    Private Sub Listar()
        Try
            Dim NegPersona As New Negocio.NegocioPersona
            DgvListado.DataSource = NegPersona.ListarCliente()
            LblTotalregistros.Text = "Total de registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BuscarCliente()
        Try
            Dim NegPersona As New Negocio.NegocioPersona
            Dim Valor As String
            Valor = TxtBusca.Text
            DgvListado.DataSource = NegPersona.BuscarCliente(Valor)
            Me.Formato()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Limpiar()
        BtnGrabar.Visible = True
        BtnActualizar.Visible = False
        TxtNombre.Text = ""
        TxtNumDocumento.Text = ""
        TxtDireccion.Text = ""
        TxtTelefono.Text = ""
        TxtId.Text = ""
        TxtEmail.Text = ""
        CmbTipo.SelectedIndex = -1
    End Sub
    Private Sub FrmProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.BuscarCliente()
    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
        Try
            If (Me.ValidateChildren = True And TxtNombre.Text <> "") Then
                Dim ObjCliente As New Entidades.Persona
                Dim NegCliente As New Negocio.NegocioPersona
                ObjCliente.TipoPersona = "Cliente"
                ObjCliente.Nombre = TxtNombre.Text
                ObjCliente.TipoDocumento = CmbTipo.Text
                ObjCliente.Direccion = TxtDireccion.Text
                ObjCliente.Telefono = TxtTelefono.Text
                ObjCliente.Email = TxtEmail.Text
                ObjCliente.NumDocumento = TxtNumDocumento.Text
                If (NegCliente.Insertar(ObjCliente)) Then
                    MsgBox("El Cliente se grabó correctamente", MsgBoxStyle.Information, "Datos Ingresados")

                    Me.Listar()
                Else
                    MsgBox("No se pudo registrar el Cliente", MsgBoxStyle.Critical, "ERROR..")
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

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If (DgvListado.Item("Seleccionar", DgvListado.CurrentRow.Index)).Value Then
            If (MsgBox("Está seguro de Eliminar los Registros seleccionados?...", vbYesNo + vbQuestion, "Acciones...") = vbYes) Then
                Try

                    Dim NegProveedor As New Negocio.NegocioPersona
                    For Each row As DataGridViewRow In DgvListado.Rows
                        Dim Marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                        If Marcado Then
                            Dim NumeroId As Integer = Convert.ToInt32(row.Cells("ID").Value)

                            NegProveedor.Eliminar(NumeroId)

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

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            If (Me.ValidateChildren = True And TxtNombre.Text <> "" And TxtId.Text <> "") Then
                Dim ObjCliente As New Entidades.Persona
                Dim NegCliente As New Negocio.NegocioPersona
                ObjCliente.IdPersona = TxtId.Text
                ObjCliente.Nombre = TxtNombre.Text
                ObjCliente.TipoDocumento = CmbTipo.Text
                ObjCliente.Direccion = TxtDireccion.Text
                ObjCliente.Telefono = TxtTelefono.Text
                ObjCliente.Email = TxtEmail.Text
                ObjCliente.NumDocumento = TxtNumDocumento.Text
                ObjCliente.TipoPersona = "Cliente"
                If (NegCliente.Actualizar(ObjCliente)) Then
                    MsgBox("El Cliente se actualizó correctamente", MsgBoxStyle.Information, "Datos Actualizados")

                    Me.Listar()
                Else
                    MsgBox("No se pudo actualizar el Cliente", MsgBoxStyle.Critical, "ERROR..")
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
            BtnActivar.Visible = False
            BtnDesactivar.Visible = False
        Else
            DgvListado.Columns.Item("Seleccionar").Visible = False
            BtnEliminar.Visible = False
            BtnActivar.Visible = False
            BtnDesactivar.Visible = False
        End If
    End Sub
End Class