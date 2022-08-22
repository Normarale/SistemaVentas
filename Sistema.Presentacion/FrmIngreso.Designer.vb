<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmIngreso
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabGeneral = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnAnular = New System.Windows.Forms.Button()
        Me.PanelMostrar = New System.Windows.Forms.Panel()
        Me.BtnCerrarMostrar = New System.Windows.Forms.Button()
        Me.TxtMostrarTotal = New System.Windows.Forms.TextBox()
        Me.TxtMostrarTotImp = New System.Windows.Forms.TextBox()
        Me.TxtMostrarSubTot = New System.Windows.Forms.TextBox()
        Me.LblMostrarTotal = New System.Windows.Forms.Label()
        Me.LblMostrarImpuesto = New System.Windows.Forms.Label()
        Me.LblMostrarSubtotal = New System.Windows.Forms.Label()
        Me.DgvMostrar = New System.Windows.Forms.DataGridView()
        Me.ChkSeleccionar = New System.Windows.Forms.CheckBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.LblTotalregistros = New System.Windows.Forms.Label()
        Me.TxtBusca = New System.Windows.Forms.TextBox()
        Me.DgvListado = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GbDetalle = New System.Windows.Forms.GroupBox()
        Me.PanelArticulos = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.LblTotalesManual = New System.Windows.Forms.Label()
        Me.DgvArticuloManual = New System.Windows.Forms.DataGridView()
        Me.BtnBuscarManual = New System.Windows.Forms.Button()
        Me.TxtBuscarManual = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBuscarArticulo = New System.Windows.Forms.Button()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtArticulo = New System.Windows.Forms.TextBox()
        Me.LblArticulo = New System.Windows.Forms.Label()
        Me.TxtTotalImpuesto = New System.Windows.Forms.TextBox()
        Me.TxtSubtotal = New System.Windows.Forms.TextBox()
        Me.LblImpuestoTotal = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.LblSubtotal = New System.Windows.Forms.Label()
        Me.DgvDetalle = New System.Windows.Forms.DataGridView()
        Me.GBCabecera = New System.Windows.Forms.GroupBox()
        Me.TxtImpuesto = New System.Windows.Forms.TextBox()
        Me.BtnBuscarProveedor = New System.Windows.Forms.Button()
        Me.LblImpuesto = New System.Windows.Forms.Label()
        Me.TxtNumComprobante = New System.Windows.Forms.TextBox()
        Me.TxtSerie = New System.Windows.Forms.TextBox()
        Me.CmbComprobante = New System.Windows.Forms.ComboBox()
        Me.LblComprobante = New System.Windows.Forms.Label()
        Me.TxtNombreProveedor = New System.Windows.Forms.TextBox()
        Me.TxtIdProveedor = New System.Windows.Forms.TextBox()
        Me.LblProveedor = New System.Windows.Forms.Label()
        Me.LblId = New System.Windows.Forms.Label()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.TabGeneral.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.PanelMostrar.SuspendLayout()
        CType(Me.DgvMostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GbDetalle.SuspendLayout()
        Me.PanelArticulos.SuspendLayout()
        CType(Me.DgvArticuloManual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabGeneral
        '
        Me.TabGeneral.Controls.Add(Me.TabPage1)
        Me.TabGeneral.Controls.Add(Me.TabPage2)
        Me.TabGeneral.Location = New System.Drawing.Point(22, 42)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.SelectedIndex = 0
        Me.TabGeneral.Size = New System.Drawing.Size(923, 663)
        Me.TabGeneral.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BtnAnular)
        Me.TabPage1.Controls.Add(Me.PanelMostrar)
        Me.TabPage1.Controls.Add(Me.ChkSeleccionar)
        Me.TabPage1.Controls.Add(Me.BtnBuscar)
        Me.TabPage1.Controls.Add(Me.LblTotalregistros)
        Me.TabPage1.Controls.Add(Me.TxtBusca)
        Me.TabPage1.Controls.Add(Me.DgvListado)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(915, 637)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "LISTADO"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnAnular
        '
        Me.BtnAnular.Location = New System.Drawing.Point(439, 374)
        Me.BtnAnular.Name = "BtnAnular"
        Me.BtnAnular.Size = New System.Drawing.Size(82, 33)
        Me.BtnAnular.TabIndex = 5
        Me.BtnAnular.Text = "Anular"
        Me.BtnAnular.UseVisualStyleBackColor = True
        '
        'PanelMostrar
        '
        Me.PanelMostrar.BackColor = System.Drawing.Color.AntiqueWhite
        Me.PanelMostrar.Controls.Add(Me.BtnCerrarMostrar)
        Me.PanelMostrar.Controls.Add(Me.TxtMostrarTotal)
        Me.PanelMostrar.Controls.Add(Me.TxtMostrarTotImp)
        Me.PanelMostrar.Controls.Add(Me.TxtMostrarSubTot)
        Me.PanelMostrar.Controls.Add(Me.LblMostrarTotal)
        Me.PanelMostrar.Controls.Add(Me.LblMostrarImpuesto)
        Me.PanelMostrar.Controls.Add(Me.LblMostrarSubtotal)
        Me.PanelMostrar.Controls.Add(Me.DgvMostrar)
        Me.PanelMostrar.Location = New System.Drawing.Point(328, 141)
        Me.PanelMostrar.Name = "PanelMostrar"
        Me.PanelMostrar.Size = New System.Drawing.Size(581, 352)
        Me.PanelMostrar.TabIndex = 4
        Me.PanelMostrar.Visible = False
        '
        'BtnCerrarMostrar
        '
        Me.BtnCerrarMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrarMostrar.ForeColor = System.Drawing.Color.Red
        Me.BtnCerrarMostrar.Location = New System.Drawing.Point(510, 15)
        Me.BtnCerrarMostrar.Name = "BtnCerrarMostrar"
        Me.BtnCerrarMostrar.Size = New System.Drawing.Size(54, 31)
        Me.BtnCerrarMostrar.TabIndex = 7
        Me.BtnCerrarMostrar.Text = "X"
        Me.BtnCerrarMostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnCerrarMostrar.UseVisualStyleBackColor = True
        '
        'TxtMostrarTotal
        '
        Me.TxtMostrarTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMostrarTotal.Location = New System.Drawing.Point(403, 317)
        Me.TxtMostrarTotal.Name = "TxtMostrarTotal"
        Me.TxtMostrarTotal.Size = New System.Drawing.Size(161, 21)
        Me.TxtMostrarTotal.TabIndex = 6
        Me.TxtMostrarTotal.Text = "0"
        '
        'TxtMostrarTotImp
        '
        Me.TxtMostrarTotImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMostrarTotImp.Location = New System.Drawing.Point(403, 283)
        Me.TxtMostrarTotImp.Name = "TxtMostrarTotImp"
        Me.TxtMostrarTotImp.Size = New System.Drawing.Size(161, 21)
        Me.TxtMostrarTotImp.TabIndex = 5
        Me.TxtMostrarTotImp.Text = "0"
        '
        'TxtMostrarSubTot
        '
        Me.TxtMostrarSubTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMostrarSubTot.Location = New System.Drawing.Point(403, 245)
        Me.TxtMostrarSubTot.Name = "TxtMostrarSubTot"
        Me.TxtMostrarSubTot.Size = New System.Drawing.Size(161, 21)
        Me.TxtMostrarSubTot.TabIndex = 4
        Me.TxtMostrarSubTot.Text = "0"
        '
        'LblMostrarTotal
        '
        Me.LblMostrarTotal.AutoSize = True
        Me.LblMostrarTotal.Location = New System.Drawing.Point(324, 320)
        Me.LblMostrarTotal.Name = "LblMostrarTotal"
        Me.LblMostrarTotal.Size = New System.Drawing.Size(34, 13)
        Me.LblMostrarTotal.TabIndex = 3
        Me.LblMostrarTotal.Text = "Total "
        '
        'LblMostrarImpuesto
        '
        Me.LblMostrarImpuesto.AutoSize = True
        Me.LblMostrarImpuesto.Location = New System.Drawing.Point(320, 286)
        Me.LblMostrarImpuesto.Name = "LblMostrarImpuesto"
        Me.LblMostrarImpuesto.Size = New System.Drawing.Size(77, 13)
        Me.LblMostrarImpuesto.TabIndex = 2
        Me.LblMostrarImpuesto.Text = "Total Impuesto"
        '
        'LblMostrarSubtotal
        '
        Me.LblMostrarSubtotal.AutoSize = True
        Me.LblMostrarSubtotal.Location = New System.Drawing.Point(320, 248)
        Me.LblMostrarSubtotal.Name = "LblMostrarSubtotal"
        Me.LblMostrarSubtotal.Size = New System.Drawing.Size(50, 13)
        Me.LblMostrarSubtotal.TabIndex = 1
        Me.LblMostrarSubtotal.Text = "SubTotal"
        '
        'DgvMostrar
        '
        Me.DgvMostrar.AllowUserToAddRows = False
        Me.DgvMostrar.AllowUserToDeleteRows = False
        Me.DgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMostrar.Location = New System.Drawing.Point(25, 52)
        Me.DgvMostrar.Name = "DgvMostrar"
        Me.DgvMostrar.ReadOnly = True
        Me.DgvMostrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvMostrar.Size = New System.Drawing.Size(539, 172)
        Me.DgvMostrar.TabIndex = 0
        '
        'ChkSeleccionar
        '
        Me.ChkSeleccionar.AutoSize = True
        Me.ChkSeleccionar.Location = New System.Drawing.Point(69, 390)
        Me.ChkSeleccionar.Name = "ChkSeleccionar"
        Me.ChkSeleccionar.Size = New System.Drawing.Size(82, 17)
        Me.ChkSeleccionar.TabIndex = 3
        Me.ChkSeleccionar.Text = "Seleccionar"
        Me.ChkSeleccionar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(753, 39)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(126, 37)
        Me.BtnBuscar.TabIndex = 2
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'LblTotalregistros
        '
        Me.LblTotalregistros.AutoSize = True
        Me.LblTotalregistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalregistros.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblTotalregistros.Location = New System.Drawing.Point(684, 332)
        Me.LblTotalregistros.Name = "LblTotalregistros"
        Me.LblTotalregistros.Size = New System.Drawing.Size(43, 16)
        Me.LblTotalregistros.TabIndex = 1
        Me.LblTotalregistros.Text = "Total"
        '
        'TxtBusca
        '
        Me.TxtBusca.Location = New System.Drawing.Point(69, 49)
        Me.TxtBusca.Name = "TxtBusca"
        Me.TxtBusca.Size = New System.Drawing.Size(452, 20)
        Me.TxtBusca.TabIndex = 1
        '
        'DgvListado
        '
        Me.DgvListado.AllowUserToAddRows = False
        Me.DgvListado.AllowUserToDeleteRows = False
        Me.DgvListado.AllowUserToOrderColumns = True
        Me.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar})
        Me.DgvListado.Location = New System.Drawing.Point(17, 141)
        Me.DgvListado.Name = "DgvListado"
        Me.DgvListado.ReadOnly = True
        Me.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvListado.Size = New System.Drawing.Size(924, 172)
        Me.DgvListado.TabIndex = 0
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GbDetalle)
        Me.TabPage2.Controls.Add(Me.GBCabecera)
        Me.TabPage2.Controls.Add(Me.LblId)
        Me.TabPage2.Controls.Add(Me.BtnActualizar)
        Me.TabPage2.Controls.Add(Me.TxtId)
        Me.TabPage2.Controls.Add(Me.BtnCancelar)
        Me.TabPage2.Controls.Add(Me.BtnGrabar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(882, 637)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ABM"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GbDetalle
        '
        Me.GbDetalle.Controls.Add(Me.PanelArticulos)
        Me.GbDetalle.Controls.Add(Me.BtnBuscarArticulo)
        Me.GbDetalle.Controls.Add(Me.TxtTotal)
        Me.GbDetalle.Controls.Add(Me.TxtArticulo)
        Me.GbDetalle.Controls.Add(Me.LblArticulo)
        Me.GbDetalle.Controls.Add(Me.TxtTotalImpuesto)
        Me.GbDetalle.Controls.Add(Me.TxtSubtotal)
        Me.GbDetalle.Controls.Add(Me.LblImpuestoTotal)
        Me.GbDetalle.Controls.Add(Me.LblTotal)
        Me.GbDetalle.Controls.Add(Me.LblSubtotal)
        Me.GbDetalle.Controls.Add(Me.DgvDetalle)
        Me.GbDetalle.Location = New System.Drawing.Point(34, 195)
        Me.GbDetalle.Name = "GbDetalle"
        Me.GbDetalle.Size = New System.Drawing.Size(799, 383)
        Me.GbDetalle.TabIndex = 10
        Me.GbDetalle.TabStop = False
        Me.GbDetalle.Text = "Detalles Compras"
        '
        'PanelArticulos
        '
        Me.PanelArticulos.BackColor = System.Drawing.Color.LemonChiffon
        Me.PanelArticulos.Controls.Add(Me.BtnCerrar)
        Me.PanelArticulos.Controls.Add(Me.LblTotalesManual)
        Me.PanelArticulos.Controls.Add(Me.DgvArticuloManual)
        Me.PanelArticulos.Controls.Add(Me.BtnBuscarManual)
        Me.PanelArticulos.Controls.Add(Me.TxtBuscarManual)
        Me.PanelArticulos.Controls.Add(Me.Label1)
        Me.PanelArticulos.Location = New System.Drawing.Point(45, 53)
        Me.PanelArticulos.Name = "PanelArticulos"
        Me.PanelArticulos.Size = New System.Drawing.Size(706, 277)
        Me.PanelArticulos.TabIndex = 13
        Me.PanelArticulos.Visible = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(650, 8)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(49, 21)
        Me.BtnCerrar.TabIndex = 19
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'LblTotalesManual
        '
        Me.LblTotalesManual.AutoSize = True
        Me.LblTotalesManual.Location = New System.Drawing.Point(449, 257)
        Me.LblTotalesManual.Name = "LblTotalesManual"
        Me.LblTotalesManual.Size = New System.Drawing.Size(31, 13)
        Me.LblTotalesManual.TabIndex = 18
        Me.LblTotalesManual.Text = "Total"
        '
        'DgvArticuloManual
        '
        Me.DgvArticuloManual.AllowUserToAddRows = False
        Me.DgvArticuloManual.AllowUserToDeleteRows = False
        Me.DgvArticuloManual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvArticuloManual.Location = New System.Drawing.Point(33, 63)
        Me.DgvArticuloManual.Name = "DgvArticuloManual"
        Me.DgvArticuloManual.ReadOnly = True
        Me.DgvArticuloManual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvArticuloManual.Size = New System.Drawing.Size(625, 150)
        Me.DgvArticuloManual.TabIndex = 17
        '
        'BtnBuscarManual
        '
        Me.BtnBuscarManual.Location = New System.Drawing.Point(595, 7)
        Me.BtnBuscarManual.Name = "BtnBuscarManual"
        Me.BtnBuscarManual.Size = New System.Drawing.Size(49, 21)
        Me.BtnBuscarManual.TabIndex = 16
        Me.BtnBuscarManual.Text = "Buscar"
        Me.BtnBuscarManual.UseVisualStyleBackColor = True
        '
        'TxtBuscarManual
        '
        Me.TxtBuscarManual.Location = New System.Drawing.Point(115, 8)
        Me.TxtBuscarManual.Name = "TxtBuscarManual"
        Me.TxtBuscarManual.Size = New System.Drawing.Size(460, 20)
        Me.TxtBuscarManual.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Artículo"
        '
        'BtnBuscarArticulo
        '
        Me.BtnBuscarArticulo.Location = New System.Drawing.Point(627, 7)
        Me.BtnBuscarArticulo.Name = "BtnBuscarArticulo"
        Me.BtnBuscarArticulo.Size = New System.Drawing.Size(49, 21)
        Me.BtnBuscarArticulo.TabIndex = 12
        Me.BtnBuscarArticulo.Text = "Buscar"
        Me.BtnBuscarArticulo.UseVisualStyleBackColor = True
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(615, 336)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(136, 20)
        Me.TxtTotal.TabIndex = 6
        '
        'TxtArticulo
        '
        Me.TxtArticulo.Location = New System.Drawing.Point(133, 8)
        Me.TxtArticulo.Name = "TxtArticulo"
        Me.TxtArticulo.Size = New System.Drawing.Size(460, 20)
        Me.TxtArticulo.TabIndex = 11
        '
        'LblArticulo
        '
        Me.LblArticulo.AutoSize = True
        Me.LblArticulo.Location = New System.Drawing.Point(49, 15)
        Me.LblArticulo.Name = "LblArticulo"
        Me.LblArticulo.Size = New System.Drawing.Size(44, 13)
        Me.LblArticulo.TabIndex = 10
        Me.LblArticulo.Text = "Artículo"
        '
        'TxtTotalImpuesto
        '
        Me.TxtTotalImpuesto.Location = New System.Drawing.Point(615, 299)
        Me.TxtTotalImpuesto.Name = "TxtTotalImpuesto"
        Me.TxtTotalImpuesto.Size = New System.Drawing.Size(136, 20)
        Me.TxtTotalImpuesto.TabIndex = 5
        '
        'TxtSubtotal
        '
        Me.TxtSubtotal.Location = New System.Drawing.Point(615, 258)
        Me.TxtSubtotal.Name = "TxtSubtotal"
        Me.TxtSubtotal.Size = New System.Drawing.Size(136, 20)
        Me.TxtSubtotal.TabIndex = 4
        '
        'LblImpuestoTotal
        '
        Me.LblImpuestoTotal.AutoSize = True
        Me.LblImpuestoTotal.Location = New System.Drawing.Point(532, 302)
        Me.LblImpuestoTotal.Name = "LblImpuestoTotal"
        Me.LblImpuestoTotal.Size = New System.Drawing.Size(77, 13)
        Me.LblImpuestoTotal.TabIndex = 3
        Me.LblImpuestoTotal.Text = "Total Impuesto"
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(532, 339)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(31, 13)
        Me.LblTotal.TabIndex = 2
        Me.LblTotal.Text = "Total"
        '
        'LblSubtotal
        '
        Me.LblSubtotal.AutoSize = True
        Me.LblSubtotal.Location = New System.Drawing.Point(532, 265)
        Me.LblSubtotal.Name = "LblSubtotal"
        Me.LblSubtotal.Size = New System.Drawing.Size(50, 13)
        Me.LblSubtotal.TabIndex = 1
        Me.LblSubtotal.Text = "SubTotal"
        '
        'DgvDetalle
        '
        Me.DgvDetalle.AllowUserToAddRows = False
        Me.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalle.Location = New System.Drawing.Point(45, 79)
        Me.DgvDetalle.Name = "DgvDetalle"
        Me.DgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDetalle.Size = New System.Drawing.Size(706, 160)
        Me.DgvDetalle.TabIndex = 0
        '
        'GBCabecera
        '
        Me.GBCabecera.Controls.Add(Me.TxtImpuesto)
        Me.GBCabecera.Controls.Add(Me.BtnBuscarProveedor)
        Me.GBCabecera.Controls.Add(Me.LblImpuesto)
        Me.GBCabecera.Controls.Add(Me.TxtNumComprobante)
        Me.GBCabecera.Controls.Add(Me.TxtSerie)
        Me.GBCabecera.Controls.Add(Me.CmbComprobante)
        Me.GBCabecera.Controls.Add(Me.LblComprobante)
        Me.GBCabecera.Controls.Add(Me.TxtNombreProveedor)
        Me.GBCabecera.Controls.Add(Me.TxtIdProveedor)
        Me.GBCabecera.Controls.Add(Me.LblProveedor)
        Me.GBCabecera.Location = New System.Drawing.Point(32, 44)
        Me.GBCabecera.Name = "GBCabecera"
        Me.GBCabecera.Size = New System.Drawing.Size(801, 132)
        Me.GBCabecera.TabIndex = 9
        Me.GBCabecera.TabStop = False
        Me.GBCabecera.Text = "Proveedores y Comprobantes"
        '
        'TxtImpuesto
        '
        Me.TxtImpuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImpuesto.Location = New System.Drawing.Point(694, 95)
        Me.TxtImpuesto.Name = "TxtImpuesto"
        Me.TxtImpuesto.Size = New System.Drawing.Size(59, 20)
        Me.TxtImpuesto.TabIndex = 9
        Me.TxtImpuesto.Text = "21"
        '
        'BtnBuscarProveedor
        '
        Me.BtnBuscarProveedor.Location = New System.Drawing.Point(627, 41)
        Me.BtnBuscarProveedor.Name = "BtnBuscarProveedor"
        Me.BtnBuscarProveedor.Size = New System.Drawing.Size(49, 21)
        Me.BtnBuscarProveedor.TabIndex = 7
        Me.BtnBuscarProveedor.Text = "Buscar"
        Me.BtnBuscarProveedor.UseVisualStyleBackColor = True
        '
        'LblImpuesto
        '
        Me.LblImpuesto.AutoSize = True
        Me.LblImpuesto.Location = New System.Drawing.Point(626, 98)
        Me.LblImpuesto.Name = "LblImpuesto"
        Me.LblImpuesto.Size = New System.Drawing.Size(50, 13)
        Me.LblImpuesto.TabIndex = 8
        Me.LblImpuesto.Text = "Impuesto"
        '
        'TxtNumComprobante
        '
        Me.TxtNumComprobante.Location = New System.Drawing.Point(396, 90)
        Me.TxtNumComprobante.Name = "TxtNumComprobante"
        Me.TxtNumComprobante.Size = New System.Drawing.Size(199, 20)
        Me.TxtNumComprobante.TabIndex = 6
        '
        'TxtSerie
        '
        Me.TxtSerie.Location = New System.Drawing.Point(276, 90)
        Me.TxtSerie.Name = "TxtSerie"
        Me.TxtSerie.Size = New System.Drawing.Size(101, 20)
        Me.TxtSerie.TabIndex = 5
        '
        'CmbComprobante
        '
        Me.CmbComprobante.FormattingEnabled = True
        Me.CmbComprobante.Items.AddRange(New Object() {"Factura A", "Factura B", "Factura C", "Factura E", "Recibo", ""})
        Me.CmbComprobante.Location = New System.Drawing.Point(114, 90)
        Me.CmbComprobante.Name = "CmbComprobante"
        Me.CmbComprobante.Size = New System.Drawing.Size(145, 21)
        Me.CmbComprobante.TabIndex = 4
        '
        'LblComprobante
        '
        Me.LblComprobante.AutoSize = True
        Me.LblComprobante.Location = New System.Drawing.Point(22, 93)
        Me.LblComprobante.Name = "LblComprobante"
        Me.LblComprobante.Size = New System.Drawing.Size(70, 13)
        Me.LblComprobante.TabIndex = 3
        Me.LblComprobante.Text = "Comprobante"
        '
        'TxtNombreProveedor
        '
        Me.TxtNombreProveedor.Location = New System.Drawing.Point(219, 42)
        Me.TxtNombreProveedor.Name = "TxtNombreProveedor"
        Me.TxtNombreProveedor.Size = New System.Drawing.Size(376, 20)
        Me.TxtNombreProveedor.TabIndex = 2
        '
        'TxtIdProveedor
        '
        Me.TxtIdProveedor.Location = New System.Drawing.Point(112, 42)
        Me.TxtIdProveedor.Name = "TxtIdProveedor"
        Me.TxtIdProveedor.Size = New System.Drawing.Size(101, 20)
        Me.TxtIdProveedor.TabIndex = 1
        '
        'LblProveedor
        '
        Me.LblProveedor.AutoSize = True
        Me.LblProveedor.Location = New System.Drawing.Point(22, 44)
        Me.LblProveedor.Name = "LblProveedor"
        Me.LblProveedor.Size = New System.Drawing.Size(56, 13)
        Me.LblProveedor.TabIndex = 0
        Me.LblProveedor.Text = "Proveedor"
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Location = New System.Drawing.Point(54, 6)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(54, 13)
        Me.LblId.TabIndex = 8
        Me.LblId.Text = "Id Ingreso"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Location = New System.Drawing.Point(211, 584)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(120, 43)
        Me.BtnActualizar.TabIndex = 7
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'TxtId
        '
        Me.TxtId.Enabled = False
        Me.TxtId.Location = New System.Drawing.Point(146, 6)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(113, 20)
        Me.TxtId.TabIndex = 6
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(347, 584)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(120, 43)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnGrabar
        '
        Me.BtnGrabar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGrabar.Location = New System.Drawing.Point(211, 584)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(120, 43)
        Me.BtnGrabar.TabIndex = 4
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.UseVisualStyleBackColor = False
        '
        'FrmIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(951, 699)
        Me.Controls.Add(Me.TabGeneral)
        Me.Name = "FrmIngreso"
        Me.Text = "Ingresos"
        Me.TabGeneral.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.PanelMostrar.ResumeLayout(False)
        Me.PanelMostrar.PerformLayout()
        CType(Me.DgvMostrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GbDetalle.ResumeLayout(False)
        Me.GbDetalle.PerformLayout()
        Me.PanelArticulos.ResumeLayout(False)
        Me.PanelArticulos.PerformLayout()
        CType(Me.DgvArticuloManual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBCabecera.ResumeLayout(False)
        Me.GBCabecera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabGeneral As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ChkSeleccionar As CheckBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents LblTotalregistros As Label
    Friend WithEvents TxtBusca As TextBox
    Friend WithEvents DgvListado As DataGridView
    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GBCabecera As GroupBox
    Friend WithEvents TxtNumComprobante As TextBox
    Friend WithEvents TxtSerie As TextBox
    Friend WithEvents CmbComprobante As ComboBox
    Friend WithEvents LblComprobante As Label
    Friend WithEvents TxtNombreProveedor As TextBox
    Friend WithEvents TxtIdProveedor As TextBox
    Friend WithEvents LblProveedor As Label
    Friend WithEvents LblId As Label
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents TxtId As TextBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGrabar As Button
    Friend WithEvents BtnBuscarProveedor As Button
    Friend WithEvents TxtImpuesto As TextBox
    Friend WithEvents LblImpuesto As Label
    Friend WithEvents GbDetalle As GroupBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents TxtTotalImpuesto As TextBox
    Friend WithEvents TxtSubtotal As TextBox
    Friend WithEvents LblImpuestoTotal As Label
    Friend WithEvents LblTotal As Label
    Friend WithEvents LblSubtotal As Label
    Friend WithEvents DgvDetalle As DataGridView
    Friend WithEvents BtnBuscarArticulo As Button
    Friend WithEvents TxtArticulo As TextBox
    Friend WithEvents LblArticulo As Label
    Friend WithEvents PanelArticulos As Panel
    Friend WithEvents DgvArticuloManual As DataGridView
    Friend WithEvents BtnBuscarManual As Button
    Friend WithEvents TxtBuscarManual As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents LblTotalesManual As Label
    Friend WithEvents PanelMostrar As Panel
    Friend WithEvents DgvMostrar As DataGridView
    Friend WithEvents LblMostrarTotal As Label
    Friend WithEvents LblMostrarImpuesto As Label
    Friend WithEvents LblMostrarSubtotal As Label
    Friend WithEvents BtnAnular As Button
    Friend WithEvents TxtMostrarTotal As TextBox
    Friend WithEvents TxtMostrarTotImp As TextBox
    Friend WithEvents TxtMostrarSubTot As TextBox
    Friend WithEvents BtnCerrarMostrar As Button
End Class
