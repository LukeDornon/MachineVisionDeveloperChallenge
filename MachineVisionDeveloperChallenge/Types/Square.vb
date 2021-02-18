Public Class Square
    Public Property center As Point
    Public Property length As Double
    Public Property orientation As Double
    Public Property color As String
    Public Sub New()
    End Sub
    Public Sub New(ByVal _center As Point, ByVal _length As Double, ByVal _orientation As Double, ByVal _color As String)
        center = _center
        length = _length
        orientation = _orientation
        color = _color
    End Sub
End Class
