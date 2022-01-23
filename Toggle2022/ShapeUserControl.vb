Public Class ShapeUserControl

    Public A As PointF
    Public B1 As PointF = New Point(-3450, 450)
    Public B2 As PointF = New Point(-450, -3450)
    Public D As PointF = New Point(-2650, 900)
    Public BC As Integer = 2700
    Public CD As Integer = 2390

    Public C1 As PointF
    Public C2 As PointF

    Public B1D As Double
    Public B2D As Double

    Private ScaleFactor As Single = 0.1

    Public Function DistanceBetween(p1 As Drawing.PointF, p2 As Drawing.PointF) As Double
        Return Math.Sqrt((p2.X - p1.X) ^ 2 + (p2.Y - p1.Y) ^ 2)
    End Function

    Public Function AngleOppositeToSideC(a As Double, b As Double, c As Double) As Double
        Return Degrees(Math.Acos((a ^ 2 + b ^ 2 - c ^ 2) / (2 * Math.Abs(a) * Math.Abs(b))))
    End Function

    Public Function Degrees(radians As Double) As Double
        Return (radians / Math.PI) * 180
    End Function

    Public Function Radians(degrees As Double) As Double
        Return (degrees / 180) * Math.PI
    End Function

    Private ReadOnly Property Origin As Point
        Get
            Return New Point(3 * ShapeContainer1.Width / 4, 2 * ShapeContainer1.Height / 4)
        End Get
    End Property

    Private Sub CanvasUserControl_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Update()

    End Sub

    Public Sub Update()
        Me.ToolStripStatusLabel1.Text = Me.ShapeContainer1.Width
        Me.ToolStripStatusLabel2.Text = Me.ShapeContainer1.Height

        B1D = DistanceBetween(B1, D)
        B2D = DistanceBetween(B2, D)

        Dim a1 As Double = AngleOppositeToSideC(B1.X - D.X, DistanceBetween(B1, D), B1.Y - D.Y)
        Dim a2 As Double = AngleOppositeToSideC(BC, DistanceBetween(B1, D), CD)
        Dim a3 As Double = a1 + a2

        C1.X = B1.X + Math.Cos(Radians(a3)) * BC
        C1.Y = B1.Y + Math.Sin(Radians(a3)) * BC

        a1 = AngleOppositeToSideC(B2.Y - D.Y, DistanceBetween(B2, D), B2.X - D.X)
        a2 = AngleOppositeToSideC(BC, DistanceBetween(B2, D), CD)
        a3 = a1 + a2

        C2.X = B2.X - Math.Sin(Radians(a3)) * BC
        C2.Y = B2.Y + Math.Cos(Radians(a3)) * BC

        With XAxisLineShape
            .X1 = 0
            .Y1 = Origin.Y
            .X2 = Me.ShapeContainer1.Width
            .Y2 = Origin.Y
        End With

        With YAxisLineShape
            .X1 = Origin.X
            .Y1 = 0
            .X2 = Origin.X
            .Y2 = Me.ShapeContainer1.Height
        End With

        With AB1LineShape
            .X1 = Origin.X
            .Y1 = Origin.Y
            .X2 = Origin.X + B1.X * ScaleFactor
            .Y2 = Origin.Y - B1.Y * ScaleFactor
        End With

        With AB2LineShape
            .X1 = Origin.X
            .Y1 = Origin.Y
            .X2 = Origin.X + B2.X * ScaleFactor
            .Y2 = Origin.Y - B2.Y * ScaleFactor
        End With

        With ADLineShape
            .X1 = Origin.X
            .Y1 = Origin.Y
            .X2 = Origin.X + D.X * ScaleFactor
            .Y2 = Origin.Y - D.Y * ScaleFactor
        End With

        With B1DLineShape
            .X1 = AB1LineShape.X2
            .Y1 = AB1LineShape.Y2
            .X2 = ADLineShape.X2
            .Y2 = ADLineShape.Y2
        End With

        With B2DLineShape
            .X1 = AB2LineShape.X2
            .Y1 = AB2LineShape.Y2
            .X2 = ADLineShape.X2
            .Y2 = ADLineShape.Y2
        End With

        With B1C1LineShape
            .X1 = AB1LineShape.X2
            .Y1 = AB1LineShape.Y2
            .X2 = Origin.X + C1.X * ScaleFactor
            .Y2 = Origin.Y - C1.Y * ScaleFactor
        End With

        With C1DLineShape
            .X1 = B1C1LineShape.X2
            .Y1 = B1C1LineShape.Y2
            .X2 = ADLineShape.X2
            .Y2 = ADLineShape.Y2
        End With


        With B2C2LineShape
            .X1 = AB2LineShape.X2
            .Y1 = AB2LineShape.Y2
            .X2 = Origin.X + C2.X * ScaleFactor
            .Y2 = Origin.Y - C2.Y * ScaleFactor
        End With

        With C2DLineShape
            .X1 = B2C2LineShape.X2
            .Y1 = B2C2LineShape.Y2
            .X2 = ADLineShape.X2
            .Y2 = ADLineShape.Y2
        End With

        With ALabel
            .Left = Origin.X + 5 * 2
            .Top = Origin.Y - 5 * 2 * 2
        End With

        With B1Label
            .Left = AB1LineShape.X2 + 5 * 2
            .Top = AB1LineShape.Y2 - 5 * 2 * 2
        End With

        With B2Label
            .Left = AB2LineShape.X2 + 5 * 2
            .Top = AB2LineShape.Y2 - 5 * 2 * 2
        End With

        With C1Label
            .Left = B1C1LineShape.X2 + 5 * 2
            .Top = B1C1LineShape.Y2 - 5 * 2 * 2
        End With

        With C2Label
            .Left = B2C2LineShape.X2 + 5 * 2
            .Top = B2C2LineShape.Y2 - 5 * 2 * 2
        End With

        With DLabel
            .Left = ADLineShape.X2 + 5 * 2
            .Top = ADLineShape.Y2 - 5 * 2 * 2
        End With

        With OvalShape1
            .Width = DistanceBetween(A, B1) * ScaleFactor * 2
            .Height = .Width
            .Left = ADLineShape.X1 - .Width / 2
            .Top = ADLineShape.Y1 - .Height / 2
        End With

        With OvalShape2
            .Width = CD * ScaleFactor * 2
            .Height = .Width
            .Left = ADLineShape.X2 - .Width / 2
            .Top = ADLineShape.Y2 - .Height / 2
        End With

        With OvalShape3
            .Width = DistanceBetween(B1, C1) * ScaleFactor * 2
            .Height = .Width
            .Left = AB1LineShape.X2 - .Width / 2
            .Top = AB1LineShape.Y2 - .Height / 2
        End With

        With OvalShape4
            .Width = DistanceBetween(B2, C2) * ScaleFactor * 2
            .Height = .Width
            .Left = AB2LineShape.X2 - .Width / 2
            .Top = AB2LineShape.Y2 - .Height / 2
        End With

        Me.ToolStripStatusLabel3.Text = "A " & A.ToString
        Me.ToolStripStatusLabel4.Text = "B1 " & B1.ToString
        Me.ToolStripStatusLabel5.Text = "B2 " & B2.ToString
        Me.ToolStripStatusLabel6.Text = "C1 " & C1.ToString
        Me.ToolStripStatusLabel7.Text = "C2 " & C2.ToString
        Me.ToolStripStatusLabel8.Text = "D " & D.ToString

        Me.ToolStripStatusLabel9.Text = "B1C1 (" & DistanceBetween(B1, C1).ToString("F3") & ")"
        Me.ToolStripStatusLabel10.Text = "C1D (" & DistanceBetween(C1, D).ToString("F3") & ")"

        Me.ToolStripStatusLabel11.Text = "B2C2 (" & DistanceBetween(B2, C2).ToString("F3") & ")"
        Me.ToolStripStatusLabel12.Text = "C2D (" & DistanceBetween(C2, D).ToString("F3") & ")"
    End Sub

End Class
