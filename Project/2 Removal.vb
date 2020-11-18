Module Module1

    Sub Main()
        'Declaration and Initialization
        Dim Str1 As String = ""
        Dim ostr As String = ""
        Dim rov As Char = ""
        Dim schar As Char = ""
        Dim x As Integer = 0
        'Input Phrase and the Character you wnt to Remove
        Console.Write("Type in your Phrase: ")
        Str1 = Console.ReadLine()
        Console.Write("What do you want to Remove: ")
        rov = Console.ReadLine
        'Removing the Character no matter if it is in Uppercase or Lowercase
        For x = 1 To Len(Str1)
            schar = Mid(Str1, x)
            If schar <> LCase(rov) Or schar <> UCase(rov) Then
                ostr = ostr & schar
            End If
        Next
        'OutPut
        Console.Write("YOUR RESULT: " & ostr)
        Console.ReadKey()
    End Sub

End Module
