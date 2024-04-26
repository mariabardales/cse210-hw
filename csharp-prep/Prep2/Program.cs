using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade=Console.ReadLine();
        int gradeint=int.Parse(grade);
        string letter;
        int gradesig= gradeint%10;

        if (gradeint>=90)
        {
            if (gradesig>=7)
            {
                letter="A+"; 
            }
            else if (gradesig<3)
            {
                letter="A-"; 
            }
            else
            {
                letter="A"; 
            }             
        }
        else if (gradeint<90 && gradeint>=80)
        {
            if (gradesig>=7)
            {
                letter="B+"; 
            }
            else if (gradesig<3)
            {
                letter="B-"; 
            }
            else
            {
                letter="B"; 
            }   
        }
        else if (gradeint<80 && gradeint>=70)
        {
            if (gradesig>=7)
            {
                letter="C+"; 
            }
            else if (gradesig<3)
            {
                letter="C-"; 
            }
            else
            {
                letter="C"; 
            }     
        }
        else if (gradeint<70 && gradeint>=60)
        {
            if (gradesig>=7)
            {
                letter="D+"; 
            }
            else if (gradesig<3)
            {
                letter="D-"; 
            }
            else
            {
                letter="D"; 
            }     
        }
        else
        {
            if (gradesig>=7)
            {
                letter="F+"; 
            }
            else if (gradesig<3)
            {
                letter="F-"; 
            }
            else
            {
                letter="F"; 
            }  
        }

        Console.WriteLine($"Your grade letter is {letter}.");  

        if (gradeint>=70)
        {
            Console.WriteLine("Congratulations! you have passed the course");
        }   
        else
        {
            Console.WriteLine("Unfortunately you have not passed the course but you have gained new knowledge. Try again and you will do better!");
        }

    }
}