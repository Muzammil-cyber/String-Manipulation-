Module Module1

    Sub Main()
        'Declaration and Initialization
        Dim str1 As String = ""
        Dim os As String = ""
        Dim ing As Integer = 0
        'Try inputing Bruceing
        Console.Write("Enter your Phrase: ")
        str1 = Console.ReadLine
        ing = InStr(str1, "ing")
        'The Good stuff Starts from here
        If ing <> 0 And Len(str1) >= 3 Then
            str1 = Left(str1, ing - 1) & "ly"
        ElseIf Len(str1) >= 3 Then
            str1 = str1 & "ing"
        End If
        'Output
        Console.Write("Your Result: " & str1)
        Console.ReadKey()
    End Sub
End Module
