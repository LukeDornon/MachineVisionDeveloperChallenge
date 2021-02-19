Public Class TriangleForm
    Public Property returnTriangle As Triangle
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        returnTriangle = New Triangle
        ValueSetup()
    End Sub

    Public Sub New(ByVal originalTriangle As Triangle)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        returnTriangle = originalTriangle
        ValueSetup()
    End Sub

    Private Sub ValueSetup()
        TextBoxCenterX.Text = returnTriangle.center.X
        TextBoxCenterY.Text = returnTriangle.center.Y
        TextBoxLength.Text = returnTriangle.length
        TextBoxOrientation.Text = returnTriangle.orientation
        ComboBoxColor.SelectedItem = returnTriangle.color
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
            returnTriangle.center = New Point(parseDbl, parsedbl2)
        Else
            MessageBox.Show("Please enter a valid center X and Y value.")
            Exit Sub
        End If
        If Double.TryParse(TextBoxLength.Text, parseDbl) Then
            returnTriangle.length = parseDbl
        Else
            MessageBox.Show("Please enter a valid radius value.")
            Exit Sub
        End If
        If Double.TryParse(TextBoxOrientation.Text, parseDbl) Then
            returnTriangle.orientation = parseDbl
        Else
            MessageBox.Show("Please enter a valid orientation value.")
            Exit Sub
        End If
        If ComboBoxColor.SelectedItem IsNot Nothing Then
            returnTriangle.color = ComboBoxColor.SelectedItem
        Else
            MessageBox.Show("Please select a color.")
            Exit Sub
        End If
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class