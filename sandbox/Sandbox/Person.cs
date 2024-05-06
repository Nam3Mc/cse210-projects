public class Person 
{
    public string _firstName;
    public string _lastName;
    public int _age;

    public void ShowEasternName ()
    {
        Console.WriteLine ($"Hello {_firstName} {_lastName}");
    }

    public void ShowWesternName ()
    {
        Console.WriteLine ($"Hello {_lastName}, {_firstName} ");
    }
}