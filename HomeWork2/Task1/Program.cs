// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] numbers = new int[6];
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Enter integer no.{i + 1}: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

foreach (int num in numbers)
{
    if (num % 2 == 0)
    {
        sum += num;
    }
}

Console.WriteLine($"The result is: {sum}");