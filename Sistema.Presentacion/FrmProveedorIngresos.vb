Public Class FrmProveedorIngresos
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

    End Sub
#End Region

    Private Sub Listar()
        Try
            Dim NegPersona As New Negocio.NegocioPersona
            DgvListado.DataSource = NegPersona.ListarProveedor()
            LblTotalregistros.Text = "Total de registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BuscarProveedor()
        Try
            Dim NegPersona As New Negocio.NegocioPersona
            Dim Valor As String
            Valor = TxtBusca.Text
            DgvListado.DataSource = NegPersona.BuscarProveedor(Valor)
            Me.Formato()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub FrmProveedorIngresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.BuscarProveedor()
    End Sub

    Private Sub DgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellDoubleClick
        Variables.IdProveedor = DgvListado.Item("ID", DgvListado.CurrentRow.Index).Value
        Variables.Nombre = DgvListado.Item("Nombre", DgvListado.CurrentRow.Index).Value
        Me.Close()

    End Sub
End Class