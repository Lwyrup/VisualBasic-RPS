Namespace rpsGame

	Public Class Game
		Sub New(Optional count As Integer = 2)
			Players = {New Player, New Player}
			Rounds = count
			Start()
		End Sub

		Dim Players() As Player
		Dim Choices() As String = {"rock", "paper", "scissors"}
		Dim Rounds As Integer

		Sub Start()
			For i As Integer = 0 To Rounds
				Players(0).Choice = AskForChoice()
				Players(1).Choice = AskForChoice()
				DetermineRound(Players(0).Choice, Players(1).Choice)
			Next
			Console.ReadKey()
		End Sub

		Function AskForChoice()
			Dim input As String = Ask()
			While Not Choices.Contains(input)
				input = Ask("Invalid option. Try again.")
			End While
			Console.Clear()
			Return input
		End Function

		Sub DetermineRound(weapon1 As String, weapon2 As String)
			If String.Equals(weapon1, weapon2) Then
				Console.WriteLine("Tie")
			ElseIf WinCondition(weapon1, weapon2) Then
				RoundWon(Players(0))
			Else
				RoundWon(Players(1))
			End If
			ShowScore()
		End Sub

		Sub RoundWon(winner As Player)
			IncreaseScore(winner)
			Console.WriteLine("{0} wins!", Players(1).Name)
		End Sub

		Sub IncreaseScore(player As Player)
			player.Score += 1
		End Sub

		Sub ShowScore()
			Console.WriteLine("{0}  |  {1}", Players(0).Stats, Players(1).Stats)
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
