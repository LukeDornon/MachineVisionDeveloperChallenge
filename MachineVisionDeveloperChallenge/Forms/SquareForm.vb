Public Class SquareForm
    Public Property returnSquare As Square
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        returnSquare = New Square
        ValueSetup()
    End Sub

    Public Sub New(ByVal originalSquare As Square)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        returnSquare = originalSquare
        ValueSetup()
    End Sub

    Private Sub ValueSetup()
        TextBoxCenterX.Text = returnSquare.center.X
        TextBoxCenterY.Text = returnSquare.center.Y
        TextBoxLength.Text = returnSquare.length
        TextBoxOrientation.Text = returnSquare.orientation
        ComboBoxColor.SelectedItem = returnSquare.color
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
            returnSquare.center = New PointF(parseDbl, parsedbl2)
        Else
            MessageBox.Show("Please enter a valid center X and Y value.")
            Exit Sub
        End If
        If Double.TryParse(TextBoxLength.Text, parseDbl) Then
            returnSquare.length = parseDbl
        Else
            MessageBox.Show("Please enter a valid radius value.")
            Exit Sub
        End If
        If Double.TryParse(TextBoxOrientation.Text, parseDbl) Then
            returnSquare.orientation = parseDbl
        Else
            MessageBox.Show("Please enter a valid orientation value.")
            Exit Sub
        End If
        If ComboBoxColor.SelectedItem IsNot Nothing Then
            returnSquare.color = ComboBoxColor.SelectedItem
        Else
            MessageBox.Show("Please select a color.")
            Exit Sub
        End If
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class