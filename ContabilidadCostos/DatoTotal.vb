Public Class DatoTotal
    Public nombre As String
    Public datos() As Dato
    Public cantidad As Double

    ' Constructores
    Public Sub New()
        MyBase.New()
        cantidad = 0
        nombre = ""
    End Sub
    Public Sub New(name As String, DT As Integer)
        MyBase.New()
        cantidad = 0
        nombre = name
        ReDim datos(DT - 1)
        For i As Integer = 0 To DT - 1
            datos(i) = New Dato
        Next
    End Sub
    Public Sub New(name As String, DT As Integer, CONCEPTOS() As String, IMPORTES() As Double)
        MyBase.New()
        cantidad = 0
        nombre = name
        ReDim datos(DT - 1)
        For i As Integer = 0 To DT - 1
            datos(i) = New Dato(CONCEPTOS(i), IMPORTES(i))
            cantidad += IMPORTES(i)
        Next
    End Sub
    Public Sub Llenado(name As String, DT As Integer)
        cantidad = 0
        nombre = name
        ReDim datos(DT - 1)
        For i As Integer = 0 To DT - 1
            datos(i) = New Dato
        Next
    End Sub

End Class
