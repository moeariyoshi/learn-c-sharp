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

        // user input
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine($"Hello, {name}!");

        // if-else
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        if (num > 0) {
            Console.WriteLine("Positive");
        } else if (num < 0) {
            Console.WriteLine("Negative");
        } else {
            Console.WriteLine("Zero");
        }

        // for-loop
        for (int i = 1; i <= 5; i++) {
            Console.Write($"{i} ");
        }
    }
}