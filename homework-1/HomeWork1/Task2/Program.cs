// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Enter the first number:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the trird number:");
int num3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the fourth number:");
int num4 = Convert.ToInt32(Console.ReadLine());

int average = (num1 + num2 + num3 + num4) / 4;

Console.WriteLine("The average of the four numbers is: " + average);
