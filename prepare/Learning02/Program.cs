class Program
{
    static void Main(string[] args)
    {
        while (true) 
        {
            Console.WriteLine("Menu");
            Console.WriteLine("Select 1 option in numbers: " );
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What do you want to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Want to write");
                    break;
                case "2":
                    Console.WriteLine("Want to Display");
                    break;
                case "3":
                    Console.WriteLine("Want to Load");
                    break;
                case "4":
                    Console.WriteLine("Want to Save");
                    break;
                case "5":
                    Console.WriteLine("Want to Quit");
                    break;
                default:
                    Console.WriteLine($"This {choice} option is not valid");
                    break;
            }

        }
    }
}
