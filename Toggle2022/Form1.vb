Imports System.ComponentModel

Public Class Form1

    Private WithEvents link As ToggleLinkage

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        link = New ToggleLinkage
        Me.PropertyGrid1.SelectedObject = link
        UpdateListView()

        Dim griditem As GridItem = Me.PropertyGrid1.SelectedGridItem
        Do
            If griditem.Parent IsNot Nothing Then
                griditem = griditem.Parent
            End If
        Loop Until griditem.Parent Is Nothing

        griditem.GridItems(2).Expanded = False
        griditem.GridItems(9).Expanded = False
        griditem.GridItems(10).Expanded = False
        griditem.GridItems(11).Expanded = False

        SplitContainer1.SplitterDistance = 0.75 * Me.ClientSize.Width
    End Sub

    Private Sub link_PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Handles link.PropertyChanged
        Me.TextBox1.AppendText(e.PropertyName & Environment.NewLine)
        Me.PropertyGrid1.Refresh()
        UpdateListView()
        UpdateDrawing
    End Sub

    Private Sub UpdateListView()
        Me.ListView1.Items.Clear()
        Me.ListView1.Items.AddRange(link.ResultItems.ToArray)
    End Sub

    Private Sub UpdateDrawing()
        Me.ShapeUserControl1.B1 = link.B1
        Me.ShapeUserControl1.B2 = link.B2
        Me.ShapeUserControl1.D = link.D
        Me.ShapeUserControl1.BC = link.BC
        Me.ShapeUserControl1.CD = link.CD
        Me.ShapeUserControl1.Update()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        link.Up()
        Me.ShapeUserControl1.Update()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        link.Down()
        Me.ShapeUserControl1.Update()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        link.Left()
        Me.ShapeUserControl1.Update()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        link.Right()
        Me.ShapeUserControl1.Update()
    End Sub
End Class
