using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Proverbs", 3, 5,6);
        Scripture scripture1 = new Scripture(reference1, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        Console.WriteLine(scripture1.GetDisplayText());

        //Reference reference2 = new Reference("Mosiah", 7, 33);
        //Scripture scripture2 = new Scripture(reference2, "But if ye will aturn to the Lord with full purpose of heart, and put your trust in him, and serve him with all bdiligence of mind, if ye do this, he will, according to his own will and pleasure, deliver you out of bondage.");
        //Console.WriteLine(scripture2.GetDisplayText());
    }
}