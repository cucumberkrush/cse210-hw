using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your first name? ");
        string first = Console.ReadLine();

        Console.Write("what is your last name? ");
        string last = Console.ReadLine();

        Console.Write("what is your middle name? ");
        string middle = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first}, {middle}.");
    }
}