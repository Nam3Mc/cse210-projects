using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 0;
        int y = 0;

        //if stament 
        if (x > y)
        {
            Console.WriteLine("greater than");
        }


        // if inside if 
        if (x > y)
        {
            if (x > z)
            {
                Console.WriteLine("greater than both");
            }
        }



        // if and else
        if (x > y)
        {   
            Console.WriteLine("greater than");
        }
        else
        {
            Console.WriteLine("less than");
        }


        // else if 
        if (x > y)
        {
            Console.WriteLine("greater than y");
        }
        else if (x > z)
        {
            Console.WriteLine("greater than z");
        }
        else
        {
            Console.WriteLine("less than both");
        }

        //converting type  string to int 
        string valueInText = "42";
        int number = int.Parse(valueInText);

        Console.Write("What is your favorite number? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        Console.Write("");  


        //int to string 
        int number = 42;
        string textVersion = number.ToString();
/////////////////////////////////////////////////////////////////////////

        // do whille 
        string response;

        do
        {
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        } while (response == "yes");

        // foreach loop
        foreach (string color in colors)
        {
            Console.WriteLine(color);
        }

        // randon generator 
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

/////////////////////////////////////////////////////////////////////////
///
    // lists 
    List<int> numbers;
    List<string> words;


    List<int> numbers;
    numbers = new List<int>();

    List<int> numbers = new List<int>();
    List<string> words = new List<string>();

    // adding items 

    List<string> words = new List<string>();

    words.Add("phone");
    words.Add("keyboard");
    words.Add("mouse");

    // having the length 
    Console.WriteLine(words.Count);

    //iteratig 

    foreach (string word in words)
    {
        Console.WriteLine(word);
    }

    // accesing by index 
    for (int i = 0; i < words.Count; i++)
    {
        Console.WriteLine(words[i]);
    }


    //////////////////////////////////////////////////
    /// functions 
    /// 

    returnType FunctionName(dataType parameter1, dataType parameter2)
    {
        // function_body
    }

    // function without parameter 
    void DisplayMessage()
    {
        Console.WriteLine("Hello world!");
    }

    // single parameter 
    void DisplayPersonalMessage(string userName)
    {
        Console.WriteLine($"Hello {userName}");
    }


    // 2 int parameters 
    int AddNumbers(int first, int second)
    {
        int sum = first + second;
        return sum;
    }

    ///
    static void DisplayMessage()
    {
        Console.WriteLine("Hello world!");
    }

    static void DisplayPersonalMessage(string userName)
    {
        Console.WriteLine($"Hello {userName}");
    }

    static int AddNumbers(int first, int second)
    {
        int sum = first + second;
        return sum;
    }


    

    }
}