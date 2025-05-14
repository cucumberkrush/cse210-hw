using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        //please note we could use a do while loop here
        int userNumber = -1;
        while
        (userNumber != 0)
        {
            Console.WriteLine(" enter a number (0 to quit): ");

            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            //add the number to the list if it is not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        // Part 1: compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum of the numbers is: {sum}");

        // Part 2: compute the average
        // notice that we first cast the sum variable to a float.otherwise , because
        // both the sum and the count are integers, the result of the division will be an integer
        // and we will lose the decimal part of the result even if the result is a float
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average of the numbers is: {average}");
        // Part 3: compute the maximum
        // there ae several ways to do this, such as sorting the list

        int max = numbers[0];
        foreach (int number in numbers)
        {
            // if the number is greater than the current max, we have found a new max
            // so we update the max variable
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The maximum of the numbers is: {max}");
    }

}