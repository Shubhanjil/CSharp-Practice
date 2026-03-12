using System;
using System.Collections.Generic;
using System.Linq;

public class LinqExamples{
    public static void Main(){
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };

        // FILTERING: using 'Where' keyword
        Console.WriteLine("FILTERING");
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        foreach (var n in evenNumbers)
            Console.WriteLine(n);

        // PROJECTION: using 'Select' keyword
        Console.WriteLine("\nPROJECTION");
        var squares = numbers.Select(n => n * n);
        foreach (var s in squares)
            Console.WriteLine(s);

        // ORDERING: using 'OrderBy' keyword
        Console.WriteLine("\nORDERING");
        var orderedNames = names.OrderBy(n => n);
        foreach (var name in orderedNames)
            Console.WriteLine(name);

        // GROUPING: using 'GroupBy' keyword
        Console.WriteLine("\nGROUPING");
        var groupedByLength = names.GroupBy(n => n.Length);
        foreach (var group in groupedByLength){
            Console.WriteLine($"Length {group.Key}:");
            foreach (var name in group)
                Console.WriteLine("  " + name);
        }

        // AGGREGATES: using 'Sum', 'Average', 'Max' keyword
        Console.WriteLine("\nAGGREGATES");
        Console.WriteLine("Sum: " + numbers.Sum());
        Console.WriteLine("Average: " + numbers.Average());
        Console.WriteLine("Max: " + numbers.Max());

        // JOINING: using 'Join' keyword
        Console.WriteLine("\nJOINING");
        var students = new List<(int Id, string Name)>{
            (1, "Alice"),
            (2, "Bob"),
            (3, "Charlie")
        };

        var scores = new List<(int StudentId, int Score)>{
            (1, 90),
            (2, 85),
            (3, 95)
        };

        var studentScores = students.Join(
            scores,
            student => student.Id,
            score => score.StudentId,
            (student, score) => new { student.Name, score.Score });

        foreach (var entry in studentScores)
            Console.WriteLine($"{entry.Name} scored {entry.Score}");
    }
}
