using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        public class Person 
        {

        // The C# convention is to start member variables with an underscore _
            public string _givenName = "";
            public string _familyName = "";

            public Person ()
            {
            }

        // A method that displays the person's full name as used in eastern 
        // countries or <family name, given name>.

            public void ShowEasternName () 
            {
            Console.WriteLine ($"{_familyName}, {_givenName}" );
            }

        // A method that displays the person's full name as used in western 
        // countries or <given name family name>.
            public void ShowWesternName ()
            {
                Console.WriteLine ($"{_givenName} {_familyName}" );
            }
        }

        public class Blind
        {
            public double _width;
            public double _height;
            public string _color;
        }
    }
//         int x = 0;
//         int y = 0;

//         //if stament 
//         if (x > y)
//         {
//             Console.WriteLine("greater than");
//         }


//         // if inside if 
//         if (x > y)
//         {
//             if (x > z)
//             {
//                 Console.WriteLine("greater than both");
//             }
//         }



//         // if and else
//         if (x > y)
//         {   
//             Console.WriteLine("greater than");
//         }
//         else
//         {
//             Console.WriteLine("less than");
//         }


//         // else if 
//         if (x > y)
//         {
//             Console.WriteLine("greater than y");
//         }
//         else if (x > z)
//         {
//             Console.WriteLine("greater than z");
//         }
//         else
//         {
//             Console.WriteLine("less than both");
//         }

//         //converting type  string to int 
//         string valueInText = "42";
//         int number = int.Parse(valueInText);

//         Console.Write("What is your favorite number? ");
//         string userInput = Console.ReadLine();
//         int number = int.Parse(userInput);
//         Console.Write("");  


//         //int to string 
//         int number = 42;
//         string textVersion = number.ToString();
// /////////////////////////////////////////////////////////////////////////

//         // do whille 
//         string response;

//         do
//         {
//             Console.Write("Do you want to continue? ");
//             response = Console.ReadLine();
//         } while (response == "yes");

//         // foreach loop
//         foreach (string color in colors)
//         {
//             Console.WriteLine(color);
//         }

//         // randon generator 
//         Random randomGenerator = new Random();
//         int number = randomGenerator.Next(1, 11);

// /////////////////////////////////////////////////////////////////////////
// ///
//     // lists 
//     List<int> numbers;
//     List<string> words;


//     List<int> numbers;
//     numbers = new List<int>();

//     List<int> numbers = new List<int>();
//     List<string> words = new List<string>();

//     // adding items 

//     List<string> words = new List<string>();

//     words.Add("phone");
//     words.Add("keyboard");
//     words.Add("mouse");

//     // having the length 
//     Console.WriteLine(words.Count);

//     //iteratig 

//     foreach (string word in words)
//     {
//         Console.WriteLine(word);
//     }

//     // accesing by index 
//     for (int i = 0; i < words.Count; i++)
//     {
//         Console.WriteLine(words[i]);
//     }


//     //////////////////////////////////////////////////
//     /// functions 
//     /// 

//     returnType FunctionName(dataType parameter1, dataType parameter2)
//     {
//         // function_body
//     }

//     // function without parameter 
//     void DisplayMessage()
//     {
//         Console.WriteLine("Hello world!");
//     }

//     // single parameter 
//     void DisplayPersonalMessage(string userName)
//     {
//         Console.WriteLine($"Hello {userName}");
//     }


//     // 2 int parameters 
//     int AddNumbers(int first, int second)
//     {
//         int sum = first + second;
//         return sum;
//     }

//     ///
//     static void DisplayMessage()
//     {
//         Console.WriteLine("Hello world!");
//     }

//     static void DisplayPersonalMessage(string userName)
//     {
//         Console.WriteLine($"Hello {userName}");
//     }

//     static int AddNumbers(int first, int second)
//     {
//         int sum = first + second;
//         return sum;
//     }
/////////////////////////////////////////////////////////////////////////
///classes 
///
    // A code template for the category of things known as Person. The
    // responsibility of a Person is to hold and display personal information.


  
}