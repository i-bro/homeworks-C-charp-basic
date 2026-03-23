// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Enter the first number: ");
double num1;
if(!double.TryParse(Console.ReadLine(), out num1))
{
    Console.WriteLine("invalid input for the first number.");
}

Console.Write("Enter the second number: ");
double num2;
if(!double.TryParse(Console.ReadLine(), out num2))
{
    Console.WriteLine("invalid input for the second number.");
}


Console.Write("Enter the operator (+, -, *, /)");
string op = Console.ReadLine();

double result = 0;
bool validOperation = true;

switch(op)
{
    case "+":
        result = num1 + num2;
        break;
    case "-":
        result = num1 - num2;
        break;
    case "*":
        result = num1 * num2;
        break;
    case "/":
        if (num2 != 0)
        {
            result = num1 / num2;
        }
        else
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            validOperation = false;
        }
        break;
    default:
        Console.WriteLine("Error: Invalid operator.");
        validOperation = false;
        break;
}

if (validOperation)
{
    Console.WriteLine($"Result: {result}");
}


