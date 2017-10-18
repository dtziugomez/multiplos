Module Module1

    Sub Main()
        Dim j As Integer
        Dim val As Integer
        Dim i As Integer = 2
        Console.Write("numero:")
        val = Integer.Parse(Console.ReadLine())
        If val > 1 Then
            j = val \ i
            While j <> 1
                If val Mod i = 0 Then
                    Console.Write(i)
                    Console.Write(" ")
                    val = val \ i
                    j = val
                Else
                    i = i + 1
                    'j = val \ i
                End If
            End While
        Else
            Console.WriteLine("se esperaba un nùmero positivo mayor que 1")
        End If
        Console.ReadKey()
    End Sub

End Module
