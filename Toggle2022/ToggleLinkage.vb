Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class ToggleLinkage

#Region "INotifyPropertyChanged implementation"

    Implements INotifyPropertyChanged

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private Sub NotifyPropertyChanged(<CallerMemberName()> Optional ByVal propertyName As String = Nothing)
        UpdateDesign()
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

#End Region

    Private Class Categories
        Public Const PivotShaft As String = "01 -- Pivot shaft"
        Public Const BladePin As String = "02 -- Blade pin"
        Public Const LeverPin As String = "03 -- Lever pin"
        Public Const DriveShaft As String = "04 -- Drive shaft"
        Public Const Settings As String = "05 -- Settings"
        Public Const Loads As String = "06 -- Loads"
        Public Const Size As String = "07 -- Size"
        Public Const ConnectingRod As String = "08 -- Connecting rod"
        Public Const DriveLever As String = "09 -- Drive lever"
        Public Const Angles As String = "10 -- Angles"
        Public Const Distances As String = "11 -- Distances"
        Public Const Result As String = "12 -- Result Loads"
    End Class

    Public Sub New()
        UpdateDesign()
    End Sub

    Private Sub UpdateDesign()
        Dim c As Point = New Point(B1.X, B1.Y + DistanceBetween(D, B2) / 2)

        m_BC = DistanceBetween(B1, c)
        m_CD = DistanceBetween(c, D)

        Dim ang As Double
        Do
            c.Y += 1
            m_BC = DistanceBetween(B1, c)
            m_CD = DistanceBetween(c, D)
            ang = Common.AngleOppositeToSideC(Common.DistanceBetween(B2, D), m_CD, m_BC)
        Loop Until ang > BetaMin

        If RoundOff Then
            m_BC = Math.Ceiling(BC / 5) * 5
            m_CD = Math.Ceiling(CD / 5) * 5
        Else
            m_BC = BC
            m_CD = CD
        End If

        m_ResultItems = New List(Of ListViewItem)

        For i As Integer = 0 To PivotShaftRotation Step 5

            Dim alfa As Double = Atan2B1 + i

            Dim pivot As Double = Math.Cos(Radians(i)) * BladeForce * Math.Abs(B1.X) / 1000

            Dim seal As Double
            If (i = 0) Then
                seal = SealForce * Math.Abs(B1.X) / 1000
            ElseIf (i = PivotShaftRotation) Then
                seal = -SealForce * Math.Abs(B1.X) / 1000
            Else
                seal = 0
            End If

            Dim B As PointF = New PointF(
                AB1 * Math.Cos(Radians(alfa)),
                AB1 * Math.Sin(Radians(alfa)))

            Dim a1 As Double = Common.AngleOppositeToSideC(Common.DistanceBetween(B, D), BC, CD)

            Dim a2 As Double = Common.AngleOppositeToSideC(Common.DistanceBetween(B, D), AB1, AD)

            Dim a3 As Double = a1 + a2

            Dim l1 As Double = Math.Sin(Radians(a3)) * AB1

            Dim rod As Double = (pivot + seal) / (l1 / 1000)

            Dim l2 As Double = Math.Sin(Radians(a1)) * Common.DistanceBetween(B, D)

            Dim drive As Double = rod * l2 / 1000
            'If (i = PivotShaftRotation) Then
            '    drive = -drive
            'End If

            Dim sFormat As String = "F1"

            m_ResultItems.Add(New ListViewItem({i,
                                               alfa.ToString(sFormat),
                                               pivot.ToString(sFormat),
                                               seal.ToString(sFormat),
                                               l1.ToString(sFormat),
                                               rod.ToString(sFormat),
                                               l2.ToString(sFormat),
                                               drive.ToString(sFormat)}))
        Next


    End Sub

#Region "Categories.PivotShaft"

    <Category(Categories.PivotShaft), Description("Pivot shaft coordinates.")>
    Public ReadOnly Property A As Point = New Point(0, 0)

    <Category(Categories.PivotShaft), Description("Pivot shaft rotation.")>
    Public ReadOnly Property PivotShaftRotation As Integer = 90

#End Region

#Region "Categories.BladePin"

    Private m_B1 As Drawing.Point = New Point(-3450, 450)
    <Category(Categories.BladePin), Description("Blade pin coordinates in bypass closed position.")>
    Public Property B1 As Point
        Get
            Return m_B1
        End Get
        Set(value As Point)
            m_B1 = New Point(-Math.Abs(value.X), +Math.Abs(value.Y))
            NotifyPropertyChanged("B1")
        End Set
    End Property

    <Category(Categories.BladePin), Description("Blade pin coordinates in boiler closed position.")>
    Public ReadOnly Property B2 As Point
        Get
            Return New Point(
                AB1 * Math.Cos(Common.Radians(Atan2B1 + PivotShaftRotation)),
                AB1 * Math.Sin(Common.Radians(Atan2B1 + PivotShaftRotation)))
        End Get
    End Property

#End Region

#Region "LeverPin"
    <Category(Categories.LeverPin), Description("Drive lever pin coordinates in bypass closed position.")>
    Public ReadOnly Property C1 As PointF
        Get
            Dim a1 As Double = AngleOppositeToSideC(B1.X - D.X, DistanceBetween(B1, D), B1.Y - D.Y)
            Dim a2 As Double = AngleOppositeToSideC(BC, DistanceBetween(B1, D), CD)
            Dim a3 As Double = a1 + a2

            Return New PointF(
                B1.X + Math.Cos(Radians(a3)) * BC,
                B1.Y + Math.Sin(Radians(a3)) * BC)

        End Get
    End Property

    <Category(Categories.LeverPin), Description("Drive lever pin coordinates in boiler closed position.")>
    Public ReadOnly Property C2 As PointF
        Get
            Dim a1 As Double = AngleOppositeToSideC(B2.Y - D.Y, DistanceBetween(B2, D), B2.X - D.X)
            Dim a2 As Double = AngleOppositeToSideC(BC, DistanceBetween(B2, D), CD)
            Dim a3 As Double = a1 + a2

            Return New PointF(
                B2.X - Math.Sin(Radians(a3)) * BC,
                B2.Y + Math.Cos(Radians(a3)) * BC)

        End Get
    End Property
#End Region

#Region "Categories.DriveShaft"

    Private m_D As Drawing.Point = New Point(-2650, 900)

    <Category(Categories.DriveShaft), Description("Drive shaft coordinates.")>
    Public Property D As Point
        Get
            Return m_D
        End Get
        Set(value As Point)
            If (Math.Abs(value.X) < Math.Abs(B1.X)) And (Math.Abs(value.Y) > Math.Abs(B1.Y)) Then
                m_D = New Point(-Math.Abs(value.X), +Math.Abs(value.Y))
                NotifyPropertyChanged("D")
            End If
        End Set
    End Property

    <Category(Categories.DriveShaft), Description("Drive shaft rotation.")>
    Public ReadOnly Property DriveShaftRotation As Double
        Get
            Return Common.AngleOppositeToSideC(B1D, CD, BC) +
                Common.AngleOppositeToSideC(B1D, AD, AB1) -
                (Common.AngleOppositeToSideC(B2D, CD, BC) +
                Common.AngleOppositeToSideC(B2D, AD, AB2))
        End Get
    End Property

#End Region

#Region "Categories.Settings"

    Private m_BetaMin As Double = 17.5
    <Category(Categories.Settings),
        Description("Minimum value for angle beta. Beta is the angle, at point 'D', in triangle 'B2C2D', boiler closed position.")>
    Public Property BetaMin As Double
        Get
            Return m_BetaMin
        End Get
        Set(value As Double)
            m_BetaMin = Math.Max(17.5, value)
            NotifyPropertyChanged("BetaMin")
        End Set
    End Property

    Private m_RoundOff As Boolean = True
    <Category(Categories.Settings), Description("If true, BC (connecting rod length) and CD (drive lever length) return rounded values.")>
    Public Property RoundOff As Boolean
        Get
            Return m_RoundOff
        End Get
        Set(value As Boolean)
            m_RoundOff = value
            NotifyPropertyChanged("RoundOff")
        End Set
    End Property

#End Region

#Region "Categories.Loads"
    Private m_UniformBladeForce As Integer = 3250
    <Category(Categories.Loads)>
    Public Property UniformBladeForce As Integer
        Get
            Return m_UniformBladeForce
        End Get
        Set(value As Integer)
            m_UniformBladeForce = Math.Abs(value)
            NotifyPropertyChanged("UniformBladeForce")
        End Set
    End Property

    Private m_UniformSealForce As Integer = 500
    <Category(Categories.Loads)>
    Public Property UniformSealForce As Integer
        Get
            Return m_UniformSealForce
        End Get
        Set(value As Integer)
            m_UniformSealForce = Math.Abs(value)
            NotifyPropertyChanged("UniformSealForce")
        End Set
    End Property

    Private m_DoubleSeal As Boolean = True
    <Category(Categories.Loads)>
    Public Property DoubleSeal As Boolean
        Get
            Return m_DoubleSeal
        End Get
        Set(value As Boolean)
            m_DoubleSeal = value
            NotifyPropertyChanged("DoubleSeal")
        End Set
    End Property

#End Region

#Region "Categories.Size"
    Private m_Height As Integer = 0
    <Category(Categories.Size)>
    Public Property Height As Integer
        Get
            Return m_Height
        End Get
        Set(value As Integer)
            m_Height = Math.Abs(value)
            NotifyPropertyChanged("Height")
        End Set
    End Property

    Private m_Width As Integer = 0
    <Category(Categories.Size)>
    Public Property Width As Integer
        Get
            Return m_Width
        End Get
        Set(value As Integer)
            m_Width = Math.Abs(value)
            NotifyPropertyChanged("Width")
        End Set
    End Property

#End Region

#Region "Categories.ConnectingRod"

    Private m_BC As Single = 0
    <Category(Categories.ConnectingRod)>
    Public ReadOnly Property BC As Single
        Get
            Return m_BC
        End Get
    End Property

#End Region

#Region "Categories.DriveLever"

    Private m_CD As Single = 0

    <Category(Categories.DriveLever)>
    Public ReadOnly Property CD As Single
        Get
            Return m_CD
        End Get
    End Property

#End Region

#Region "Categories.Angles"

    <Category(Categories.Angles), DisplayName("Atan2(B1)")>
    Public ReadOnly Property Atan2B1 As Double
        Get
            Return Common.Atan2(B1)
        End Get
    End Property

    <Category(Categories.Angles), DisplayName("Atan2(B2)")>
    Public ReadOnly Property Atan2B2 As Double
        Get
            Return Common.Atan2(B2)
        End Get
    End Property

    <Category(Categories.Angles)>
    Public ReadOnly Property Beta As Double
        Get
            Return Common.AngleOppositeToSideC(Common.DistanceBetween(B2, D), CD, BC)
        End Get
    End Property

#End Region

#Region "Categories.Distances"

    <Category(Categories.Distances)>
    Public ReadOnly Property AB1 As Double
        Get
            Return Common.DistanceBetween(A, B1)
        End Get
    End Property

    <Category(Categories.Distances)>
    Public ReadOnly Property AB2 As Double
        Get
            Return Common.DistanceBetween(A, B2)
        End Get
    End Property

    <Category(Categories.Distances)>
    Public ReadOnly Property B1D As Double
        Get
            Return Common.DistanceBetween(B1, D)
        End Get
    End Property

    <Category(Categories.Distances)>
    Public ReadOnly Property B2D As Double
        Get
            Return Common.DistanceBetween(B2, D)
        End Get
    End Property

    <Category(Categories.Distances)>
    Public ReadOnly Property AD As Double
        Get
            Return Common.DistanceBetween(A, D)
        End Get
    End Property

#End Region

#Region "Categories.Result"

    <Category(Categories.Result), DisplayName("Size: Area")>
    Public ReadOnly Property BladeArea As Double
        Get
            Return (Height / 1000) * (Width / 1000)
        End Get
    End Property

    <Category(Categories.Result), DisplayName("Size: Perimeter")>
    Public ReadOnly Property SealPerimeter As Double
        Get
            Return 2 * ((Height / 1000) + (Width / 1000))
        End Get
    End Property

    <Category(Categories.Result), DisplayName("Force: Blade")>
    Public ReadOnly Property BladeForce() As Double
        Get
            Return UniformBladeForce * BladeArea() / 1000
        End Get
    End Property

    <Category(Categories.Result), DisplayName("Force: Seal")>
    Public ReadOnly Property SealForce() As Double
        Get
            If DoubleSeal Then
                Return 2 * UniformSealForce * SealPerimeter() / 1000
            Else
                Return UniformSealForce * SealPerimeter() / 1000
            End If
        End Get
    End Property

    <Category(Categories.Result), DisplayName("Moment: Pivot Blade")>
    Public ReadOnly Property PivotBladeMoment() As Double
        Get
            Return BladeForce * Math.Abs(B1.X) / 1000
        End Get
    End Property

    <Category(Categories.Result), DisplayName("Moment: Pivot Seal")>
    Public ReadOnly Property PivotSealMoment() As Double
        Get
            Return SealForce * Math.Abs(B1.X) / 1000
        End Get
    End Property
#End Region


    Private m_ResultItems As List(Of ListViewItem)
    '<Browsable(False)>
    Public ReadOnly Property ResultItems As List(Of ListViewItem)
        Get
            Return m_ResultItems
        End Get
    End Property

    Public Sub Up()
        D = New Point(D.X, D.Y + 100)
    End Sub

    Public Sub Down()
        D = New Point(D.X, D.Y - 100)
    End Sub

    Public Sub Left()
        D = New Point(D.X - 100, D.Y)
    End Sub

    Public Sub Right()
        D = New Point(D.X + 100, D.Y)
    End Sub
End Class
