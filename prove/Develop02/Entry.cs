public class Entry
{
    public string _date;
    public string _promtText;
    public string _entryText;

    public void Display ()
    {
        Console.WriteLine ( $"{_date}, {_promtText}, {_entryText}");
    }
}