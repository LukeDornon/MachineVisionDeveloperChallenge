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

    Public Function ValidatePolygon() As Boolean
        Try
            If vertices.Count < 3 Then
                Return False
            Else
                Dim edges As New List(Of Segment)
                For i As Integer = 0 To vertices.Count - 1
                    If i < (vertices.Count - 1) Then
                        If Not (vertices(i).X = vertices(i + 1).X AndAlso vertices(i).Y = vertices(i + 1).Y) Then edges.Add(New Segment(vertices(i), vertices(i + 1)))
                    Else
                        If Not (vertices(i).X = vertices(0).X AndAlso vertices(i).Y = vertices(0).Y) Then edges.Add(New Segment(vertices(i), vertices(0)))
                    End If
                Next
                For i As Integer = 0 To edges.Count - 1
                    For j As Integer = 0 To edges.Count - 1
                        If SegmentsIntersect(edges(i).P1.X, edges(i).P1.Y, edges(i).P2.X, edges(i).P2.Y, edges(j).P1.X, edges(j).P1.Y, edges(j).P2.X, edges(j).P2.Y) Then
                            Return False
                        End If
                    Next
                Next
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show($"Error validating polygon {ex}")
        End Try
    End Function

    Public Function CorrectPolygon() As Boolean
        Try
            If vertices.Count < 3 Then
                Return False
            Else
                'Deduplicate points and sort in order of ascending X value
                Dim dedupVertices = vertices.Distinct.ToList()
                Dim sortedVertices = dedupVertices.OrderBy(Function(p) p.X).ToList

                'Draw line from smallest to largest x-value points.  By determining if sorted points are above or below this line we can arrange points in a counterclockwise order that should define a polygon.
                Dim centerline = New Segment(sortedVertices(0), sortedVertices(sortedVertices.Count - 1))
                Dim m As Single = (centerline.P2.Y - centerline.P1.Y) / (centerline.P2.X - centerline.P1.X)     'slope
                Dim b As Single = centerline.P1.Y - m * centerline.P1.X                                         'intercept
                Dim aboveVertices As New List(Of PointF)
                Dim belowVertices As New List(Of PointF)
                For i As Integer = 1 To sortedVertices.Count - 2
                    Dim verticalOffset As Single = sortedVertices(i).Y - (m * (sortedVertices(i).X) + b)
                    If verticalOffset > 0 Then
                        aboveVertices.Add(sortedVertices(i))
                    Else
                        belowVertices.Add(sortedVertices(i))
                    End If
                Next
                'Create list with points counterclockwise from lowest x-value
                Dim fixedVertices As New List(Of PointF)
                fixedVertices.Add(sortedVertices(0))
                For j As Integer = 0 To belowVertices.Count - 1
                    fixedVertices.Add(belowVertices(j))
                Next
                fixedVertices.Add(sortedVertices(sortedVertices.Count - 1))
                For k As Integer = aboveVertices.Count - 1 To 0 Step -1
                    fixedVertices.Add(aboveVertices(k))
                Next
                vertices = fixedVertices
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show($"Error correcting polygon {ex}")
        End Try
    End Function

    Private Function SegmentsIntersect(ByVal X1 As Single, ByVal Y1 As Single, ByVal X2 As Single, ByVal Y2 As Single, ByVal X3 As Single, ByVal Y3 As Single, ByVal X4 As Single, ByVal Y4 As Single) As Boolean
        'This is from vb-helper.net.  There is some linear algebra going on here that I haven't 100% wrapped my head around.
        Dim dx As Single
        Dim dy As Single
        Dim da As Single
        Dim db As Single
        Dim t As Single
        Dim s As Single

        dx = X2 - X1
        dy = Y2 - Y1
        da = X4 - X3
        db = Y4 - Y3
        If (da * dy - db * dx) = 0 Then
            ' The segments are parallel.
            Return False
        End If

        s = (dx * (Y3 - Y1) + dy * (X1 - X3)) / (da * dy - db * dx)
        t = (da * (Y1 - Y3) + db * (X3 - X1)) / (db * dx - da * dy)

        If (s >= 0# And s <= 1.0# And t >= 0# And t <= 1.0#) Then
            Dim intersection As PointF = New PointF(X1 + t * dx, Y1 + t * dy)
            'Don't flag an intersection if segments meet at an endPoint
            If Not ((Math.Round(intersection.X, 1) = Math.Round(X1, 1) AndAlso Math.Round(intersection.Y, 1) = Math.Round(Y1, 1)) OrElse (Math.Round(intersection.X, 1) = Math.Round(X2, 1) AndAlso Math.Round(intersection.Y, 1) = Math.Round(Y2, 1))) Then
                Return True
            End If
        Else
            Return False
        End If
    End Function
End Class
