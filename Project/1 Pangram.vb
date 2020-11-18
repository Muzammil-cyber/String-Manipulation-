Module Module1

    Sub Main()
        'Declaration and Initialization
        Dim Str1 As String = ""
        Dim Cha1 As Char = ""
        Dim cha2 As Integer = 64
        Dim cha3 As Integer = 0
        Dim x As Integer = 1
        Dim total As Integer = 0
        'Input 
        Console.Write("Enter your Pharase to Check if its Pangram or Not: ")
        Str1 = Console.ReadLine
        Str1 = UCase(Str1)
        'Checks if its Pangram or not
        For x = 1 To Len(Str1)
            cha2 = cha2 + 1
            cha3 = InStr(Str1, Chr(cha2))
            If cha3 > 0 Then
                Cha1 = Mid(Str1, cha3)
                If Asc(Cha1) = cha2 Then
                    total = total + 1
                End If
            End If
        Next
        'Output If Pangram or Not
        If total >= 26 Then
            Console.Write("Its a Pangram")
        Else
            Console.Write("Not A Pangram")
        End If
        Console.ReadKey()
    End Sub

End Module
