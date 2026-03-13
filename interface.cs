using System;

// using 'public' modifier
public interface ILogger {
    
    // implicitly public
    void LoginInfo(string message);
    
    // default interface method which is public
    // from C# 8.0 we can define implementation of a method inside the interface
    public void LogError(string error){
        LogWithFormat("ERROR", error);
    }
    private void LogWithFormat(string level, string message){
        Console.WriteLine($"{level} - {DateTime.Now.ToShortTimeString()}: {message}");
    }
}

public class ConsoleLogger : ILogger {
    public void LoginInfo(string message){
        Console.WriteLine($"[INFO] - {message}");
    }
}

public class Program {
    public static void Main() {
        ILogger logger = new ConsoleLogger();
        logger.LoginInfo("Application started successfully");
        logger.LogError("Error in connection");
    }
}