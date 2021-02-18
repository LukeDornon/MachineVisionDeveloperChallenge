Public Class Polygon
    Public Property vertices As New List(Of Point)
    Public Property color As String
    Public Sub New()
    End Sub
    Public Sub New(ByVal _vertices As List(Of Point), ByVal _color As String)
        For Each pointItem In _vertices
            vertices.Add(pointItem)
        Next
        color = _color
    End Sub
End Class
