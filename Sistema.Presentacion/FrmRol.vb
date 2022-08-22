Public Class FrmRol

#Region "Formato gridView"
    Public Sub Formato()

        DgvListado.Columns(0).Width = 100
        DgvListado.Columns(1).Width = 100
        DgvListado.Columns(0).HeaderText = "ID"
        DgvListado.Columns(1).HeaderText = "Nombre"


    End Sub
#End Region

    Private Sub Listar()
        Try
            Dim NegRol As New Negocio.NegocioRol
            DgvListado.DataSource = NegRol.Listar()
            LblTotalRegistros.Text = "Total de registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub FrmRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
    End Sub
End Class