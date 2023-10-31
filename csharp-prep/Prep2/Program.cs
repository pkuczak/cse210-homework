using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");

        // ask for grade percent, convert to letter grade
        Console.Write("What is your grade percentage? ");
        int gradePercent = int.Parse(Console.ReadLine());
        string letter;

        if (gradePercent >= 90)
        {
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        // Console.WriteLine($"Your letter grade is '{letter}'.");

        // determine +, -, or no symbol
        int lastDigit = gradePercent % 10;
        string symbol;
        if (lastDigit >= 7)
        {
            symbol = "+";
        }
        else if (lastDigit < 3)
        {
            symbol = "-";
        }
        else
        {
            symbol = "";
        }
        // show letter grade with proper symbol
        if (gradePercent >= 93 || gradePercent < 60)
        {
            Console.WriteLine($"Your letter grade is: {letter}");
        }
        else
        {
            Console.WriteLine($"Your letter grade is: {letter}{symbol}");
        }
        // state if passed or failed
        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations! You've passed the course.");
        }
        else
        {
            Console.WriteLine("I'm sorry you didn't pass. Please try again, you can still do this!");
        }
    }
}