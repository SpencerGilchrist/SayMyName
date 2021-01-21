
'Spencer Gilchrist
'RCET0265
'Spring 2021
'Say My Name
'

Option Explicit On
Option Strict On
Module SayMyName

    Sub Main()

        Console.WriteLine("Say Your Name!")

        Dim UserInput As String

        UserInput = Console.ReadLine()
        Console.WriteLine($"Hello, {UserInput} How was your day today?")
        System.Threading.Thread.Sleep(1500)
        Console.WriteLine("Was it Good or Bad?")

        UserInput = Console.ReadLine()

        Console.WriteLine($"That's {UserInput}.")


        Console.ReadLine()
    End Sub

End Module
