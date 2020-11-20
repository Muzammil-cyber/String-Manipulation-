Module Module1

    Sub Main()
        'Declaration and Initialization
        Dim Str1 As String = ""
        Dim ostr As String = ""
        Dim rov As Char = ""
        Dim cha As Char = ""
        Dim x As Integer = 0
        Dim rep As Char = ""
        'Input Phrase and the Character you wnt to Remove
        Console.Write("Type in your Phrase: ")
        Str1 = Console.ReadLine()
        Str1 = LCase(Str1)
        Console.Write("What do you want to Remove: ")
        rov = Console.ReadLine
        rov = LCase(rov)
        Console.Write("What do you want to replace it with:")
        rep = Console.ReadLine
        rep = LCase(rep)
        'Replacing the Character no matter if it is in Uppercase or Lowercase
        For x = 1 To Len(Str1)
            cha = Mid(Str1, x, 1)
            If cha = rov Then
                ostr = ostr & rep
            Else
                ostr = ostr & cha
            End If
        Next
        'OutPut
        Console.Write("YOUR RESULT: " & ostr)
        Console.ReadKey()

    End Sub

End Module
