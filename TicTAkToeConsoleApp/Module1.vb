Option Explicit On
Option Strict On



Module Module1
    ' if a1=a2=a3 then win etc. (Define winners)

    'store game/trun data. "X", "O", or " "
    Private gameBoardData(2, 2) As String
    Dim rows As Integer = 2
    Dim Columns As Integer = 2


    Sub Main()

        For i = 1 To 10
            Console.WriteLine($"It is {currentPlayer()}'s Turn")
        Next

        Console.ReadLine()

    End Sub


    Function winner() As String
        Dim _winner As String
        'TODO
        Return _winner

    End Function

    Private Function CheckRows() As String
        'TODO Need to check rows to verify if all three are the same character
        Return ""
    End Function

    Private Function CheckColumns() As String
        'TODO Need to check Columns to verify if all three are the same character
        Return ""
    End Function
    Private Function CheckDiagonals() As String
        'TODO Need to check the two Diagonals to verify if all three are the same character
        Return ""
    End Function
    Private Sub turn()
        'TODO

    End Sub

    Private Sub DisplayGameBoard()
        'TODO
    End Sub

    Private Sub NewGame()
        'TODO
    End Sub


    ''' <summary>
    ''' Determines the current player in the game
    ''' </summary>
    ''' <returns>Either "X" or "O" as string</returns>
    Private Function currentPlayer() As String
        Static _currentPlayer As String

        Select Case _currentPlayer
            Case "X"
                _currentPlayer = "O"
            Case Else
                _currentPlayer = "X"
        End Select

        Return _currentPlayer
    End Function

End Module