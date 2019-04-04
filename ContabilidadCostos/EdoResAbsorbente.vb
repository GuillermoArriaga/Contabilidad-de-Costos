Public Class EdoResAbsorbente
    Public precioVenta As Double
    Public unidadesVendidas As Integer
    Public ventas As Double
    Public costoProduccionUnitario As Double
    Public costoDeLoVendido As Double
    Public utilidadBruta As Double
    Public gastosOperacion As Double
    Public gastoVenta As Double
    Public gastoAdmin As Double
    Public gastoFinan As Double
    Public utilidadNeta As Double

    ' Constructores
    Public Sub New(CPU As Double, GO As Double, GV As Double, GA As Double, GF As Double)
        MyBase.New()
        costoProduccionUnitario = CPU
        gastosOperacion = GO
        gastoVenta = GV
        gastoAdmin = GA
        gastoFinan = GF
    End Sub

    Public Sub New(CPU As Double, GO As Double, GV As Double, GA As Double, GF As Double, Truncar2 As Boolean)
        MyBase.New()
        If Truncar2 Then
            costoProduccionUnitario = Math.Truncate(CPU * 100) / 100
            gastosOperacion = Math.Truncate(GO * 100) / 100
            gastoVenta = Math.Truncate(GV * 100) / 100
            gastoAdmin = Math.Truncate(GA * 100) / 100
            gastoFinan = Math.Truncate(GF * 100) / 100
        Else
            costoProduccionUnitario = CPU
            gastosOperacion = GO
            gastoVenta = GV
            gastoAdmin = GA
            gastoFinan = GF
        End If
    End Sub


    'Metodos
    Public Sub Calcular(PV As Double, UV As Integer)
        precioVenta = PV
        unidadesVendidas = UV
        ventas = precioVenta * unidadesVendidas
        costoDeLoVendido = costoProduccionUnitario * unidadesVendidas
        utilidadBruta = ventas - costoDeLoVendido
        utilidadNeta = utilidadBruta - gastosOperacion
    End Sub

    Public Sub Calcular(PV As Double, UV As Integer, Truncar2 As Boolean)
        If Truncar2 Then
            precioVenta = Math.Truncate(PV * 100) / 100
            unidadesVendidas = Math.Truncate(UV)
            ventas = Math.Truncate(precioVenta * unidadesVendidas * 100) / 100
            costoDeLoVendido = Math.Truncate(costoProduccionUnitario * unidadesVendidas * 100) / 100
            utilidadBruta = ventas - costoDeLoVendido
            utilidadNeta = utilidadBruta - gastosOperacion
        Else
            precioVenta = PV
            unidadesVendidas = UV
            ventas = precioVenta * unidadesVendidas
            costoDeLoVendido = costoProduccionUnitario * unidadesVendidas
            utilidadBruta = ventas - costoDeLoVendido
            utilidadNeta = utilidadBruta - gastosOperacion
        End If
    End Sub

End Class
