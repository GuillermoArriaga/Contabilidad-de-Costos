Public Class fContabilidadCostos

    ' Creacion de objetos
    Dim cedulaCostoProduccion As Cedula
    Dim cedulaGastoOperativo As Cedula
    Dim cedulaCostos As Cedula
    Dim cedulaComportamiento As Cedula
    Dim valoresUnitarios As DatoTotal
    Dim valoresUnitariosNT As DatoTotal

    Dim edoResEnv() As EdoResAbsorbente
    Dim edoResNTEnv() As EdoResAbsorbente
    Dim edoResDir() As EdoResDirecto
    Dim edoResNTDir() As EdoResDirecto

    Dim PrecioV() As PrecioVenta     'Truncado
    Dim PrecioVNT() As PrecioVenta   'No truncado

    'Fuentes
    Dim fuenteTitulo1 As Font = New Font("Calibri", 18.0F, FontStyle.Bold)
    Dim fuenteTitulo2 As Font = New Font("Calibri", 14.0F, FontStyle.Bold)
    Dim fuenteSemiTitulo As Font = New Font("Consolas", 9.0F, FontStyle.Bold)
    Dim fuenteParrafo As Font = New Font("Consolas", 9.0F, FontStyle.Regular)



    Private Sub fContabilidadCostos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Periodo de prueba
        '      If Val(System.DateTime.Now.ToString("yyyyMMdd")) > 20180000 Then
        '      MsgBox("A terminado el periodo de prueba del programa: Contabilidad de Costos." + vbCrLf + vbCrLf + "Si desea comprar una licencia, puede contactar al desarrollador en guillermoarriagag@gmail.com")
        '      Application.Exit()
        '      Exit Sub
        '      End If

        Inicializacion()
    End Sub

    Sub Inicializacion()

        'cbEnumerar.Checked = True
        cbCedulaTipo.Visible = False

        ' Inicializacion de data grids
        dgvCedula.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgvEdoRes.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgvEdoResultados.CellBorderStyle = DataGridViewCellBorderStyle.None

        dgvDatos.Rows.Clear()
        dgvCedula.Rows.Clear()
        dgvEdoRes.Rows.Clear()
        dgvEdoResultados.Rows.Clear()

        ' Inicializacion de textboxes
        tbCFijo.Text = ""
        tbCIF.Text = ""
        tbCMOD.Text = ""
        tbCMPD.Text = ""
        tbCostoTotal.Text = ""
        tbCPrimo.Text = ""
        tbCProduccion.Text = ""
        tbCPU.Text = ""
        tbCTransformacion.Text = ""
        tbCTU.Text = ""
        tbCVariable.Text = ""
        tbCVU.Text = ""
        tbGA.Text = ""
        tbGF.Text = ""
        tbGFijo.Text = ""
        tbGOperacion.Text = ""
        tbGV.Text = ""
        tbGVariable.Text = ""
        tbGVU.Text = ""
        tbPrecioVenta.Text = ""
        tbUnidadesProducidas.Text = ""
        tbUnidadesVendidas.Text = ""
        tbUtilidadDeseada.Text = ""
        tbResultadosUnidadesProducidas.Text = ""

        tbNombreEmpresa.Text = ""
        tbRubro.Text = ""
        tbPeriodo.Text = ""

        'Inicializacion de comboboxes
        cbResultadosUtilidadDeseada.Items.Clear()
        cbUnidadesVendidas.Items.Clear()
        cbUtilidadDeseada.Items.Clear()
        cbResultadosUtilidadDeseada.Text = ""
        cbUnidadesVendidas.Text = ""
        cbUtilidadDeseada.Text = ""
    End Sub

    Private Sub bCalcularTodo_Click(sender As Object, e As EventArgs) Handles bCalcularTodo.Click
        Try
            cbCedulaTipo.Visible = True
            CargarDatos()                     'Carga Datos y Calcula Todo en los Objetos

            'Muestra de Resultados cargando en datagrids
            cbCedulaTipo.SelectedIndex = 1
            cbCedulaTipo.SelectedIndex = 0
            cbNoTruncar.Checked = True
            cbEdoResTipo.SelectedIndex = 1
            cbEdoResTipo.SelectedIndex = 0
            cbNoTruncar.Checked = False
            cbEdoResTipo.SelectedIndex = 1
            cbEdoResTipo.SelectedIndex = 0

            cbResultadosUtilidadDeseada.SelectedIndex = 0
            cbUnidadesVendidas.SelectedIndex = 0
            cbUtilidadDeseada.SelectedIndex = 0

        Catch ex As Exception
            MsgBox("Para calcular es necesario que los datos esten correctamente agregados.")
        End Try
    End Sub

    Public Sub CargarDatos()
        Dim fila As Integer
        Dim contaCMPD, contaCMOD, contaCIF, contaGV, contaGA, contaGF As Integer
        Dim contaCF, contaCV, contaGFijo, contaGVariable As Integer
        Dim valorDouble As Double

        Dim datosCorrectos As Boolean

        contaCMPD = 0
        contaCMOD = 0
        contaCIF = 0
        contaGV = 0
        contaGA = 0
        contaGF = 0
        contaCF = 0
        contaCV = 0
        contaGFijo = 0
        contaGVariable = 0

        datosCorrectos = True

        ' Revision de datos completos
        If (tbUnidadesProducidas.Text = "") Then
            MsgBox("No ha indicado las unidades producidas.")
            datosCorrectos = False
        End If
        If (cbUnidadesVendidas.Items.Count = 0) Then
            MsgBox("No ha indicado al menos una cantidad de unidades vendidas.")
            datosCorrectos = False
        End If
        If (cbUtilidadDeseada.Items.Count = 0) Then
            MsgBox("No ha indicado al menos una cantidad de porcentaje de utilidad deseada.")
            datosCorrectos = False
        End If
        If datosCorrectos = False Then
            Exit Sub
        End If


        For fila = 0 To dgvDatos.RowCount - 2   'El ultimo renglon debe estar vacio

            ' Formato para los datos de entrada
            dgvDatos.Item(1, fila).Value = Convert.ToDouble(dgvDatos.Item(1, fila).Value).ToString("N2")
            If cbEnumerar.Checked Then
                dgvDatos.Item(0, fila).Value = UCase(Mid(dgvDatos.Item(0, fila).Value, 1, 1)) + Mid(dgvDatos.Item(0, fila).Value, 2, Len(dgvDatos.Item(0, fila).Value))
            End If

            'Deteccion de cantidades de conceptos segun sus clasificaciones
            Dim comboFuncion As DataGridViewComboBoxCell
            comboFuncion = dgvDatos.Item(2, fila)
            Dim comboComportamiento As DataGridViewComboBoxCell
            comboComportamiento = dgvDatos.Item(3, fila)

            Try
                Select Case (comboFuncion.Value.ToString)
                    Case "CMPD"
                        contaCMPD += 1
                    Case "CMOD"
                        contaCMOD += 1
                    Case "CIF"
                        contaCIF += 1
                    Case "GV"
                        contaGV += 1
                    Case "GA"
                        contaGA += 1
                    Case "GF"
                        contaGF += 1
                    Case Else
                        MsgBox("La fila " + (fila + 1).ToString + " no tiene seleccionada su funcion.")
                        datosCorrectos = False
                End Select
                Select Case (comboComportamiento.Value.ToString)
                    Case "C Fijo"
                        contaCF += 1
                    Case "C Variable"
                        contaCV += 1
                    Case "G Fijo"
                        contaGFijo += 1
                    Case "G Variable"
                        contaGVariable += 1
                    Case Else
                        MsgBox("La fila " + (fila + 1).ToString + " no tiene seleccionado su comportamiento.")
                        datosCorrectos = False
                End Select
            Catch ex As Exception
                MsgBox("Revise los datos de entrada por favor")
                Exit Sub
            End Try
        Next

        If datosCorrectos = False Then
            MsgBox("Para realizar el calculo se requiere que los datos sean identificados en su funcion o comportamiento.")
            Exit Sub
        End If


        'Creacion de cedulas basicas
        cedulaCostoProduccion = New Cedula("Costo de Produccion", 3, {"Costo de Materia Prima Directa", "Costo de Mano de Obra Directa", "Costo Indirecto de Fabricacion"}, {contaCMPD, contaCMOD, contaCIF})
        cedulaGastoOperativo = New Cedula("Gasto Operativo", 3, {"Gasto de Venta", "Gasto Administrativo", "Gasto Financiero"}, {contaGV, contaGA, contaGF})
        cedulaComportamiento = New Cedula("Costo y Gastos segun Comportamiento", 4, {"Costo Fijo", "Costo Variable", "Gasto Fijo", "Gasto Variable"}, {contaCF, contaCV, contaGFijo, contaGVariable})

        ' Ubicacion de datos
        contaCMPD = 0
        contaCMOD = 0
        contaCIF = 0
        contaGV = 0
        contaGA = 0
        contaGF = 0
        contaCF = 0
        contaCV = 0
        contaGFijo = 0
        contaGVariable = 0

        For fila = 0 To dgvDatos.RowCount - 2

            Dim comboFuncion As DataGridViewComboBoxCell
            comboFuncion = dgvDatos.Item(2, fila)
            Dim comboComportamiento As DataGridViewComboBoxCell
            comboComportamiento = dgvDatos.Item(3, fila)


            Select Case (comboFuncion.Value.ToString)
                Case "CMPD"
                    cedulaCostoProduccion.datosTotales(0).datos(contaCMPD).concepto = dgvDatos.Item(0, fila).Value
                    valorDouble = Convert.ToDouble(dgvDatos.Item(1, fila).Value)
                    cedulaCostoProduccion.datosTotales(0).datos(contaCMPD).importe = valorDouble
                    cedulaCostoProduccion.datosTotales(0).cantidad += valorDouble
                    contaCMPD += 1
                Case "CMOD"
                    cedulaCostoProduccion.datosTotales(1).datos(contaCMOD).concepto = dgvDatos.Item(0, fila).Value
                    valorDouble = Convert.ToDouble(dgvDatos.Item(1, fila).Value)
                    cedulaCostoProduccion.datosTotales(1).datos(contaCMOD).importe = valorDouble
                    cedulaCostoProduccion.datosTotales(1).cantidad += valorDouble
                    contaCMOD += 1
                Case "CIF"
                    cedulaCostoProduccion.datosTotales(2).datos(contaCIF).concepto = dgvDatos.Item(0, fila).Value
                    valorDouble = Convert.ToDouble(dgvDatos.Item(1, fila).Value)
                    cedulaCostoProduccion.datosTotales(2).datos(contaCIF).importe = valorDouble
                    cedulaCostoProduccion.datosTotales(2).cantidad += valorDouble
                    contaCIF += 1
                Case "GV"
                    cedulaGastoOperativo.datosTotales(0).datos(contaGV).concepto = dgvDatos.Item(0, fila).Value
                    valorDouble = Convert.ToDouble(dgvDatos.Item(1, fila).Value)
                    cedulaGastoOperativo.datosTotales(0).datos(contaGV).importe = valorDouble
                    cedulaGastoOperativo.datosTotales(0).cantidad += valorDouble
                    contaGV += 1
                Case "GA"
                    cedulaGastoOperativo.datosTotales(1).datos(contaGA).concepto = dgvDatos.Item(0, fila).Value
                    valorDouble = Convert.ToDouble(dgvDatos.Item(1, fila).Value)
                    cedulaGastoOperativo.datosTotales(1).datos(contaGA).importe = valorDouble
                    cedulaGastoOperativo.datosTotales(1).cantidad += valorDouble
                    contaGA += 1
                Case "GF"
                    cedulaGastoOperativo.datosTotales(2).datos(contaGF).concepto = dgvDatos.Item(0, fila).Value
                    valorDouble = Convert.ToDouble(dgvDatos.Item(1, fila).Value)
                    cedulaGastoOperativo.datosTotales(2).datos(contaGF).importe = valorDouble
                    cedulaGastoOperativo.datosTotales(2).cantidad += valorDouble
                    contaGF += 1
                Case Else
                    MsgBox("La fila " + (fila + 1).ToString + " no tiene seleccionada su funcion.")
                    datosCorrectos = False
            End Select

            Select Case (comboComportamiento.Value.ToString)
                Case "C Fijo"
                    cedulaComportamiento.datosTotales(0).datos(contaCF).concepto = dgvDatos.Item(0, fila).Value
                    valorDouble = Convert.ToDouble(dgvDatos.Item(1, fila).Value)
                    cedulaComportamiento.datosTotales(0).datos(contaCF).importe = valorDouble
                    cedulaComportamiento.datosTotales(0).cantidad += valorDouble
                    contaCF += 1
                Case "C Variable"
                    cedulaComportamiento.datosTotales(1).datos(contaCV).concepto = dgvDatos.Item(0, fila).Value
                    valorDouble = Convert.ToDouble(dgvDatos.Item(1, fila).Value)
                    cedulaComportamiento.datosTotales(1).datos(contaCV).importe = valorDouble
                    cedulaComportamiento.datosTotales(1).cantidad += valorDouble
                    contaCV += 1
                Case "G Fijo"
                    cedulaComportamiento.datosTotales(2).datos(contaGFijo).concepto = dgvDatos.Item(0, fila).Value
                    valorDouble = Convert.ToDouble(dgvDatos.Item(1, fila).Value)
                    cedulaComportamiento.datosTotales(2).datos(contaGFijo).importe = valorDouble
                    cedulaComportamiento.datosTotales(2).cantidad += valorDouble
                    contaGFijo += 1
                Case "G Variable"
                    cedulaComportamiento.datosTotales(3).datos(contaGVariable).concepto = dgvDatos.Item(0, fila).Value
                    valorDouble = Convert.ToDouble(dgvDatos.Item(1, fila).Value)
                    cedulaComportamiento.datosTotales(3).datos(contaGVariable).importe = valorDouble
                    cedulaComportamiento.datosTotales(3).cantidad += valorDouble
                    contaGVariable += 1
                Case Else
                    MsgBox("La fila " + (fila + 1).ToString + " no tiene seleccionado su comportamiento.")
                    datosCorrectos = False
            End Select
        Next

        tbCMPD.Text = "$ " + cedulaCostoProduccion.datosTotales(0).cantidad.ToString("N")
        tbCMOD.Text = "$ " + cedulaCostoProduccion.datosTotales(1).cantidad.ToString("N")
        tbCIF.Text = "$ " + cedulaCostoProduccion.datosTotales(2).cantidad.ToString("N")

        tbGV.Text = "$ " + cedulaGastoOperativo.datosTotales(0).cantidad.ToString("N")
        tbGA.Text = "$ " + cedulaGastoOperativo.datosTotales(1).cantidad.ToString("N")
        tbGF.Text = "$ " + cedulaGastoOperativo.datosTotales(2).cantidad.ToString("N")

        tbCFijo.Text = "$ " + cedulaComportamiento.datosTotales(0).cantidad.ToString("N")
        tbCVariable.Text = "$ " + cedulaComportamiento.datosTotales(1).cantidad.ToString("N")
        tbGFijo.Text = "$ " + cedulaComportamiento.datosTotales(2).cantidad.ToString("N")
        tbGVariable.Text = "$ " + cedulaComportamiento.datosTotales(3).cantidad.ToString("N")

        'Costo Primo, de transformacion, total y valores unitarios
        cedulaCostoProduccion.cantidad = cedulaCostoProduccion.datosTotales(0).cantidad + cedulaCostoProduccion.datosTotales(1).cantidad + cedulaCostoProduccion.datosTotales(2).cantidad
        cedulaGastoOperativo.cantidad = cedulaGastoOperativo.datosTotales(0).cantidad + cedulaGastoOperativo.datosTotales(1).cantidad + cedulaGastoOperativo.datosTotales(2).cantidad
        cedulaCostos = New Cedula("Costos Sinteticos", 3, {"Costo Primo", "Costo de Transformacion", "Costo Total"}, {2, 2, 2}, {{"Costo de Materia Prima Directa", "Costo de Mano de Obra Directa"}, {"Costo de Mano de Obra Directa", "Costo Indirecto de Fabricacion"}, {"Costo de Produccion", "Gasto Operativo"}}, {{cedulaCostoProduccion.datosTotales(0).cantidad, cedulaCostoProduccion.datosTotales(1).cantidad}, {cedulaCostoProduccion.datosTotales(1).cantidad, cedulaCostoProduccion.datosTotales(2).cantidad}, {cedulaCostoProduccion.cantidad, cedulaGastoOperativo.cantidad}})

        tbCPrimo.Text = "$ " + cedulaCostos.datosTotales(0).cantidad.ToString("N")
        tbCTransformacion.Text = "$ " + cedulaCostos.datosTotales(1).cantidad.ToString("N")
        tbCostoTotal.Text = "$ " + cedulaCostos.datosTotales(2).cantidad.ToString("N")
        tbCProduccion.Text = "$ " + cedulaCostoProduccion.cantidad.ToString("N")
        tbGOperacion.Text = "$ " + cedulaGastoOperativo.cantidad.ToString("N")

        'Valores unitarios trucados
        valoresUnitarios = New DatoTotal("Valores Unitarios", 4)
        valoresUnitarios.datos(0).concepto = "Costo Total Unitario"
        valoresUnitarios.datos(0).importe = Math.Truncate(cedulaCostos.datosTotales(2).cantidad * 100 / Convert.ToDouble(tbUnidadesProducidas.Text)) / 100
        valoresUnitarios.datos(1).concepto = "Costo de Produccion Unitario"
        valoresUnitarios.datos(1).importe = Math.Truncate(cedulaCostoProduccion.cantidad * 100 / Convert.ToDouble(tbUnidadesProducidas.Text)) / 100
        valoresUnitarios.datos(2).concepto = "Costo Variable Unitario"
        valoresUnitarios.datos(2).importe = Math.Truncate(cedulaComportamiento.datosTotales(1).cantidad * 100 / Convert.ToDouble(tbUnidadesProducidas.Text)) / 100
        valoresUnitarios.datos(3).concepto = "Gasto Variable Unitario"
        valoresUnitarios.datos(3).importe = Math.Truncate(cedulaComportamiento.datosTotales(3).cantidad * 100 / Convert.ToDouble(tbUnidadesProducidas.Text)) / 100

        'Valores unitarios no trucados
        valoresUnitariosNT = New DatoTotal("Valores Unitarios", 4)
        valoresUnitariosNT.datos(0).concepto = "Costo Total Unitario"
        valoresUnitariosNT.datos(0).importe = cedulaCostos.datosTotales(2).cantidad / Convert.ToDouble(tbUnidadesProducidas.Text)
        valoresUnitariosNT.datos(1).concepto = "Costo de Produccion Unitario"
        valoresUnitariosNT.datos(1).importe = cedulaCostoProduccion.cantidad / Convert.ToDouble(tbUnidadesProducidas.Text)
        valoresUnitariosNT.datos(2).concepto = "Costo Variable Unitario"
        valoresUnitariosNT.datos(2).importe = cedulaComportamiento.datosTotales(1).cantidad / Convert.ToDouble(tbUnidadesProducidas.Text)
        valoresUnitariosNT.datos(3).concepto = "Gasto Variable Unitario"
        valoresUnitariosNT.datos(3).importe = cedulaComportamiento.datosTotales(3).cantidad / Convert.ToDouble(tbUnidadesProducidas.Text)

        If cbNoTruncar.Checked = True Then
            tbCTU.Text = "$ " + valoresUnitariosNT.datos(0).importe.ToString("N4")
            tbCPU.Text = "$ " + valoresUnitariosNT.datos(1).importe.ToString("N4")
            tbCVU.Text = "$ " + valoresUnitariosNT.datos(2).importe.ToString("N4")
            tbGVU.Text = "$ " + valoresUnitariosNT.datos(3).importe.ToString("N4")
        Else
            tbCTU.Text = "$ " + valoresUnitarios.datos(0).importe.ToString("N")
            tbCPU.Text = "$ " + valoresUnitarios.datos(1).importe.ToString("N")
            tbCVU.Text = "$ " + valoresUnitarios.datos(2).importe.ToString("N")
            tbGVU.Text = "$ " + valoresUnitarios.datos(3).importe.ToString("N")
        End If

        'Precio unitario de venta
        ReDim PrecioV(cbUtilidadDeseada.Items.Count - 1)
        ReDim PrecioVNT(cbUtilidadDeseada.Items.Count - 1)
        tbResultadosUnidadesProducidas.Text = tbUnidadesProducidas.Text + " unid."

        cbResultadosUtilidadDeseada.Items.Clear()
        For i As Integer = 0 To cbUtilidadDeseada.Items.Count - 1
            cbResultadosUtilidadDeseada.Items.Add(cbUtilidadDeseada.Items(i).ToString + " %")
            PrecioV(i) = New PrecioVenta(Convert.ToDouble(cbUtilidadDeseada.Items(i).ToString), valoresUnitarios.datos(0).importe)
            PrecioV(i).precio = Math.Truncate(100 * PrecioV(i).precio) / 100
            PrecioVNT(i) = New PrecioVenta(Convert.ToDouble(cbUtilidadDeseada.Items(i).ToString), valoresUnitariosNT.datos(0).importe)
        Next
        cbResultadosUtilidadDeseada.SelectedIndex = 0

        ' Estados de Resultados
        Dim proyeccionesVenta As Integer
        proyeccionesVenta = cbUnidadesVendidas.Items.Count * cbUtilidadDeseada.Items.Count
        proyeccionesVenta -= 1

        ReDim edoResEnv(proyeccionesVenta)
        ReDim edoResNTEnv(proyeccionesVenta)
        ReDim edoResDir(proyeccionesVenta)
        ReDim edoResNTDir(proyeccionesVenta)

        Dim UVnum As Integer = cbUnidadesVendidas.Items.Count

        For i As Integer = 0 To proyeccionesVenta
            edoResEnv(i) = New EdoResAbsorbente(valoresUnitariosNT.datos(1).importe, cedulaGastoOperativo.cantidad, cedulaGastoOperativo.datosTotales(0).cantidad, cedulaGastoOperativo.datosTotales(1).cantidad, cedulaGastoOperativo.datosTotales(2).cantidad, True)
            edoResEnv(i).Calcular(PrecioV(Math.Floor(i / UVnum)).precio, Convert.ToDouble(cbUnidadesVendidas.Items(i Mod UVnum)), True)
            edoResNTEnv(i) = New EdoResAbsorbente(valoresUnitariosNT.datos(1).importe, cedulaGastoOperativo.cantidad, cedulaGastoOperativo.datosTotales(0).cantidad, cedulaGastoOperativo.datosTotales(1).cantidad, cedulaGastoOperativo.datosTotales(2).cantidad, False)
            edoResNTEnv(i).Calcular(PrecioVNT(Math.Floor(i / UVnum)).precio, Convert.ToDouble(cbUnidadesVendidas.Items(i Mod UVnum)), False)

            edoResDir(i) = New EdoResDirecto(valoresUnitariosNT.datos(2).importe, valoresUnitariosNT.datos(3).importe, cedulaComportamiento.datosTotales(0).cantidad, cedulaComportamiento.datosTotales(2).cantidad, True)
            edoResDir(i).Calcular(PrecioV(Math.Floor(i / UVnum)).precio, Convert.ToDouble(cbUnidadesVendidas.Items(i Mod UVnum)), True)
            edoResNTDir(i) = New EdoResDirecto(valoresUnitariosNT.datos(2).importe, valoresUnitariosNT.datos(3).importe, cedulaComportamiento.datosTotales(0).cantidad, cedulaComportamiento.datosTotales(2).cantidad, False)
            edoResNTDir(i).Calcular(PrecioVNT(Math.Floor(i / UVnum)).precio, Convert.ToDouble(cbUnidadesVendidas.Items(i Mod UVnum)), False)
        Next
    End Sub

    Public Sub CargarEstadoDeResultadosDirecto(TRUNCADO As Boolean)
        ' Proyecciones de venta
        Dim proyeccionesVenta As Integer
        proyeccionesVenta = cbUnidadesVendidas.Items.Count * cbUtilidadDeseada.Items.Count - 1

        Dim er() As EdoResDirecto

        If TRUNCADO Then
            er = edoResDir
        Else
            er = edoResNTDir
        End If

        ' Conceptos de las filas
        dgvEdoRes.Rows.Clear()
        dgvEdoResultados.Rows.Clear()
        If cbSinSangrias.Checked Then
            dgvEdoResultados.Rows.Add("Precio de Venta")
            dgvEdoResultados.Rows.Add("Unidades Vendidas")
            dgvEdoResultados.Rows.Add("Ventas")
            dgvEdoResultados.Rows.Add("Costo de Ventas Variable")
            dgvEdoResultados.Rows.Add("Contribucion Marginal")
            dgvEdoResultados.Rows.Add("Gasto Variable")
            dgvEdoResultados.Rows.Add("Utilidad o Perdida BRUTA")
            dgvEdoResultados.Rows.Add("Costo Fijo")
            dgvEdoResultados.Rows.Add("Gasto Fijo")
            dgvEdoResultados.Rows.Add("Utilidad/Per NETA del periodo")
        Else
            dgvEdoResultados.Rows.Add("      Precio de Venta")
            dgvEdoResultados.Rows.Add("      Unidades Vendidas")
            dgvEdoResultados.Rows.Add("    Ventas")
            dgvEdoResultados.Rows.Add("    Costo de Ventas Var.")
            dgvEdoResultados.Rows.Add("  Contribucion Marginal")
            dgvEdoResultados.Rows.Add("  Gasto Variable")
            dgvEdoResultados.Rows.Add("Utilidad o Perdida BRUTA")
            dgvEdoResultados.Rows.Add("Costo Fijo")
            dgvEdoResultados.Rows.Add("Gasto Fijo")
            dgvEdoResultados.Rows.Add("Utilidad/Per NETA del periodo")
        End If

        'Importes de las columnas de proyecciones de ventas
        dgvEdoRes.Columns.Clear()
        dgvEdoRes.ColumnCount = proyeccionesVenta
        For i As Integer = 1 To 10
            dgvEdoRes.Rows.Add()
        Next
        For i As Integer = 0 To proyeccionesVenta - 1
            dgvEdoRes.Columns(i).HeaderText = "Proyeccion " + (i + 1).ToString
            dgvEdoRes.Columns(i).Width = 130
            dgvEdoRes.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            'Llenado de datagridview
            If TRUNCADO Then
                dgvEdoRes.Item(i, 0).Value = er(i).precioVenta.ToString("N")
                dgvEdoRes.Item(i, 1).Value = er(i).unidadesVendidas.ToString("N0") + " un"
                dgvEdoRes.Item(i, 2).Value = er(i).ventas.ToString("N")
                dgvEdoRes.Item(i, 3).Value = er(i).costoDeVentaVariable.ToString("N")
                dgvEdoRes.Item(i, 4).Value = er(i).contribucionMarginal.ToString("N")
                dgvEdoRes.Item(i, 5).Value = er(i).gastoVariable.ToString("N")
                dgvEdoRes.Item(i, 6).Value = er(i).utilidadBRUTA.ToString("N")
                dgvEdoRes.Item(i, 7).Value = er(i).costoFijo.ToString("N")
                dgvEdoRes.Item(i, 8).Value = er(i).gastoFijo.ToString("N")
                dgvEdoRes.Item(i, 9).Value = er(i).utilidadNETA.ToString("N")
            Else
                dgvEdoRes.Item(i, 0).Value = er(i).precioVenta.ToString("N3")
                dgvEdoRes.Item(i, 1).Value = er(i).unidadesVendidas.ToString("N0") + " uni"
                dgvEdoRes.Item(i, 2).Value = er(i).ventas.ToString("N3")
                dgvEdoRes.Item(i, 3).Value = er(i).costoDeVentaVariable.ToString("N3")
                dgvEdoRes.Item(i, 4).Value = er(i).contribucionMarginal.ToString("N3")
                dgvEdoRes.Item(i, 5).Value = er(i).gastoVariable.ToString("N3")
                dgvEdoRes.Item(i, 6).Value = er(i).utilidadBRUTA.ToString("N3")
                dgvEdoRes.Item(i, 7).Value = er(i).costoFijo.ToString("N3")
                dgvEdoRes.Item(i, 8).Value = er(i).gastoFijo.ToString("N3")
                dgvEdoRes.Item(i, 9).Value = er(i).utilidadNETA.ToString("N3")
            End If
        Next
    End Sub


    Public Sub CargarEstadoDeResultadosAbsorbente(TRUNCADO As Boolean)
        ' Proyecciones de venta
        Dim proyeccionesVenta As Integer
        proyeccionesVenta = cbUnidadesVendidas.Items.Count * cbUtilidadDeseada.Items.Count - 1

        Dim er() As EdoResAbsorbente

        If TRUNCADO Then
            er = edoResEnv
        Else
            er = edoResNTEnv
        End If

        'Conceptos de las filas
        dgvEdoRes.Rows.Clear()
        dgvEdoResultados.Rows.Clear()
        If cbSinSangrias.Checked Then
            dgvEdoResultados.Rows.Add("Precio de Venta")
            dgvEdoResultados.Rows.Add("Unidades Vendidas")
            dgvEdoResultados.Rows.Add("Ventas")
            dgvEdoResultados.Rows.Add("Costo de Prod. DL Vendido")
            dgvEdoResultados.Rows.Add("Utilidad o Perdida BRUTA")
            dgvEdoResultados.Rows.Add("Gasto Operativo")
            dgvEdoResultados.Rows.Add("Gasto de Venta")
            dgvEdoResultados.Rows.Add("Gasto Administrativo")
            dgvEdoResultados.Rows.Add("Gasto Financiero")
            dgvEdoResultados.Rows.Add("Utilidad o Perdida NETA")
        Else
            dgvEdoResultados.Rows.Add("      Precio de Venta")
            dgvEdoResultados.Rows.Add("      Unidades Vendidas")
            dgvEdoResultados.Rows.Add("   Ventas")
            dgvEdoResultados.Rows.Add("   Costo de Prod. DL Vendido")
            dgvEdoResultados.Rows.Add("Utilidad o Perdida BRUTA")
            dgvEdoResultados.Rows.Add("Gasto Operativo")
            dgvEdoResultados.Rows.Add("   Gasto de Venta")
            dgvEdoResultados.Rows.Add("   Gasto Administrativo")
            dgvEdoResultados.Rows.Add("   Gasto Financiero")
            dgvEdoResultados.Rows.Add("Utilidad o Perdida NETA")
        End If

        'Importes de las columnas de proyecciones de venta
        dgvEdoRes.Columns.Clear()
        dgvEdoRes.ColumnCount = proyeccionesVenta + 1
        For i As Integer = 1 To 10
            dgvEdoRes.Rows.Add()
        Next
        For i As Integer = 0 To proyeccionesVenta
            dgvEdoRes.Columns(i).HeaderText = "Proyeccion " + (i + 1).ToString
            dgvEdoRes.Columns(i).Width = 130
            dgvEdoRes.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            'Llenado de datagridview
            If TRUNCADO Then
                dgvEdoRes.Item(i, 0).Value = er(i).precioVenta.ToString("N")
                dgvEdoRes.Item(i, 2).Value = er(i).ventas.ToString("N")
                dgvEdoRes.Item(i, 3).Value = er(i).costoDeLoVendido.ToString("N")
                dgvEdoRes.Item(i, 4).Value = er(i).utilidadBruta.ToString("N")
                dgvEdoRes.Item(i, 9).Value = er(i).utilidadNeta.ToString("N")
                dgvEdoRes.Item(i, 1).Value = er(i).unidadesVendidas.ToString("N0") + " un"
                dgvEdoRes.Item(i, 5).Value = er(i).gastosOperacion.ToString("N")
                dgvEdoRes.Item(i, 6).Value = er(i).gastoVenta.ToString("N")
                dgvEdoRes.Item(i, 7).Value = er(i).gastoAdmin.ToString("N")
                dgvEdoRes.Item(i, 8).Value = er(i).gastoFinan.ToString("N")
            Else
                dgvEdoRes.Item(i, 0).Value = er(i).precioVenta.ToString("N3")
                dgvEdoRes.Item(i, 2).Value = er(i).ventas.ToString("N3")
                dgvEdoRes.Item(i, 3).Value = er(i).costoDeLoVendido.ToString("N3")
                dgvEdoRes.Item(i, 4).Value = er(i).utilidadBruta.ToString("N3")
                dgvEdoRes.Item(i, 9).Value = er(i).utilidadNeta.ToString("N3")
                dgvEdoRes.Item(i, 1).Value = er(i).unidadesVendidas.ToString("N0") + " uni"
                dgvEdoRes.Item(i, 5).Value = er(i).gastosOperacion.ToString("N3")
                dgvEdoRes.Item(i, 6).Value = er(i).gastoVenta.ToString("N3")
                dgvEdoRes.Item(i, 7).Value = er(i).gastoAdmin.ToString("N3")
                dgvEdoRes.Item(i, 8).Value = er(i).gastoFinan.ToString("N3")
            End If
        Next
    End Sub

    Private Sub bAgregarUnidadesVendidas_Click(sender As Object, e As EventArgs) Handles bAgregarUnidadesVendidas.Click
        cbUnidadesVendidas.Items.Add(tbUnidadesVendidas.Text)
        cbUnidadesVendidas.Text = tbUnidadesVendidas.Text
        tbUnidadesVendidas.Text = ""
    End Sub

    Private Sub bQuitarUnidadesVendidas_Click(sender As Object, e As EventArgs) Handles bQuitarUnidadesVendidas.Click
        If cbUnidadesVendidas.Items.Count > 1 Then
            cbUnidadesVendidas.Items.Remove(cbUnidadesVendidas.SelectedItem)
            cbUnidadesVendidas.SelectedIndex = 0
        Else
            cbUnidadesVendidas.Items.Clear()
            cbUnidadesVendidas.Text = ""
        End If
    End Sub

    Private Sub bAgregarUtilidadDeseada_Click(sender As Object, e As EventArgs) Handles bAgregarUtilidadDeseada.Click
        cbUtilidadDeseada.Items.Add(tbUtilidadDeseada.Text)
        cbUtilidadDeseada.Text = tbUtilidadDeseada.Text
        tbUtilidadDeseada.Text = ""
    End Sub

    Private Sub bQuitarUtilidadDeseada_Click(sender As Object, e As EventArgs) Handles bQuitarUtilidadDeseada.Click
        If cbUtilidadDeseada.Items.Count > 1 Then
            cbUtilidadDeseada.Items.Remove(cbUtilidadDeseada.SelectedItem)
            cbUtilidadDeseada.SelectedIndex = 0
        Else
            cbUtilidadDeseada.Items.Clear()
            cbUtilidadDeseada.Text = ""
        End If
    End Sub

    Private Sub cbResultadosUtilidadDeseada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbResultadosUtilidadDeseada.SelectedIndexChanged
        If cbNoTruncar.Checked Then
            tbPrecioVenta.Text = "$ " + PrecioVNT(cbResultadosUtilidadDeseada.SelectedIndex).precio.ToString("N4")
        Else
            tbPrecioVenta.Text = "$ " + PrecioV(cbResultadosUtilidadDeseada.SelectedIndex).precio.ToString("N")
        End If
    End Sub

    Private Sub bDatosBorrar_Click(sender As Object, e As EventArgs) Handles bDatosBorrar.Click
        Dim respuesta As MsgBoxResult
        Dim fila As Integer

        fila = dgvDatos.CurrentCellAddress.Y
        dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDatos.Rows(fila).Selected = True
        respuesta = MsgBox("Quiere borrar sólo la linea seleccionada?" + vbCrLf + "Si elige no, se borrará toda la tabla", vbYesNoCancel)

        If respuesta = MsgBoxResult.Yes Then
            dgvDatos.Rows.RemoveAt(fila)
        End If

        If respuesta = MsgBoxResult.No Then
            dgvDatos.Rows.Clear()
            Inicializacion()
        End If
        dgvDatos.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
    End Sub

    Private Sub cbCedulaTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCedulaTipo.SelectedIndexChanged
        dgvCedula.Rows.Clear()
        dgvCedula.CellBorderStyle = DataGridViewCellBorderStyle.None

        'Dim linea As String = "------------"
        Dim linea As String = "____________"

        Select Case (cbCedulaTipo.SelectedItem.ToString)
            Case "para determinar los elementos del costo y el COSTO de PRODUCCION."
                For k As Integer = 0 To cedulaCostoProduccion.datosTotales.Length - 1
                    dgvCedula.Rows.Add({"* " + cedulaCostoProduccion.datosTotales(k).nombre, "", ""})
                    For i As Integer = 0 To cedulaCostoProduccion.datosTotales(k).datos.Length - 1
                        dgvCedula.Rows.Add({"   " + cedulaCostoProduccion.datosTotales(k).datos(i).concepto, cedulaCostoProduccion.datosTotales(k).datos(i).importe.ToString("N"), ""})
                    Next
                    dgvCedula.Rows.Add({"", linea, ""})
                    dgvCedula.Rows.Add({"   TOTAL de " + cedulaCostoProduccion.datosTotales(k).nombre, "", cedulaCostoProduccion.datosTotales(k).cantidad.ToString("N")})
                    dgvCedula.Rows.Add({"", "", ""})
                Next
                dgvCedula.Rows.Add({"", "", linea})
                dgvCedula.Rows.Add({"TOTAL de " + cedulaCostoProduccion.nombre, "", cedulaCostoProduccion.cantidad.ToString("N")})

            Case "para determinar el COSTO PRIMO."
                For i As Integer = 0 To cedulaCostos.datosTotales(0).datos.Length - 1
                    dgvCedula.Rows.Add({"   " + cedulaCostos.datosTotales(0).datos(i).concepto, cedulaCostos.datosTotales(0).datos(i).importe.ToString("N"), ""})
                Next
                dgvCedula.Rows.Add({"", linea, ""})
                dgvCedula.Rows.Add({"TOTAL de " + cedulaCostos.datosTotales(0).nombre, "", cedulaCostos.datosTotales(0).cantidad.ToString("N")})

            Case "para determinar el COSTO de TRANSFORMACION."
                For i As Integer = 0 To cedulaCostos.datosTotales(1).datos.Length - 1
                    dgvCedula.Rows.Add({"   " + cedulaCostos.datosTotales(1).datos(i).concepto, cedulaCostos.datosTotales(1).datos(i).importe.ToString("N"), ""})
                Next
                dgvCedula.Rows.Add({"", linea, ""})
                dgvCedula.Rows.Add({"TOTAL de " + cedulaCostos.datosTotales(1).nombre, "", cedulaCostos.datosTotales(1).cantidad.ToString("N")})

            Case "para determinar el GASTO de OPERACION."
                For k As Integer = 0 To cedulaGastoOperativo.datosTotales.Length - 1
                    dgvCedula.Rows.Add({"* " + cedulaGastoOperativo.datosTotales(k).nombre, "", ""})
                    For i As Integer = 0 To cedulaGastoOperativo.datosTotales(k).datos.Length - 1
                        dgvCedula.Rows.Add({"   " + cedulaGastoOperativo.datosTotales(k).datos(i).concepto, cedulaGastoOperativo.datosTotales(k).datos(i).importe.ToString("N"), ""})
                    Next
                    dgvCedula.Rows.Add({"", linea, ""})
                    dgvCedula.Rows.Add({"   TOTAL de " + cedulaGastoOperativo.datosTotales(k).nombre, "", cedulaGastoOperativo.datosTotales(k).cantidad.ToString("N")})
                    dgvCedula.Rows.Add({"", "", ""})
                Next
                dgvCedula.Rows.Add({"", "", linea})
                dgvCedula.Rows.Add({"TOTAL de " + cedulaGastoOperativo.nombre, "", cedulaGastoOperativo.cantidad.ToString("N")})

            Case "para determinar el COSTO TOTAL."
                For i As Integer = 0 To cedulaCostos.datosTotales(2).datos.Length - 1
                    dgvCedula.Rows.Add({"   " + cedulaCostos.datosTotales(2).datos(i).concepto, cedulaCostos.datosTotales(2).datos(i).importe.ToString("N"), ""})
                Next
                dgvCedula.Rows.Add({"", linea, ""})
                dgvCedula.Rows.Add({"TOTAL de " + cedulaCostos.datosTotales(2).nombre, "", cedulaCostos.datosTotales(2).cantidad.ToString("N")})

            Case "para determinar el COSTO FIJO."
                For i As Integer = 0 To cedulaComportamiento.datosTotales(0).datos.Length - 1
                    dgvCedula.Rows.Add({"   " + cedulaComportamiento.datosTotales(0).datos(i).concepto, cedulaComportamiento.datosTotales(0).datos(i).importe.ToString("N"), ""})
                Next
                dgvCedula.Rows.Add({"", linea, ""})
                dgvCedula.Rows.Add({"TOTAL de " + cedulaComportamiento.datosTotales(0).nombre, "", cedulaComportamiento.datosTotales(0).cantidad.ToString("N")})

            Case "para determinar el COSTO VARIABLE."
                For i As Integer = 0 To cedulaComportamiento.datosTotales(1).datos.Length - 1
                    dgvCedula.Rows.Add({"   " + cedulaComportamiento.datosTotales(1).datos(i).concepto, cedulaComportamiento.datosTotales(1).datos(i).importe.ToString("N"), ""})
                Next
                dgvCedula.Rows.Add({"", linea, ""})
                dgvCedula.Rows.Add({"TOTAL de " + cedulaComportamiento.datosTotales(1).nombre, "", cedulaComportamiento.datosTotales(1).cantidad.ToString("N")})

            Case "para determinar el GASTO FIJO."
                For i As Integer = 0 To cedulaComportamiento.datosTotales(2).datos.Length - 1
                    dgvCedula.Rows.Add({"   " + cedulaComportamiento.datosTotales(2).datos(i).concepto, cedulaComportamiento.datosTotales(2).datos(i).importe.ToString("N"), ""})
                Next
                dgvCedula.Rows.Add({"", linea, ""})
                dgvCedula.Rows.Add({"TOTAL de " + cedulaComportamiento.datosTotales(2).nombre, "", cedulaComportamiento.datosTotales(2).cantidad.ToString("N")})

            Case "para determinar el GASTO VARIABLE."
                For i As Integer = 0 To cedulaComportamiento.datosTotales(3).datos.Length - 1
                    dgvCedula.Rows.Add({"   " + cedulaComportamiento.datosTotales(3).datos(i).concepto, cedulaComportamiento.datosTotales(3).datos(i).importe.ToString("N"), ""})
                Next
                dgvCedula.Rows.Add({"", linea, ""})
                dgvCedula.Rows.Add({"TOTAL de " + cedulaComportamiento.datosTotales(3).nombre, "", cedulaComportamiento.datosTotales(3).cantidad.ToString("N")})

            Case Else
                MsgBox("Seleccione el tipo de cedula para desplegar su contenido.")
        End Select
    End Sub

    Private Sub bInforme_Click(sender As Object, e As EventArgs) Handles bInforme.Click

        If tbCMPD.Text = "" Then
            Exit Sub
        End If

        bCalcularTodo_Click(sender, e)

        'Ver caja de texto enrquecida
        FormInforme.Show()

        'Presentacion
        With FormInforme.rtbInforme
            .Clear()
            .DeselectAll()
            .SelectionAlignment = 2
            .SelectionFont = fuenteTitulo1
            .AppendText(vbCrLf + "CONTABILIDAD DE COSTOS" + vbCrLf + vbCrLf)
        End With

        With FormInforme.rtbInforme
            .DeselectAll()
            .SelectionAlignment = 2
            .SelectionFont = fuenteTitulo2
            .AppendText("EMPRESA: " + tbNombreEmpresa.Text + "  " + vbCrLf + "PERIODO: " + tbPeriodo.Text + vbCrLf + "RUBRO: " + tbRubro.Text + "  " + vbCrLf + vbCrLf + vbCrLf + vbCrLf)
        End With

        With FormInforme.rtbInforme
            .DeselectAll()
            .SelectionAlignment = 2
            .SelectionFont = fuenteTitulo2
            .AppendText("_______________   RESUMEN DE LOS CALCULOS   _______________" + vbCrLf + vbCrLf)
        End With

        With FormInforme.rtbInforme
            .DeselectAll()
            .SelectionAlignment = 0
            .SelectionFont = fuenteParrafo
        End With

        AgregarResumen(cedulaCostoProduccion, True)
        AgregarResumen(cedulaGastoOperativo, True)
        AgregarResumen(cedulaCostos, False)
        AgregarResumen(cedulaComportamiento, False)
        AgregarResumen(valoresUnitarios, True, True)
        AgregarResumen(PrecioV, True)
        AgregarResumen(valoresUnitariosNT, False, False)
        AgregarResumen(PrecioVNT, False)

        With FormInforme.rtbInforme
            .DeselectAll()
            .SelectionAlignment = 2
            .SelectionFont = fuenteTitulo2
            .AppendText(vbCrLf + vbCrLf + vbCrLf + vbCrLf + "___________   COSTEO ABSORBENTE POR FUNCIONES   ___________" + vbCrLf + vbCrLf + vbCrLf)
        End With

        For i As Integer = 0 To 4
            cbCedulaTipo.SelectedIndex = i
            With FormInforme.rtbInforme
                .DeselectAll()
                .SelectionAlignment = 0
                .SelectionFont = fuenteSemiTitulo
                .AppendText("___________________________________________________________________________")
                .AppendText(vbCrLf + "CEDULA " + cbCedulaTipo.SelectedItem.ToString() + vbCrLf + vbCrLf)
            End With
            With FormInforme.rtbInforme
                .DeselectAll()
                .SelectionAlignment = 0
                .SelectionFont = fuenteParrafo
            End With
            AgregarCedulaAInforme(dgvCedula)
            FormInforme.rtbInforme.AppendText(vbCrLf + vbCrLf)
        Next

        'Estado de Resultados por COSTEO ABSORBENTE
        CargarEstadoDeResultadosAbsorbente(False)
        AgregareEdoResAInforme(dgvEdoResultados, dgvEdoRes, 0, True)
        CargarEstadoDeResultadosAbsorbente(True)
        AgregareEdoResAInforme(dgvEdoResultados, dgvEdoRes, 0, False)

        With FormInforme.rtbInforme
            .DeselectAll()
            .SelectionAlignment = 2
            .SelectionFont = fuenteTitulo2
            .AppendText(vbCrLf + vbCrLf + "_________   COSTEO DIRECTO POR COMPORTAMIENTO   _________" + vbCrLf + vbCrLf + vbCrLf)
        End With

        For i As Integer = 5 To cbCedulaTipo.Items.Count - 1
            cbCedulaTipo.SelectedIndex = i
            With FormInforme.rtbInforme
                .DeselectAll()
                .SelectionAlignment = 0
                .SelectionFont = fuenteSemiTitulo
                .AppendText("___________________________________________________________________________")
                .AppendText(vbCrLf + "CEDULA " + cbCedulaTipo.SelectedItem.ToString() + vbCrLf + vbCrLf)
            End With
            With FormInforme.rtbInforme
                .DeselectAll()
                .SelectionAlignment = 0
                .SelectionFont = fuenteParrafo
            End With
            AgregarCedulaAInforme(dgvCedula)
            FormInforme.rtbInforme.AppendText(vbCrLf + vbCrLf)
        Next

        'Estado de Resultados por COSTEO DIRECTO
        CargarEstadoDeResultadosDirecto(False)
        AgregareEdoResAInforme(dgvEdoResultados, dgvEdoRes, 1, True)
        CargarEstadoDeResultadosDirecto(True)
        AgregareEdoResAInforme(dgvEdoResultados, dgvEdoRes, 1, False)


        'Datos
        With FormInforme.rtbInforme
            .DeselectAll()
            .SelectionAlignment = 2
            .SelectionFont = fuenteTitulo2
            .AppendText(vbCrLf + vbCrLf + vbCrLf + vbCrLf + "____________________   DATOS   ____________________" + vbCrLf + vbCrLf + vbCrLf)
        End With

        With FormInforme.rtbInforme
            .DeselectAll()
            .SelectionAlignment = 0
            .SelectionFont = fuenteParrafo
        End With

        AgregareDGVAInforme(dgvDatos, FormInforme.rtbInforme)

        'Creacion de archivo y apertura en WordPad o Word
        Try
            'FormInforme.rtbInforme.SaveFile("Informe.rtf")
            FormInforme.rtbInforme.SaveFile(Application.StartupPath & "\Informe.rtf")
            Process.Start(Application.StartupPath & "\Informe.rtf")
        Catch ex As Exception
            MsgBox("Debe cerrar el anterior archivo de Word o WordPad del Informe para Crear el Nuevo. Favor de volver a seleccionar el boton de 'Informe'")
        End Try

        FormInforme.rtbInforme.SelectionStart = 0


    End Sub

    Public Sub AgregarResumen(ced As Cedula, primaria As Boolean)
        Dim espacioConcepto As Integer = 42
        Dim espacioImporte As Integer = 28

        With FormInforme.rtbInforme
            .DeselectAll()
            .SelectionAlignment = 2
        End With

        For i As Integer = 0 To ced.datosTotales.Length - 1
            FormInforme.rtbInforme.AppendText(ced.datosTotales(i).nombre + espacios(espacioConcepto, ced.datosTotales(i).nombre.Length) + espacios(espacioImporte, ced.datosTotales(i).cantidad.ToString("N").Length) + ced.datosTotales(i).cantidad.ToString("N") + vbCrLf)
        Next
        If primaria Then
            FormInforme.rtbInforme.AppendText(ced.nombre + espacios(espacioConcepto, ced.nombre.Length) + espacios(espacioImporte, ced.cantidad.ToString("N").Length) + ced.cantidad.ToString("N") + vbCrLf)
        End If
        FormInforme.rtbInforme.AppendText(vbCrLf)
    End Sub

    Public Sub AgregarResumen(dt As DatoTotal, truncado As Boolean, unidProd As Boolean)
        Dim espacioConcepto As Integer = 42
        Dim espacioImporte As Integer = 28

        With FormInforme.rtbInforme
            .DeselectAll()
            .SelectionAlignment = 2
        End With
        If unidProd Then
            FormInforme.rtbInforme.AppendText("Unidades Producidas" + espacios(espacioConcepto, 19) + espacios(espacioImporte, tbUnidadesProducidas.Text.Length + 3) + tbUnidadesProducidas.Text + " un" + vbCrLf + vbCrLf)
        End If

        If truncado Then
            FormInforme.rtbInforme.AppendText(vbCrLf + "Valores unitarios truncados a dos decimales:" + vbCrLf)
        Else
            FormInforme.rtbInforme.AppendText(vbCrLf + "Valores unitarios no truncados:" + vbCrLf)
        End If

        For i As Integer = 0 To dt.datos.Length - 1
            FormInforme.rtbInforme.AppendText(dt.datos(i).concepto + espacios(espacioConcepto, dt.datos(i).concepto.Length) + espacios(espacioImporte, dt.datos(i).importe.ToString().Length) + dt.datos(i).importe.ToString() + vbCrLf)
        Next
    End Sub

    Public Sub AgregarResumen(pv() As PrecioVenta, truncado As Boolean)
        Dim espacioConcepto As Integer = 42
        Dim espacioImporte As Integer = 28
        Dim cadena As String

        With FormInforme.rtbInforme
            .DeselectAll()
            .SelectionAlignment = 2
        End With

        For i As Integer = 0 To pv.Length - 1
            cadena = "Precio de Venta ( " + pv(i).porcentajeUtilidadDeseada.ToString() + " % )"
            FormInforme.rtbInforme.AppendText(cadena + espacios(espacioConcepto, cadena.Length) + espacios(espacioImporte, pv(i).precio.ToString().Length) + pv(i).precio.ToString() + vbCrLf)
        Next
    End Sub


    Public Sub AgregarCedulaAInforme(dgv As DataGridView)
        Dim maxConcepto As Integer = 0
        Dim maxImporte As Integer = 0
        Dim maxTotal As Integer = 0

        'Deteccion de longitudes mayores de string
        For fila As Integer = 0 To dgv.Rows.Count - 2
            If maxConcepto < dgv(0, fila).Value.Length Then
                maxConcepto = dgv(0, fila).Value.Length
            End If
            If maxImporte < dgv(1, fila).Value.Length Then
                maxImporte = dgv(1, fila).Value.Length
            End If
            If maxTotal < dgv(2, fila).Value.Length Then
                maxTotal = dgv(2, fila).Value.Length
            End If
        Next

        'Captura de datos con agregado de espacios para tener conceptos de igual longitud
        For fila As Integer = 0 To dgv.Rows.Count - 2
            For columna As Integer = 0 To dgv.Columns.Count - 1
                Select Case columna
                    Case 0
                        FormInforme.rtbInforme.AppendText(dgv.Item(columna, fila).Value + espacios(maxConcepto, dgv(columna, fila).Value.Length) + "  ")
                    Case 1
                        FormInforme.rtbInforme.AppendText(espacios(maxImporte, dgv(columna, fila).Value.Length) + dgv.Item(columna, fila).Value + "  ")
                    Case 2
                        FormInforme.rtbInforme.AppendText(espacios(maxTotal, dgv(columna, fila).Value.Length) + dgv.Item(columna, fila).Value + vbCrLf)
                End Select
            Next
        Next
    End Sub

    Public Function espacios(max As Integer, longitud As Integer) As String
        Dim espa As String = ""
        For i As Integer = longitud To max - 1
            espa += " "
        Next
        Return espa
    End Function

    Public Sub AgregareEdoResAInforme(dgvIni As DataGridView, dgv As DataGridView, tipo As Integer, NO_TRUNCADO As Boolean)

        Dim proyeccionesPorRenglon As Integer = 2 'Se proyectan n+1 partiendo del cero
        Dim colsMax As Integer = proyeccionesPorRenglon
        Dim maxConcepto As Integer = 0
        Dim maxImporte(dgv.Columns.Count - 1) As Integer

        'Subtitulo
        cbEdoResTipo.SelectedIndex = tipo
        With FormInforme.rtbInforme
            .DeselectAll()
            .SelectionAlignment = 0
            .SelectionFont = fuenteSemiTitulo
            .AppendText("___________________________________________________________________________")
            .AppendText(vbCrLf + "ESTADO DE RESULTADOS " + cbEdoResTipo.SelectedItem.ToString())
        End With

        If NO_TRUNCADO Then
            With FormInforme.rtbInforme
                .DeselectAll()
                .AppendText(" con valores unitarios sin truncar" + vbCrLf + vbCrLf)
            End With
            cbNoTruncar.Checked = True
        Else
            With FormInforme.rtbInforme
                .DeselectAll()
                .AppendText(" con valores unitarios truncados" + vbCrLf + vbCrLf)
            End With
            cbNoTruncar.Checked = False
        End If

        With FormInforme.rtbInforme
            .DeselectAll()
            .SelectionAlignment = 0
            .SelectionFont = fuenteParrafo
        End With


        For columna As Integer = 0 To dgv.Columns.Count - 1
            maxImporte(columna) = 0
        Next

        'Deteccion de longitudes mayores de string
        For fila As Integer = 0 To dgv.Rows.Count - 2
            If maxConcepto < dgvIni(0, fila).Value.Length Then
                maxConcepto = dgvIni(0, fila).Value.Length
            End If
            For columna As Integer = 0 To dgv.Columns.Count - 1
                If maxImporte(columna) < dgv(columna, fila).Value.Length Then
                    maxImporte(columna) = dgv(columna, fila).Value.Length
                End If
            Next
        Next

        'Captura de datos con agregado de espacios para tener conceptos de igual longitud
        For col As Integer = 0 To dgv.Columns.Count - 1 Step (proyeccionesPorRenglon + 1)
            For fila As Integer = 0 To dgv.Rows.Count - 2
                FormInforme.rtbInforme.AppendText(dgvIni.Item(0, fila).Value + espacios(maxConcepto, dgvIni(0, fila).Value.Length) + " | ")
                For columna As Integer = col To dgv.Columns.Count - 1
                    FormInforme.rtbInforme.AppendText(espacios(maxImporte(columna), dgv(columna, fila).Value.Length) + dgv.Item(columna, fila).Value)
                    If columna = dgv.Columns.Count - 1 Or columna = colsMax Then
                        FormInforme.rtbInforme.AppendText(" |" + vbCrLf)
                    Else
                        FormInforme.rtbInforme.AppendText(" | ")
                    End If
                    If columna = colsMax Then
                        Exit For
                    End If
                Next
            Next
            colsMax += proyeccionesPorRenglon + 1
            FormInforme.rtbInforme.AppendText(vbCrLf + vbCrLf)
        Next
        FormInforme.rtbInforme.AppendText(vbCrLf + vbCrLf)
    End Sub

    Public Sub AgregareDGVAInforme(dgv As DataGridView, rtb As RichTextBox)

        Dim maxLongitud(dgv.Columns.Count - 1) As Integer

        With FormInforme.rtbInforme
            .DeselectAll()
            .SelectionAlignment = 0
            .SelectionFont = fuenteParrafo
        End With

        'Deteccion de longitudes mayores de string por columna para agregar espacios e igualar y hacer tablas
        For columna As Integer = 0 To dgv.Columns.Count - 1
            maxLongitud(columna) = dgv.Columns(columna).HeaderText.Length
            For fila As Integer = 0 To dgv.Rows.Count - 1
                If dgv(columna, fila).Value = "" Then
                    Exit For
                End If
                If maxLongitud(columna) < dgv(columna, fila).Value.Length Then
                    maxLongitud(columna) = dgv(columna, fila).Value.Length
                End If
            Next
        Next

        Dim separador As String = ""
        For columna As Integer = 0 To dgv.Columns.Count - 1
            rtb.AppendText(dgv.Columns(columna).HeaderText + espacios(maxLongitud(columna), dgv.Columns(columna).HeaderText.Length))
            If columna = dgv.Columns.Count - 1 Then
                FormInforme.rtbInforme.AppendText(" |" + vbCrLf)
            Else
                FormInforme.rtbInforme.AppendText(" | ")
            End If
        Next

        rtb.AppendText(vbCrLf)

        For fila As Integer = 0 To dgv.Rows.Count - 1
            If dgv(0, fila).Value = "" Then
                Exit For
            End If
            For columna As Integer = 0 To dgv.Columns.Count - 1
                If columna = 0 Then
                    rtb.AppendText(dgv.Item(columna, fila).Value + espacios(maxLongitud(columna), dgv(columna, fila).Value.Length))
                Else
                    rtb.AppendText(espacios(maxLongitud(columna), dgv(columna, fila).Value.Length) + dgv.Item(columna, fila).Value)
                End If

                If columna = dgv.Columns.Count - 1 Then
                    FormInforme.rtbInforme.AppendText(" |" + vbCrLf)
                Else
                    FormInforme.rtbInforme.AppendText(" | ")
                End If
            Next
        Next
        FormInforme.rtbInforme.AppendText(vbCrLf + vbCrLf)
    End Sub


    ' Seleccion de misma fila en los dos datagridviews del edo de resultados
    Private Sub dgvEdoResultados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEdoResultados.CellContentClick
        Dim col As Integer = dgvEdoRes.CurrentCell.ColumnIndex
        dgvEdoRes.ClearSelection()
        dgvEdoRes(col, dgvEdoResultados.CurrentCell.RowIndex).Selected = True
    End Sub

    Private Sub dgvEdoRes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEdoRes.CellContentClick
        dgvEdoResultados.ClearSelection()
        dgvEdoResultados(0, dgvEdoRes.CurrentCell.RowIndex).Selected = True
    End Sub

    Private Sub cbEdoResTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEdoResTipo.SelectedIndexChanged, cbNoTruncar.CheckedChanged

        If cbNoTruncar.Checked Then
            tbCTU.Text = "$ " + valoresUnitariosNT.datos(0).importe.ToString("N4")
            tbCPU.Text = "$ " + valoresUnitariosNT.datos(1).importe.ToString("N4")
            tbCVU.Text = "$ " + valoresUnitariosNT.datos(2).importe.ToString("N4")
            tbGVU.Text = "$ " + valoresUnitariosNT.datos(3).importe.ToString("N4")
            cbResultadosUtilidadDeseada_SelectedIndexChanged(sender, e)
        Else
            tbCTU.Text = "$ " + valoresUnitarios.datos(0).importe.ToString("N")
            tbCPU.Text = "$ " + valoresUnitarios.datos(1).importe.ToString("N")
            tbCVU.Text = "$ " + valoresUnitarios.datos(2).importe.ToString("N")
            tbGVU.Text = "$ " + valoresUnitarios.datos(3).importe.ToString("N")
            cbResultadosUtilidadDeseada_SelectedIndexChanged(sender, e)
        End If

        Try
            Dim renglon As Integer = dgvEdoRes.CurrentCell.RowIndex
            Dim columna As Integer = dgvEdoRes.CurrentCell.ColumnIndex

            Select Case cbEdoResTipo.SelectedIndex
                Case 0
                    CargarEstadoDeResultadosAbsorbente((Not cbNoTruncar.Checked))
                Case 1
                    CargarEstadoDeResultadosDirecto((Not cbNoTruncar.Checked))
            End Select
            dgvEdoRes.ClearSelection()
            dgvEdoRes(columna, renglon).Selected = True
            dgvEdoRes.CurrentCell = dgvEdoRes.Item(columna, renglon)
            dgvEdoResultados.ClearSelection()
            dgvEdoResultados(0, renglon).Selected = True
        Catch
            Select Case cbEdoResTipo.SelectedIndex
                Case 0
                    CargarEstadoDeResultadosAbsorbente((Not cbNoTruncar.Checked))
                Case 1
                    CargarEstadoDeResultadosDirecto((Not cbNoTruncar.Checked))
            End Select
        End Try
    End Sub

    Private Sub cbEnumerar_CheckedChanged(sender As Object, e As EventArgs) Handles cbEnumerar.CheckedChanged
        For fila = 0 To dgvDatos.RowCount - 2   'El ultimo renglon debe estar vacio
            If cbEnumerar.Checked Then
                dgvDatos.Item(0, fila).Value = (fila + 1).ToString + ". " + dgvDatos.Item(0, fila).Value
            Else
                dgvDatos.Item(0, fila).Value = quitarNumeracion(dgvDatos.Item(0, fila).Value)
            End If
        Next
    End Sub

    Private Function quitarNumeracion(cadena As String) As String
        Dim i As Integer
        For i = 0 To cadena.Length - 1
            Select Case Mid(cadena, i + 1, 1)
                Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ".", " ", ")", "-"
                Case Else
                    Exit For
            End Select
        Next
        Return Mid(cadena, i + 1, cadena.Length - i)
    End Function

    Private Sub cbSinSangrias_CheckedChanged(sender As Object, e As EventArgs) Handles cbSinSangrias.CheckedChanged
        dgvEdoResultados.Rows.Clear()
        If cbSinSangrias.Checked And cbEdoResTipo.SelectedIndex = 1 Then
            dgvEdoResultados.Rows.Add("Precio de Venta")
            dgvEdoResultados.Rows.Add("Unidades Vendidas")
            dgvEdoResultados.Rows.Add("Ventas")
            dgvEdoResultados.Rows.Add("Costo de Ventas Variable")
            dgvEdoResultados.Rows.Add("Contribucion Marginal")
            dgvEdoResultados.Rows.Add("Gasto Variable")
            dgvEdoResultados.Rows.Add("Utilidad o Perdida BRUTA")
            dgvEdoResultados.Rows.Add("Costo Fijo")
            dgvEdoResultados.Rows.Add("Gasto Fijo")
            dgvEdoResultados.Rows.Add("Utilidad/Per NETA del periodo")
        ElseIf cbEdoResTipo.SelectedIndex = 1 Then
            dgvEdoResultados.Rows.Add("      Precio de Venta")
            dgvEdoResultados.Rows.Add("      Unidades Vendidas")
            dgvEdoResultados.Rows.Add("    Ventas")
            dgvEdoResultados.Rows.Add("    Costo de Ventas Var.")
            dgvEdoResultados.Rows.Add("  Contribucion Marginal")
            dgvEdoResultados.Rows.Add("  Gasto Variable")
            dgvEdoResultados.Rows.Add("Utilidad o Perdida BRUTA")
            dgvEdoResultados.Rows.Add("Costo Fijo")
            dgvEdoResultados.Rows.Add("Gasto Fijo")
            dgvEdoResultados.Rows.Add("Utilidad/Per NETA del periodo")
        End If

        If cbSinSangrias.Checked And cbEdoResTipo.SelectedIndex = 0 Then
            dgvEdoResultados.Rows.Add("Precio de Venta")
            dgvEdoResultados.Rows.Add("Unidades Vendidas")
            dgvEdoResultados.Rows.Add("Ventas")
            dgvEdoResultados.Rows.Add("Costo de Prod. de lo Vendido")
            dgvEdoResultados.Rows.Add("Utilidad o Perdida BRUTA")
            dgvEdoResultados.Rows.Add("Gasto Operativo")
            dgvEdoResultados.Rows.Add("Gasto de Venta")
            dgvEdoResultados.Rows.Add("Gasto Administrativo")
            dgvEdoResultados.Rows.Add("Gasto Financiero")
            dgvEdoResultados.Rows.Add("Utilidad o Perdida NETA")
        ElseIf cbEdoResTipo.SelectedIndex = 0 Then
            dgvEdoResultados.Rows.Add("      Precio de Venta")
            dgvEdoResultados.Rows.Add("      Unidades Vendidas")
            dgvEdoResultados.Rows.Add("   Ventas")
            dgvEdoResultados.Rows.Add("   Costo de Prod. DL Vendido")
            dgvEdoResultados.Rows.Add("Utilidad o Perdida BRUTA")
            dgvEdoResultados.Rows.Add("Gasto Operativo")
            dgvEdoResultados.Rows.Add("   Gasto de Venta")
            dgvEdoResultados.Rows.Add("   Gasto Administrativo")
            dgvEdoResultados.Rows.Add("   Gasto Financiero")
            dgvEdoResultados.Rows.Add("Utilidad o Perdida NETA")
        End If
    End Sub

    Private Sub bLeyenda_Click(sender As Object, e As EventArgs) Handles bLeyenda.Click
        MsgBox("LEYENDA" + vbCrLf + vbCrLf +
               "C = Costo         G = Gasto" + vbCrLf +
               "CMPD = Costo de Materia Prima Directa" + vbCrLf +
               "CMOD = Costo de Mano de Obra Directa" + vbCrLf +
               "CIF = Costo Indirecto de Fabricacion" + vbCrLf +
               "GV = Gasto de Venta" + vbCrLf +
               "GA = Gasto Administrativo" + vbCrLf +
               "GF = Gasto Financiero" + vbCrLf +
               "CPr = C Primo = Costo Primo = CMPD + CMOD" + vbCrLf +
               "CT = C Trans = Costo de Transformacion = CMOD + CIF" + vbCrLf +
               "CP = C Prod = Costo de Produccion = CMPD + CMOD + CIF" + vbCrLf +
               "GO = G Oper = Gasto Operativo = GV + GA + GF" + vbCrLf +
               "CT = Costo Total = CP + GO" + vbCrLf +
               "UP = Unidades Producidas" + vbCrLf +
               "CTU = Costo Total Unitario = CT / UP truncado a 2 decimas" + vbCrLf +
               "CPU = Costo de Produccion Unitario = CP / UP truncado a 2 dec." + vbCrLf +
               "PUD = Porcentaje de Utilidad Deseada" + vbCrLf +
               "PV = Precio de Venta = CTU * ( 1 + PUD/100) truncado a 2 dec." + vbCrLf + vbCrLf +
               "C Fijo = Costo Fijo" + vbCrLf +
               "C Varia = Costo Variable" + vbCrLf +
               "G Fijo = Gasto Fijo" + vbCrLf +
               "G Varia = Gasto Variable" + vbCrLf +
               "CVU = Costo Variable Unitario = CV / UP truncado a 2 dec." + vbCrLf +
               "GVU = Gasto Variable Unitario = GV / UP truncado a 2 dec." + vbCrLf + "")
    End Sub

    Private Sub bAcercaDe_Click(sender As Object, e As EventArgs) Handles bAcercaDe.Click
        MsgBox("ACERCA DE ESTE SOFTWARE" + vbCrLf + vbCrLf +
               "Creado por Guillermo Arriaga García" + vbCrLf +
               "Marzo de 2017" + vbCrLf + vbCrLf +
               "Este programa sólo requiere windows y basta ingresar en la tabla de datos los conceptos, importes y clasificación según función y comportamiento. Además de indicar las unidades producidas, vendidas y los porcentajes de utilidad deseada (pueden ser más de uno y se agregan estos dos últimos ingresando el valor con el botón + o se borra uno seleccionado en la lista con el botón -)." + vbCrLf + vbCrLf +
               "El programa organiza las cédulas, obtiene los totales y calcula el Estado de Resultados." + vbCrLf + vbCrLf +
               "Es útil recordar que la distincion de pagos en costo o gasto es relativo al área de producción de una empresa." + vbCrLf +
               "   Costo Indirecto de Fabricación: materia prima no se pueden medir o fijar en una cantidad, como el hilo e la costura de zapatos o su pintura, lo referente a maquinaria de produccion, a trabajadores que no tocan el producto y los almacenes de materia prima y de artículo en proceso de produccion. También puede ser el empaquetado o etiquetado del producto, ya que no son materia prima directa para su elaboracion." + vbCrLf +
               "   Costo de Mano de Obra Direacta: relativo al personal que toca el producto en su elaboracion." + vbCrLf +
               "   Costo de Materia Prima Directa: relativo al material que cuya cantidad es fija o predecible." + vbCrLf +
               "   Gasto de Venta: relativo al departamento de ventas (personal, lugar, publicidad, ...)." + vbCrLf +
               "   Gasto Financiero: relativo al pago de servicios financieros (bancos, intereses, comisiones, cambios de moneda, ...)" + vbCrLf +
               "   Gasto Administrativo: TODO LO QUE NO SEA costo o gasto de venta y financiero." + vbCrLf +
               "   " + vbCrLf +
               "   Los Costos o Gastos serán fijos o variables si en un período se sabe cuanto se desenvolsará o no. Las depreciaciones de muebles, amortizaciones de inmuebles, primas de seguros, impuestos, gastos financierosy demás concpetos regidos por un índice porcentual son fijos, dado que el índice es fijo, no la cantidad de entrada, y es dado por el gobierno." + vbCrLf +
               "   " + vbCrLf +
               "(*) Cada empresa tiene sus políticas para el manejo de los cálculos, en este programa se optó por truncar a dos decimales los valores unitarios por deafult, pero puede elegir 'no truncar valores unitarios' y trabajar con la precision de un numero tipo double." + vbCrLf + "")
    End Sub

    Private Sub bTipsUso_Click(sender As Object, e As EventArgs) Handles bTipsUso.Click
        MsgBox("TIPS DE USO" + vbCrLf + vbCrLf + "Ingreso de datos:" + vbCrLf + "1. Se puede hacer en la tabla del programa." + vbCrLf +
            "2. El ultimo renglon de la tabla dada siempre queda en blanco pues es para agrergar informacion nueva." + vbCrLf +
            "3. Se puede ingresar informacion de una tabla en excel guardada en formato csv y con la debida nomenclatura la funcion y comportamiento de cada concepto (ver leyenda y elementos de seleccion brindados en la tabla)" + vbCrLf +
            "Salida de lo calculado:" + vbCrLf + "1. La primera salida es en el mismo programa, se pueden explorar los diversos precios de venta según la utilidad deseada elegida en el area de resumen; tambien, se puede elegir el tipo de cedula a visualizar o de estado de resultados." + vbCrLf +
            "2. La segunda salida consiste en una integracion de todo lo calculado, enviada a un documento de texto: Informe.rtf, creado en la misma ubicacion o carpeta donde se encuentre el ejecutable o .exe de este programa. Una vez creado es abierto automáticamente para su visualizacion en Word o en WordPad (presente en Windows) y de ahi se puede imprimir o modificar su formato o contenido." + vbCrLf +
            "3. El archivo de la segunda salida siempre se llamara Informe, por lo que si gusta conservar uno proveniente de ciertos datos, debera cambiar el nombre del archivo manualmente una vez creado y antes de ser reemplazado." +
            "Guardado de datos:" + vbCrLf + "* Si elige guardar en la seccion de datos, lo ingresado en la tabla se pasara a un archivo .csv (valores separados por comas), que es el tipo de archivo mas sencillo para almacenar datos en tabla y puede ser abierto en MS Excel. Este le permite tener un ejemplo, o irlo caturando en diferentes momentos, a la mano al elegir 'cargar' en la seccion de datos." + vbCrLf + vbCrLf +
            "+ Si elige 'no truncar los valores unitarios', entonces los calculos de costos de lo vendido e ingreso por ventas (ventas netas) y todo lo que dependa de la multiplicacion de unidades por algun valor unitario, tendra la mayor precision posible, comunmente al rededor de 15 cifras significativas." + vbCrLf +
            "+ Si elige 'enumerar conceptos', entonces a lo escrito como concepto se le agregara un numero, incluso si ya tenia uno, y su numeracion formara parte del nombre del concepto." + vbCrLf +
            "+ Si la primer letra de un concepto es minuscula, siempre sera cambiada por mayuscula." + vbCrLf +
            "+ Si ingresa un importe con cifras menores a centavos, seran redondeadas a centavos" + vbCrLf +
            "+ Si opto por un ejemplo, basta con elegir posteriormente 'calcular' para poder observar los resultados o imprimirslos si elige la generacion de informe." + vbCrLf + vbCrLf +
            "++ Es recomendable que los nombres de los conceptos no sean muy grandes, pues al pasar al documento de texto pueden desajustar los renglones de las tablas, volviendo dificil su lectura." + vbCrLf +
            "++ Si elige operaciones sin truncamiento, los calculos finales que estén en el estado de resultados se redondearan a tres decimales, para facilitar su visualizacion y diferenciacion de los truncados a dos decimales.")
    End Sub

    Private Sub bEjemplo1_Click(sender As Object, e As EventArgs) Handles bEjemplo1.Click
        Inicializacion()

        tbNombreEmpresa.Text = "Comercial Ejecutiva, SA de CV."
        tbPeriodo.Text = "de enero 1 de 2017 a febrero 28 de 2017"
        tbRubro.Text = "Elaboracion y distribucion de portafolios de piel."

        tbUnidadesProducidas.Text = 300000.ToString("N0")

        cbUnidadesVendidas.Items.Add(125000.ToString("N0"))
        cbUnidadesVendidas.Items.Add(150000.ToString("N0"))
        cbUnidadesVendidas.Items.Add(180000.ToString("N0"))
        cbUnidadesVendidas.Items.Add(200000.ToString("N0"))
        cbUnidadesVendidas.Items.Add(285000.ToString("N0"))

        cbUtilidadDeseada.Items.Add(250.ToString())

        dgvDatos.Rows.Add({"Mantenimiento maquinas de cocer", 45000, "CIF", "C Variable"})
        dgvDatos.Rows.Add({"Energia electrica almacen articulo terminado", 12500, "GV", "G Variable"})
        dgvDatos.Rows.Add({"Sueldo gerente produccion", 75000, "CIF", "C Fijo"})
        dgvDatos.Rows.Add({"Piel", 200000, "CMPD", "C Variable"})
        dgvDatos.Rows.Add({"Telefono oficina ventas", 13200, "GV", "G Variable"})
        dgvDatos.Rows.Add({"Sueldo gerente general", 100000, "GA", "G Fijo"})
        dgvDatos.Rows.Add({"Telefono almacen produccion en proceso", 65000, "CIF", "C Variable"})
        dgvDatos.Rows.Add({"Sueldo personal costura cierres de portafolios", 125000, "CMOD", "C Fijo"})
        dgvDatos.Rows.Add({"Broches para portafolios", 195000, "CMPD", "C Variable"})
        dgvDatos.Rows.Add({"Depreciacion eq. computo gerente produccion", 5600, "CIF", "C Fijo"})
        dgvDatos.Rows.Add({"Sueldo vigilancia acceso a empresa", 15000, "GA", "G Fijo"})
        dgvDatos.Rows.Add({"Bonos de productividad a obreros", 65000, "CMOD", "C Variable"})
        dgvDatos.Rows.Add({"Sueldo aux. contable depto. produccion", 12300, "CIF", "C Fijo"})
        dgvDatos.Rows.Add({"Depreciacion maquinas de cocer", 2500, "CIF", "C Fijo"})
        dgvDatos.Rows.Add({"Hilo", 25000, "CIF", "C Variable"})
        dgvDatos.Rows.Add({"Amortizacion gastos instal. fabrica", 25000, "CIF", "C Fijo"})
        dgvDatos.Rows.Add({"Gasolina equipo reparto", 3500, "GV", "G Variable"})
        dgvDatos.Rows.Add({"Comisiones bancarias por manejo de cuentas", 2000, "GF", "G Variable"})
        dgvDatos.Rows.Add({"Articulos limpieza depto. ventas", 1500, "GV", "G Variable"})
        dgvDatos.Rows.Add({"Cierres de 50cm para portafolios", 45000, "CMPD", "C Variable"})
        dgvDatos.Rows.Add({"Intereses bancarios por financiamiento", 6500, "GF", "G Fijo"})
        dgvDatos.Rows.Add({"Sueldo personal corte de piel", 120000, "CMOD", "C Fijo"})
        dgvDatos.Rows.Add({"Comisiones vendedores", 25000, "GV", "G Variable"})
        dgvDatos.Rows.Add({"Papeleria secretaria del gerente ventas", 2500, "GV", "G Variable"})
        dgvDatos.Rows.Add({"Sueldo personal Tecnol. Informacion empresa", 45000, "GA", "G Fijo"})
        dgvDatos.Rows.Add({"Etiquetas para portafolios", 25000, "CIF", "C Variable"})
        dgvDatos.Rows.Add({"Prima seguros contra incendios de la empresa", 6000, "GA", "G Fijo"})
        dgvDatos.Rows.Add({"Bolsas para empaquetado de portafolios", 90000, "CIF", "C Variable"})
        dgvDatos.Rows.Add({"Agua potable linea de produccion", 25000, "CIF", "C Variable"})
        dgvDatos.Rows.Add({"Deprec. montacargas depto. produccion", 2500, "CIF", "C Fijo"})
        dgvDatos.Rows.Add({"Sueldo jefe depto. produccion", 15000, "CIF", "C Fijo"})
    End Sub


    Private Sub bEjemplo2_Click(sender As Object, e As EventArgs) Handles bEjemplo2.Click
        Inicializacion()

        tbNombreEmpresa.Text = "Fabricacion La Moderna, SA de CV."
        tbPeriodo.Text = "enero y febrero de 2017"
        tbRubro.Text = "Elaboracion y distribucion generica de un producto."

        tbUnidadesProducidas.Text = 150000.ToString("N0")

        cbUnidadesVendidas.Items.Add(75000.ToString("N0"))
        cbUnidadesVendidas.Items.Add(90000.ToString("N0"))
        cbUnidadesVendidas.Items.Add(120000.ToString("N0"))
        cbUnidadesVendidas.Items.Add(130000.ToString("N0"))
        cbUnidadesVendidas.Items.Add(145000.ToString("N0"))

        cbUtilidadDeseada.Items.Add(153.ToString())
        cbUtilidadDeseada.Items.Add(79.ToString())
        cbUtilidadDeseada.Items.Add(210.ToString())

        dgvDatos.Rows.Add({"Renta depto. produccion", 15000, "CIF", "C Fijo"})
        dgvDatos.Rows.Add({"Comision a vendedores", 12300, "GV", "G Variable"})
        dgvDatos.Rows.Add({"Materia prima directa", 180000, "CMPD", "C Variable"})
        dgvDatos.Rows.Add({"Mantenimiento maquinaria de fabricacion", 7800, "CIF", "C Variable"})
        dgvDatos.Rows.Add({"Depreciacion de equipo de reparto", 1300, "GV", "G Fijo"})
        dgvDatos.Rows.Add({"Renta de oficina administrativa", 20000, "GA", "G Fijo"})
        dgvDatos.Rows.Add({"Intereses pagados", 2300, "GF", "G Variable"})
        dgvDatos.Rows.Add({"Fletes para entrega de mercancia", 1000, "GV", "G Variable"})
        dgvDatos.Rows.Add({"Sueldo supervisor de produccion", 16000, "CIF", "C Fijo"})
        dgvDatos.Rows.Add({"Mano de obra directa", 36000, "CMOD", "C Fijo"})
        dgvDatos.Rows.Add({"Renta de oficina de ventas", 25000, "GV", "G Fijo"})
        dgvDatos.Rows.Add({"Energia electrica depto. produccion", 15500, "CIF", "C Variable"})
        dgvDatos.Rows.Add({"Seguros y fianzas almacen articulo terminado", 5000, "GV", "G Fijo"})
        dgvDatos.Rows.Add({"Publicidad", 3500, "GV", "G Variable"})
        dgvDatos.Rows.Add({"Sueldo personal almacen articulo terminado", 18000, "GV", "G Fijo"})
        dgvDatos.Rows.Add({"Telefono del depto. produccion", 7500, "CIF", "C Variable"})
        dgvDatos.Rows.Add({"Sueldo personal almacen materia prima", 16000, "CIF", "C Fijo"})
        dgvDatos.Rows.Add({"Deprec. eq. computo ofic. administrativa", 3600, "GA", "G Fijo"})
        dgvDatos.Rows.Add({"Telefono oficina ventas", 10000, "GV", "G Variable"})
        dgvDatos.Rows.Add({"Sueldo personal limpieza depto. produccion", 7000, "CIF", "C Fijo"})
        dgvDatos.Rows.Add({"Sueldo director general", 80000, "GA", "G Fijo"})
        dgvDatos.Rows.Add({"Sueldo personal administrativo", 63000, "GA", "G Fijo"})
        dgvDatos.Rows.Add({"Materia prima indirecta", 125000, "CIF", "C Variable"})
        dgvDatos.Rows.Add({"Deprec. mobiliario depto. produccion", 8600, "CIF", "C Fijo"})
        dgvDatos.Rows.Add({"Sueldo personal vigilancia depto, produccion", 12000, "CIF", "C Fijo"})
        dgvDatos.Rows.Add({"Telefono de oficina administrativa", 9200, "GA", "G Variable"})
        dgvDatos.Rows.Add({"Sueldo del gerente de produccion", 55000, "CIF", "C Fijo"})
        dgvDatos.Rows.Add({"Amort. gastos instalacion depto. produccion", 15200, "CIF", "C Fijo"})
    End Sub

    Private Sub retirarComas(dgv As DataGridView, col As Integer)
        For i As Integer = 0 To dgv.Rows.Count - 1
            dgv(col, i).Value = Convert.ToDouble(dgv(col, i).Value).ToString()
        Next
    End Sub

    Private Sub agregarComas(dgv As DataGridView, col As Integer)
        For i As Integer = 0 To dgv.Rows.Count - 1
            dgv(col, i).Value = Convert.ToDouble(dgv(col, i).Value).ToString("N2")
        Next
    End Sub


    Private Sub bDatosGuardar_Click(sender As Object, e As EventArgs) Handles bDatosGuardar.Click
        'Revisa la existencia de la base de datos de alumnos, si no está sale del sub
        'If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\Datos.csv") Then
        'MsgBox("Falta el archivo Datos.csv, coloquelo para trabajar adecuadamente (puede estar vacio y solo tener e nombre deseado).", vbOKOnly)
        'Exit Sub
        'End If

        'Retiro de comas en columna de numeros (importe)
        retirarComas(dgvDatos, 1)

        'Guardado del archivo capturando en variable
        Dim headers = (From header As DataGridViewColumn In dgvDatos.Columns.Cast(Of DataGridViewColumn)()
                       Select header.HeaderText).ToArray
        Dim rows = From row As DataGridViewRow In dgvDatos.Rows.Cast(Of DataGridViewRow)()
                   Where Not row.IsNewRow
                   Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))
        Using sw As New IO.StreamWriter(Application.StartupPath & "\Datos.csv")
            sw.WriteLine(String.Join(",", headers))
            For Each r In rows
                sw.WriteLine(String.Join(",", r))
            Next
        End Using

        'Agregar comas en columna de numeros (importe)
        agregarComas(dgvDatos, 1)

        Process.Start(Application.StartupPath & "\Datos.csv")
    End Sub

    Private Sub bDatosCargar_Click(sender As Object, e As EventArgs) Handles bDatosCargar.Click
        'Revisa la existencia de la base de datos de alumnos, si no está sale del sub
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\Datos.csv") Then
            MsgBox("Falta el archivo Datos.csv, coloquelo para trabajar adecuadamente.", vbOKOnly)
            Exit Sub
        End If

        'Vacia el contenido del data grid view para evitar duplicidad
        dgvDatos.Rows.Clear()

        'Comienza la obtencion de informacion
        Dim TextFieldParser1 As New Microsoft.VisualBasic.FileIO.TextFieldParser(Application.StartupPath & "\Datos.csv")
        Dim conta As Integer

        TextFieldParser1.Delimiters = New String() {","}
        conta = 0

        While Not TextFieldParser1.EndOfData
            Dim Row1 As String() = TextFieldParser1.ReadFields()
            'Se salta el primer renglon: encabezados
            If conta > 0 Then dgvDatos.Rows.Add(Row1)
            conta = conta + 1
        End While

        'Agregar comas en columna de numeros (importe)
        agregarComas(dgvDatos, 1)

    End Sub
End Class
