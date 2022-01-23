<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.PropertiesTabPage = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TorqueTabPage = New System.Windows.Forms.TabPage()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DrawingTabPage = New System.Windows.Forms.TabPage()
        Me.ShapeUserControl1 = New Toggle2022.ShapeUserControl()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.PropertiesTabPage.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TorqueTabPage.SuspendLayout()
        Me.DrawingTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 465)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1155, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1155, 25)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "ToolStripButton4"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.PropertiesTabPage)
        Me.TabControl1.Controls.Add(Me.TorqueTabPage)
        Me.TabControl1.Controls.Add(Me.DrawingTabPage)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1155, 440)
        Me.TabControl1.TabIndex = 8
        '
        'PropertiesTabPage
        '
        Me.PropertiesTabPage.Controls.Add(Me.SplitContainer1)
        Me.PropertiesTabPage.Location = New System.Drawing.Point(4, 30)
        Me.PropertiesTabPage.Name = "PropertiesTabPage"
        Me.PropertiesTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.PropertiesTabPage.Size = New System.Drawing.Size(1147, 406)
        Me.PropertiesTabPage.TabIndex = 0
        Me.PropertiesTabPage.Text = "Properties"
        Me.PropertiesTabPage.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PropertyGrid1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1141, 400)
        Me.SplitContainer1.SplitterDistance = 428
        Me.SplitContainer1.TabIndex = 7
        '
        'PropertyGrid1
        '
        Me.PropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertyGrid1.Location = New System.Drawing.Point(0, 0)
        Me.PropertyGrid1.Name = "PropertyGrid1"
        Me.PropertyGrid1.Size = New System.Drawing.Size(428, 400)
        Me.PropertyGrid1.TabIndex = 0
        Me.PropertyGrid1.ToolbarVisible = False
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(709, 400)
        Me.TextBox1.TabIndex = 2
        '
        'TorqueTabPage
        '
        Me.TorqueTabPage.Controls.Add(Me.ListView1)
        Me.TorqueTabPage.Location = New System.Drawing.Point(4, 30)
        Me.TorqueTabPage.Name = "TorqueTabPage"
        Me.TorqueTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.TorqueTabPage.Size = New System.Drawing.Size(669, 258)
        Me.TorqueTabPage.TabIndex = 1
        Me.TorqueTabPage.Text = "Torque"
        Me.TorqueTabPage.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(3, 3)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(663, 252)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "STEP"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ALFA"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 90
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "BLADE"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 90
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "SEAL"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 90
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "ROD->A"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 90
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "ROD"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader10.Width = 90
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "ROD->D"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader11.Width = 90
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "DRIVE"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader12.Width = 90
        '
        'DrawingTabPage
        '
        Me.DrawingTabPage.Controls.Add(Me.ShapeUserControl1)
        Me.DrawingTabPage.Location = New System.Drawing.Point(4, 30)
        Me.DrawingTabPage.Name = "DrawingTabPage"
        Me.DrawingTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DrawingTabPage.Size = New System.Drawing.Size(669, 258)
        Me.DrawingTabPage.TabIndex = 2
        Me.DrawingTabPage.Text = "Drawing"
        Me.DrawingTabPage.UseVisualStyleBackColor = True
        '
        'ShapeUserControl1
        '
        Me.ShapeUserControl1.BackColor = System.Drawing.SystemColors.Window
        Me.ShapeUserControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShapeUserControl1.Location = New System.Drawing.Point(3, 3)
        Me.ShapeUserControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ShapeUserControl1.Name = "ShapeUserControl1"
        Me.ShapeUserControl1.Size = New System.Drawing.Size(663, 252)
        Me.ShapeUserControl1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 487)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.PropertiesTabPage.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TorqueTabPage.ResumeLayout(False)
        Me.DrawingTabPage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents PropertiesTabPage As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PropertyGrid1 As PropertyGrid
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TorqueTabPage As TabPage
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents DrawingTabPage As TabPage
    Friend WithEvents ShapeUserControl1 As ShapeUserControl
End Class
