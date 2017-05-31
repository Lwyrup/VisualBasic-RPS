Namespace rpsGame

	Public Class Game
		'players: an array of two player objects
		'Dim players() As String = {"player1", "player2"}
		'choices: array of valid choices
		Dim Choices() As String = {"rock", "paper", "scissors"}

		Function AskForChoice()
			Console.WriteLine("{0}, {1}, or {2}?", Choices(0), Choices(1), Choices(2))
			Return Console.ReadLine()
		End Function

		Sub DetermineRound(weapon1 As String, weapon2 As String)
			If String.Equals(weapon1, weapon2) Then
				Console.WriteLine("Tie")
			ElseIf WinCondition(weapon1, weapon2) Then
				Console.WriteLine("Player one wins")
			Else
				Console.WriteLine("Player two wins")
			End If
			Console.ReadKey()
		End Sub

		Private Function WinCondition(winner As String, loser As String)
			Return String.Equals(winner, "rock") And String.Equals(loser, "scissors") Or
				String.Equals(winner, "paper") And String.Equals(loser, "rock") Or
				String.Equals(winner, "scissors") And String.Equals(loser, "paper")
		End Function

	End Class

End Namespace
