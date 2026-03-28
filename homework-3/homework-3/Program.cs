// See https://aka.ms/new-console-template for more information
Console.WriteLine("global age calculator");

Console.Write("enter your birth date(yyyy-mm-dd):");
string dateInput = Console.ReadLine();

if (DateTime.TryParse(dateInput, out DateTime birthDate))
{
    int age = AgeCalculator(birthDate);

    Console.WriteLine($"based on universal time (utc) you are {age} years old");
} else
{
    Console.WriteLine("invalid date format");
}

static int AgeCalculator(DateTime birthDate)
{
    DateTime today = DateTime.UtcNow.Date;
    int age = today.Year - birthDate.Year;

    if(birthDate.AddYears(age) > today)
    {
        age--;
    }
    return age;
}