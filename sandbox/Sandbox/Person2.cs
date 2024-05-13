// public class Account
// {
//     public int _balance;

//     public void Deposit(int amount)
//     {
//         _balance = _balance + amount;
//     }
// }



//     Account savings = new Account();
//     savings._balance = 50;
//     savings.Deposit(100); 

// public class Account
// {
//     public List<int> _transactions = new List<int>(); // if we change this to a list...

//     public void Deposit(int amount)
//     {
//         _transactions.Add(amount);
//     }
// }

// // Account savings = new Account();
// // savings._balance = 50; // if we make the change above, this doesn't work anymore!
// // savings.Deposit(100); // however, this approach would continue to work



// public class Account
// {
//     private List<int> _transactions = new List<int>();

//     public void Deposit(int amount)
//     {
//         _transactions.Add(amount);
//     }

//     public int GetBalance()
//     {
//         return _transactions.Count;
//     }
// }


// public class Person2
// {
//     private string _title;
//     private string _firstName;
//     private string _lastName;


//     public Person2()
//     {
//         _title = "";
//         _firstName = "Anonymous";
//         _lastName = "Unknown";
//     }

//     public string GetFirstName()
//     {
//         return _firstName;
//     }

//     public void SetFirstName(string firstName)
//     {
//         _firstName = firstName;
//     }

//     public string GetInformalSignature()
//     {
//         return "Thanks," + _firstName;
//     }

//     public string GetFormalSignature()
//     {
//         return "Sincerely" + GetFullName();
//     }

//     private string GetFullName()
//     {
//         return _title + " " + _firstName + " " + _lastName;
//     }

// }

// Person p = new Person(); // This calls a no-argument constructor and doesn't need any information

public class Person2
{
    private string _title;
    private string _firstName;
    private string _lastName;

    public Person2()
    {
        _title = "";
        _firstName = "Anonymous";
        _lastName = "Unknown";
    }

    public Person2(string first, string last)
    {
        _title = "";
        _firstName = first;
        _lastName = last;
    }

    public Person2(string title, string first, string last)
    {
        _title = title;
        _firstName = first;
        _lastName = last;
    }
}

Person2 p1 = new Person2(); // Don't pass any information to get the default values
Person2 p2 = new Person2("Jane", "Doe"); // pass the first and last names
Person2 p3 = new Person2("Mrs.", "Jane", "Doe"); // pass all three variables