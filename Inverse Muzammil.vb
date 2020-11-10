Module Module1

    Sub Main()
        Dim X, Mychar As String
        Dim a As Integer
        X = ""
        Mychar = ""
        a = 0

        Console.Write("PLease type: ")
        X = Console.ReadLine
        For a = Len(X) To 1 Step (-1)
            Mychar = Mid(X, a, 1)
            Console.Write(Mychar)
        Next
        Console.ReadKey()
    End Sub

End Module
