Public Class Circle
    Public Property center As Point
    Public Property radius As Double
    Public Property color As String
    Public Sub New()
    End Sub
    Public Sub New(ByVal _center As Point, ByVal _radius As Double, ByVal _color As String)
        center = _center
        radius = _radius
        color = _color
    End Sub
End Class
