//ask user for input and take a grade to store as a variable.

Console.WriteLine("What was your grade?");
string grade = Console.Read();
int number = int.Parse(grade);
Console.WriteLine("$Your grade was a {number}.");

//Use an if, else, or else if to convert the int value to a string/grade letter value. (This will be a function)
{
    string lettergrade = "";
    
    if (number >= 90)
{
   string letterGrade ="A";
   Console.WriteLine($"Your grade is a {letterGrade}");
}
else if (number >= 80)
{
   string letterGrade ="B";
   Console.WriteLine("Your grade is a ${letterGrade}");
}
else if (number >= 70)
{
    string letterGrade ="C";
    Console.WriteLine("Your grade is a ${letterGrade}");
}
else if (number >= 60)
{
   string letterGrade ="D";
   Console.WriteLine("Your grade is a ${letterGrade}");
}
else if (number > 60)
{
   string letterGrade ="F";
   Console.WriteLine("Your grade is a ${letterGrade}");
}
}