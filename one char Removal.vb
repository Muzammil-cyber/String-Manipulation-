Module Module1

    Sub Main()
        Dim str1, name As String
        Dim mychar, remove As Char
        Dim L1, X As Integer
        str1 = ""
        name = ""
        mychar = ""
        L1 = 0
        X = 0
        Console.Write("Enter our stuff: ")
        str1 = Console.ReadLine
        Console.Write("What do you want to Remove: ")
        remove = Console.ReadLine()
        L1 = Len(str1)
        For X = 1 To L1
            mychar = Mid(str1, X, 1)
            If mychar <> remove Then
                name = name & mychar
            End If
        Next
        Console.WriteLine("Name: " & name)
        Console.ReadKey()
    End Sub

End Module
