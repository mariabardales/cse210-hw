using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int elem;
        List<int> lnum;
        lnum = new List<int>();
        int sum=0;
        double ave;
        int max = int.MinValue;
        int minpos=int.MaxValue;

        do{
            Console.Write("Enter number: ");
            string ele=Console.ReadLine();
            elem=int.Parse(ele);
            if(elem!=0)
            {
                lnum.Add(elem);
                if(elem>max)
                {
                    max = elem;
                }
                if(elem<minpos && elem>0)
                {
                    minpos=elem;
                }
            }
        }while (elem!=0);

        for (int i = 0; i < lnum.Count; i++)
        {
            sum=sum+lnum[i];
        }

        ave=(double)sum/lnum.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {ave}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {minpos}");
    }
}