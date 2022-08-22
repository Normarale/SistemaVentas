Public Class FrmVentas
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
        DgvDetalle.Columns(3).HeaderText = "STOCK"
        DgvDetalle.Columns(3).Width = 100
        DgvDetalle.Columns(4).HeaderText = "CANTIDAD"
        DgvDetalle.Columns(4).Width = 100
        DgvDetalle.Columns(5).HeaderText = "PRECIO"
        DgvDetalle.Columns(5).Width = 100
        DgvDetalle.Columns(6).HeaderText = "DESCUENTO"
        DgvDetalle.Columns(6).Width = 100
        DgvDetalle.Columns(7).HeaderText = "IMPORTE"
        DgvDetalle.Columns(7).Width = 120

        DgvDetalle.Columns(1).ReadOnly = True
        DgvDetalle.Columns(2).ReadOnly = True
        DgvDetalle.Columns(3).ReadOnly = True
        DgvDetalle.Columns(7).ReadOnly = True
    End Sub



#End Region
    Private Sub Listar()
        Try
            Dim NegVenta As New Negocio.NegocioVenta
            DgvListado.DataSource = NegVenta.Listar()
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
            Dim NegVenta As New Negocio.NegocioVenta
            Dim Valor As String
            Valor = TxtBusca.Text
            DgvListado.DataSource = NegVenta.Buscar(Valor)
            Me.Formato()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Limpiar()
        BtnGrabar.Visible = True
        BtnActualizar.Visible = False
        TxtId.Text = ""
        TxtIdCliente.Text = ""
        TxtNombreCliente.Text = ""
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
        Me.Detalle.Columns.Add("stock", System.Type.GetType("System.Int32"))
        Me.Detalle.Columns.Add("cantidad", System.Type.GetType("System.Int32"))
        Me.Detalle.Columns.Add("precio", System.Type.GetType("System.Decimal"))
        Me.Detalle.Columns.Add("descuento", System.Type.GetType("System.Decimal"))
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
            Row("stock") = Convert.ToString(Filas.Stock)
            Row("cantidad") = Convert.ToString(1)
            Row("precio") = Convert.ToString(Filas.PrecioVenta)
            Row("descuento") = Convert.ToString(0)
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


    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.Buscar()
    End Sub

    Private Sub BtnBuscarCliente_Click(sender As Object, e As EventArgs) Handles BtnBuscarCliente.Click
        FrmClienteVenta.ShowDialog()
        TxtIdCliente.Text = Variables.IdCliente
        TxtNombreCliente.Text = Variables.NombreCliente
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
            DgvArticuloManual.DataSource = NegArticulo.BuscarVenta(Valor)
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
            Obj.Stock = DgvArticuloManual.Item("stock", DgvArticuloManual.CurrentRow.Index).Value

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
        Dim Descuento As Decimal = fila.Cells("descuento").Value
        Dim Stock As Integer = fila.Cells("stock").Value
        Dim Articulo As String = fila.Cells("articulo").Value

        If (Cantidad > Stock) Then
            Cantidad = Stock
            MsgBox("La Cantidad a vender del artículo " & Articulo & " supera la cantidad existente", MsgBoxStyle.Critical, "Error Cantidad")
        End If

        fila.Cells("cantidad").Value = Cantidad
        fila.Cells("importe").Value = (Precio * Cantidad) - Descuento

        Me.CalcularTotales()

    End Sub

    Private Sub DgvDetalle_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DgvDetalle.RowsRemoved
        Me.CalcularTotales()
    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
        Try
            If (TxtIdCliente.Text <> "" And CmbComprobante.Text <> "" And TxtSerie.Text <> "" And TxtNumComprobante.Text <> "" And DgvDetalle.Rows.Count > 0) Then
                Dim ObjVenta As New Entidades.Ventas
                Dim NegVenta As New Negocio.NegocioVenta

                ObjVenta.IdUsuario = Variables.IdUsuario
                ObjVenta.IdCliente = TxtIdCliente.Text
                ObjVenta.TipoComprobante = CmbComprobante.Text
                ObjVenta.SerieComprobante = TxtSerie.Text
                ObjVenta.NumComprobante = TxtNumComprobante.Text
                ObjVenta.Impuesto = TxtImpuesto.Text
                ObjVenta.Total = TxtTotal.Text


                If (NegVenta.Insertar(ObjVenta, Detalle)) Then
                    MsgBox("Las Ventas se registraron correctamente", MsgBoxStyle.Information, "Registro Correcto")
                    Me.Listar()
                Else
                    MsgBox("No se han podrido registrar las Ventas", MsgBoxStyle.Critical, "Error registración")
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
            Dim Negventa As New Negocio.NegocioVenta
            DgvMostrar.DataSource = Negventa.ListarDetalle(DgvListado.Item("ID", DgvListado.CurrentRow.Index).Value)
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
        If (MsgBox("Está seguro de Anular las Ventas seleccionados?...", vbYesNo + vbQuestion, "Anular...") = vbYes) Then
            Try
                Dim NegVenta As New Negocio.NegocioVenta
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim Marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If Marcado Then
                        Dim NumeroId As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        NegVenta.Anular(NumeroId)
                    End If
                Next
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub FrmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
        Me.CrearTablaDetalle()
    End Sub

    Private Sub TxtBuscarManual_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBuscarManual.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Try
                Dim NegArticulo As New Negocio.NegocioArticulo
                Dim Obj As New Entidades.Articulo
                Obj = NegArticulo.BuscarArticuloVenta(TxtArticulo.Text)
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

    Private Sub BtnReporteVenta_Click(sender As Object, e As EventArgs) Handles BtnReporteVenta.Click
        Try
            Variables.IdVenta = DgvListado.Item("ID", DgvListado.CurrentRow.Index).Value
            FrmReporteComprobanteVenta.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        FrmReporteComprobanteVenta.ShowDialog()
    End Sub
End Class