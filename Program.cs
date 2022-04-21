using System;

namespace Program.Console
{
    class Program
    {
    static void Main(string[] args)
    {
        //ask user for input and take a grade to store as a variable/convert from a string to a number.
        Console.WriteLine("What was your grade?");
        string response = Console.Read();
        int grade = int.Parse(response);
        Console.WriteLine($"Your grade was a {grade}.");


//Use an if, else, or else if to convert the int value to a string/grade letter value. (This will be a function)
if (grade >= 90)
    {
        string lettergrade = "A";
    }
else if (grade >= 80)
    {
        string lettergrade = "B";
    }
else if (grade >= 70)
    {
        string lettergrade = "C";
    }
else if (grade >= 60)
    {
        string lettergrade = "D";
    }
else (grade > 60)
    {
        string lettergrade = "F";
    }
}
}
}


        