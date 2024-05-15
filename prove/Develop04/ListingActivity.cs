using System;
public class ListingActivity:Activity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity()
    {
        _name="Listing";
        _description="This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    public void Run()
    {
        Console.Write("Listing 1");
    }
    public void GetRandomPrompt()
    {

    }
    public string GetListFromUser(List<string> list)
    {
        return "";
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