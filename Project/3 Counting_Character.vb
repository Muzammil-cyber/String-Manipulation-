Module Module1
    Sub Main()
        'Declaration and Initialization
        Dim Str1 As String = ""
        Dim Cha As Char = ""
        Dim count As Integer = 0
        Dim schar As Char = ""
        'Input
        Console.Write("Enter Pharase: ")
        Str1 = Console.ReadLine
        Console.Write("Enter character you want to Count: ")
        Cha = Console.ReadLine
        'Counting the Character no matter if it is in Uppercase or Lowercase 
        For x = 1 To Len(Str1)
            schar = Mid(Str1, x)
            If schar = LCase(Cha) Or schar = UCase(Cha) Then
                count = count + 1
            End If
        Next
        Console.Write(Cha & " comes " & count & " times")
        Console.ReadKey()
    End Sub
End Module
