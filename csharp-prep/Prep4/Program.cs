using System;

class Program
{
    static void Main(string[] args)
    {

        int userInput = 1;
        int total = 0;
        int largestN = 0;
        int lowest = int.MaxValue;
        List<int> numbers = new List<int>();
        while ( userInput != 0 ) {
            
            Console.WriteLine("Type 0 to QUIT.");
            Console.Write("Type a number: ");
            userInput = int.Parse(Console.ReadLine());

            if ( userInput != 0 ) 
            {
                numbers.Add(userInput);
            }
        }

        foreach (int number in numbers) 
        {
            total += number;
            if (number > largestN )
            {
                largestN = number;
            }
        }
        Console.WriteLine(largestN);
        
        foreach ( int number in numbers) 
        {
            if  (number < lowest & number > 0 )
            {
                lowest = number;
            }

        }

        numbers.Sort();
        int nNumber = numbers.Count;
        int averange = total / nNumber;

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The averange is: {averange}");
        Console.WriteLine($"The largest number is: {largestN}");
        Console.WriteLine($" The loswest positive number is:{lowest}");
        foreach (int number in numbers) 
        {
            Console.WriteLine(number);
        }

    }
}