Module Common
    Public Function DistanceBetween(p1 As Drawing.PointF, p2 As Drawing.PointF) As Double
        Return Math.Sqrt((p2.X - p1.X) ^ 2 + (p2.Y - p1.Y) ^ 2)
    End Function

    Public Function AngleOppositeToSideC(a As Double, b As Double, c As Double) As Double
        Return Common.Degrees(Math.Acos((a ^ 2 + b ^ 2 - c ^ 2) / (2 * Math.Abs(a) * Math.Abs(b))))
    End Function

    Public Function Atan2(p As Point) As Double
        Dim result As Double
        If p.X > 0 Then
            result = Math.Atan(p.Y / p.X)
        ElseIf (p.X < 0) And (p.Y >= 0) Then
            result = Math.Atan(p.Y / p.X) + Math.PI
        ElseIf (p.X < 0) And (p.Y < 0) Then
            result = Math.Atan(p.Y / p.X) + Math.PI
        ElseIf (p.X = 0) And (p.Y > 0) Then
            result = Math.PI / 2
        ElseIf (p.X = 0) And (p.Y < 0) Then
            result = -Math.PI / 2
        Else
            result = Double.NaN
        End If
        Return Degrees(result)
    End Function

    Public Function Radians(degrees As Double) As Double
        Return (degrees / 180) * Math.PI
    End Function

    Public Function Degrees(radians As Double) As Double
        Return (radians / Math.PI) * 180
    End Function
End Module
