Public Class PrecioVenta
    Public precio As Double
    Public porcentajeUtilidadDeseada As Double
    Public costoTotalUnitario As Double

    Public Sub New(porcentajeUD As Double, CTU As Double)
        MyBase.New()
        porcentajeUtilidadDeseada = porcentajeUD
        costoTotalUnitario = CTU
        precio = CTU * (1 + porcentajeUD / 100)
    End Sub
End Class
