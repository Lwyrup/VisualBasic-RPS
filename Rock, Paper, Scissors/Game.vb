Namespace rpsGame

	Public Class Game
		'players: an array of two player objects'
		'choices: const array of valid choices'

		Function AskForChoice()
			Console.WriteLine("Rock, Paper, or Scissors?")
			Return Console.ReadLine()
		End Function

		Sub DetermineRound(weapon1 As String, weapon2 As String)
			If String.Compare(weapon1, "rock") And String.Compare(weapon2, "scissors") Or
				String.Compare(weapon1, "paper") And String.Compare(weapon2, "rock") Or
				String.Compare(weapon1, "scissors") And String.Compare(weapon2, "paper") Then
				Console.WriteLine("Player one wins")
			ElseIf String.Compare(weapon1, weapon2) Then
				Console.WriteLine("Tie")
			Else
				Console.WriteLine("Player two wins")
			End If
		End Sub

	End Class

End Namespace
