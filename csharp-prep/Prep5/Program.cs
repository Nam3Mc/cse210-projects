using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();
        string userName = PromptUserName();
        int squareNumber = PromptUserNumber();

        Console.WriteLine ($"Brother { userName}, the square of your number is { squareNumber }");

        static void DisplayWelcome  () 
        {
            Console.WriteLine ("Welcome to the program!");
        }

        static string PromptUserName  () 
        {
            Console.Write ("Please enter yoour name: ");
            string userInput = Console.ReadLine();
            return userInput;
        }

        static int PromptUserNumber  () 
        {
            Console.Write("Please eter your favorite number: ");
            int userInput = int.Parse(Console.ReadLine());

            return userInput * userInput;
        }

    }
}