using System;
class Program {
    
    // IN: Read only reference. no operations allowed
    static void ShowValue( in int number){
        Console.WriteLine($"Value (in): {number}");
    }
    
    // REF: read/write reference
    static void Increment( ref int number){
        number++;
        Console.WriteLine($"Value (ref): {number}");
    }
    
    // OUT: write only (must be assigned before returning)
    static void GetCoordinates(out int x, out int y){
        x = 12;
        y = 50;
    }
    
    // DEFAULT PARAMETER: if, when calling, no parameter is passed, then 'User' will be passed.
    static void Greet( string name = "User") {
        Console.WriteLine($"Hi, {name}.");
    }
    
    // METHOD OVERLOADING
    static void Add(int a, int b){
        Console.WriteLine($"Integers: {a} + {b} = {a+b}");
    }
    static void Add(double a, double b){
        Console.WriteLine($"Doubles: {a} + {b} = {a+b}");
    }
    
    static void Main() {
        int num = 5;
        ShowValue(in num);
        Increment(ref num);
        GetCoordinates(out int x, out int y);
        Console.WriteLine($"Values (OUT): {x}, {y}");
        
        // DEFAULT VALUE DEMONSTRATION
        Greet();
        Greet("Alice");
        
        // METHOD OVERLOADING DEMONSTRATION
        Add(3,4);
        Add(13.4, 27.42);
        
        // LOCAL FUNCTION
        void LocalSum(int[] arr) {
            int Sum(int[] numbers) => numbers.Sum() ;
            Console.WriteLine($"Sum of array: {Sum(arr)}");
        }
        int[] values = {1,2,3,4,5};
        LocalSum(values);
    }
} 
