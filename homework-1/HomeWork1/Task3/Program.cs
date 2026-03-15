// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Enter the first number:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

int temp = num1;
num1 = num2;
num2 = temp;

Console.WriteLine("After swapping:");
Console.WriteLine("First number: " + num1);
Console.WriteLine("Second number: " + num2);
