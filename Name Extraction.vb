Module Module1

    Sub Main()
        Dim N, LN, FN, MN As String
        Dim FS, SS, L As Integer

        Console.Write("Write your 3 letter Name: ")
        N = Console.ReadLine
        L = Len(N)
        FS = InStr(N, " ")
        SS = InStr(FS + 1, N, " ")
        FN = Left(N, FS)
        MN = Mid(N, FS + 1, SS - FS)
        LN = Mid(N, SS + 1, L - SS)
        Console.WriteLine("First Name:" & FN)
        Console.WriteLine("Middle Name:" & MN)
        Console.WriteLine("Last Name:" & LN)
        Console.ReadKey()

    End Sub

End Module
