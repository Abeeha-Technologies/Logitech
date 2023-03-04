Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel

Public Class TextBoxHint
	Inherits System.Windows.Forms.TextBox

#Region " Variables "
	Private _AlphaLevel As Integer = 255
	Private _HasFaded As Boolean = False
	Private _HintDetails As New TextBoxHintDetails
	Private _CharFilter As CharFilterting
	Private _CharFilterSpecial As String = ""

	Private FadeTimer As System.Windows.Forms.Timer

	Public Enum CharFilterting As Integer
		All = 0
		AlphaOnly = 2
		NumericOnly = 3
	End Enum

#End Region

#Region " Constructor "
	Public Sub New()
		' This call is required by the Windows Form Designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		FadeTimer = New System.Windows.Forms.Timer
		FadeTimer.Interval = 50
		FadeTimer.Enabled = False
		AddHandler FadeTimer.Tick, AddressOf FadeTimer_Tick

		' Tells the control the Hint Details have changed.  No clue why .Net doesnt detect the changes automatically
		AddHandler _HintDetails.HintChanged, AddressOf HintChanged
	End Sub

	Private Sub HintChanged()
		Me.Invalidate()
	End Sub

#End Region

#Region " Properties "
	''' <summary>
	''' Hint Details: Color, Alignment, Text and Fade Speed
	''' </summary>
	<DesignerSerializationVisibility(DesignerSerializationVisibility.Content), _
	TypeConverter(GetType(HintDetailConverter))> _
	Public Property HintDetails() As TextBoxHintDetails
		Get
			Return _HintDetails
		End Get
		Set(ByVal value As TextBoxHintDetails)
			_HintDetails = value
			Me.Refresh()
			Me.Invalidate()
		End Set
	End Property

	<System.ComponentModel.DefaultValue(GetType(CharFilterting), "All"), _
	 System.ComponentModel.Category("Char Filter"), _
	 System.ComponentModel.Description("Select allowable characters")> _
	Public Property CharFilter() As CharFilterting
		Get
			Return _CharFilter
		End Get
		Set(ByVal value As CharFilterting)
			_CharFilter = value
		End Set
	End Property

	<System.ComponentModel.DefaultValue(GetType(String), ""), _
	 System.ComponentModel.Category("Char Filter"), _
	 System.ComponentModel.Description("Any special characters ALSO allowed")> _
	Public Property CharFilterSpecial() As String
		Get
			Return _CharFilterSpecial
		End Get
		Set(ByVal value As String)
			_CharFilterSpecial = value
		End Set
	End Property

#End Region

#Region " Methods "
	Private Sub Repaint()
		Dim graphic As Graphics = MyBase.CreateGraphics()
		OnPaint(New System.Windows.Forms.PaintEventArgs(graphic, MyBase.ClientRectangle))
		graphic.Dispose()
	End Sub

	Private Function MakeAlpha(ByVal AlphaLevel As Integer, ByVal SolidColor As Color) As Color
		Dim R As Integer = SolidColor.R
		Dim G As Integer = SolidColor.G
		Dim B As Integer = SolidColor.B
		Return Color.FromArgb(AlphaLevel, R, G, B)
	End Function

	Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        If _HintDetails.HintText.Length > 0 Then
            Dim FadeBrush As New SolidBrush(MakeAlpha(_AlphaLevel, _HintDetails.HintColor))

            Dim myFormat As New StringFormat
            Select Case _HintDetails.HintTextAlign
                Case HorizontalAlignment.Left
                    myFormat.Alignment = StringAlignment.Near

                Case HorizontalAlignment.Center
                    myFormat.Alignment = StringAlignment.Center

                Case Else
                    myFormat.Alignment = StringAlignment.Far
            End Select

            Dim myBounds As Rectangle
            myBounds.X = 0
            myBounds.Y = 0
            myBounds.Height = Me.Height
            myBounds.Width = Me.Width

            ' If we have a border for the Textbox, adjust our bounds
            Select Case Me.BorderStyle
                Case System.Windows.Forms.BorderStyle.Fixed3D
                    myBounds.Width -= 2

                Case System.Windows.Forms.BorderStyle.FixedSingle
                    myBounds.Width -= 1

                Case Else
            End Select

            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighSpeed
            e.Graphics.DrawString(_HintDetails.HintText, MyBase.Font, FadeBrush, myBounds, myFormat)

            FadeBrush.Dispose()
            FadeBrush = Nothing
        End If

		MyBase.OnPaint(e)
	End Sub

	Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
		If m.Msg = &HF Then
			' raise the paint event
			MyBase.WndProc(m)
			Repaint()
		Else
			MyBase.WndProc(m)
		End If
	End Sub
#End Region

#Region " Control Methods "

	Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
		If _CharFilter <> CharFilterting.All Then
			Dim KeyChar As String = e.KeyChar
			Dim FoundChar As Boolean = False

			' Did the user hit the back-space key?
			If Asc(KeyChar) <> 8 Then
				' Alpha-only?
				If _CharFilter = CharFilterting.AlphaOnly Then
					If Not System.Text.RegularExpressions.Regex.IsMatch(KeyChar, "^[A-Z][a-z]") Then
						e.Handled = True
					Else
						FoundChar = True
					End If
				End If

				' Numeric-only?
				If _CharFilter = CharFilterting.NumericOnly Then
					If Not System.Text.RegularExpressions.Regex.IsMatch(KeyChar, "^[0-9]") Then
						e.Handled = True
					Else
						FoundChar = True
					End If
				End If

				' Look in the specials (if we havent already found it)
				If Not FoundChar Then
					If _CharFilterSpecial.Length > 0 Then
						If InStr(_CharFilterSpecial, KeyChar) = 0 Then
							e.Handled = True
						Else
							e.Handled = False
						End If
					End If
				End If

			End If
		End If

		MyBase.OnKeyPress(e)

	End Sub


	Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)
		If Me.Text.Length > 0 Then
			If Not IsNothing(FadeTimer) Then
				If FadeTimer.Enabled = False Then
					FadeTimer.Enabled = True
				End If
			End If
		Else
			If Not IsNothing(FadeTimer) Then
				FadeTimer.Enabled = False
				_HasFaded = False
				_AlphaLevel = 255
			End If
		End If

		Me.Invalidate()
		MyBase.OnTextChanged(e)
	End Sub

	Private Sub FadeTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs)

		' If our Speed is zero - just turn off the Hint
		' Otherwise, reduce our Alpha by a factor of 5 * our Speed.
		If _HintDetails.HintFadeSpeed = 0 Then
			_AlphaLevel = 0
		Else
			_AlphaLevel -= (5 * _HintDetails.HintFadeSpeed)
		End If

		' If our Alpha is too low to display - turn off our fader and reset all values
		If _AlphaLevel <= 5 Then
			_HasFaded = True
			FadeTimer.Enabled = False
			_AlphaLevel = 0
		End If

		Me.Invalidate()
	End Sub
#End Region

	Private Sub TextBoxHint_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

	End Sub

	Private Sub TextBoxHint_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

	End Sub

	Private Sub TextBoxHint_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

	End Sub

End Class

