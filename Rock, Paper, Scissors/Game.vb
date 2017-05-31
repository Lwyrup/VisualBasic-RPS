Namespace rpsGame

	Public Class Game
		'players: an array of two player objects'
		'choices: const array of valid choices'

		Function AskForChoice()
			Console.WriteLine("Rock, Paper, or Scissors?")
			Return Console.ReadLine()
		End Function

		Sub DetermineRound(weapon1 As String, weapon2 As String)
			If String.Equals(weapon1, weapon2) Then
				Console.WriteLine("Tie")
			ElseIf String.Equals(weapon1, "rock") And String.Equals(weapon2, "scissors") Or
				String.Equals(weapon1, "paper") And String.Equals(weapon2, "rock") Or
				String.Equals(weapon1, "scissors") And String.Equals(weapon2, "paper") Then
				Console.WriteLine("Player one wins")
			Else
				Console.WriteLine("Player two wins")
			End If
			Console.ReadKey()
		End Sub

	End Class

End Namespace
