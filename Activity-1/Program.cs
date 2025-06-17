using System;

class Program
{
    static void Main(string[] args)
    {
        GreetUser("Vivien");
        int result = Add(2, 5);
        Console.WriteLine("Result: " + result);
    }

    static void GreetUser(string name)
    {
        Console.WriteLine("Hello, " + name);
    }

    static int Add(int a, int b)
    {
        return a + b;
    }
    static void SayBye()
    {
        Console.WriteLine("Goodbye!");
    }
}
