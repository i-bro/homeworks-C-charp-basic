// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = { "Ana", "Marija", "Elena", "Sara", "Ivana" };

Console.Write("Enter student group (1 or 2): ");
int group = int.Parse(Console.ReadLine());

if (group == 1)
{
    Console.WriteLine("The Students in G1 are:");
    foreach (string student in studentsG1)
    {
        Console.WriteLine(student);
    }
}
else if (group == 2)
{
    Console.WriteLine("The Students in G2 are:");
    foreach (string student in studentsG2)
    {
        Console.WriteLine(student);
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter 1 or 2.");
}