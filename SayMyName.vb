﻿Option Strict On
Option Explicit On
Option Compare Text



'Lane Coleman
'RCET0265
'Fall 2020
'Say My Name
'https://github.com/colelane/SayMyName.git



Module SayMyName
    'Ian and I wrote this code together so we could learn together.
    'This is a reference to a video we like.  Dont hug me im scared 4. Which is linked in the program.

    Sub Main()
        Dim userInput As String
        Console.WriteLine("What is your name?")
        userInput = Console.ReadLine()
        Console.WriteLine("Great, Great news! " & userInput & "!" & " Welcome to this program!")
        Console.WriteLine("Before we start our adventure, I just need to get some information from you!")
        Console.WriteLine("Where do you live?")
        Console.ReadLine()
        Console.WriteLine("What do you like to eat?")
        Console.ReadLine()
        Console.WriteLine("Great news! Now just a few more questions and we'll be on our way")
        Console.WriteLine("Whats your favorite color?")
        Console.ReadLine()
        Console.WriteLine("Do you like cows? Or goats?...milk")
        Console.ReadLine()
        Console.WriteLine("Do you have brown hair? What's your bloodtype?")
        Console.ReadLine()
        Console.WriteLine("Are you allergic to oats?")
        userInput = Console.ReadLine()
        If userInput = "Shut up" Then My.Computer.Audio.Play(My.Resources.dont_touch_me, AudioPlayMode.WaitToComplete)
        Console.WriteLine("https://www.youtube.com/watch?v=G9FGgwCQ22w")
        Console.WriteLine("Would you like to watch the video? Yes or No?")
        userInput = Console.ReadLine()
        If userInput = "Yes" Then Process.Start("https://www.youtube.com/watch?v=G9FGgwCQ22w")










    End Sub

End Module
