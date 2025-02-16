'Rudy Earnest
'RCET 2265
'Spring 2025
'ConvertAndValidate
'https://github.com/rc-earnest/convertAndValidate.git
Option Compare Text
Option Explicit On
Option Strict On


Module convertAndValidate

    Sub Main()
        Dim aValidNumber As Integer
        Dim userResponse As String
        Do

            Console.WriteLine($"Enter a number:")

            userResponse = Console.ReadLine()

            If ConversionValid(userResponse, aValidNumber) = True Then

                Console.WriteLine($"{userResponse} converted successfully to {aValidNumber}!")

            Else

                Console.WriteLine($"Oops, {userResponse} does not seem to be a number")

            End If

        Loop

    End Sub

    'make this work


    Function ConversionValid(ByVal convertThisString As String, ByRef toThisInteger As Integer) As Boolean

        Dim status As Boolean


        Try
            toThisInteger = CInt(convertThisString)
            status = True
        Catch ex As Exception
            status = False
        End Try
        Return status


    End Function

End Module
