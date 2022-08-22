Public Class FrmIngreso

    Private Detalle As New DataTable

#Region "Formato gridView"
    Public Sub Formato()
        DgvListado.Columns(0).Visible = False
        DgvListado.Columns(2).Visible = False
        DgvListado.Columns(0).Width = 100
        DgvListado.Columns(1).Width = 60
        DgvListado.Columns(3).Width = 150
        DgvListado.Columns(4).Width = 150
        DgvListado.Columns(5).Width = 100
        DgvListado.Columns(6).Width = 70
        DgvListado.Columns(7).Width = 200
        DgvListado.Columns(8).Width = 60
        DgvListado.Columns(9).Width = 100
        DgvListado.Columns(10).Width = 100
        DgvListado.Columns(11).Width = 100

        DgvListado.Columns.Item("Seleccionar").Visible = False
        BtnAnular.Visible = False
        ChkSeleccionar.CheckState = False
    End Sub
#End Region


#Region "Formato Detalle"
    Public Sub FormatoDetalle()

        DgvDetalle.Columns(0).Visible = False
        DgvDetalle.Columns(1).HeaderText = "CÓDIGO"
        DgvDetalle.Columns(1).Width = 100
        DgvDetalle.Columns(2).HeaderText = "ARTÍCULO"
        DgvDetalle.Columns(2).Width = 200
        DgvDetalle.Columns(3).HeaderText = "CANTIDAD"
        DgvDetalle.Columns(3).Width = 100
        DgvDetalle.Columns(4).HeaderText = "PRECIO"
        DgvDetalle.Columns(4).Width = 120
        DgvDetalle.Columns(5).HeaderText = "IMPORTE"
        DgvDetalle.Columns(5).Width = 120

        DgvDetalle.Columns(1).ReadOnly = True
        DgvDetalle.Columns(2).ReadOnly = True
        DgvDetalle.Columns(5).ReadOnly = True
    End Sub



#End Region
    Private Sub Listar()
        Try
            Dim NegIngreso As New Negocio.NegocioIngreso
            DgvListado.DataSource = NegIngreso.Listar()
            LblTotalregistros.Text = "Total de registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


#Region "Formato Artículos"
    Public Sub FormatoArtículos()
        DgvArticuloManual.Columns(0).Visible = False
        DgvArticuloManual.Columns(1).Visible = False
        DgvArticuloManual.Columns(2).Width = 100
        DgvArticuloManual.Columns(3).Width = 100
        DgvArticuloManual.Columns(4).Width = 150
        DgvArticuloManual.Columns(5).Width = 100
        DgvArticuloManual.Columns(6).Width = 100
        DgvArticuloManual.Columns(7).Width = 200
        DgvArticuloManual.Columns(8).Width = 100
        DgvArticuloManual.Columns(9).Width = 100

    End Sub



#End Region


    Private Sub Buscar()
        Try
            Dim NegIngreso As New Negocio.NegocioIngreso
            Dim Valor As String
            Valor = TxtBusca.Text
            DgvListado.DataSource = NegIngreso.Buscar(Valor)
            Me.Formato()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Limpiar()
        BtnGrabar.Visible = True
        BtnActualizar.Visible = False
        TxtId.Text = ""
        TxtIdProveedor.Text = ""
        TxtNombreProveedor.Text = ""
        CmbComprobante.Text = ""
        TxtSerie.Text = ""
        TxtNumComprobante.Text = ""
        Detalle.Clear()
        TxtSubtotal.Text = 0
        TxtTotalImpuesto.Text = 0
        TxtTotal.Text = 0

    End Sub



    Private Sub CrearTablaDetalle()
        Me.Detalle = New DataTable("Detalle")
        Me.Detalle.Columns.Add("idarticulo", System.Type.GetType("System.Int32"))
        Me.Detalle.Columns.Add("codigo", System.Type.GetType("System.String"))
        Me.Detalle.Columns.Add("articulo", System.Type.GetType("System.String"))
        Me.Detalle.Columns.Add("cantidad", System.Type.GetType("System.Int32"))
        Me.Detalle.Columns.Add("precio", System.Type.GetType("System.Decimal"))
        Me.Detalle.Columns.Add("Importe", System.Type.GetType("System.Decimal"))

        DgvDetalle.DataSource = Me.Detalle
        Me.FormatoDetalle()

    End Sub

    Public Sub AgregarDetalle(Filas As Entidades.Articulo)
        Dim Agregar As Boolean = True

        For Each FilaTemp As DataGridViewRow In DgvDetalle.Rows
            If (Convert.ToInt32(FilaTemp.Cells("idarticulo").Value = Convert.ToInt32(Filas.IdArticulo))) Then
                Agregar = False
                MsgBox("El artículo ya fue agregado", vbOKOnly + vbCritical, "Articulo Duplicado")
            End If
        Next

        If (Agregar) Then
            Dim Row As DataRow
            Row = Detalle.NewRow 'creamos una nueva fila de ese detalle
            Row("idarticulo") = Convert.ToString(Filas.IdArticulo)
            Row("codigo") = Convert.ToString(Filas.Codigo)
            Row("articulo") = Convert.ToString(Filas.Nombre)
            Row("cantidad") = Convert.ToString(1)
            Row("precio") = Convert.ToString(Filas.PrecioVenta)
            Row("importe") = Convert.ToString(Filas.PrecioVenta)
            Me.Detalle.Rows.Add(Row)
            Me.CalcularTotales()
        End If
    End Sub


    Private Sub CalcularTotales()
        Dim Total As Decimal = 0
        Dim SubTotal As Decimal = 0
        Dim TotalImpuesto As Decimal = 0
        For Each FilaTemp As DataGridViewRow In DgvDetalle.Rows
            Total = Total + CDec(FilaTemp.Cells("importe").Value)

        Next
        TotalImpuesto = Math.Round((Total * (TxtImpuesto.Text) / 100), 2)
        SubTotal = (Total - TotalImpuesto)
        TxtSubtotal.Text = SubTotal
        TxtTotal.Text = Total
        TxtTotalImpuesto.Text = TotalImpuesto
    End Sub
    Private Sub FrmIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
        Me.CrearTablaDetalle()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.Buscar()
    End Sub

    Private Sub BtnBuscarProveedor_Click(sender As Object, e As EventArgs) Handles BtnBuscarProveedor.Click
        FrmProveedorIngresos.ShowDialog()
        TxtIdProveedor.Text = Variables.IdProveedor
        TxtNombreProveedor.Text = Variables.Nombre
    End Sub

    Private Sub TxtArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtArticulo.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Try
                Dim NegArticulo As New Negocio.NegocioArticulo
                Dim Obj As New Entidades.Articulo
                Obj = NegArticulo.BuscarArticulo(TxtArticulo.Text)
                If (Obj Is Nothing) Then
                    MsgBox("No Existe el Artículo con ese Código de Barras....", vbOKOnly + vbCritical, "Código No Existente")
                Else
                    Me.AgregarDetalle(Obj)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnBuscarArticulo_Click(sender As Object, e As EventArgs) Handles BtnBuscarArticulo.Click
        PanelArticulos.Visible = True
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        PanelArticulos.Visible = False

    End Sub

    Private Sub BtnBuscarManual_Click(sender As Object, e As EventArgs) Handles BtnBuscarManual.Click
        Try
            Dim NegArticulo As New Negocio.NegocioArticulo
            Dim Valor As String
            Valor = TxtBuscarManual.Text
            DgvArticuloManual.DataSource = NegArticulo.Buscar(Valor)
            LblTotalesManual.Text = "Total de registros: " & DgvArticuloManual.DataSource.Rows.Count
            Me.FormatoArtículos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub DgvArticuloManual_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvArticuloManual.CellDoubleClick
        Try
            Dim Obj As New Entidades.Articulo
            Obj.IdArticulo = DgvArticuloManual.Item("ID", DgvArticuloManual.CurrentRow.Index).Value
            Obj.Codigo = DgvArticuloManual.Item("Codigo", DgvArticuloManual.CurrentRow.Index).Value
            Obj.Nombre = DgvArticuloManual.Item("Nombre", DgvArticuloManual.CurrentRow.Index).Value
            Obj.PrecioVenta = DgvArticuloManual.Item("Precio_Venta", DgvArticuloManual.CurrentRow.Index).Value
            Me.AgregarDetalle(Obj)
            'PanelArticulos.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DgvDetalle_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDetalle.CellEndEdit
        Dim fila As DataGridViewRow = CType(DgvDetalle.Rows(e.RowIndex), DataGridViewRow)
        Dim Precio As Decimal = fila.Cells("precio").Value
        Dim Cantidad As Integer = fila.Cells("cantidad").Value
        fila.Cells("importe").Value = Precio * Cantidad
        Me.CalcularTotales()

    End Sub

    Private Sub DgvDetalle_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DgvDetalle.RowsRemoved
        Me.CalcularTotales()
    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
        Try
            If (TxtIdProveedor.Text <> "" And CmbComprobante.Text <> "" And TxtSerie.Text <> "" And TxtNumComprobante.Text <> "" And DgvDetalle.Rows.Count > 0) Then
                Dim ObjIngreso As New Entidades.Ingresos
                Dim NegIngreso As New Negocio.NegocioIngreso

                ObjIngreso.IdUsuario = Variables.IdUsuario
                ObjIngreso.IdProveedor = TxtIdProveedor.Text
                ObjIngreso.TipoComprobante = CmbComprobante.Text
                ObjIngreso.SerieComprobante = TxtSerie.Text
                ObjIngreso.NumComprobante = TxtNumComprobante.Text
                ObjIngreso.Impuesto = TxtImpuesto.Text
                ObjIngreso.Total = TxtTotal.Text


                If (NegIngreso.Insertar(ObjIngreso, Detalle)) Then
                    MsgBox("Las compras se registraron correctamente", MsgBoxStyle.Information, "Registro Correcto")
                    Me.Listar()
                Else
                    MsgBox("No se han podrido registrar las compras", MsgBoxStyle.Critical, "Erro registración")
                End If
            Else
                MsgBox("Faltan de rellenar campos (*)... agregue al menos un detalle", MsgBoxStyle.Exclamation, "Completar Campos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnCerrarMostrar_Click(sender As Object, e As EventArgs) Handles BtnCerrarMostrar.Click
        PanelMostrar.Visible = False

    End Sub

    Private Sub DgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellDoubleClick
        Try
            Dim NegIngreso As New Negocio.NegocioIngreso
            DgvMostrar.DataSource = NegIngreso.ListarDetalle(DgvListado.Item("ID", DgvListado.CurrentRow.Index).Value)
            Dim Tot As Decimal = 0
            Dim SubTot As Decimal = 0
            Dim Impuesto As Decimal = 0
            Tot = DgvListado.Item("Total", DgvListado.CurrentRow.Index).Value
            Impuesto = Math.Round((Tot * (DgvListado.Item("impuesto", DgvListado.CurrentRow.Index).Value / 100)), 2)
            SubTot = Tot - Impuesto

            TxtMostrarTotal.Text = Tot
            TxtMostrarSubTot.Text = SubTot
            TxtMostrarTotImp.Text = Impuesto
            PanelMostrar.Visible = True



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Limpiar()
        TabGeneral.SelectedIndex = 0
    End Sub



    Private Sub ChkSeleccionar_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSeleccionar.CheckedChanged
        If ChkSeleccionar.CheckState = CheckState.Checked Then
            DgvListado.Columns.Item("Seleccionar").Visible = True
            BtnAnular.Visible = True
        Else
            DgvListado.Columns.Item("Seleccionar").Visible = False
            BtnAnular.Visible = False
        End If
    End Sub

    Private Sub DgvListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellContentClick
        If e.ColumnIndex = DgvListado.Columns.Item("Seleccionar").Index Then
            Dim checkcell As DataGridViewCheckBoxCell = DgvListado.Rows(e.RowIndex).Cells("Seleccionar")
            checkcell.Value = Not checkcell.Value
        End If
    End Sub

    Private Sub BtnAnular_Click(sender As Object, e As EventArgs) Handles BtnAnular.Click
        If (MsgBox("Está seguro de Anular los Ingresos seleccionados?...", vbYesNo + vbQuestion, "Anular...") = vbYes) Then
            Try
                Dim NegIngresos As New Negocio.NegocioIngreso
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim Marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If Marcado Then
                        Dim NumeroId As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        NegIngresos.Anular(NumeroId)
                    End If
                Next
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class