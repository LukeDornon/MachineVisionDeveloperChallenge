Public Class Polygon
    Public Property vertices As New List(Of PointF)
    Public Property color As String
    Public Sub New()
    End Sub
    Public Sub New(ByVal _vertices As List(Of PointF), ByVal _color As String)
        For Each pointItem In _vertices
            vertices.Add(pointItem)
        Next
        color = _color
    End Sub

    'Public Function ValidPolygon() As Boolean
    '    Try
    '        If vertices.Count < 3 Then
    '            Return False
    '        Else
    '            Dim edges As New List(Of Segment)
    '            For i As Integer = 0 To vertices.Count - 1
    '                If i < (vertices.Count - 1) Then
    '                    If Not (vertices(i).X = vertices(i + 1).X AndAlso vertices(i).Y = vertices(i + 1).Y) Then edges.Add(New Segment(vertices(i), vertices(i + 1)))
    '                Else
    '                    If Not (vertices(i).X = vertices(0).X AndAlso vertices(i).Y = vertices(0).Y) Then edges.Add(New Segment(vertices(i), vertices(0)))
    '                End If
    '            Next
    '            For i As Integer = 0 To edges.Count - 1
    '                For j As Integer = 0 To edges.Count - 1
    '                    If SegmentsIntersect(edges(i).P1.X, edges(i).P1.Y, edges(i).P2.X, edges(i).P2.Y, edges(j).P1.X, edges(j).P1.Y, edges(j).P2.X, edges(j).P2.Y) Then
    '                        Return False
    '                    End If
    '                Next
    '            Next
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show($"Error validating polygon {ex}")
    '    End Try
    'End Function

    'Private Function SegmentsIntersect(ByVal X1 As Single, ByVal Y1 As Single, ByVal X2 As Single, ByVal Y2 As Single, ByVal X3 As Single, ByVal Y3 As Single, ByVal X4 As Single, ByVal Y4 As Single) As Boolean
    '    'This is from vb-helper.net.  There is some linear algebra going on here that I haven't 100% wrapped my head around.
    '    Dim dx As Single
    '    Dim dy As Single
    '    Dim da As Single
    '    Dim db As Single
    '    Dim t As Single
    '    Dim s As Single

    '    dx = X2 - X1
    '    dy = Y2 - Y1
    '    da = X4 - X3
    '    db = Y4 - Y3
    '    If (da * dy - db * dx) = 0 Then
    '        ' The segments are parallel.
    '        Return False
    '    End If

    '    s = (dx * (Y3 - Y1) + dy * (X1 - X3)) / (da * dy - db * dx)
    '    t = (da * (Y1 - Y3) + db * (X3 - X1)) / (db * dx - da * dy)

    '    Dim doesInterect = (s >= 0# And s <= 1.0# And t >= 0# And t <= 1.0#)
    '    If doesInterect Then
    '        Dim intersection As PointF = New PointF(X1 + t * dx, Y1 + t * dy)
    '        MessageBox.Show($"Segments ({X1}, {Y1})-({X2}, {Y2}) and ({X3}, {Y3})-({X4}, {Y4}) intersect at ({intersection.X}, {intersection.Y})")
    '        'Don't flag an intersection if segments meet at endPoint
    '        Return Not (intersection.X = X1 OrElse intersection.X = X2 OrElse intersection.X = X3 OrElse intersection.X - X4)
    '    Else
    '        Return False
    '    End If

    '    ' If it exists, the PointF of intersection is:
    '    ' (x1 + t * dx, y1 + t * dy)
    'End Function
End Class
