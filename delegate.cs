using System;

public class DelegateExamples{
    
    // BASIC DELEGATE
    // return type is set to void and method must take single string input
    public delegate void MyDelegate(string message);
    
    // return type is set to void and method must take 2 inputs (1 string and 1 int)
    public delegate void MyDelegateTwo(string item, int price);

    public static void PrintMessage(string msg){
        Console.WriteLine("Message: " + msg);
    }

    // MULTICAST DELEGATE
    public static void ShowMessage(string msg){
        Console.WriteLine("Show: " + msg);
    }

    // DELEGATE WITH RETURN VALUE
    // return type is set to int and method must take 2 integers
    public delegate int MathOperation(int a, int b);
    public static int Add(int x, int y) => x + y;
    public static int Multiply(int x, int y) => x * y;

    public static void Main(){
        Console.WriteLine("BASIC DELEGATE");
        // delegate_name var = method_name
        MyDelegate del1 = PrintMessage;
        del1("Hello, Delegates!");

        Console.WriteLine("\nMULTICAST DELEGATE");
        MyDelegate del2 = PrintMessage;
        del2 += ShowMessage;
        del2("Delegates are powerful!");

        Console.WriteLine("\nDELEGATE WITH RETURN VALUE");
        MathOperation op1 = Add;
        MathOperation op2 = Multiply;
        Console.WriteLine("Add: " + op1(5, 3));
        Console.WriteLine("Multiply: " + op2(5, 3));

        Console.WriteLine("\nANONYMOUS METHOD");
        MyDelegateTwo del3 = delegate(string item, int price){
            Console.WriteLine("Anonymous says: Item Name="+item+ "\tItem Price="+price);
        };
        del3("Pen",35);

        Console.WriteLine("\nLAMBDA EXPRESSION");
        MathOperation add = (x, y) => x + y;
        MathOperation multiply = (x, y) => x * y;
        Console.WriteLine("Add: " + add(10, 20));
        Console.WriteLine("Multiply: " + multiply(10, 20));
    }
}
