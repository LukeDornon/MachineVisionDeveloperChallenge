Public Class MainForm
    Private _shapeCollection As New ShapeCollection
    Private _settingsDir As String = "C:\ProgramData\Gentex Corporation\MachineVisionDeveloperChallenge\"
#Region "Form Events"
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Initialize shape collection from saved xml, or from startup csv if no xml exists
            If Not IO.File.Exists($"{_settingsDir}shapes.xml") Then
                ParseStartupCSV()
            Else
                LoadSavedCollection()
            End If
            If _shapeCollection IsNot Nothing Then CalculateAll()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Save Collection?", "Save Collection?", MessageBoxButtons.YesNo) = DialogResult.Yes Then SaveCollection()
    End Sub

    Private Sub ComboBoxIndex_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxIndex.SelectedIndexChanged
        Try
            PanelShape.Invalidate()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub ComboBoxShape_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxShape.SelectedIndexChanged
        Try
            ComboBoxIndex.Items.Clear()
            Select Case ComboBoxShape.SelectedItem
                Case "Circles"
                    For i As Integer = 0 To _shapeCollection.Circles.Count - 1
                        ComboBoxIndex.Items.Add($"Circle {i}")
                    Next
                Case "Ellipses"
                    For i As Integer = 0 To _shapeCollection.Ellipses.Count - 1
                        ComboBoxIndex.Items.Add($"Ellipse {i}")
                    Next
                Case "Polygons"
                    For i As Integer = 0 To _shapeCollection.Polygons.Count - 1
                        ComboBoxIndex.Items.Add($"Polygon {i}")
                    Next
                Case "Squares"
                    For i As Integer = 0 To _shapeCollection.Squares.Count - 1
                        ComboBoxIndex.Items.Add($"Square {i}")
                    Next
                Case "Equilateral Triangles"
                    For i As Integer = 0 To _shapeCollection.Triangles.Count - 1
                        ComboBoxIndex.Items.Add($"Equilateral Triangle {i}")
                    Next
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub ToolStripMenuItemExit_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemExit.Click
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItemSave_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemSave.Click
        SaveCollection()
    End Sub

    Private Sub PanelShapePaint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles PanelShape.Paint
        Try
            Select Case ComboBoxShape.SelectedItem
                Case "Circles"
                    If ComboBoxIndex.SelectedItem IsNot Nothing AndAlso ComboBoxIndex.SelectedIndex < _shapeCollection.Circles.Count Then
                        DrawCircle(ComboBoxIndex.SelectedIndex)
                    End If
                Case "Ellipses"
                    If ComboBoxIndex.SelectedItem IsNot Nothing AndAlso ComboBoxIndex.SelectedIndex < _shapeCollection.Ellipses.Count Then
                        DrawEllipse(ComboBoxIndex.SelectedIndex)
                    End If
                Case "Polygons"
                    If ComboBoxIndex.SelectedItem IsNot Nothing AndAlso ComboBoxIndex.SelectedIndex < _shapeCollection.Polygons.Count Then
                        DrawPolygon(ComboBoxIndex.SelectedIndex)
                    End If
                Case "Squares"
                    If ComboBoxIndex.SelectedItem IsNot Nothing AndAlso ComboBoxIndex.SelectedIndex < _shapeCollection.Squares.Count Then
                        DrawSquare(ComboBoxIndex.SelectedIndex)
                    End If
                Case "Equilateral Triangles"
                    If ComboBoxIndex.SelectedItem IsNot Nothing AndAlso ComboBoxIndex.SelectedIndex < _shapeCollection.Triangles.Count Then
                        DrawTriangle(ComboBoxIndex.SelectedIndex)
                    End If
                Case Else
                    PanelShape.BackColor = DefaultBackColor
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub ButtonAddShape_Click(sender As Object, e As EventArgs) Handles ButtonAddShape.Click
        Try
            Dim updated As Boolean = False
            Select Case ComboBoxShape.SelectedItem
                Case "Circles"
                    Using modifyForm As New CircleForm()
                        If modifyForm.ShowDialog = DialogResult.OK Then
                            _shapeCollection.Circles.Add(modifyForm.returnCircle)
                            updated = True
                            Dim i = _shapeCollection.Circles.Count - 1
                            ComboBoxIndex.Items.Add($"Circle {i}")
                            ComboBoxIndex.SelectedIndex = i
                        End If
                    End Using
                Case "Ellipses"
                    Using modifyForm As New EllipseForm()
                        If modifyForm.ShowDialog = DialogResult.OK Then
                            _shapeCollection.Ellipses.Add(modifyForm.returnEllipse)
                            updated = True
                            Dim i = _shapeCollection.Ellipses.Count - 1
                            ComboBoxIndex.Items.Add($"Ellipse {i}")
                            ComboBoxIndex.SelectedIndex = i
                        End If
                    End Using
                Case "Polygons"
                    Using modifyForm As New PolygonForm()
                        If modifyForm.ShowDialog = DialogResult.OK Then
                            _shapeCollection.Polygons.Add(modifyForm.returnpolygon)
                            updated = True
                            Dim i = _shapeCollection.Polygons.Count - 1
                            ComboBoxIndex.Items.Add($"Polygon {i}")
                            ComboBoxIndex.SelectedIndex = i
                        End If
                    End Using
                Case "Squares"
                    Using modifyForm As New SquareForm()
                        If modifyForm.ShowDialog = DialogResult.OK Then
                            _shapeCollection.Squares.Add(modifyForm.returnSquare)
                            updated = True
                            Dim i = _shapeCollection.Squares.Count - 1
                            ComboBoxIndex.Items.Add($"Square {i}")
                            ComboBoxIndex.SelectedIndex = i
                        End If
                    End Using
                Case "Equilateral Triangles"
                    Using modifyForm As New TriangleForm()
                        If modifyForm.ShowDialog = DialogResult.OK Then
                            _shapeCollection.Triangles.Add(modifyForm.returnTriangle)
                            updated = True
                            Dim i = _shapeCollection.Triangles.Count - 1
                            ComboBoxIndex.Items.Add($"Equilateral Triangle {i}")
                            ComboBoxIndex.SelectedIndex = i
                        End If
                    End Using
            End Select
            If updated Then CalculateAll()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub ButtonModifyShape_Click(sender As Object, e As EventArgs) Handles ButtonModifyShape.Click
        Try
            Dim updated As Boolean = False
            Select Case ComboBoxShape.SelectedItem
                Case "Circles"
                    If ComboBoxIndex.SelectedIndex >= 0 AndAlso ComboBoxIndex.SelectedIndex < _shapeCollection.Circles.Count Then
                        Using modifyForm As New CircleForm(_shapeCollection.Circles(ComboBoxIndex.SelectedIndex))
                            If modifyForm.ShowDialog = DialogResult.OK Then _shapeCollection.Circles(ComboBoxIndex.SelectedIndex) = modifyForm.returnCircle : updated = True
                        End Using
                    Else
                        MessageBox.Show("Selected shape index outside of collection limits.")
                    End If
                Case "Ellipses"
                    If ComboBoxIndex.SelectedIndex >= 0 AndAlso ComboBoxIndex.SelectedIndex < _shapeCollection.Ellipses.Count Then
                        Using modifyForm As New EllipseForm(_shapeCollection.Ellipses(ComboBoxIndex.SelectedIndex))
                            If modifyForm.ShowDialog = DialogResult.OK Then _shapeCollection.Ellipses(ComboBoxIndex.SelectedIndex) = modifyForm.returnEllipse : updated = True
                        End Using
                    Else
                        MessageBox.Show("Selected shape index outside of collection limits.")
                    End If
                Case "Polygons"
                    If ComboBoxIndex.SelectedIndex >= 0 AndAlso ComboBoxIndex.SelectedIndex < _shapeCollection.Polygons.Count Then
                        Using modifyForm As New PolygonForm(_shapeCollection.Polygons(ComboBoxIndex.SelectedIndex))
                            If modifyForm.ShowDialog = DialogResult.OK Then _shapeCollection.Polygons(ComboBoxIndex.SelectedIndex) = modifyForm.returnPolygon : updated = True
                        End Using
                    Else
                        MessageBox.Show("Selected shape index outside of collection limits.")
                    End If
                Case "Squares"
                    If ComboBoxIndex.SelectedIndex >= 0 AndAlso ComboBoxIndex.SelectedIndex < _shapeCollection.Squares.Count Then
                        Using modifyForm As New SquareForm(_shapeCollection.Squares(ComboBoxIndex.SelectedIndex))
                            If modifyForm.ShowDialog = DialogResult.OK Then _shapeCollection.Squares(ComboBoxIndex.SelectedIndex) = modifyForm.returnSquare : updated = True
                        End Using
                    Else
                        MessageBox.Show("Selected shape index outside of collection limits.")
                    End If
                Case "Equilateral Triangles"
                    If ComboBoxIndex.SelectedIndex >= 0 AndAlso ComboBoxIndex.SelectedIndex < _shapeCollection.Triangles.Count Then
                        Using modifyForm As New TriangleForm(_shapeCollection.Triangles(ComboBoxIndex.SelectedIndex))
                            If modifyForm.ShowDialog = DialogResult.OK Then _shapeCollection.Triangles(ComboBoxIndex.SelectedIndex) = modifyForm.returnTriangle : updated = True
                        End Using
                    Else
                        MessageBox.Show("Selected shape index outside of collection limits.")
                    End If
            End Select
            If updated Then
                PanelShape.Invalidate()
                CalculateAll()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Initialization"
    Private Sub ParseStartupCSV()
        Try
            Dim parser = New FileIO.TextFieldParser("../../../../Machine Vision Development Engineer Coding Exercise _ ShapeList.csv")
            parser.TextFieldType = FileIO.FieldType.Delimited
            parser.SetDelimiters(New String() {","})
            While Not parser.EndOfData
                Dim row As String() = parser.ReadFields()
                Select Case row(0)
                    Case "Circle"
                        _shapeCollection.Circles.Add(New Circle(New Point(row(2), row(4)), row(6), "Red"))
                    Case "Ellipse"
                        _shapeCollection.Ellipses.Add(New Ellipse(New Point(row(2), row(4)), row(6), row(8), row(10), "Red"))
                    Case "Polygon"
                        Dim points As New List(Of Point)
                        For i As Integer = 1 To row.Length - 1
                            If row(i).Contains("X") Then points.Add(New Point(row(i + 1), row(i + 3)))
                        Next
                        _shapeCollection.Polygons.Add(New Polygon(points, "Red"))
                    Case "Square"
                        _shapeCollection.Squares.Add(New Square(New Point(row(2), row(4)), row(6), row(8), "Red"))
                    Case "Equilateral Triangle"
                        _shapeCollection.Triangles.Add(New Triangle(New Point(row(2), row(4)), row(6), row(8), "Red"))
                    Case Else
                        MessageBox.Show($"You missed {row(0)}")
                End Select
            End While
        Catch ex As Exception
            Throw New Exception($"Error parsing CSV shapes file: {ex}")
        End Try
    End Sub
    Private Sub LoadSavedCollection()
        Try
            Dim serializer As New Xml.Serialization.XmlSerializer(GetType(ShapeCollection))
            If Not IO.Directory.Exists(_settingsDir) Then
                Throw New Exception($"Save directory {_settingsDir} does not exist.")
            End If
            Using reader As New IO.StreamReader($"{_settingsDir}shapes.xml")
                _shapeCollection = serializer.Deserialize(reader)
            End Using
        Catch ex As Exception
            Throw (ex)
        End Try
    End Sub
    Private Sub SaveCollection()
        Try
            Dim serializer As New Xml.Serialization.XmlSerializer(GetType(ShapeCollection))
            If Not IO.Directory.Exists(_settingsDir) Then IO.Directory.CreateDirectory(_settingsDir)
            Using writer As New IO.StreamWriter($"{_settingsDir}shapes.xml")
                serializer.Serialize(writer, _shapeCollection)
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Drawing"
    Private Sub DrawCircle(ByVal index As Integer)
        Try
            PanelShape.BackColor = DefaultBackColor

            'Determine Optimal Origin
            Dim origin As Point
            Dim originOffset = _shapeCollection.Circles(index).radius + 2
            If _shapeCollection.Circles(index).center.X > 0 Then
                origin.X = originOffset
            Else
                origin.X = PanelShape.Width - originOffset
            End If
            If _shapeCollection.Circles(index).center.Y > 0 Then
                origin.Y = PanelShape.Height - originOffset
            Else
                origin.Y = originOffset
            End If

            'Draw Origin
            Dim myPen As New Pen(Color.Black)
            Dim formGraphics As Graphics = PanelShape.CreateGraphics
            formGraphics.DrawLine(myPen, New Point(origin.X - 4, origin.Y), New Point(origin.X + 10, origin.Y))
            formGraphics.DrawLine(myPen, New Point(origin.X, origin.Y - 10), New Point(origin.X, origin.Y + 4))

            'Draw and Fill Circle
            Dim myBrush As New SolidBrush(Color.FromName(_shapeCollection.Circles(index).color))
            myPen.Color = Color.FromName(_shapeCollection.Circles(index).color)
            Dim boundingRect As Rectangle = New Rectangle(origin.X + _shapeCollection.Circles(index).center.X - _shapeCollection.Circles(index).radius, origin.Y - _shapeCollection.Circles(index).center.Y - _shapeCollection.Circles(index).radius, _shapeCollection.Circles(index).radius * 2, _shapeCollection.Circles(index).radius * 2)
            formGraphics.DrawEllipse(myPen, boundingRect)
            formGraphics.FillEllipse(myBrush, boundingRect)

            myPen.Dispose()
            myBrush.Dispose()
            formGraphics.Dispose()

            'Display Dimensions
            Dim Dimensions = CalculateCircleDimensions(_shapeCollection.Circles(index).radius)
            TextBoxCurrentShape.Text = $"Area: {Dimensions(0):0.00}{vbNewLine}Perimeter: {Dimensions(1):0.00}"
        Catch ex As Exception
            Throw New Exception($"Error Drawing Circle: {ex}")
        End Try
    End Sub
    Private Sub DrawEllipse(ByVal index As Integer)
        Try
            PanelShape.BackColor = DefaultBackColor

            'Determine Optimal Origin
            Dim origin As Point
            Dim originOffset = If(_shapeCollection.Ellipses(index).majorRadius > _shapeCollection.Ellipses(index).minorRadius, _shapeCollection.Ellipses(index).majorRadius, _shapeCollection.Ellipses(index).minorRadius) + 2
            If _shapeCollection.Ellipses(index).center.X > 0 Then
                origin.X = originOffset
            Else
                origin.X = PanelShape.Width - originOffset
            End If
            If _shapeCollection.Ellipses(index).center.Y > 0 Then
                origin.Y = PanelShape.Height - originOffset
            Else
                origin.Y = originOffset
            End If

            'Draw Origin
            Dim myPen As New Pen(Color.Black)
            Dim formGraphics As Graphics = PanelShape.CreateGraphics
            formGraphics.DrawLine(myPen, New Point(origin.X - 4, origin.Y), New Point(origin.X + 10, origin.Y))
            formGraphics.DrawLine(myPen, New Point(origin.X, origin.Y - 10), New Point(origin.X, origin.Y + 4))

            'Translate Graphics, then rotate applied to all later graphics calls
            formGraphics.TranslateTransform(origin.X + _shapeCollection.Ellipses(index).center.X, origin.Y - _shapeCollection.Ellipses(index).center.Y)
            formGraphics.RotateTransform(-1 * (_shapeCollection.Ellipses(index).orientation * (180 / Math.PI)))

            'Draw and Fill Ellipse
            Dim myBrush As New SolidBrush(Color.FromName(_shapeCollection.Ellipses(index).color))
            myPen.Color = Color.FromName(_shapeCollection.Ellipses(index).color)
            Dim boundingRect As Rectangle = New Rectangle(-1 * _shapeCollection.Ellipses(index).majorRadius, -1 * _shapeCollection.Ellipses(index).minorRadius, _shapeCollection.Ellipses(index).majorRadius * 2, _shapeCollection.Ellipses(index).minorRadius * 2)
            formGraphics.DrawEllipse(myPen, boundingRect)
            formGraphics.FillEllipse(myBrush, boundingRect)

            myPen.Dispose()
            myBrush.Dispose()
            formGraphics.Dispose()

            'Display Dimensions
            Dim Dimensions = CalculateEllipseDimensions(_shapeCollection.Ellipses(index).majorRadius, _shapeCollection.Ellipses(index).minorRadius)
            TextBoxCurrentShape.Text = $"Area: {Dimensions(0):0.00}{vbNewLine}Perimeter: {Dimensions(1):0.00}"
        Catch ex As Exception
            Throw New Exception($"Error Drawing Ellipse: {ex}")
        End Try
    End Sub
    Private Sub DrawPolygon(ByVal index As Integer)
        Try
            PanelShape.BackColor = DefaultBackColor

            'Determine Optimal Origin
            Dim origin As Point
            If _shapeCollection.Polygons(index).vertices(0).X > 0 Then
                origin.X = 10
            Else
                origin.X = PanelShape.Width - 10
            End If
            If _shapeCollection.Polygons(index).vertices(0).Y > 0 Then
                origin.Y = PanelShape.Height - 10
            Else
                origin.Y = 10
            End If

            'Draw Origin
            Dim myPen As New Pen(Color.Black)
            Dim formGraphics As Graphics = PanelShape.CreateGraphics
            formGraphics.DrawLine(myPen, New Point(origin.X - 4, origin.Y), New Point(origin.X + 10, origin.Y))
            formGraphics.DrawLine(myPen, New Point(origin.X, origin.Y - 10), New Point(origin.X, origin.Y + 4))

            'Reorient points to origin
            Dim pointsTemp As New List(Of Point)
            For Each pointVal In _shapeCollection.Polygons(index).vertices
                pointsTemp.Add(New Point(origin.X + pointVal.X, origin.Y - pointVal.Y))
            Next

            'Draw and Fill Poygon
            Dim myBrush As New SolidBrush(Color.FromName(_shapeCollection.Polygons(index).color))
            myPen.Color = Color.FromName(_shapeCollection.Polygons(index).color)
            formGraphics.DrawPolygon(myPen, pointsTemp.ToArray)
            formGraphics.FillPolygon(myBrush, pointsTemp.ToArray)

            myPen.Dispose()
            myBrush.Dispose()
            formGraphics.Dispose()

            'Display Dimensions
            Dim Dimensions = CalculatePolygonDimensions(_shapeCollection.Polygons(index).vertices)
            TextBoxCurrentShape.Text = $"Area: {Dimensions(0):0.00}{vbNewLine}Perimeter: {Dimensions(1):0.00}"
        Catch ex As Exception
            Throw New Exception($"Error Drawing Polygon: {ex}")
        End Try
    End Sub
    Private Sub DrawSquare(ByVal index As Integer)
        Try
            PanelShape.BackColor = DefaultBackColor

            'Determine Optimal Origin
            Dim origin As Point
            Dim originOffset = (_shapeCollection.Squares(index).length / 2) + 2
            If _shapeCollection.Squares(index).center.X > 0 Then
                origin.X = originOffset
            Else
                origin.X = PanelShape.Width - originOffset
            End If
            If _shapeCollection.Squares(index).center.Y > 0 Then
                origin.Y = PanelShape.Height - originOffset
            Else
                origin.Y = originOffset
            End If

            'Draw Origin
            Dim myPen As New Pen(Color.Black)
            Dim formGraphics As Graphics = PanelShape.CreateGraphics
            formGraphics.DrawLine(myPen, New Point(origin.X - 4, origin.Y), New Point(origin.X + 10, origin.Y))
            formGraphics.DrawLine(myPen, New Point(origin.X, origin.Y - 10), New Point(origin.X, origin.Y + 4))

            'Translate Graphics, then rotate applied to all later graphics calls
            formGraphics.TranslateTransform(origin.X + _shapeCollection.Squares(index).center.X, origin.Y - _shapeCollection.Squares(index).center.Y)
            formGraphics.RotateTransform(-1 * (_shapeCollection.Squares(index).orientation * (180 / Math.PI)))

            'Draw and Fill Square
            Dim myBrush As New SolidBrush(Color.FromName(_shapeCollection.Squares(index).color))
            myPen.Color = Color.FromName(_shapeCollection.Squares(index).color)
            Dim boundingRect As Rectangle = New Rectangle(-1 * (_shapeCollection.Squares(index).length / 2), -1 * (_shapeCollection.Squares(index).length / 2), _shapeCollection.Squares(index).length, _shapeCollection.Squares(index).length)
            formGraphics.DrawRectangle(myPen, boundingRect)
            formGraphics.FillRectangle(myBrush, boundingRect)

            myPen.Dispose()
            myBrush.Dispose()
            formGraphics.Dispose()

            'Display Dimensions
            Dim Dimensions = CalculateSquareDimensions(_shapeCollection.Squares(index).length)
            TextBoxCurrentShape.Text = $"Area: {Dimensions(0):0.00}{vbNewLine}Perimeter: {Dimensions(1):0.00}"
        Catch ex As Exception
            Throw New Exception($"Error Drawing Square: {ex}")
        End Try
    End Sub
    Private Sub DrawTriangle(ByVal index As Integer)
        Try
            PanelShape.BackColor = DefaultBackColor

            'Determine Optimal Origin
            Dim origin As Point
            Dim originOffset = _shapeCollection.Triangles(index).length + 2
            If _shapeCollection.Triangles(index).center.X > 0 Then
                origin.X = originOffset
            Else
                origin.X = PanelShape.Width - originOffset
            End If
            If _shapeCollection.Triangles(index).center.Y > 0 Then
                origin.Y = PanelShape.Height - originOffset
            Else
                origin.Y = originOffset
            End If

            'Draw Origin
            Dim myPen As New Pen(Color.Black)
            Dim formGraphics As Graphics = PanelShape.CreateGraphics
            formGraphics.DrawLine(myPen, New Point(origin.X - 4, origin.Y), New Point(origin.X + 10, origin.Y))
            formGraphics.DrawLine(myPen, New Point(origin.X, origin.Y - 10), New Point(origin.X, origin.Y + 4))

            'Translate Graphics, then rotate applied to all later graphics calls
            formGraphics.TranslateTransform(origin.X + _shapeCollection.Triangles(index).center.X, origin.Y - _shapeCollection.Triangles(index).center.Y)
            formGraphics.RotateTransform(-1 * (_shapeCollection.Triangles(index).orientation * (180 / Math.PI)))

            'Calculate Vertices
            Dim pointsTemp As New List(Of Point)
            pointsTemp.Add(New Point(-(_shapeCollection.Triangles(index).length / 2), (_shapeCollection.Triangles(index).length / (2 * Math.Sqrt(3)))))
            pointsTemp.Add(New Point((_shapeCollection.Triangles(index).length / 2), (_shapeCollection.Triangles(index).length / (2 * Math.Sqrt(3)))))
            pointsTemp.Add(New Point(0, -1 * (_shapeCollection.Triangles(index).length / (Math.Sqrt(3)))))

            'Draw and Fill Triangle
            Dim myBrush As New SolidBrush(Color.FromName(_shapeCollection.Triangles(index).color))
            myPen.Color = Color.FromName(_shapeCollection.Triangles(index).color)
            formGraphics.DrawPolygon(myPen, pointsTemp.ToArray)
            formGraphics.FillPolygon(myBrush, pointsTemp.ToArray)

            myPen.Dispose()
            myBrush.Dispose()
            formGraphics.Dispose()

            'Display Dimensions
            Dim Dimensions = CalculateEquilateralTriangleDimensions(_shapeCollection.Triangles(index).length)
            TextBoxCurrentShape.Text = $"Area: {Dimensions(0):0.00}{vbNewLine}Perimeter: {Dimensions(1):0.00}"
        Catch ex As Exception
            Throw New Exception($"Error Drawing Triangle: {ex}")
        End Try
    End Sub
#End Region

#Region "Math"
    Private Sub CalculateAll()
        Try
            'Sum all dimensions
            Dim Dimensions As Double() = {0.0, 0.0}
            For Each circleVal In _shapeCollection.Circles
                Dim theseDimensions = CalculateCircleDimensions(circleVal.radius)
                Dimensions(0) += theseDimensions(0)
                Dimensions(1) += theseDimensions(1)
            Next
            For Each ellipseVal In _shapeCollection.Ellipses
                Dim theseDimensions = CalculateEllipseDimensions(ellipseVal.majorRadius, ellipseVal.minorRadius)
                Dimensions(0) += theseDimensions(0)
                Dimensions(1) += theseDimensions(1)
            Next
            For Each polygonVal In _shapeCollection.Polygons
                Dim theseDimensions = CalculatePolygonDimensions(polygonVal.vertices)
                Dimensions(0) += theseDimensions(0)
                Dimensions(1) += theseDimensions(1)
            Next
            For Each squareVal In _shapeCollection.Squares
                Dim theseDimensions = CalculateSquareDimensions(squareVal.length)
                Dimensions(0) += theseDimensions(0)
                Dimensions(1) += theseDimensions(1)
            Next
            For Each triangleVal In _shapeCollection.Triangles
                Dim theseDimensions = CalculateCircleDimensions(triangleVal.length)
                Dimensions(0) += theseDimensions(0)
                Dimensions(1) += theseDimensions(1)
            Next

            'Display Dimensions
            TextBoxAllShapes.Text = $"Area: {Dimensions(0):0.00}{vbNewLine}Perimeter: {Dimensions(1):0.00}"
        Catch ex As Exception
            Throw New Exception($"Error Drawing Circle: {ex}")
        End Try
    End Sub
    Public Function CalculateCircleDimensions(ByVal r As Double) As Double()
        Try
            Dim returnValues As Double() = {0.0, 0.0}
            returnValues(0) = Math.PI * (r ^ 2)
            returnValues(1) = 2 * Math.PI * r
            Return returnValues
        Catch ex As Exception
            Throw (ex)
        End Try
    End Function
    Public Function CalculateEllipseDimensions(ByVal r1 As Double, ByVal r2 As Double) As Double()
        Try
            Dim returnValues As Double() = {0.0, 0.0}
            returnValues(0) = Math.PI * r1 * r2
            'Apparently this is the best approximation of an ellipse perimeter that doesn't require summation or integration.  I must have missed that part of geometry class...
            Dim h As Double = ((r1 - r2) ^ 2) / ((r1 + r2) ^ 2)
            returnValues(1) = Math.PI * (r1 + r2) * (1 + ((3 * h) / (10 + Math.Sqrt(4 - 3 * h))))
            Return returnValues
        Catch ex As Exception
            Throw (ex)
        End Try
    End Function
    Public Function CalculatePolygonDimensions(ByVal points As List(Of Point)) As Double()
        Try
            Dim returnValues As Double() = {0.0, 0.0}
            Dim areaSum, perimeterSum As Double
            For i As Integer = 0 To points.Count - 1
                If i < (points.Count - 1) Then
                    areaSum += points(i).X * points(i + 1).Y - points(i + 1).X * points(i).Y
                    perimeterSum += Math.Sqrt((points(i + 1).X - points(i).X) ^ 2 + (points(i + 1).Y - points(i).Y) ^ 2)
                Else
                    areaSum += points(i).X * points(0).Y - points(0).X * points(i).Y
                    perimeterSum += Math.Sqrt((points(0).X - points(i).X) ^ 2 + (points(0).Y - points(i).Y) ^ 2)
                End If
            Next
            returnValues(0) = Math.Abs(areaSum) / 2
            returnValues(1) = perimeterSum
            Return returnValues
        Catch ex As Exception
            Throw (ex)
        End Try
    End Function
    Public Function CalculateSquareDimensions(ByVal l As Double) As Double()
        Try
            Dim returnValues As Double() = {0.0, 0.0}
            returnValues(0) = 4 * l
            returnValues(1) = l ^ 2
            Return returnValues
        Catch ex As Exception
            Throw (ex)
        End Try
    End Function
    Public Function CalculateEquilateralTriangleDimensions(ByVal l As Double) As Double()
        Try
            Dim returnValues As Double() = {0.0, 0.0}
            returnValues(0) = 3 * l
            returnValues(1) = (l ^ 2) * Math.Sqrt(3) / 4
            Return returnValues
        Catch ex As Exception
            Throw (ex)
        End Try
    End Function
#End Region
End Class
