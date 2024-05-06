using System;
using System.Collections.Generic;

public class Program 
{
    public static void Main(string[] args)
    {

        Menu menu= new Menu();
        menu.Options();
        
    }


    public static void SaveToFile(List<string> userPrompts, string pathToSave)
    {
        string filename = pathToSave;
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string prompt in userPrompts)
            {
                outputFile.WriteLine(prompt);
            }
        }
    }

    public static List<string> ReadFromFile ( string filePath )
    {
       List<string> journalRecord = new  List<string>();
       {
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                journalRecord.Add(line);
            }
        }
       }
        return journalRecord;
    }
}