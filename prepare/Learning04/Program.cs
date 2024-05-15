using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assi1= new Assignment("Maria Bardales","Topic name 1");
        Console.WriteLine(assi1.GetSummary());

        MathAssignment assi2 = new MathAssignment("Rolando García", "Topic 2","7.1","23-29");
        Console.WriteLine(assi2.GetSummary());
        Console.WriteLine(assi2.GetHomeworkList());

        WritingAssignment assi3 = new WritingAssignment("Rolando García", "Topic 2","The title");
        Console.WriteLine(assi3.GetSummary());
        Console.WriteLine(assi3.GetWritingInformation());
    }
}