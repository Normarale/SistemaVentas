Public Class FrmReporteArticulos
    Private Sub FrmReporteArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsSistema.articulo_listar' Puede moverla o quitarla según sea necesario.
        Me.Articulo_listarTableAdapter.Fill(Me.DsSistema.articulo_listar)

        Me.ReportViewer1.RefreshReport()

    End Sub
End Class