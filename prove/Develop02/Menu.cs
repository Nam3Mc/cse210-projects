public class Menu
{
    List<string> _menuItems = new List<string>{
        "To quit type 0",
        "MENU",
        "1. Write", 
        "2. Dispaly",
        "3. Load from file",
        "4. Save to file",
        "0. Quit" 
    };

    List<string> _menu2 = new List<string>{
        "MENU",
        "1. Display", 
        "2. Delete",
        "3. Edit",
        "4. Save to file",
        "0. Quit" 
    };



    public void DisplayMenu ()
    {
        foreach ( string item in _menuItems)
        {
            Console.WriteLine(item);
        } 
    }

    public void DisplayMenu2 ()
    {
        foreach ( string item in _menu2)
        {
            Console.WriteLine(item);
        } 
    }


    public void Options ()
    {
        int userChoice = -1;
        Entry entry= new Entry();
        Journal journal= new Journal();
        RandomQuestions randomQuestions= new RandomQuestions();

        while ( userChoice != 0)
        {
            DisplayMenu();
            Console.Write("What do you want to do? ");
            


            if  (userChoice == 1)
            {
                Console.WriteLine(randomQuestions.DisplayRandon());
                entry._promtText = randomQuestions.DisplayRandon();

                Console.WriteLine(": ");
                entry._entryText = Console.ReadLine();

                string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                entry._date = dateTime;

                journal.AddEntry(entry);
                Console.WriteLine("");
            }

            else if (userChoice == 2)
            {
                journal.DisplayAll();
            }

            else if (userChoice == 3)
            {
                Console.WriteLine("What will be the file name you want to work with? ");
                Console.Write(": " );
                Journal.ReadFromFile(Console.ReadLine());
            }

            else if (userChoice == 4)
            {   
                Console.WriteLine("What will be the file name? " ) ;
                string fileName = Console.ReadLine() ;
                Journal.SaveToFile( journal._entries , fileName );
                Console.WriteLine("");
                DisplayMenu2();
                
            }

        }
    }

}