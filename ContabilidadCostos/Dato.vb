Public Class Dato
    Public concepto As String
    Public importe As Double
    ' Constructor
    Public Sub New()
        MyBase.New()
        concepto = ""
        importe = 0
    End Sub
    Public Sub New(CONCEPT As String, IMPORT As Double)
        MyBase.New()
        concepto = CONCEPT
        importe = IMPORT
    End Sub
    Public Sub Llenado(CONCEPT As String, IMPORT As Double)
        concepto = CONCEPT
        importe = IMPORT
    End Sub

End Class
