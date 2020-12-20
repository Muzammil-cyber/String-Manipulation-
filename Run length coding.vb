Module Module1

    Sub Main()
        Dim str1 As String = ""
        Dim cha As Char = ""
        Dim y As Integer = 1
        Dim count As Integer = 0
        Console.Write("Enter your Text: ")
        str1 = Console.ReadLine
        Do
            cha = Mid(str1, y, 1)
            count = 0
            Do
                If cha = Mid(str1, y, 1) Then
                    count = count + 1
                    y = y + 1
                End If
            Loop Until (cha <> Mid(str1, y, 1))
            Console.Write(cha & " " & count & " ")
        Loop Until (y >= Len(str1))
        Console.ReadKey()
    End Sub

End Module
