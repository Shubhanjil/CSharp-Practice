using System;

public class DelegateExamples{
    
    // BASIC DELEGATE
    public delegate void MyDelegate(string message);

    public static void PrintMessage(string msg){
        Console.WriteLine("Message: " + msg);
    }

    // MULTICAST DELEGATE
    public static void ShowMessage(string msg){
        Console.WriteLine("Show: " + msg);
    }

    // DELEGATE WITH RETURN VALUE
    public delegate int MathOperation(int a, int b);
    public static int Add(int x, int y) => x + y;
    public static int Multiply(int x, int y) => x * y;

    public static void Main(){
        Console.WriteLine("BASIC DELEGATE");
        MyDelegate del1 = PrintMessage;
        del1("Hello, Delegates!\n");

        Console.WriteLine("MULTICAST DELEGATE");
        MyDelegate del2 = PrintMessage;
        del2 += ShowMessage;
        del2("Delegates are powerful!\n");

        Console.WriteLine("DELEGATE WITH RETURN VALUE");
        MathOperation op1 = Add;
        MathOperation op2 = Multiply;
        Console.WriteLine("Add: " + op1(5, 3));
        Console.WriteLine("Multiply: " + op2(5, 3) +"\n");

        Console.WriteLine("ANONYMOUS METHOD");
        MyDelegate del3 = delegate(string msg){
            Console.WriteLine("Anonymous says: " + msg);
        };
        del3("Hello from anonymous method!\n");

        Console.WriteLine("LAMBDA EXPRESSION");
        MathOperation add = (x, y) => x + y;
        MathOperation multiply = (x, y) => x * y;
        Console.WriteLine("Add: " + add(10, 20));
        Console.WriteLine("Multiply: " + multiply(10, 20));
    }
}
