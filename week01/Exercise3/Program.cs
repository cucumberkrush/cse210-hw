using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        // for part 1 and 2 where the user is prompted to enter a magic number...
        // console.write("enter the magic number: ");
        // int magicNumber = int.parse(console.readline());

        //for part 3, where we generate a random number between 1 and 101
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        //we could use a while loop here, but for the sake of this exercise, we will use a do while lo

        while (guess != magicNumber)
        {
            Console.Write("Enter your guess: ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the magic number!");
            }
        }
    }
}