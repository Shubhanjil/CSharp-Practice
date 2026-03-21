using System;

/* 

ENCAPSULATION : 
Hiding the internal state of a class and controlling access through properties or methods.
Instead of exposing the raw fields directly, wrap them with controlled accessors ( get, set, init )

*/


// AUTO-IMPLEMENTED PROPERTY: exposing the property instead of the field.
public class Student{
    public string Name {get; set;}
    public int Age {get; set;} = 18; // with default value
}

// INIT-ONLY SETTERS: immutable after initialization.
public class Book {
    public string Title {get; init; }
    public string Author { get; init;}
}

// RECORD type: generally immutable. 
public record Person(string FName, string LName);

// BACKING FIELD: hide the raw field and expose it through property.
// lets enforce rules before changing the internal state.
public class Account{
    private decimal balance;
    public decimal Balance {
        get { return balance ; }
        set { 
            if (value < 0) 
                throw new ArgumentException("Balance cannot be negative");
            balance = value;
        }
    }
}

class Program {
    static void Main() {
        var student = new Student {Name = "Alice"} ;
        Console.WriteLine($"Student: {student.Name}, Age: {student.Age}");
        
        var book = new Book{Title= "And Then There Were None", Author= "Agatha Christie"};
        Console.WriteLine($"Book: {book.Title}, Written By: {book.Author}");
        
        var p1 = new Person("John", "Doe");
        var p2 = new Person("John", "Doe");
        var p3 = new Person("Amy", "Shells");
        Console.WriteLine($"Person1 is same as Person2 ?  {p1 == p2}");
        Console.WriteLine($"Person2 is same as Person3 ?  {p2 == p3}");
        
        var account = new Account();
        account.Balance = 1000m;
        Console.WriteLine($"Account Balance: {account.Balance}");
        
        // uncommenting will lead to ArgumentException
        // account.Balance = -500m;
    }
}
