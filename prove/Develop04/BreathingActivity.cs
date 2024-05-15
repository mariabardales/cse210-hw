using System;
public class BreathingActivity:Activity
{
    public BreathingActivity()
    {
        _name="Breathing";
        _description="This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void Run()
    {
        Console.Write("Breathing 1");
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