using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write ("What is your percentage:");
        string percentage =Console.ReadLine();
        int number= int.Parse(percentage);
        string letter;
        if (number>=90)
        {
            letter="A";
        }

        else if (number>=80)
        {
            letter= "B";
        }
        else if (number>=70)
        {
           letter ="C";
        }
        else if (number>=60)
        {
            letter="D";
        }

        else 
        {
            letter="F";
        }
        Console.WriteLine($"Grade: {letter}");

        if (number>=70)
        {
            Console.WriteLine("CONGRATULATIONS, YOU PASSESD");
        }
        else 
        {
            Console.WriteLine("PUT IN MORE EFFORT NEXT TIME");
        }   
    }
}