Public Class EllipseForm
    Public Property returnEllipse As Ellipse
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        returnEllipse = New Ellipse
        ValueSetup()
    End Sub

    Public Sub New(ByVal originalEllipse As Ellipse)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        returnEllipse = originalEllipse
        ValueSetup()
    End Sub

    Private Sub ValueSetup()
        TextBoxCenterX.Text = returnEllipse.center.X
        TextBoxCenterY.Text = returnEllipse.center.Y
        TextBoxMajorRadius.Text = returnEllipse.majorRadius
        TextBoxMinorRadius.Text = returnEllipse.minorRadius
        TextBoxOrientation.Text = returnEllipse.orientation
        ComboBoxColor.SelectedItem = returnEllipse.color
    End Sub

    Private Function TestDbl(ByVal input As Double) As Boolean
        Dim temp As Double
        Return Double.TryParse(input, temp)
    End Function

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Dim parseDbl, parsedbl2 As Double
        If Double.TryParse(TextBoxCenterX.Text, parseDbl) AndAlso Double.TryParse(TextBoxCenterY.Text, parsedbl2) Then
            returnEllipse.center = New Point(parseDbl, parsedbl2)
        Else
            MessageBox.Show("Please enter a valid center X and Y value.")
            Exit Sub
        End If
        If Double.TryParse(TextBoxMajorRadius.Text, parseDbl) Then
            returnEllipse.majorRadius = parseDbl
        Else
            MessageBox.Show("Please enter a valid major radius value.")
            Exit Sub
        End If
        If Double.TryParse(TextBoxMinorRadius.Text, parseDbl) Then
            returnEllipse.minorRadius = parseDbl
        Else
            MessageBox.Show("Please enter a valid minor radius value.")
            Exit Sub
        End If
        If Double.TryParse(TextBoxOrientation.Text, parseDbl) Then
            returnEllipse.orientation = parseDbl
        Else
            MessageBox.Show("Please enter a valid orientation value.")
            Exit Sub
        End If
        If ComboBoxColor.SelectedItem IsNot Nothing Then
            returnEllipse.color = ComboBoxColor.SelectedItem
        Else
            MessageBox.Show("Please select a color.")
            Exit Sub
        End If
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class