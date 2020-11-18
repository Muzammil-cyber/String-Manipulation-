Module Module1

    Sub Main()
        'Declaration and Initialization
        Dim count As Integer = 0
        'Input
        Console.Write("Number of Dounts: ")
        count = Console.ReadLine
        'Easy Stuff
        If count >= 1 And count <= 9 Then
            Console.Write("No. of Dounts: " & Str(count))
        Else
            Console.Write("No. of Dount: Many")
        End If
        'Important thing below
        Console.ReadKey()
    End Sub

End Module
