Module Module1

    Sub Main()
        Dim l, x, y, sum As Integer 'Declaration
        'Initialization
        l = 0
        sum = 0
        x = 0
        y = 1
        'The real Stuff
        Console.Write("Enter Fibonacci Range: ")
        l = Console.ReadLine
        Console.Write(Str(x) & "," & Str(y))
        While sum <= l
            sum = x + y
            Console.Write("," & Str(sum))
            x = y
            y = sum
        End While
        'Could have made an accurate one but Sir didnt allowed us to use Repeat Until
        Console.ReadKey()
    End Sub

End Module
