Module Module1

    Sub Main()
        'Declaration and Initialization
        Dim str1(15) As String
        Dim mt2 As Integer = 0
        Dim sfl As Integer = 0
        Dim son As Boolean = False
        str1(1) = "I"
        str1(2) = "AM"
        str1(3) = "TO"
        str1(4) = "LEARN"
        str1(5) = "BONG"
        str1(6) = "GILL"
        str1(7) = "BORING"
        str1(8) = "GRILL"
        str1(9) = "HELL"
        str1(10) = "THIS"
        str1(11) = "IS"
        str1(12) = "MY"
        str1(13) = "TOWN"
        str1(14) = "GIRL"
        str1(15) = "BOY"
        'Complicated stuff happens
        For x = 1 To 15
            son = False
            If Len(str1(x)) >= 2 Then
                mt2 = mt2 + 1
            End If
            For y = 1 To 15
                If Left(str1(x), 1) = Left(str1(y), 1) And Right(str1(x), 1) = Right(str1(y), 1) And x <> y Then
                    son = True
                End If
            Next
            If son = True Then
                sfl = sfl + 1
            End If
        Next
        'Output
        Console.WriteLine("Have more Than Two Character: " & mt2)
        Console.Write("First and Last Character are the Same: " & sfl)
        Console.ReadKey()
    End Sub

End Module
