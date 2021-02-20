Public Class CircleForm
    Public Property returnCircle As Circle
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        returnCircle = New Circle
        ValueSetup()
    End Sub

    Public Sub New(ByVal originalCircle As Circle)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        returnCircle = originalCircle
        ValueSetup()
    End Sub

    Private Sub ValueSetup()
        TextBoxCenterX.Text = returnCircle.center.X
        TextBoxCenterY.Text = returnCircle.center.Y
        TextBoxRadius.Text = returnCircle.radius
        ComboBoxColor.SelectedItem = returnCircle.color
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
            returnCircle.center = New PointF(parseDbl, parsedbl2)
        Else
            MessageBox.Show("Please enter a valid center X and Y value.")
            Exit Sub
        End If
        If Double.TryParse(TextBoxRadius.Text, parseDbl) Then
            returnCircle.radius = parseDbl
        Else
            MessageBox.Show("Please enter a valid radius value.")
            Exit Sub
        End If
        If ComboBoxColor.SelectedItem IsNot Nothing Then
            returnCircle.color = ComboBoxColor.SelectedItem
        Else
            MessageBox.Show("Please select a color.")
            Exit Sub
        End If
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class