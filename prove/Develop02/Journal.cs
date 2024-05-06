using System.Collections.Generic;
using System.IO;
using System.Reflection;

public class Journal 
{
  
    public List<Entry> _entries = new List<Entry>();

    public void DisplayAll ()
    {
        foreach (var entry in _entries)
        {

            Console.WriteLine($"On: {entry._date} you answered this question: ");
            Console.WriteLine(entry._promtText);
            Console.WriteLine(entry._entryText);
        }
    }

    public void AddEntry (Entry entry)
    {
        _entries.Add(entry);
    }

    public string FilePath()
    {
        string executablePath = Assembly.GetExecutingAssembly().Location;
        string directoryPath = Path.GetDirectoryName(executablePath);
        return directoryPath;
    }

    public static void SaveToFile(List<Entry> userPrompts, string fileName)
    {
        // the file is saved automatically to this address
        // C:\Users\USUARIO\Desktop\BYU 2024\cse210-projects\prove\Develop02\bin\Debug\net8.0
        using (StreamWriter outputFile = new StreamWriter(fileName+".txt"))
        {
            foreach (Entry prompt in userPrompts)
            {
                outputFile.WriteLine($"Date: {prompt._date}");
                outputFile.WriteLine($"Question: {prompt._promtText}");
                outputFile.WriteLine($"Answer: {prompt._entryText}");
                outputFile.WriteLine();
            }
        }
    }

    public static List<Entry> ReadFromFile ( string fileName )
    {
       List<Entry> entries = new  List<Entry>();

       string[] lines = System.IO.File.ReadAllLines(fileName);

       foreach (string line in lines)
       {
        Console.WriteLine(line);
       }
       
        return entries;
    }
}