using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Enter number 1:");
string input1 = Console.ReadLine();
Console.WriteLine("Enter number 2:");
string input2 = Console.ReadLine();
float number1 = 0;
float number2 = 0;

if(float.TryParse(input1, out number1) && float.TryParse(input2, out number2))
{
    if (number2 == 0)
    {
        Console.WriteLine("Divide by zero");
    }
    else
    {
        Console.WriteLine($"Result: {number1 / number2}");
    }
}
else
{
    Console.WriteLine("Incorrect input");
}
