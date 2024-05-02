using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        int userGuest = 0;
        int count = 0;
        string userChoise = "";

        while (userChoise.ToUpper() != "NO") 
        {

            Console.WriteLine("Whould you like to play a game? ");
            Console.Write("'YES' or 'NO': ");
            userChoise = Console.ReadLine().ToUpper();

            if (userChoise == "NO") {
                Console.WriteLine("Godbye");
                break;
            }

            count = 0;
            userGuest = 0;
            
            while (userGuest != number) 
            {
                Console.Write("What is the magic number? ");
                userGuest = int.Parse(Console.ReadLine());

                if (userGuest > number) 
                {
                    Console.WriteLine($"The number is lower than {userGuest}");
                    count += 1;
                }
                else if (userGuest < number) 
                {
                    Console.WriteLine($"The number is higher than {userGuest}");
                    count += 1;
                }
                else 
                {
                    count += 1;
                    Console.WriteLine($"The number {userGuest} is the right one! YOU DID IT");
                    Console.WriteLine($"You guest ir in {count} atemts ");
                }
            }

            Console.WriteLine("Whould you like to play again? ");
            Console.Write("'YES' or 'NO': ");
            userChoise = Console.ReadLine().ToUpper();

            if (userChoise != "YES"){
                Console.WriteLine("Godbye");
            }

        }
        
    }
}