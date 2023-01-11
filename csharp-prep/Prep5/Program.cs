using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquaredNumber(userNumber);
        DisplayResult(userName, squaredNumber);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the programe");
        }

        static string PromptUserName()
        {
            Console.Write("What is your First name? ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favourite numter? ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;

        }

        static int SquaredNumber(int userNumber)
        {
            int square = userNumber * userNumber;
            return square;
        }

        static void DisplayResult(string userName, int square)
        {
            Console.WriteLine($"{userName}, the square of your number is {square}");
        }
    }

    
}