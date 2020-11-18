Module Module1
    Sub Main()
        'Declaration and Initialization
        Dim s As String = ""
        Dim fchar As Char = ""
        Dim cha As Char = ""
        Dim os As String = ""
        'Input
        Console.Write("Your Phrase: ")
        s = Console.ReadLine
        s = LCase(s)
        'Taking First character
        fchar = Left(s, 1)
        os = fchar
        'Somethig happens here which makes it all work
        For x = 2 To Len(s)
            cha = Mid(s, x, 1)
            If cha = fchar Then
                os = os & "*"
            Else
                os = os & cha
            End If
        Next
        'and ends here, after which it Outputs
        Console.Write("Your Result: " & os)
        Console.ReadKey()
    End Sub
End Module
