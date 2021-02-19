Imports System.Windows.Forms

Public Class PointCollectionEditorDialog

    Public Property pointList As List(Of Point)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pointList = New List(Of Point)
    End Sub

    Public Sub New(ByVal points As List(Of Point))

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pointList = points
    End Sub

    Private Sub createPoints()
        For Each value In pointList
            ListBox1.Items.Add(value.X)
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

End Class
