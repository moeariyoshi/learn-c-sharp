using System; // console class for i/o

class Program {
    static void Main() {
        Console.WriteLine("Hello, World!");

        int age = 25;
        float height = 5.9f;  // Note the 'f' suffix for float literals
        char grade = 'A';
        string message = "Hello, C#!";

        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Message: {message}");
    }
}