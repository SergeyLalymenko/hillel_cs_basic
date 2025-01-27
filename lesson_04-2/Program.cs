Console.WriteLine("Enter number 1:");
string input1 = Console.ReadLine();
Console.WriteLine("Enter number 2:");
string input2 = Console.ReadLine();

int number1 = Convert.ToInt32(input1);
int number2 = Convert.ToInt32(input2);

Console.WriteLine("Enter operation:");
string operation = Console.ReadLine();

float result = 0;

switch (operation)
{
    case "*":
        {
            result = number1 * number2;
            break;
        }
    case "/":
        {
            result = (float)number1 / number2;
            break;
        }
    case "+":
        {
            result = number1 + number2;
            break;
        }
    case "-":
        {
            result = number1 - number2;
            break;
        }
}

Console.WriteLine($"Result: {result}");
