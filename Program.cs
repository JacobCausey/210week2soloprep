//ask user for input and take a grade to store as a variable.

Console.WriteLine("What was your grade?");
int grade = Console.Read();
//Console.WriteLine("Your grade was a ${grade}.");

//Use an if, else, or else if to convert the int value to a string/grade letter value. (This will be a function)
string letterGrade = if (grade >= 90)
{
    letterGrade ="A);
}
else if (grade >= 80)
{
    letterGrade ="B");
}
else if (grade >= 70)
{
    Console.WriteLine("Your grade is a C");
}
else if (grade >= 60)
{
    Console.WriteLine("Your grade is a d");
}
else if (grade > 60)
{
    Console.WriteLine("Your grade is an F");
}

Console.WriteLine("Your grade is a ${letterGrade}");
