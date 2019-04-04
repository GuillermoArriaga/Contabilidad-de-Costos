Public Class Cedula
    Public nombre As String
    Public datosTotales() As DatoTotal
    Public cantidad As Double

    ' Constructor
    Public Sub New(name As String, DT As Integer, NAMES() As String, SIZE() As Integer)
        MyBase.New()
        nombre = name
        ReDim datosTotales(DT - 1)

        For i As Integer = 0 To DT - 1
            datosTotales(i) = New DatoTotal(NAMES(i), SIZE(i))
        Next
    End Sub
    Public Sub New(name As String, DT As Integer, NAMES() As String, SIZE() As Integer, CONCEPTOS(,) As String, IMPORTES(,) As Double)
        MyBase.New()
        nombre = name
        ReDim datosTotales(DT - 1)
        Dim concep() As String
        Dim import() As Double

        For i As Integer = 0 To DT - 1
            ReDim concep(SIZE(i) - 1)
            ReDim import(SIZE(i) - 1)
            For j As Integer = 0 To SIZE(i) - 1
                concep(j) = CONCEPTOS(i, j)
                import(j) = IMPORTES(i, j)
            Next
            datosTotales(i) = New DatoTotal(NAMES(i), SIZE(i), concep, import)
        Next
    End Sub

End Class
