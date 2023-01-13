Imports System.ComponentModel

<TypeConverter(GetType(HintDetailConverter))> _
Public Class TextBoxHintDetails

#Region " Variables "
    Private _HintText As String = ""
	Private _HintColor As Color = Color.LightSlateGray
	Private _HintFadeSpeed As Integer = 5
    Private _HintTextAlign As System.Windows.Forms.HorizontalAlignment



    Public Event HintChanged()
#End Region

#Region " Properties "

    <System.ComponentModel.DefaultValue(GetType(String), ""), _
     System.ComponentModel.Category("Hint Text"), _
     RefreshProperties(RefreshProperties.All), _
     NotifyParentProperty(True), _
     System.ComponentModel.Description("The text displayed inside the TextBox as a hint for the User.")> _
    Public Property HintText() As String
        Get
            Return _HintText
        End Get
        Set(ByVal value As String)
            _HintText = value
            RaiseEvent HintChanged()
        End Set
    End Property

 

	<System.ComponentModel.DefaultValue(GetType(Color), "LightSlateGray"), _
	 System.ComponentModel.Category("Hint Text"), _
	 RefreshProperties(RefreshProperties.All), _
	 NotifyParentProperty(True), _
	 System.ComponentModel.Description("Color for the HintText.  This should be a slightly darker version of your backcolor to give a ghost appearance.")> _
	Public Property HintColor() As Color
		Get
			Return _HintColor
		End Get
		Set(ByVal value As Color)
			_HintColor = value
			RaiseEvent HintChanged()
		End Set
	End Property

    <System.ComponentModel.DefaultValue(GetType(Integer), "5"), _
     System.ComponentModel.Category("Hint Text"), _
     RefreshProperties(RefreshProperties.All), _
     NotifyParentProperty(True), _
     System.ComponentModel.Description("The speed at which the HintText will fade. 0:Immediate, 1-10: Higher number=Faster Fade")> _
    Public Property HintFadeSpeed() As Integer
        Get
            Return _HintFadeSpeed
        End Get
        Set(ByVal value As Integer)
            _HintFadeSpeed = value
            If value < 0 Then _HintFadeSpeed = 0
            If value > 10 Then _HintFadeSpeed = 10
            RaiseEvent HintChanged()
        End Set
    End Property

	<System.ComponentModel.DefaultValue(GetType(System.Windows.Forms.HorizontalAlignment), "Left"), _
	 System.ComponentModel.Category("Hint Text"), _
	 RefreshProperties(RefreshProperties.All), _
	 NotifyParentProperty(True), _
	 System.ComponentModel.Description("The Horizontal Alignment for the HintText")> _
	Public Property HintTextAlign() As System.Windows.Forms.HorizontalAlignment
		Get
			Return _HintTextAlign
		End Get
		Set(ByVal value As System.Windows.Forms.HorizontalAlignment)
			_HintTextAlign = value
			RaiseEvent HintChanged()
		End Set
	End Property

#End Region

End Class


#Region " TextBoxHint Property Converter "

''' <summary>
''' This is the converter for our BorderDetail type - its what makes this property collapsable
''' </summary>
''' <remarks></remarks>
Friend Class HintDetailConverter
	Inherits ExpandableObjectConverter

	Private _myTextBoxHint As TextBoxHintDetails

	Public Overloads Overrides Function CanConvertTo(ByVal context As ITypeDescriptorContext, ByVal destinationType As System.Type) As Boolean
		If (destinationType Is GetType(TextBoxHintDetails)) Then
			Return True
		End If
		Return MyBase.CanConvertTo(context, destinationType)
	End Function

	Public Overloads Overrides Function CanConvertFrom(ByVal context As ITypeDescriptorContext, ByVal sourceType As System.Type) As Boolean
		If (sourceType Is GetType(String)) Then
			Return True
		End If
		Return MyBase.CanConvertFrom(context, sourceType)
	End Function


	Public Overloads Overrides Function ConvertFrom(ByVal context As ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object) As Object
		If TypeOf value Is TextBoxHintDetails Then
			Try
				Dim myTextBoxHint As New TextBoxHintDetails
				myTextBoxHint.HintText = CType(_myTextBoxHint, TextBoxHintDetails).HintText
				myTextBoxHint.HintColor = CType(_myTextBoxHint, TextBoxHintDetails).HintColor
				myTextBoxHint.HintFadeSpeed = CType(_myTextBoxHint, TextBoxHintDetails).HintFadeSpeed
                myTextBoxHint.HintTextAlign = CType(_myTextBoxHint, TextBoxHintDetails).HintTextAlign
				Return myTextBoxHint

			Catch ex As Exception
				Throw New ArgumentException("CANNOT convert '" & value.ToString & "' to type TextBoxHint")

			End Try
		Else
			Return MyBase.ConvertFrom(context, culture, value)
		End If

		Return Nothing

	End Function

	Public Overloads Overrides Function ConvertTo(ByVal context As ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object, ByVal destinationType As System.Type) As Object
		If (destinationType Is GetType(System.String) AndAlso TypeOf value Is TextBoxHintDetails) Then
			_myTextBoxHint = CType(value, TextBoxHintDetails)

			Return _myTextBoxHint
		Else
			Return MyBase.ConvertTo(context, culture, value, destinationType)
		End If
	End Function

	Public Overrides Function IsValid(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal value As Object) As Boolean
		Return True
	End Function

End Class

#End Region

