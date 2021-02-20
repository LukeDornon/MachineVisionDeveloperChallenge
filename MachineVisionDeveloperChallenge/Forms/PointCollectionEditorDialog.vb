Imports System.Windows.Forms

Public Class PointCollectionEditorDialog

    Public Property pointList As List(Of PointF)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pointList = New List(Of PointF)
    End Sub

    Public Sub New(ByVal points As List(Of PointF))

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pointList = points
        For i As Integer = 0 To pointList.Count - 1
            ListBox1.Items.Add($"Point {i}")
        Next
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex = -1 Then
            PropertyGrid1.SelectedObject = Nothing
        Else
            PropertyGrid1.SelectedObject = pointList(ListBox1.SelectedIndex)
        End If
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        pointList.Add(New PointF)
        ListBox1.Items.Add($"Point {pointList.Count - 1}")
    End Sub

    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click
        If ListBox1.SelectedIndex = -1 Then
            MessageBox.Show("Select a point to remove")
        Else
            pointList.RemoveAt(ListBox1.SelectedIndex)
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        End If
    End Sub
End Class
