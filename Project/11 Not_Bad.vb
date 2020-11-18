Module Module1

    Sub Main()
        'Declaration and Initialization
        Dim str1 As String = ""
        Dim no As Integer = 0
        Dim bad As Integer = 0
        Console.Write("Enter Your Phrase: ")
        str1 = Console.ReadLine
        str1 = UCase(Left(str1, 1)) & LCase(Right(str1, Len(str1) - 1)) 'NVM I fixed it IG
        'IF bad or not is written in caps then it wont work properly, so just dont do it
        no = InStr(str1, "not")
        bad = InStr(no, str1, "bad")
        If no <> 0 And bad <> 0 Then
            str1 = Left(str1, no - 1) & "good" & Right(str1, Len(str1) - bad - 2)
        End If
        Console.Write("Your Result: " & str1)
        Console.ReadKey()
    End Sub

End Module
