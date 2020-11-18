Module Module1

    Sub Main()
        'Declaration and Initialization
        Dim s As String = ""
        Dim pstr1 As String = ""
        Dim pstr2 As String = ""
        Dim sp As Integer = 0
        Console.Write("Enter your Phrase: ")
        s = Console.ReadLine
        sp = InStr(s, " ")
        'if String length is more Than 2
        If Len(s) > 2 Then
            pstr1 = Left(s, 2)
            'if it has a space
            If sp <> 0 Then
                pstr2 = Mid(s, sp - 2, 2)
                s = pstr1 & pstr2
                'if it doesnt has a space
            Else
                pstr2 = Right(s, 2)
            End If
            s = pstr1 & pstr2
        End If
        Console.Write("Your Result: " & s)
        Console.ReadKey()
    End Sub

End Module
