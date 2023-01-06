using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your score in percentage? ");
        string UserInput = Console.ReadLine();
        int score = int.Parse(UserInput);

        string letter = "";

        if (score >= 90)
        {
            letter = "A";
        }
        else if ( score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter ="D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade letter is {letter}");

        if (score >= 70)
        {
            Console.WriteLine("Congratulation, You have passed the class!!!!");
        }
        else
        {
            Console.WriteLine("Sorry you need to work harder to be able to pass this class.");
        }



    }
}