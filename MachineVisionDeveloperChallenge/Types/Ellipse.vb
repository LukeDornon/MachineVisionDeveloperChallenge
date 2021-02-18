Public Class Ellipse
    Public Property center As Point
    Public Property majorRadius As Double
    Public Property minorRadius As Double
    Public Property orientation As Double
    Public Property color As String
    Public Sub New()
    End Sub
    Public Sub New(ByVal _center As Point, ByVal _majorRadius As Double, ByVal _minorRadius As Double, ByVal _orientation As Double, ByVal _color As String)
        center = _center
        majorRadius = _majorRadius
        minorRadius = _minorRadius
        orientation = _orientation
        color = _color
    End Sub
End Class
