using System;

class Program
{
    static void Main()
    {
        // ==========================================
        // Task 1: Processing User Input
        // ==========================================
        Console.WriteLine("--- TASK 1: USER INPUT ---");
        Console.Write("Enter your name: ");
        string name = Console.ReadLine()!;

        Console.Write("Enter your age: ");
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            int futureAge = age + 5;
            Console.WriteLine($"Hello {name}! In 5 years, you will be {futureAge} years old.");
        }
        else
        {
            Console.WriteLine("Invalid age input.");
        }
        Console.WriteLine(); // Blank line for spacing


        // ==========================================
        // Task 2: Selection Statements (Age Categorization)
        // ==========================================
        Console.WriteLine("--- TASK 2: AGE CATEGORIZATION ---");
        Console.Write("Please enter your age again for categorization: ");
        if (int.TryParse(Console.ReadLine(), out int task2Age))
        {
            if (task2Age < 0 || task2Age >= 110)
            {
                Console.WriteLine("Error: Age must be between 0 and 109.");
            }
            else if (task2Age < 13)
            {
                Console.WriteLine("You are a child.");
            }
            else if (task2Age <= 19)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are an adult.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        Console.WriteLine();


        // ==========================================
        // Task 3: Logical Operators (Number Sign Checker)
        // ==========================================
        Console.WriteLine("--- TASK 3: NUMBER SIGN CHECKER ---");
        Console.Write("Enter an integer: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number > 0)
            {
                Console.WriteLine($"{number} is a positive number.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is a negative number.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a whole number.");
        }
        Console.WriteLine();


        // ==========================================
        // Task 4: Leap Year Checker
        // ==========================================
        Console.WriteLine("--- TASK 4: LEAP YEAR CHECKER ---");
        Console.Write("Enter a year: ");
        if (int.TryParse(Console.ReadLine(), out int year))
        {
            if (year < 0)
            {
                Console.WriteLine("Error: Year cannot be negative.");
            }
            else if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid numerical year.");
        }
        Console.WriteLine();


        // ==========================================
        // Task 5: Even or Odd Checker
        // ==========================================
        Console.WriteLine("--- TASK 5: EVEN OR ODD CHECKER ---");
        Console.Write("Enter an integer to check if it's even or odd: ");
        if (int.TryParse(Console.ReadLine(), out int checkNumber))
        {
            // Modulus by 2: If the remainder is 0, the number is even
            if (checkNumber % 2 == 0)
            {
                Console.WriteLine($"{checkNumber} is an even number.");
            }
            else
            {
                Console.WriteLine($"{checkNumber} is an odd number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a whole number.");
        }
    }
}
