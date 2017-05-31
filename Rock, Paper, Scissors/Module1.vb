Namespace rpsGame

	Module Module1

		Sub Main()
			Dim game = New Game
			Dim choice1 As String = game.AskForChoice()
			Dim choice2 As String = game.AskForChoice()
			game.DetermineRound(choice1, choice2)
		End Sub

	End Module

End Namespace

