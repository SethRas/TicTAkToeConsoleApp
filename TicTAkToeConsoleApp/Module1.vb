﻿Option Explicit On
Option Strict On


Module Module1
    ' if a1=a2=a3 then win etc. (Define winners)

    'store game/trun data. "X", "O", or " "
    Private gameBoardData(2, 2) As String

    Sub Main()

        For i = 0 To 8

        Next

        Console.ReadLine()

    End Sub


    Function winner() As String
        Dim _winner As String
        'TODO
        Return _winner

    End Function

    Private Function CheckRows() As String
        'TODO
        Return ""
    End Function

    Private Function CheckColumns() As String
        'TODO
        Return ""
    End Function
    Private Function CheckDiagonals() As String
        'TODO
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
            Case "x"
                _currentPlayer = "O"
            Case Else
                _currentPlayer = "X"
        End Select

        Return _currentPlayer
    End Function

End Module