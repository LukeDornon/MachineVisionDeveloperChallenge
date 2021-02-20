Imports System.ComponentModel.Design

Public Class PolygonForm
    Public Property returnPolygon As Polygon
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        returnPolygon = New Polygon
        ValueSetup()
    End Sub

    Public Sub New(ByVal originalPolygon As Polygon)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        returnPolygon = originalPolygon
        ValueSetup()
    End Sub

    Private Sub ValueSetup()

        ComboBoxColor.SelectedItem = returnPolygon.color
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

        If ComboBoxColor.SelectedItem IsNot Nothing Then
            returnPolygon.color = ComboBoxColor.SelectedItem
        Else
            MessageBox.Show("Please select a color.")
            Exit Sub
        End If
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub ButtonModifyPoints_Click(sender As Object, e As EventArgs) Handles ButtonModifyPoints.Click
        Using editor As New PointCollectionEditorDialog(returnPolygon.vertices)
            If editor.ShowDialog = DialogResult.OK Then
                returnPolygon.vertices = editor.pointList
                'MessageBox.Show($"Valid Polygon? {returnPolygon.ValidPolygon}")
            End If
        End Using
    End Sub
End Class