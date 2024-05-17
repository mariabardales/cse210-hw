using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind press enter to continue: ");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.\nYou may begin in: ");
        ShowCountDown(4);
        Console.Clear();

        do
        {
            DisplayQuestions();
        }
        while (DateTime.Now < stopTime);

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        _prompts = new List<string> 
        { 
            "Think of a time when you stood up for someone else.", 
            "Think of a time when you did something really difficult.", 
            "Think of a time when you helped someone in need.", 
            "Think of a time when you did something truly selfless." 
        };

        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        Random random2 = new Random();
        int index = random2.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine("--------" + randomPrompt + "--------");
    }

    public void DisplayQuestions()
    {
        string randomQuestion = GetRandomQuestion();
        Console.WriteLine(">" + randomQuestion + " ");
        Showspinner(4);
    }
}