<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteArticulos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DsSistema = New Sistema.Presentacion.DsSistema()
        Me.DsSistemaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticulolistarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Articulo_listarTableAdapter = New Sistema.Presentacion.DsSistemaTableAdapters.articulo_listarTableAdapter()
        CType(Me.DsSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSistemaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulolistarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DsArticulos"
        ReportDataSource1.Value = Me.ArticulolistarBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema.Presentacion.RptArticulos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'DsSistema
        '
        Me.DsSistema.DataSetName = "DsSistema"
        Me.DsSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsSistemaBindingSource
        '
        Me.DsSistemaBindingSource.DataSource = Me.DsSistema
        Me.DsSistemaBindingSource.Position = 0
        '
        'ArticulolistarBindingSource
        '
        Me.ArticulolistarBindingSource.DataMember = "articulo_listar"
        Me.ArticulolistarBindingSource.DataSource = Me.DsSistema
        '
        'Articulo_listarTableAdapter
        '
        Me.Articulo_listarTableAdapter.ClearBeforeFill = True
        '
        'FrmReporteArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmReporteArticulos"
        Me.Text = "FrmReporteArticulos"
        CType(Me.DsSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSistemaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulolistarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DsSistema As DsSistema
    Friend WithEvents DsSistemaBindingSource As BindingSource
    Friend WithEvents ArticulolistarBindingSource As BindingSource
    Friend WithEvents Articulo_listarTableAdapter As DsSistemaTableAdapters.articulo_listarTableAdapter
End Class
