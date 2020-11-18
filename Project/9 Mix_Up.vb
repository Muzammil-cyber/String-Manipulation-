Module Module1

    Sub Main()
        'Declaration and Initialization
        Dim a As String = ""
        Dim b As String = ""
        Dim ao As String = ""
        Dim bo As String = ""
        'Input
        Console.WriteLine("Enter Two Strings")
        Console.Write("Enter String 1: ")
        a = Console.ReadLine
        Console.Write("Enter String 2: ")
        b = Console.ReadLine
        'Mixing Up
        ao = Left(b, 2) & Right(a, Len(a) - 2)
        bo = Left(a, 2) & Right(b, Len(b) - 2)
        Console.Write("Your Result: " & ao & " " & bo)
        Console.ReadKey()
    End Sub

End Module
