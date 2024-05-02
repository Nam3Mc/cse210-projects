using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade? ");
        int grade = int.Parse(Console.ReadLine());

        string letter = "Congratulation You have passed the curse! ";
        string reprovedletter = "Unfortunatelly you have not passe dthe curse, But surely you will do it next time, don't GIVE UP YOU CAN DO IT!";

        if ( grade >= 90  ) 
        {
            if ( grade % 10 >= 7 )
            {
                Console.WriteLine(letter);
                Console.WriteLine($"Your grade is {grade}+");
            }
            else if ( grade % 10 <= 3 )
            {
                Console.WriteLine(letter);
                Console.WriteLine($"Your grade is {grade}-");
            }
            else
            {
                Console.WriteLine(letter);
            }
        }
        else if ( grade >= 80 )
        {
             if ( grade % 10 >= 7 )
            {
                Console.WriteLine(letter);
                Console.WriteLine($"Your grade is {grade}+");
            }
            else if ( grade % 10 <= 3 )
            {
                Console.WriteLine(letter);
                Console.WriteLine($"Your grade is {grade}-");
            }
            else
            {
                Console.WriteLine(letter);
            }
        }
        else if ( grade >= 70 )
        {
             if ( grade % 10 >= 7 )
            {
                Console.WriteLine(letter);
                Console.WriteLine($"Your grade is {grade}+");
            }
            else if ( grade % 10 <= 3 )
            {
                Console.WriteLine(letter);
                Console.WriteLine($"Your grade is {grade}-");
            }
            else
            {
                Console.WriteLine(letter);
            }
        }
        else if ( grade >= 60 )
        {
             if ( grade % 10 >= 7 )
            {
                Console.WriteLine(reprovedletter);
                Console.WriteLine($"Your grade is {grade}+");
            }
            else if ( grade % 10 <= 3 )
            {
                Console.WriteLine(reprovedletter);
                Console.WriteLine($"Your grade is {grade}-");
            }
            else
            {
                Console.WriteLine(reprovedletter);
            }
        }
        else 
        {
             if ( grade % 10 >= 7 )
            {
                Console.WriteLine(reprovedletter);
                Console.WriteLine($"Your grade is {grade}+");
            }
            else if ( grade % 10 <= 3 )
            {
                Console.WriteLine(reprovedletter);
                Console.WriteLine($"Your grade is {grade}-");
            }
            else
            {
                Console.WriteLine(reprovedletter);
            }
        }
        
    }
}