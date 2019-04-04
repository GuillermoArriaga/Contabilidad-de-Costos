<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fContabilidadCostos
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fContabilidadCostos))
        Me.lContabilidadCostos = New System.Windows.Forms.Label()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.dgvDatosColConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDatosColImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDatosColFuncion = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dgvDatosColComportamiento = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.tbRubro = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.tbPeriodo = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.tbNombreEmpresa = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.cbEnumerar = New System.Windows.Forms.CheckBox()
        Me.bQuitarUtilidadDeseada = New System.Windows.Forms.Button()
        Me.tbUtilidadDeseada = New System.Windows.Forms.TextBox()
        Me.bAgregarUtilidadDeseada = New System.Windows.Forms.Button()
        Me.cbUtilidadDeseada = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.bQuitarUnidadesVendidas = New System.Windows.Forms.Button()
        Me.bAgregarUnidadesVendidas = New System.Windows.Forms.Button()
        Me.cbUnidadesVendidas = New System.Windows.Forms.ComboBox()
        Me.tbUnidadesVendidas = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.tbUnidadesProducidas = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.bDatosBorrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bDatosCargar = New System.Windows.Forms.Button()
        Me.bDatosGuardar = New System.Windows.Forms.Button()
        Me.gbCedula = New System.Windows.Forms.GroupBox()
        Me.cbCedulaTipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvCedula = New System.Windows.Forms.DataGridView()
        Me.dgvCedulaColConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCedulaColImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCedulaColTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bCalcularTodo = New System.Windows.Forms.Button()
        Me.gbResumen = New System.Windows.Forms.GroupBox()
        Me.tbResultadosUnidadesProducidas = New System.Windows.Forms.TextBox()
        Me.cbResultadosUtilidadDeseada = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.tbCVU = New System.Windows.Forms.TextBox()
        Me.tbGVU = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.tbGVariable = New System.Windows.Forms.TextBox()
        Me.tbGFijo = New System.Windows.Forms.TextBox()
        Me.tbCVariable = New System.Windows.Forms.TextBox()
        Me.tbCFijo = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tbCPU = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbPrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbCTU = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbCostoTotal = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tbGOperacion = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tbCProduccion = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbCTransformacion = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbCPrimo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbGF = New System.Windows.Forms.TextBox()
        Me.tbGA = New System.Windows.Forms.TextBox()
        Me.tbGV = New System.Windows.Forms.TextBox()
        Me.tbCIF = New System.Windows.Forms.TextBox()
        Me.tbCMOD = New System.Windows.Forms.TextBox()
        Me.tbCMPD = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbEdoResultados = New System.Windows.Forms.GroupBox()
        Me.cbNoTruncar = New System.Windows.Forms.CheckBox()
        Me.cbSinSangrias = New System.Windows.Forms.CheckBox()
        Me.cbEdoResTipo = New System.Windows.Forms.ComboBox()
        Me.dgvEdoRes = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvEdoResultados = New System.Windows.Forms.DataGridView()
        Me.dgvEdoResColConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bInforme = New System.Windows.Forms.Button()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.bLeyenda = New System.Windows.Forms.Button()
        Me.bAcercaDe = New System.Windows.Forms.Button()
        Me.bEjemplo2 = New System.Windows.Forms.Button()
        Me.bTipsUso = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bEjemplo1 = New System.Windows.Forms.Button()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatos.SuspendLayout()
        Me.gbCedula.SuspendLayout()
        CType(Me.dgvCedula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbResumen.SuspendLayout()
        Me.gbEdoResultados.SuspendLayout()
        CType(Me.dgvEdoRes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEdoResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lContabilidadCostos
        '
        Me.lContabilidadCostos.AutoSize = True
        Me.lContabilidadCostos.BackColor = System.Drawing.Color.Goldenrod
        Me.lContabilidadCostos.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lContabilidadCostos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lContabilidadCostos.Location = New System.Drawing.Point(412, 23)
        Me.lContabilidadCostos.Name = "lContabilidadCostos"
        Me.lContabilidadCostos.Size = New System.Drawing.Size(485, 38)
        Me.lContabilidadCostos.TabIndex = 0
        Me.lContabilidadCostos.Text = "CONTABILIDAD DE COSTOS"
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToOrderColumns = True
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvDatosColConcepto, Me.dgvDatosColImporte, Me.dgvDatosColFuncion, Me.dgvDatosColComportamiento})
        Me.dgvDatos.GridColor = System.Drawing.Color.DimGray
        Me.dgvDatos.Location = New System.Drawing.Point(5, 142)
        Me.dgvDatos.Name = "dgvDatos"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.dgvDatos.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDatos.RowTemplate.Height = 24
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvDatos.Size = New System.Drawing.Size(637, 256)
        Me.dgvDatos.TabIndex = 1
        '
        'dgvDatosColConcepto
        '
        Me.dgvDatosColConcepto.FillWeight = 250.0!
        Me.dgvDatosColConcepto.HeaderText = "Concepto"
        Me.dgvDatosColConcepto.Name = "dgvDatosColConcepto"
        Me.dgvDatosColConcepto.Width = 250
        '
        'dgvDatosColImporte
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.dgvDatosColImporte.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDatosColImporte.FillWeight = 105.0!
        Me.dgvDatosColImporte.HeaderText = "Importe"
        Me.dgvDatosColImporte.Name = "dgvDatosColImporte"
        Me.dgvDatosColImporte.Width = 105
        '
        'dgvDatosColFuncion
        '
        Me.dgvDatosColFuncion.FillWeight = 85.0!
        Me.dgvDatosColFuncion.HeaderText = "Funcion"
        Me.dgvDatosColFuncion.Items.AddRange(New Object() {"CMPD", "CMOD", "CIF", "GV", "GA", "GF"})
        Me.dgvDatosColFuncion.Name = "dgvDatosColFuncion"
        Me.dgvDatosColFuncion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDatosColFuncion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgvDatosColFuncion.Width = 85
        '
        'dgvDatosColComportamiento
        '
        Me.dgvDatosColComportamiento.FillWeight = 130.0!
        Me.dgvDatosColComportamiento.HeaderText = "Comportamiento"
        Me.dgvDatosColComportamiento.Items.AddRange(New Object() {"C Fijo", "C Variable", "G Fijo", "G Variable"})
        Me.dgvDatosColComportamiento.Name = "dgvDatosColComportamiento"
        Me.dgvDatosColComportamiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgvDatosColComportamiento.Width = 130
        '
        'gbDatos
        '
        Me.gbDatos.BackColor = System.Drawing.Color.Transparent
        Me.gbDatos.Controls.Add(Me.tbRubro)
        Me.gbDatos.Controls.Add(Me.Label36)
        Me.gbDatos.Controls.Add(Me.tbPeriodo)
        Me.gbDatos.Controls.Add(Me.Label35)
        Me.gbDatos.Controls.Add(Me.tbNombreEmpresa)
        Me.gbDatos.Controls.Add(Me.Label34)
        Me.gbDatos.Controls.Add(Me.cbEnumerar)
        Me.gbDatos.Controls.Add(Me.bQuitarUtilidadDeseada)
        Me.gbDatos.Controls.Add(Me.tbUtilidadDeseada)
        Me.gbDatos.Controls.Add(Me.bAgregarUtilidadDeseada)
        Me.gbDatos.Controls.Add(Me.cbUtilidadDeseada)
        Me.gbDatos.Controls.Add(Me.Label31)
        Me.gbDatos.Controls.Add(Me.bQuitarUnidadesVendidas)
        Me.gbDatos.Controls.Add(Me.bAgregarUnidadesVendidas)
        Me.gbDatos.Controls.Add(Me.cbUnidadesVendidas)
        Me.gbDatos.Controls.Add(Me.tbUnidadesVendidas)
        Me.gbDatos.Controls.Add(Me.Label30)
        Me.gbDatos.Controls.Add(Me.tbUnidadesProducidas)
        Me.gbDatos.Controls.Add(Me.Label28)
        Me.gbDatos.Controls.Add(Me.bDatosBorrar)
        Me.gbDatos.Controls.Add(Me.Label1)
        Me.gbDatos.Controls.Add(Me.bDatosCargar)
        Me.gbDatos.Controls.Add(Me.bDatosGuardar)
        Me.gbDatos.Controls.Add(Me.dgvDatos)
        Me.gbDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatos.ForeColor = System.Drawing.Color.Goldenrod
        Me.gbDatos.Location = New System.Drawing.Point(8, 74)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(648, 404)
        Me.gbDatos.TabIndex = 3
        Me.gbDatos.TabStop = False
        '
        'tbRubro
        '
        Me.tbRubro.BackColor = System.Drawing.Color.LightGray
        Me.tbRubro.ForeColor = System.Drawing.Color.Black
        Me.tbRubro.Location = New System.Drawing.Point(273, 110)
        Me.tbRubro.Name = "tbRubro"
        Me.tbRubro.Size = New System.Drawing.Size(189, 22)
        Me.tbRubro.TabIndex = 62
        Me.tbRubro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.ForeColor = System.Drawing.Color.Silver
        Me.Label36.Location = New System.Drawing.Point(225, 113)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(47, 17)
        Me.Label36.TabIndex = 61
        Me.Label36.Text = "Rubro"
        '
        'tbPeriodo
        '
        Me.tbPeriodo.BackColor = System.Drawing.Color.LightGray
        Me.tbPeriodo.ForeColor = System.Drawing.Color.Black
        Me.tbPeriodo.Location = New System.Drawing.Point(531, 110)
        Me.tbPeriodo.Name = "tbPeriodo"
        Me.tbPeriodo.Size = New System.Drawing.Size(111, 22)
        Me.tbPeriodo.TabIndex = 60
        Me.tbPeriodo.Text = "mes / año"
        Me.tbPeriodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ForeColor = System.Drawing.Color.Silver
        Me.Label35.Location = New System.Drawing.Point(468, 113)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(57, 17)
        Me.Label35.TabIndex = 59
        Me.Label35.Text = "Periodo"
        '
        'tbNombreEmpresa
        '
        Me.tbNombreEmpresa.BackColor = System.Drawing.Color.LightGray
        Me.tbNombreEmpresa.ForeColor = System.Drawing.Color.Black
        Me.tbNombreEmpresa.Location = New System.Drawing.Point(73, 110)
        Me.tbNombreEmpresa.Name = "tbNombreEmpresa"
        Me.tbNombreEmpresa.Size = New System.Drawing.Size(147, 22)
        Me.tbNombreEmpresa.TabIndex = 58
        Me.tbNombreEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ForeColor = System.Drawing.Color.Silver
        Me.Label34.Location = New System.Drawing.Point(6, 113)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(64, 17)
        Me.Label34.TabIndex = 57
        Me.Label34.Text = "Empresa"
        '
        'cbEnumerar
        '
        Me.cbEnumerar.AutoSize = True
        Me.cbEnumerar.Location = New System.Drawing.Point(133, 29)
        Me.cbEnumerar.Name = "cbEnumerar"
        Me.cbEnumerar.Size = New System.Drawing.Size(161, 21)
        Me.cbEnumerar.TabIndex = 55
        Me.cbEnumerar.Text = "Enumerar conceptos"
        Me.cbEnumerar.UseVisualStyleBackColor = True
        '
        'bQuitarUtilidadDeseada
        '
        Me.bQuitarUtilidadDeseada.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bQuitarUtilidadDeseada.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bQuitarUtilidadDeseada.ForeColor = System.Drawing.Color.Black
        Me.bQuitarUtilidadDeseada.Location = New System.Drawing.Point(618, 72)
        Me.bQuitarUtilidadDeseada.Name = "bQuitarUtilidadDeseada"
        Me.bQuitarUtilidadDeseada.Size = New System.Drawing.Size(24, 30)
        Me.bQuitarUtilidadDeseada.TabIndex = 54
        Me.bQuitarUtilidadDeseada.Text = "-"
        Me.bQuitarUtilidadDeseada.UseVisualStyleBackColor = False
        '
        'tbUtilidadDeseada
        '
        Me.tbUtilidadDeseada.BackColor = System.Drawing.Color.LightGray
        Me.tbUtilidadDeseada.ForeColor = System.Drawing.Color.Black
        Me.tbUtilidadDeseada.Location = New System.Drawing.Point(492, 74)
        Me.tbUtilidadDeseada.Name = "tbUtilidadDeseada"
        Me.tbUtilidadDeseada.Size = New System.Drawing.Size(33, 22)
        Me.tbUtilidadDeseada.TabIndex = 53
        Me.tbUtilidadDeseada.Text = "120"
        Me.tbUtilidadDeseada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bAgregarUtilidadDeseada
        '
        Me.bAgregarUtilidadDeseada.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bAgregarUtilidadDeseada.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAgregarUtilidadDeseada.ForeColor = System.Drawing.Color.Black
        Me.bAgregarUtilidadDeseada.Location = New System.Drawing.Point(531, 72)
        Me.bAgregarUtilidadDeseada.Name = "bAgregarUtilidadDeseada"
        Me.bAgregarUtilidadDeseada.Size = New System.Drawing.Size(24, 30)
        Me.bAgregarUtilidadDeseada.TabIndex = 53
        Me.bAgregarUtilidadDeseada.Text = "+"
        Me.bAgregarUtilidadDeseada.UseVisualStyleBackColor = False
        '
        'cbUtilidadDeseada
        '
        Me.cbUtilidadDeseada.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbUtilidadDeseada.FormattingEnabled = True
        Me.cbUtilidadDeseada.Location = New System.Drawing.Point(556, 74)
        Me.cbUtilidadDeseada.Name = "cbUtilidadDeseada"
        Me.cbUtilidadDeseada.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbUtilidadDeseada.Size = New System.Drawing.Size(61, 24)
        Me.cbUtilidadDeseada.TabIndex = 52
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.Silver
        Me.Label31.Location = New System.Drawing.Point(418, 68)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(73, 34)
        Me.Label31.TabIndex = 52
        Me.Label31.Text = "% Utilidad" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Deseada"
        '
        'bQuitarUnidadesVendidas
        '
        Me.bQuitarUnidadesVendidas.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bQuitarUnidadesVendidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bQuitarUnidadesVendidas.ForeColor = System.Drawing.Color.Black
        Me.bQuitarUnidadesVendidas.Location = New System.Drawing.Point(388, 72)
        Me.bQuitarUnidadesVendidas.Name = "bQuitarUnidadesVendidas"
        Me.bQuitarUnidadesVendidas.Size = New System.Drawing.Size(24, 30)
        Me.bQuitarUnidadesVendidas.TabIndex = 51
        Me.bQuitarUnidadesVendidas.Text = "-"
        Me.bQuitarUnidadesVendidas.UseVisualStyleBackColor = False
        '
        'bAgregarUnidadesVendidas
        '
        Me.bAgregarUnidadesVendidas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bAgregarUnidadesVendidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAgregarUnidadesVendidas.ForeColor = System.Drawing.Color.Black
        Me.bAgregarUnidadesVendidas.Location = New System.Drawing.Point(273, 72)
        Me.bAgregarUnidadesVendidas.Name = "bAgregarUnidadesVendidas"
        Me.bAgregarUnidadesVendidas.Size = New System.Drawing.Size(24, 29)
        Me.bAgregarUnidadesVendidas.TabIndex = 50
        Me.bAgregarUnidadesVendidas.Text = "+"
        Me.bAgregarUnidadesVendidas.UseVisualStyleBackColor = False
        '
        'cbUnidadesVendidas
        '
        Me.cbUnidadesVendidas.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbUnidadesVendidas.FormattingEnabled = True
        Me.cbUnidadesVendidas.Location = New System.Drawing.Point(298, 74)
        Me.cbUnidadesVendidas.Name = "cbUnidadesVendidas"
        Me.cbUnidadesVendidas.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbUnidadesVendidas.Size = New System.Drawing.Size(88, 24)
        Me.cbUnidadesVendidas.TabIndex = 49
        '
        'tbUnidadesVendidas
        '
        Me.tbUnidadesVendidas.BackColor = System.Drawing.Color.LightGray
        Me.tbUnidadesVendidas.ForeColor = System.Drawing.Color.Black
        Me.tbUnidadesVendidas.Location = New System.Drawing.Point(220, 74)
        Me.tbUnidadesVendidas.Name = "tbUnidadesVendidas"
        Me.tbUnidadesVendidas.Size = New System.Drawing.Size(52, 22)
        Me.tbUnidadesVendidas.TabIndex = 48
        Me.tbUnidadesVendidas.Text = "120000"
        Me.tbUnidadesVendidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.Silver
        Me.Label30.Location = New System.Drawing.Point(152, 68)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(68, 34)
        Me.Label30.TabIndex = 47
        Me.Label30.Text = "Unidades" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vendidas"
        '
        'tbUnidadesProducidas
        '
        Me.tbUnidadesProducidas.BackColor = System.Drawing.Color.LightGray
        Me.tbUnidadesProducidas.ForeColor = System.Drawing.Color.Black
        Me.tbUnidadesProducidas.Location = New System.Drawing.Point(84, 75)
        Me.tbUnidadesProducidas.Name = "tbUnidadesProducidas"
        Me.tbUnidadesProducidas.Size = New System.Drawing.Size(55, 22)
        Me.tbUnidadesProducidas.TabIndex = 46
        Me.tbUnidadesProducidas.Text = "120000"
        Me.tbUnidadesProducidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.Silver
        Me.Label28.Location = New System.Drawing.Point(6, 67)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(83, 34)
        Me.Label28.TabIndex = 45
        Me.Label28.Text = "Unidades" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Producidas "
        '
        'bDatosBorrar
        '
        Me.bDatosBorrar.BackColor = System.Drawing.Color.MidnightBlue
        Me.bDatosBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDatosBorrar.Location = New System.Drawing.Point(531, 22)
        Me.bDatosBorrar.Name = "bDatosBorrar"
        Me.bDatosBorrar.Size = New System.Drawing.Size(111, 35)
        Me.bDatosBorrar.TabIndex = 6
        Me.bDatosBorrar.Text = "Borrar"
        Me.bDatosBorrar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(8, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "DATOS"
        '
        'bDatosCargar
        '
        Me.bDatosCargar.BackColor = System.Drawing.Color.MidnightBlue
        Me.bDatosCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDatosCargar.ForeColor = System.Drawing.Color.Silver
        Me.bDatosCargar.Location = New System.Drawing.Point(423, 22)
        Me.bDatosCargar.Name = "bDatosCargar"
        Me.bDatosCargar.Size = New System.Drawing.Size(104, 35)
        Me.bDatosCargar.TabIndex = 4
        Me.bDatosCargar.Text = "Cargar"
        Me.bDatosCargar.UseVisualStyleBackColor = False
        '
        'bDatosGuardar
        '
        Me.bDatosGuardar.BackColor = System.Drawing.Color.MidnightBlue
        Me.bDatosGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDatosGuardar.ForeColor = System.Drawing.Color.Silver
        Me.bDatosGuardar.Location = New System.Drawing.Point(318, 22)
        Me.bDatosGuardar.Name = "bDatosGuardar"
        Me.bDatosGuardar.Size = New System.Drawing.Size(101, 35)
        Me.bDatosGuardar.TabIndex = 3
        Me.bDatosGuardar.Text = "Guardar"
        Me.bDatosGuardar.UseVisualStyleBackColor = False
        '
        'gbCedula
        '
        Me.gbCedula.BackColor = System.Drawing.Color.Transparent
        Me.gbCedula.Controls.Add(Me.cbCedulaTipo)
        Me.gbCedula.Controls.Add(Me.Label2)
        Me.gbCedula.Controls.Add(Me.dgvCedula)
        Me.gbCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCedula.ForeColor = System.Drawing.Color.Goldenrod
        Me.gbCedula.Location = New System.Drawing.Point(8, 478)
        Me.gbCedula.Name = "gbCedula"
        Me.gbCedula.Size = New System.Drawing.Size(648, 390)
        Me.gbCedula.TabIndex = 6
        Me.gbCedula.TabStop = False
        '
        'cbCedulaTipo
        '
        Me.cbCedulaTipo.FormattingEnabled = True
        Me.cbCedulaTipo.Items.AddRange(New Object() {"para determinar los elementos del costo y el COSTO de PRODUCCION.", "para determinar el COSTO PRIMO.", "para determinar el COSTO de TRANSFORMACION.", "para determinar el GASTO de OPERACION.", "para determinar el COSTO TOTAL.", "para determinar el COSTO FIJO.", "para determinar el COSTO VARIABLE.", "para determinar el GASTO FIJO.", "para determinar el GASTO VARIABLE."})
        Me.cbCedulaTipo.Location = New System.Drawing.Point(128, 24)
        Me.cbCedulaTipo.Name = "cbCedulaTipo"
        Me.cbCedulaTipo.Size = New System.Drawing.Size(514, 24)
        Me.cbCedulaTipo.TabIndex = 6
        Me.cbCedulaTipo.Text = "- Tipo -"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(8, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 29)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "CÉDULA"
        '
        'dgvCedula
        '
        Me.dgvCedula.AllowUserToOrderColumns = True
        Me.dgvCedula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCedula.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvCedulaColConcepto, Me.dgvCedulaColImporte, Me.dgvCedulaColTotal})
        Me.dgvCedula.GridColor = System.Drawing.Color.DimGray
        Me.dgvCedula.Location = New System.Drawing.Point(5, 61)
        Me.dgvCedula.Name = "dgvCedula"
        Me.dgvCedula.ReadOnly = True
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.dgvCedula.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCedula.RowTemplate.Height = 24
        Me.dgvCedula.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCedula.Size = New System.Drawing.Size(637, 323)
        Me.dgvCedula.TabIndex = 1
        '
        'dgvCedulaColConcepto
        '
        Me.dgvCedulaColConcepto.FillWeight = 300.0!
        Me.dgvCedulaColConcepto.HeaderText = "Concepto"
        Me.dgvCedulaColConcepto.Name = "dgvCedulaColConcepto"
        Me.dgvCedulaColConcepto.ReadOnly = True
        Me.dgvCedulaColConcepto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvCedulaColConcepto.Width = 300
        '
        'dgvCedulaColImporte
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.dgvCedulaColImporte.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCedulaColImporte.FillWeight = 130.0!
        Me.dgvCedulaColImporte.HeaderText = "Importe"
        Me.dgvCedulaColImporte.Name = "dgvCedulaColImporte"
        Me.dgvCedulaColImporte.ReadOnly = True
        Me.dgvCedulaColImporte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvCedulaColImporte.Width = 130
        '
        'dgvCedulaColTotal
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.dgvCedulaColTotal.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCedulaColTotal.FillWeight = 130.0!
        Me.dgvCedulaColTotal.HeaderText = "Total"
        Me.dgvCedulaColTotal.Name = "dgvCedulaColTotal"
        Me.dgvCedulaColTotal.ReadOnly = True
        Me.dgvCedulaColTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvCedulaColTotal.Width = 130
        '
        'bCalcularTodo
        '
        Me.bCalcularTodo.BackColor = System.Drawing.Color.Silver
        Me.bCalcularTodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCalcularTodo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.bCalcularTodo.Location = New System.Drawing.Point(138, 23)
        Me.bCalcularTodo.Name = "bCalcularTodo"
        Me.bCalcularTodo.Size = New System.Drawing.Size(83, 39)
        Me.bCalcularTodo.TabIndex = 4
        Me.bCalcularTodo.Text = "Calcular"
        Me.bCalcularTodo.UseVisualStyleBackColor = False
        '
        'gbResumen
        '
        Me.gbResumen.BackColor = System.Drawing.Color.Transparent
        Me.gbResumen.Controls.Add(Me.tbResultadosUnidadesProducidas)
        Me.gbResumen.Controls.Add(Me.cbResultadosUtilidadDeseada)
        Me.gbResumen.Controls.Add(Me.Label27)
        Me.gbResumen.Controls.Add(Me.tbCVU)
        Me.gbResumen.Controls.Add(Me.tbGVU)
        Me.gbResumen.Controls.Add(Me.Label29)
        Me.gbResumen.Controls.Add(Me.tbGVariable)
        Me.gbResumen.Controls.Add(Me.tbGFijo)
        Me.gbResumen.Controls.Add(Me.tbCVariable)
        Me.gbResumen.Controls.Add(Me.tbCFijo)
        Me.gbResumen.Controls.Add(Me.Label21)
        Me.gbResumen.Controls.Add(Me.Label24)
        Me.gbResumen.Controls.Add(Me.Label25)
        Me.gbResumen.Controls.Add(Me.Label26)
        Me.gbResumen.Controls.Add(Me.Label22)
        Me.gbResumen.Controls.Add(Me.tbCPU)
        Me.gbResumen.Controls.Add(Me.Label23)
        Me.gbResumen.Controls.Add(Me.Label20)
        Me.gbResumen.Controls.Add(Me.tbPrecioVenta)
        Me.gbResumen.Controls.Add(Me.Label19)
        Me.gbResumen.Controls.Add(Me.tbCTU)
        Me.gbResumen.Controls.Add(Me.Label18)
        Me.gbResumen.Controls.Add(Me.tbCostoTotal)
        Me.gbResumen.Controls.Add(Me.Label17)
        Me.gbResumen.Controls.Add(Me.tbGOperacion)
        Me.gbResumen.Controls.Add(Me.Label16)
        Me.gbResumen.Controls.Add(Me.tbCProduccion)
        Me.gbResumen.Controls.Add(Me.Label15)
        Me.gbResumen.Controls.Add(Me.tbCTransformacion)
        Me.gbResumen.Controls.Add(Me.Label14)
        Me.gbResumen.Controls.Add(Me.tbCPrimo)
        Me.gbResumen.Controls.Add(Me.Label13)
        Me.gbResumen.Controls.Add(Me.tbGF)
        Me.gbResumen.Controls.Add(Me.tbGA)
        Me.gbResumen.Controls.Add(Me.tbGV)
        Me.gbResumen.Controls.Add(Me.tbCIF)
        Me.gbResumen.Controls.Add(Me.tbCMOD)
        Me.gbResumen.Controls.Add(Me.tbCMPD)
        Me.gbResumen.Controls.Add(Me.Label12)
        Me.gbResumen.Controls.Add(Me.Label11)
        Me.gbResumen.Controls.Add(Me.Label10)
        Me.gbResumen.Controls.Add(Me.Label9)
        Me.gbResumen.Controls.Add(Me.Label8)
        Me.gbResumen.Controls.Add(Me.Label7)
        Me.gbResumen.Controls.Add(Me.Label6)
        Me.gbResumen.Controls.Add(Me.Label5)
        Me.gbResumen.Controls.Add(Me.Label3)
        Me.gbResumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbResumen.ForeColor = System.Drawing.Color.Goldenrod
        Me.gbResumen.Location = New System.Drawing.Point(660, 74)
        Me.gbResumen.Name = "gbResumen"
        Me.gbResumen.Size = New System.Drawing.Size(648, 404)
        Me.gbResumen.TabIndex = 8
        Me.gbResumen.TabStop = False
        '
        'tbResultadosUnidadesProducidas
        '
        Me.tbResultadosUnidadesProducidas.BackColor = System.Drawing.Color.MidnightBlue
        Me.tbResultadosUnidadesProducidas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbResultadosUnidadesProducidas.ForeColor = System.Drawing.Color.Goldenrod
        Me.tbResultadosUnidadesProducidas.Location = New System.Drawing.Point(524, 231)
        Me.tbResultadosUnidadesProducidas.Name = "tbResultadosUnidadesProducidas"
        Me.tbResultadosUnidadesProducidas.ReadOnly = True
        Me.tbResultadosUnidadesProducidas.Size = New System.Drawing.Size(102, 15)
        Me.tbResultadosUnidadesProducidas.TabIndex = 60
        Me.tbResultadosUnidadesProducidas.Text = "$ 12,987,000.95"
        Me.tbResultadosUnidadesProducidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbResultadosUtilidadDeseada
        '
        Me.cbResultadosUtilidadDeseada.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbResultadosUtilidadDeseada.FormattingEnabled = True
        Me.cbResultadosUtilidadDeseada.Location = New System.Drawing.Point(527, 321)
        Me.cbResultadosUtilidadDeseada.Name = "cbResultadosUtilidadDeseada"
        Me.cbResultadosUtilidadDeseada.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbResultadosUtilidadDeseada.Size = New System.Drawing.Size(99, 24)
        Me.cbResultadosUtilidadDeseada.TabIndex = 59
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.Silver
        Me.Label27.Location = New System.Drawing.Point(237, 340)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(125, 17)
        Me.Label27.TabIndex = 57
        Me.Label27.Text = "G Variabe Unitario"
        '
        'tbCVU
        '
        Me.tbCVU.BackColor = System.Drawing.Color.MidnightBlue
        Me.tbCVU.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbCVU.ForeColor = System.Drawing.Color.Goldenrod
        Me.tbCVU.Location = New System.Drawing.Point(289, 311)
        Me.tbCVU.Name = "tbCVU"
        Me.tbCVU.ReadOnly = True
        Me.tbCVU.Size = New System.Drawing.Size(102, 15)
        Me.tbCVU.TabIndex = 56
        Me.tbCVU.Text = "$ 12,987,000.95"
        Me.tbCVU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbGVU
        '
        Me.tbGVU.BackColor = System.Drawing.Color.MidnightBlue
        Me.tbGVU.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbGVU.ForeColor = System.Drawing.Color.Goldenrod
        Me.tbGVU.Location = New System.Drawing.Point(289, 372)
        Me.tbGVU.Name = "tbGVU"
        Me.tbGVU.ReadOnly = True
        Me.tbGVU.Size = New System.Drawing.Size(102, 15)
        Me.tbGVU.TabIndex = 54
        Me.tbGVU.Text = "$ 12,987,000.95"
        Me.tbGVU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.Color.Silver
        Me.Label29.Location = New System.Drawing.Point(236, 277)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(126, 17)
        Me.Label29.TabIndex = 53
        Me.Label29.Text = "C Variable Unitario"
        '
        'tbGVariable
        '
        Me.tbGVariable.BackColor = System.Drawing.Color.MidnightBlue
        Me.tbGVariable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbGVariable.ForeColor = System.Drawing.Color.Goldenrod
        Me.tbGVariable.Location = New System.Drawing.Point(117, 372)
        Me.tbGVariable.Name = "tbGVariable"
        Me.tbGVariable.ReadOnly = True
        Me.tbGVariable.Size = New System.Drawing.Size(102, 15)
        Me.tbGVariable.TabIndex = 52
        Me.tbGVariable.Text = "$ 12,987,000.95"
        Me.tbGVariable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbGFijo
        '
        Me.tbGFijo.BackColor = System.Drawing.Color.MidnightBlue
        Me.tbGFijo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbGFijo.ForeColor = System.Drawing.Color.Goldenrod
        Me.tbGFijo.Location = New System.Drawing.Point(117, 341)
        Me.tbGFijo.Name = "tbGFijo"
        Me.tbGFijo.ReadOnly = True
        Me.tbGFijo.Size = New System.Drawing.Size(102, 15)
        Me.tbGFijo.TabIndex = 51
        Me.tbGFijo.Text = "$ 12,987,000.95"
        Me.tbGFijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCVariable
        '
        Me.tbCVariable.BackColor = System.Drawing.Color.MidnightBlue
        Me.tbCVariable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbCVariable.ForeColor = System.Drawing.Color.Goldenrod
        Me.tbCVariable.Location = New System.Drawing.Point(117, 309)
        Me.tbCVariable.Name = "tbCVariable"
        Me.tbCVariable.ReadOnly = True
        Me.tbCVariable.Size = New System.Drawing.Size(102, 15)
        Me.tbCVariable.TabIndex = 50
        Me.tbCVariable.Text = "$ 12,987,000.95"
        Me.tbCVariable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCFijo
        '
        Me.tbCFijo.BackColor = System.Drawing.Color.MidnightBlue
        Me.tbCFijo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbCFijo.ForeColor = System.Drawing.Color.Goldenrod
        Me.tbCFijo.Location = New System.Drawing.Point(115, 279)
        Me.tbCFijo.Name = "tbCFijo"
        Me.tbCFijo.ReadOnly = True
        Me.tbCFijo.Size = New System.Drawing.Size(102, 15)
        Me.tbCFijo.TabIndex = 49
        Me.tbCFijo.Text = "$ 12,987,000.95"
        Me.tbCFijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Silver
        Me.Label21.Location = New System.Drawing.Point(62, 372)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(60, 17)
        Me.Label21.TabIndex = 48
        Me.Label21.Text = "G Varia."
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.Silver
        Me.Label24.Location = New System.Drawing.Point(62, 341)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(45, 17)
        Me.Label24.TabIndex = 47
        Me.Label24.Text = "G Fijo"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.Silver
        Me.Label25.Location = New System.Drawing.Point(62, 309)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(58, 17)
        Me.Label25.TabIndex = 46
        Me.Label25.Text = "C Varia."
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.Silver
        Me.Label26.Location = New System.Drawing.Point(62, 277)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(43, 17)
        Me.Label26.TabIndex = 45
        Me.Label26.Text = "C Fijo"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Silver
        Me.Label22.Location = New System.Drawing.Point(419, 202)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(203, 17)
        Me.Label22.TabIndex = 43
        Me.Label22.Text = "si las unidades producidas son"
        '
        'tbCPU
        '
        Me.tbCPU.BackColor = System.Drawing.Color.MidnightBlue
        Me.tbCPU.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbCPU.ForeColor = System.Drawing.Color.Goldenrod
        Me.tbCPU.Location = New System.Drawing.Point(524, 173)
        Me.tbCPU.Name = "tbCPU"
        Me.tbCPU.ReadOnly = True
        Me.tbCPU.Size = New System.Drawing.Size(102, 15)
        Me.tbCPU.TabIndex = 42
        Me.tbCPU.Text = "$ 12,987,000.95"
        Me.tbCPU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.Silver
        Me.Label23.Location = New System.Drawing.Point(419, 171)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(108, 17)
        Me.Label23.TabIndex = 41
        Me.Label23.Text = "C Prod. Unitario"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Silver
        Me.Label20.Location = New System.Drawing.Point(419, 295)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(196, 17)
        Me.Label20.TabIndex = 35
        Me.Label20.Text = "si el % de utilidad deseado es"
        '
        'tbPrecioVenta
        '
        Me.tbPrecioVenta.BackColor = System.Drawing.Color.MidnightBlue
        Me.tbPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbPrecioVenta.ForeColor = System.Drawing.Color.Goldenrod
        Me.tbPrecioVenta.Location = New System.Drawing.Point(521, 264)
        Me.tbPrecioVenta.Name = "tbPrecioVenta"
        Me.tbPrecioVenta.ReadOnly = True
        Me.tbPrecioVenta.Size = New System.Drawing.Size(102, 15)
        Me.tbPrecioVenta.TabIndex = 34
        Me.tbPrecioVenta.Text = "$ 12,987,000.95"
        Me.tbPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Silver
        Me.Label19.Location = New System.Drawing.Point(416, 262)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(109, 17)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "Precio de Venta"
        '
        'tbCTU
        '
        Me.tbCTU.BackColor = System.Drawing.Color.MidnightBlue
        Me.tbCTU.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbCTU.ForeColor = System.Drawing.Color.Goldenrod
        Me.tbCTU.Location = New System.Drawing.Point(524, 142)
        Me.tbCTU.Name = "tbCTU"
        Me.tbCTU.ReadOnly = True
        Me.tbCTU.Size = New System.Drawing.Size(102, 15)
        Me.tbCTU.TabIndex = 32
        Me.tbCTU.Text = "$ 12,987,000.95"
        Me.tbCTU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Silver
        Me.Label18.Location = New System.Drawing.Point(419, 140)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(106, 17)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "C Total Unitario"
        '
        'tbCostoTotal
        '
        Me.tbCostoTotal.BackColor = System.Drawing.Color.MidnightBlue
        Me.tbCostoTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbCostoTotal.ForeColor = System.Drawing.Color.Goldenrod
        Me.tbCostoTotal.Location = New System.Drawing.Point(524, 108)
        Me.tbCostoTotal.Name = "tbCostoTotal"
        Me.tbCostoTotal.ReadOnly = True
        Me.tbCostoTotal.Size = New System.Drawing.Size(102, 15)
        Me.tbCostoTotal.TabIndex = 30
        Me.tbCostoTotal.Text = "$ 12,987,000.95"
        Me.tbCostoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Silver
        Me.Label17.Location = New System.Drawing.Point(419, 106)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 17)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Costo Total"
        '
        'tbGOperacion
        '
        Me.tbGOperacion.BackColor = System.Drawing.Color.MidnightBlue
        Me.tbGOperacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbGOperacion.ForeColor = System.Drawing.Color.Goldenrod
        Me.tbGOperacion.Location = New System.Drawing.Point(289, 204)
        Me.tbGOperacion.Name = "tbGOperacion"
        Me.tbGOperacion.ReadOnly = True
        Me.tbGOperacion.Size = New System.Drawing.Size(102, 15)
        Me.tbGOperacion.TabIndex = 28
        Me.tbGOperacion.Text = "$ 12,987,000.95"
        Me.tbGOperacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Silver
        Me.Label16.Location = New System.Drawing.Point(236, 202)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 17)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "G Oper."
        '
        'tbCProduccion
        '
        Me.tbCProduccion.BackColor = System.Drawing.Color.MidnightBlue
        Me.tbCProduccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbCProduccion.ForeColor = System.Drawing.Color.Goldenrod
        Me.tbCProduccion.Location = New System.Drawing.Point(288, 140)
        Me.tbCProduccion.Name = "tbCProduccion"
        Me.tbCProduccion.ReadOnly = True
        Me.tbCProduccion.Size = New System.Drawing.Size(102, 15)
        Me.tbCProduccion.TabIndex = 26
        Me.tbCProduccion.Text = "$ 12,987,000.95"
        Me.tbCProduccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Silver
        Me.Label15.Location = New System.Drawing.Point(235, 138)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 17)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "C Prod."
        '
        'tbCTransformacion
        '
        Me.tbCTransformacion.BackColor = System.Drawing.Color.MidnightBlue
        Me.tbCTransformacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbCTransformacion.ForeColor = System.Drawing.Color.Goldenrod
        Me.tbCTransformacion.Location = New System.Drawing.Point(287, 109)
        Me.tbCTransformacion.Name = "tbCTransformacion"
        Me.tbCTransformacion.ReadOnly = True
        Me.tbCTransformacion.Size = New System.Drawing.Size(102, 15)
        Me.tbCTransformacion.TabIndex = 24
        Me.tbCTransformacion.Text = "$ 12,987,000.95"
        Me.tbCTransformacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Silver
        Me.Label14.Location = New System.Drawing.Point(234, 107)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 17)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "C Trans."
        '
        'tbCPrimo
        '
        Me.tbCPrimo.BackColor = System.Drawing.Color.MidnightBlue
        Me.tbCPrimo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbCPrimo.ForeColor = System.Drawing.Color.Goldenrod
        Me.tbCPrimo.Location = New System.Drawing.Point(287, 77)
        Me.tbCPrimo.Name = "tbCPrimo"
        Me.tbCPrimo.ReadOnly = True
        Me.tbCPrimo.Size = New System.Drawing.Size(102, 15)
        Me.tbCPrimo.TabIndex = 22
        Me.tbCPrimo.Text = "$ 12,987,000.95"
        Me.tbCPrimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Silver
        Me.Label13.Location = New System.Drawing.Point(234, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 17)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "C Primo"
        '
        'tbGF
        '
        Me.tbGF.BackColor = System.Drawing.Color.MidnightBlue
        Me.tbGF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbGF.ForeColor = System.Drawing.Color.Goldenrod
        Me.tbGF.Location = New System.Drawing.Point(115, 235)
        Me.tbGF.Name = "tbGF"
        Me.tbGF.ReadOnly = True
        Me.tbGF.Size = New System.Drawing.Size(102, 15)
        Me.tbGF.TabIndex = 20
        Me.tbGF.Text = "$ 12,987,000.95"
        Me.tbGF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbGA
        '
        Me.tbGA.BackColor = System.Drawing.Color.MidnightBlue
        Me.tbGA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbGA.ForeColor = System.Drawing.Color.Goldenrod
        Me.tbGA.Location = New System.Drawing.Point(115, 204)
        Me.tbGA.Name = "tbGA"
        Me.tbGA.ReadOnly = True
        Me.tbGA.Size = New System.Drawing.Size(102, 15)
        Me.tbGA.TabIndex = 19
        Me.tbGA.Text = "$ 12,987,000.95"
        Me.tbGA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbGV
        '
        Me.tbGV.BackColor = System.Drawing.Color.MidnightBlue
        Me.tbGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbGV.ForeColor = System.Drawing.Color.Goldenrod
        Me.tbGV.Location = New System.Drawing.Point(115, 171)
        Me.tbGV.Name = "tbGV"
        Me.tbGV.ReadOnly = True
        Me.tbGV.Size = New System.Drawing.Size(102, 15)
        Me.tbGV.TabIndex = 18
        Me.tbGV.Text = "$ 12,987,000.95"
        Me.tbGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCIF
        '
        Me.tbCIF.BackColor = System.Drawing.Color.MidnightBlue
        Me.tbCIF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbCIF.ForeColor = System.Drawing.Color.Goldenrod
        Me.tbCIF.Location = New System.Drawing.Point(115, 140)
        Me.tbCIF.Name = "tbCIF"
        Me.tbCIF.ReadOnly = True
        Me.tbCIF.Size = New System.Drawing.Size(102, 15)
        Me.tbCIF.TabIndex = 17
        Me.tbCIF.Text = "$ 12,987,000.95"
        Me.tbCIF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCMOD
        '
        Me.tbCMOD.BackColor = System.Drawing.Color.MidnightBlue
        Me.tbCMOD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbCMOD.ForeColor = System.Drawing.Color.Goldenrod
        Me.tbCMOD.Location = New System.Drawing.Point(115, 108)
        Me.tbCMOD.Name = "tbCMOD"
        Me.tbCMOD.ReadOnly = True
        Me.tbCMOD.Size = New System.Drawing.Size(102, 15)
        Me.tbCMOD.TabIndex = 16
        Me.tbCMOD.Text = "$ 12,987,000.95"
        Me.tbCMOD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCMPD
        '
        Me.tbCMPD.BackColor = System.Drawing.Color.MidnightBlue
        Me.tbCMPD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbCMPD.ForeColor = System.Drawing.Color.Goldenrod
        Me.tbCMPD.Location = New System.Drawing.Point(113, 78)
        Me.tbCMPD.Name = "tbCMPD"
        Me.tbCMPD.ReadOnly = True
        Me.tbCMPD.Size = New System.Drawing.Size(102, 15)
        Me.tbCMPD.TabIndex = 15
        Me.tbCMPD.Text = "$ 12,987,000.95"
        Me.tbCMPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Silver
        Me.Label12.Location = New System.Drawing.Point(60, 233)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 17)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "GF"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Silver
        Me.Label11.Location = New System.Drawing.Point(60, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 17)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "GA"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Silver
        Me.Label10.Location = New System.Drawing.Point(60, 171)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 17)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "GV"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Silver
        Me.Label9.Location = New System.Drawing.Point(60, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 17)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "CIF"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Silver
        Me.Label8.Location = New System.Drawing.Point(60, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "CMOD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(60, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "CMPD"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 119)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "D" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " I" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "R" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "C" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "T" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "O"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 170)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "B" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "O" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "R" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "B" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "N" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "T" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Silver
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(8, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(446, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "RESUMEN POR MODO DE COSTEO"
        '
        'gbEdoResultados
        '
        Me.gbEdoResultados.BackColor = System.Drawing.Color.Transparent
        Me.gbEdoResultados.Controls.Add(Me.cbNoTruncar)
        Me.gbEdoResultados.Controls.Add(Me.cbSinSangrias)
        Me.gbEdoResultados.Controls.Add(Me.cbEdoResTipo)
        Me.gbEdoResultados.Controls.Add(Me.dgvEdoRes)
        Me.gbEdoResultados.Controls.Add(Me.Label4)
        Me.gbEdoResultados.Controls.Add(Me.dgvEdoResultados)
        Me.gbEdoResultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEdoResultados.ForeColor = System.Drawing.Color.Goldenrod
        Me.gbEdoResultados.Location = New System.Drawing.Point(660, 478)
        Me.gbEdoResultados.Name = "gbEdoResultados"
        Me.gbEdoResultados.Size = New System.Drawing.Size(648, 390)
        Me.gbEdoResultados.TabIndex = 9
        Me.gbEdoResultados.TabStop = False
        '
        'cbNoTruncar
        '
        Me.cbNoTruncar.AutoSize = True
        Me.cbNoTruncar.Location = New System.Drawing.Point(238, 55)
        Me.cbNoTruncar.Name = "cbNoTruncar"
        Me.cbNoTruncar.Size = New System.Drawing.Size(205, 21)
        Me.cbNoTruncar.TabIndex = 58
        Me.cbNoTruncar.Text = "No truncar valores unitarios"
        Me.cbNoTruncar.UseVisualStyleBackColor = True
        '
        'cbSinSangrias
        '
        Me.cbSinSangrias.AutoSize = True
        Me.cbSinSangrias.Location = New System.Drawing.Point(7, 55)
        Me.cbSinSangrias.Name = "cbSinSangrias"
        Me.cbSinSangrias.Size = New System.Drawing.Size(108, 21)
        Me.cbSinSangrias.TabIndex = 57
        Me.cbSinSangrias.Text = "Sin sangrias"
        Me.cbSinSangrias.UseVisualStyleBackColor = True
        '
        'cbEdoResTipo
        '
        Me.cbEdoResTipo.FormattingEnabled = True
        Me.cbEdoResTipo.Items.AddRange(New Object() {"por Costeo Absorbente", "por Costeo Directo"})
        Me.cbEdoResTipo.Location = New System.Drawing.Point(353, 24)
        Me.cbEdoResTipo.Name = "cbEdoResTipo"
        Me.cbEdoResTipo.Size = New System.Drawing.Size(172, 24)
        Me.cbEdoResTipo.TabIndex = 7
        Me.cbEdoResTipo.Text = "- Tipo -"
        '
        'dgvEdoRes
        '
        Me.dgvEdoRes.AllowUserToOrderColumns = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEdoRes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvEdoRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEdoRes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEdoRes.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvEdoRes.GridColor = System.Drawing.Color.DimGray
        Me.dgvEdoRes.Location = New System.Drawing.Point(237, 76)
        Me.dgvEdoRes.Name = "dgvEdoRes"
        Me.dgvEdoRes.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEdoRes.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvEdoRes.RowHeadersVisible = False
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        Me.dgvEdoRes.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvEdoRes.RowTemplate.Height = 24
        Me.dgvEdoRes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvEdoRes.Size = New System.Drawing.Size(405, 308)
        Me.dgvEdoRes.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn1.FillWeight = 160.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 160
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(8, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(339, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ESTADO DE RESULTADOS"
        '
        'dgvEdoResultados
        '
        Me.dgvEdoResultados.AllowUserToOrderColumns = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEdoResultados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvEdoResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEdoResultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvEdoResColConcepto})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEdoResultados.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvEdoResultados.GridColor = System.Drawing.Color.DimGray
        Me.dgvEdoResultados.Location = New System.Drawing.Point(5, 76)
        Me.dgvEdoResultados.Name = "dgvEdoResultados"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEdoResultados.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvEdoResultados.RowHeadersVisible = False
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black
        Me.dgvEdoResultados.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvEdoResultados.RowTemplate.Height = 24
        Me.dgvEdoResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvEdoResultados.Size = New System.Drawing.Size(231, 308)
        Me.dgvEdoResultados.TabIndex = 1
        '
        'dgvEdoResColConcepto
        '
        Me.dgvEdoResColConcepto.FillWeight = 220.0!
        Me.dgvEdoResColConcepto.HeaderText = "Concepto"
        Me.dgvEdoResColConcepto.Name = "dgvEdoResColConcepto"
        Me.dgvEdoResColConcepto.ReadOnly = True
        Me.dgvEdoResColConcepto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvEdoResColConcepto.Width = 220
        '
        'bInforme
        '
        Me.bInforme.BackColor = System.Drawing.Color.Silver
        Me.bInforme.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bInforme.ForeColor = System.Drawing.Color.MidnightBlue
        Me.bInforme.Location = New System.Drawing.Point(227, 23)
        Me.bInforme.Name = "bInforme"
        Me.bInforme.Size = New System.Drawing.Size(87, 39)
        Me.bInforme.TabIndex = 10
        Me.bInforme.Text = "Informe"
        Me.bInforme.UseVisualStyleBackColor = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label32.Location = New System.Drawing.Point(113, 29)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(360, 17)
        Me.Label32.TabIndex = 11
        Me.Label32.Text = "____________________________________________"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label33.Location = New System.Drawing.Point(897, 29)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(328, 17)
        Me.Label33.TabIndex = 12
        Me.Label33.Text = "________________________________________"
        '
        'bLeyenda
        '
        Me.bLeyenda.BackColor = System.Drawing.Color.Silver
        Me.bLeyenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bLeyenda.ForeColor = System.Drawing.Color.MidnightBlue
        Me.bLeyenda.Location = New System.Drawing.Point(1107, 23)
        Me.bLeyenda.Name = "bLeyenda"
        Me.bLeyenda.Size = New System.Drawing.Size(83, 39)
        Me.bLeyenda.TabIndex = 13
        Me.bLeyenda.Text = "Leyenda"
        Me.bLeyenda.UseVisualStyleBackColor = False
        '
        'bAcercaDe
        '
        Me.bAcercaDe.BackColor = System.Drawing.Color.Silver
        Me.bAcercaDe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAcercaDe.ForeColor = System.Drawing.Color.MidnightBlue
        Me.bAcercaDe.Location = New System.Drawing.Point(1005, 23)
        Me.bAcercaDe.Name = "bAcercaDe"
        Me.bAcercaDe.Size = New System.Drawing.Size(96, 39)
        Me.bAcercaDe.TabIndex = 14
        Me.bAcercaDe.Text = "Acerca de"
        Me.bAcercaDe.UseVisualStyleBackColor = False
        '
        'bEjemplo2
        '
        Me.bEjemplo2.BackColor = System.Drawing.Color.Silver
        Me.bEjemplo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEjemplo2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.bEjemplo2.Location = New System.Drawing.Point(64, 18)
        Me.bEjemplo2.Name = "bEjemplo2"
        Me.bEjemplo2.Size = New System.Drawing.Size(50, 24)
        Me.bEjemplo2.TabIndex = 15
        Me.bEjemplo2.Text = "2"
        Me.bEjemplo2.UseVisualStyleBackColor = False
        '
        'bTipsUso
        '
        Me.bTipsUso.BackColor = System.Drawing.Color.Silver
        Me.bTipsUso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bTipsUso.ForeColor = System.Drawing.Color.MidnightBlue
        Me.bTipsUso.Location = New System.Drawing.Point(1196, 23)
        Me.bTipsUso.Name = "bTipsUso"
        Me.bTipsUso.Size = New System.Drawing.Size(114, 39)
        Me.bTipsUso.TabIndex = 16
        Me.bTipsUso.Text = "Tips de uso"
        Me.bTipsUso.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bEjemplo1)
        Me.GroupBox1.Controls.Add(Me.bEjemplo2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 49)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "  Ejemplos  "
        '
        'bEjemplo1
        '
        Me.bEjemplo1.BackColor = System.Drawing.Color.Silver
        Me.bEjemplo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEjemplo1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.bEjemplo1.Location = New System.Drawing.Point(7, 18)
        Me.bEjemplo1.Name = "bEjemplo1"
        Me.bEjemplo1.Size = New System.Drawing.Size(50, 24)
        Me.bEjemplo1.TabIndex = 16
        Me.bEjemplo1.Text = "1"
        Me.bEjemplo1.UseVisualStyleBackColor = False
        '
        'fContabilidadCostos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1316, 872)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bTipsUso)
        Me.Controls.Add(Me.bAcercaDe)
        Me.Controls.Add(Me.bLeyenda)
        Me.Controls.Add(Me.bInforme)
        Me.Controls.Add(Me.gbEdoResultados)
        Me.Controls.Add(Me.gbResumen)
        Me.Controls.Add(Me.bCalcularTodo)
        Me.Controls.Add(Me.gbCedula)
        Me.Controls.Add(Me.gbDatos)
        Me.Controls.Add(Me.lContabilidadCostos)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label33)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fContabilidadCostos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contabilidad de Costos"
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.gbCedula.ResumeLayout(False)
        Me.gbCedula.PerformLayout()
        CType(Me.dgvCedula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbResumen.ResumeLayout(False)
        Me.gbResumen.PerformLayout()
        Me.gbEdoResultados.ResumeLayout(False)
        Me.gbEdoResultados.PerformLayout()
        CType(Me.dgvEdoRes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEdoResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lContabilidadCostos As Label
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents gbDatos As GroupBox
    Friend WithEvents bDatosCargar As Button
    Friend WithEvents bDatosGuardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents gbCedula As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents bCalcularTodo As Button
    Friend WithEvents dgvCedula As DataGridView
    Friend WithEvents bDatosBorrar As Button
    Friend WithEvents gbResumen As GroupBox
    Friend WithEvents Label22 As Label
    Friend WithEvents tbCPU As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents tbPrecioVenta As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents tbCTU As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents tbCostoTotal As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents tbGOperacion As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents tbCProduccion As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents tbCTransformacion As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents tbCPrimo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents tbGF As TextBox
    Friend WithEvents tbGA As TextBox
    Friend WithEvents tbGV As TextBox
    Friend WithEvents tbCIF As TextBox
    Friend WithEvents tbCMOD As TextBox
    Friend WithEvents tbCMPD As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents gbEdoResultados As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvEdoResultados As DataGridView
    Friend WithEvents Label27 As Label
    Friend WithEvents tbCVU As TextBox
    Friend WithEvents tbGVU As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents tbGVariable As TextBox
    Friend WithEvents tbGFijo As TextBox
    Friend WithEvents tbCVariable As TextBox
    Friend WithEvents tbCFijo As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents tbUnidadesVendidas As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents tbUnidadesProducidas As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents cbUnidadesVendidas As ComboBox
    Friend WithEvents bQuitarUtilidadDeseada As Button
    Friend WithEvents tbUtilidadDeseada As TextBox
    Friend WithEvents bAgregarUtilidadDeseada As Button
    Friend WithEvents cbUtilidadDeseada As ComboBox
    Friend WithEvents Label31 As Label
    Friend WithEvents bQuitarUnidadesVendidas As Button
    Friend WithEvents bAgregarUnidadesVendidas As Button
    Friend WithEvents cbCedulaTipo As ComboBox
    Friend WithEvents bInforme As Button
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents cbResultadosUtilidadDeseada As ComboBox
    Friend WithEvents bLeyenda As Button
    Friend WithEvents bAcercaDe As Button
    Friend WithEvents dgvEdoRes As DataGridView
    Friend WithEvents dgvCedulaColConcepto As DataGridViewTextBoxColumn
    Friend WithEvents dgvCedulaColImporte As DataGridViewTextBoxColumn
    Friend WithEvents dgvCedulaColTotal As DataGridViewTextBoxColumn
    Friend WithEvents tbResultadosUnidadesProducidas As TextBox
    Friend WithEvents cbEnumerar As CheckBox
    Friend WithEvents bEjemplo2 As Button
    Friend WithEvents dgvEdoResColConcepto As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents bTipsUso As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents bEjemplo1 As Button
    Friend WithEvents cbEdoResTipo As ComboBox
    Friend WithEvents tbPeriodo As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents tbNombreEmpresa As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents cbSinSangrias As CheckBox
    Friend WithEvents cbNoTruncar As CheckBox
    Friend WithEvents tbRubro As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents dgvDatosColConcepto As DataGridViewTextBoxColumn
    Friend WithEvents dgvDatosColImporte As DataGridViewTextBoxColumn
    Friend WithEvents dgvDatosColFuncion As DataGridViewComboBoxColumn
    Friend WithEvents dgvDatosColComportamiento As DataGridViewComboBoxColumn
End Class
