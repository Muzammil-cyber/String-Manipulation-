Module Module1

    Sub Main()
        'Declaration and Initialization
        Dim str1 As String = ""
        Dim a, e, i, o, u As Integer
        Dim Cha As Char = ""
        a = 0
        e = 0
        i = 0
        o = 0
        u = 0
        'Input
        Console.Write("Enter Your Phrase: ")
        str1 = Console.ReadLine
        str1 = UCase(str1)
        'Counting Vowels
        For x = 1 To Len(str1)
            Cha = Mid(str1, x)
            Select Case Cha
                Case "A"
                    a = a + 1
                Case "E"
                    e = e + 1
                Case "I"
                    i = i + 1
                Case "O"
                    o = o + 1
                Case "U"
                    u = u + 1
            End Select
        Next
        'Outputing Vowels
        Console.WriteLine("Vowel A appears " & a & " times")
        Console.WriteLine("Vowel E appears " & e & " times")
        Console.WriteLine("Vowel I appears " & i & " times")
        Console.WriteLine("Vowel O appears " & o & " times")
        Console.WriteLine("Vowel U appears " & u & " times")
        Console.ReadKey()
    End Sub

End Module
