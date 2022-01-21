Imports System.ComponentModel

Public Class Form1

    Private WithEvents link As ToggleLinkage

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        link = New ToggleLinkage
        Me.PropertyGrid1.SelectedObject = link
    End Sub

    Private Sub link_PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Handles link.PropertyChanged
        Me.TextBox1.AppendText(e.PropertyName & Environment.NewLine)
        Me.PropertyGrid1.Refresh()
        Me.ListView1.Items.Clear()
        Me.ListView1.Items.AddRange(link.ResultItems.ToArray)
    End Sub
End Class
