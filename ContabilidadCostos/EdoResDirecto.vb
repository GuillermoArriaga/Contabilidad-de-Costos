Public Class EdoResDirecto
    Public precioVenta As Double
    Public unidadesVendidas As Integer
    Public ventas As Double
    Public costoDeVentaVariable As Double
    Public costoVariableUnitario As Double
    Public gastoVariableUnitario As Double
    Public gastoVariable As Double
    Public contribucionMarginal As Double
    Public utilidadBRUTA As Double
    Public costoFijo As Double
    Public gastoFijo As Double
    Public utilidadNETA As Double

    ' Constructores
    Public Sub New(CVU As Double, GVU As Double, CFijo As Double, GFijo As Double)
        MyBase.New()
        costoVariableUnitario = CVU
        gastoVariableUnitario = GVU
        costoFijo = CFijo
        gastoFijo = GFijo
    End Sub

    Public Sub New(CVU As Double, GVU As Double, CFijo As Double, GFijo As Double, Truncado2 As Boolean)
        MyBase.New()
        If (Truncado2) Then
            costoVariableUnitario = Math.Truncate(CVU * 100) / 100
            gastoVariableUnitario = Math.Truncate(GVU * 100) / 100
            costoFijo = Math.Truncate(CFijo * 100) / 100
            gastoFijo = Math.Truncate(GFijo * 100) / 100
        Else
            costoVariableUnitario = CVU
            gastoVariableUnitario = GVU
            costoFijo = CFijo
            gastoFijo = GFijo
        End If
    End Sub


    'Metodos
    Public Sub Calcular(PV As Double, UV As Integer)
        precioVenta = PV
        unidadesVendidas = UV
        ventas = PV * UV
        costoDeVentaVariable = costoVariableUnitario * UV
        contribucionMarginal = ventas - costoDeVentaVariable
        gastoVariable = gastoVariableUnitario * UV
        utilidadBRUTA = contribucionMarginal - gastoVariable
        utilidadNETA = utilidadBRUTA - costoFijo - gastoFijo
    End Sub

    Public Sub Calcular(PV As Double, UV As Integer, Truncar2 As Boolean)
        If Truncar2 Then
            precioVenta = Math.Truncate(PV * 100) / 100
            unidadesVendidas = Math.Truncate(UV)
            ventas = Math.Truncate(PV * UV * 100) / 100
            costoDeVentaVariable = costoVariableUnitario * UV
            contribucionMarginal = ventas - costoDeVentaVariable
            gastoVariable = gastoVariableUnitario * UV
            utilidadBRUTA = contribucionMarginal - gastoVariable
            utilidadNETA = utilidadBRUTA - costoFijo - gastoFijo
        Else
            precioVenta = PV
            unidadesVendidas = UV
            ventas = PV * UV
            costoDeVentaVariable = costoVariableUnitario * UV
            contribucionMarginal = ventas - costoDeVentaVariable
            gastoVariable = gastoVariableUnitario * UV
            utilidadBRUTA = contribucionMarginal - gastoVariable
            utilidadNETA = utilidadBRUTA - costoFijo - gastoFijo
        End If
    End Sub
End Class
