using System;
public class ReflectingActivity:Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity()
    {
        _name="Reflecting";
        _description="This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    public void Run()
    {
        Console.Write("Reflecting 1");
    }
    public string GetRandomPrompt()
    {
        return "";
    }
    public string GetRandomQuestion()
    {
        return "";
    }
    public void DisplayPrompt()
    {

    }
    public void DisplayQuestions()
    {
        
    }
    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }
}