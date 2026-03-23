// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Enter the first number:");
int num1;
if(!int.TryParse(Console.ReadLine(), out num1))
{
    Console.WriteLine("invalid input for the first number.");
}


Console.Write("Enter the second number:");
int num2;
if(!int.TryParse(Console.ReadLine(), out num2))
{
    Console.WriteLine("invalid input for the second number.");
}


Console.Write("Enter the trird number:");
int num3;
if(!int.TryParse(Console.ReadLine(), out num3))
{
    Console.WriteLine("invalid input for the third number.");
}

Console.Write("Enter the fourth number:");
int num4;
if(!int.TryParse(Console.ReadLine(), out num4))
{
    Console.WriteLine("invalid input for the fourth number.");
}

int average = (num1 + num2 + num3 + num4) / 4;

Console.WriteLine("The average of the four numbers is: " + average);
