Module Module1
    Sub Main()
        'Declaration and Initialization
        Dim Str1 As String = ""
        Dim Mchar As Char = ""
        Dim tchar As Integer = 0
        Dim ptchar As Integer = 0
        Dim cha1 As Char = ""
        Dim ASCII As Integer = 64
        Dim x As Integer = 0
        'Input
        Console.Write("Enter Your Phrase: ")
        Str1 = Console.ReadLine
        Str1 = UCase(Str1)
        'The Magic Starts from here (Note:It will count Upper and Lower case as one)
        For ASCII = 64 To 90
            tchar = 0
            For x = 1 To Len(Str1)
                cha1 = Mid(Str1, x)
                If Asc(cha1) = ASCII Then
                    tchar = tchar + 1
                End If
                If ptchar < tchar Then
                    Mchar = cha1
                    ptchar = tchar
                End If
            Next
        Next
        'Magic Ends and Most used Character is Output in UpperCase
        Console.Write("Character used most Number of times: " & Mchar)
        Console.ReadKey()
    End Sub
End Module
