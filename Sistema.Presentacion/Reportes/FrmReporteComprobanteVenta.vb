Public Class FrmReporteComprobanteVenta
    Private Sub FrmReporteComprobanteVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsSistema.venta_comprobante' Puede moverla o quitarla según sea necesario.
        Me.Venta_comprobanteTableAdapter.Fill(Me.DsSistema.venta_comprobante, Variables.IdVenta)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class