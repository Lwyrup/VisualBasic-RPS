Namespace rpsGame

	Public Class Game
		Sub New(Optional count As Integer = 2)
			'create players
			Rounds = count
		End Sub

		'players: an array of two player objects
		Dim Choices() As String = {"rock", "paper", "scissors"}
		Dim Rounds As Integer

		Function AskForChoice()
			Dim input As String = Ask()
			While Not Choices.Contains(input)
				input = Ask("Invalid option. Try again.")
			End While
			Return input
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

		Private Function ValidateInput(input As String)
			If Choices.Contains(input) Then
				Return True
			Else
				Return False
			End If
		End Function

		Private Function Ask(Optional message As String = "Rock, Paper, or Scissors?")
			Console.WriteLine(message)
			Return Console.ReadLine()
		End Function

	End Class

End Namespace
