Namespace rpsGame

	Public Class Player
		Sub New()
			Console.WriteLine("Enter your name.")
			Name = Console.ReadLine
			Console.Clear()
		End Sub

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

		Private _score As Integer = 0
		Public Property Score() As Integer
			Get
				Return _score
			End Get
			Set(ByVal value As Integer)
				_score = value
			End Set
		End Property

		Function Stats()
			Return Name + ": " + CStr(Score)
		End Function
	End Class
End Namespace
