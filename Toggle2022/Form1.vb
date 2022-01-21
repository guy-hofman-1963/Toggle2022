Imports System.ComponentModel

Public Class Form1

    Private WithEvents link As ToggleLinkage

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        link = New ToggleLinkage
        Me.PropertyGrid1.SelectedObject = link
        UpdateListView()
    End Sub

    Private Sub link_PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Handles link.PropertyChanged
        Me.TextBox1.AppendText(e.PropertyName & Environment.NewLine)
        Me.PropertyGrid1.Refresh()
        UpdateListView()
    End Sub

    Private Sub UpdateListView()
        Me.ListView1.Items.Clear()
        Me.ListView1.Items.AddRange(link.ResultItems.ToArray)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        link.Up()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        link.Down()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        link.Left()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        link.Right()
    End Sub
End Class
