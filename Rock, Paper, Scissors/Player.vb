﻿Namespace rpsGame

	Public Class Player
		Private _name As String
		Public Property Name() As String
			Get
				Return _name
			End Get
			Set(ByVal value As String)
				_name = value
			End Set
		End Property

		Private _choice As String
		Public Property Choice() As String
			Get
				Return _choice
			End Get
			Set(ByVal value As String)
				_choice = value
			End Set
		End Property
	End Class
End Namespace