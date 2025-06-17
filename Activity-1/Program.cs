using System;

class Program
{
    static void Main(string[] args)
    {
        GreetUser("John");
        int result = Add(3, 5);
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
}
