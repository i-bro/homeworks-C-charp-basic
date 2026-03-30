// See https://aka.ms/new-console-template for more information
using homework_4;

Console.WriteLine("Hello, World!");

Car car1 = new Car( "Hyundai", 200 );
Car car2 = new Car("Mazda", 180);
Car car3 = new Car("Ferrari", 380);
Car car4 = new Car("Porsche", 280);

Driver driver1 = new Driver("bob", 5);
Driver driver2 = new Driver("Greg", 8);
Driver driver3 = new Driver("Jill", 3);
Driver driver4 = new Driver("Anne", 9);

Console.WriteLine("Choose Car No. 1:");
Console.WriteLine("1. Hyundai\n2. Mazda\n3. Ferrari\n4. Porsche");
int carChoice1;
while (!int.TryParse(Console.ReadLine(), out carChoice1))
{
    Console.WriteLine("Choose Car No. 1:");
}
Car selectedCar1 = GetCarByChoice(carChoice1, car1, car2, car3, car4);

Console.WriteLine($"Choose Driver for {selectedCar1.Model}:");
Console.WriteLine("1. Bob\n2. Greg\n3. Jill\n4. Anne");
int driverChoice1;
while (!int.TryParse(Console.ReadLine(), out driverChoice1))
{
    Console.WriteLine($"Choose Driver for {selectedCar1.Model}:");
}
selectedCar1.Driver = GetDriverByChoice(driverChoice1, driver1, driver2, driver3, driver4);

Console.WriteLine("\nChoose Car No. 2:");
int carChoice2;
while (!int.TryParse(Console.ReadLine(), out carChoice2) || carChoice1 == carChoice2)
{
    if (carChoice1 == carChoice2)
    {
        Console.WriteLine("You picked the same car! Defaulting to a different one.");
    }
    else
    {
        Console.WriteLine("Choose Car No. 2:");
    }
}
Car selectedCar2 = GetCarByChoice(carChoice2, car1, car2, car3, car4);


Console.WriteLine($"Choose Driver for {selectedCar2.Model}:");
Console.WriteLine("1. Bob\n2. Greg\n3. Jill\n4. Anne");
int driverChoice2;
while (!int.TryParse(Console.ReadLine(), out driverChoice2) || driverChoice1 == driverChoice2)
{
    if (driverChoice1 == driverChoice2)
    {
        Console.WriteLine("You picked the same driver! Defaulting to a different one.");
    }
    else
    {
        Console.WriteLine($"Choose Driver for {selectedCar2.Model}:");
    }
    
}
selectedCar2.Driver = GetDriverByChoice(driverChoice2, driver1, driver2, driver3, driver4);


RaceCars(selectedCar1, selectedCar2);


static void RaceCars(Car c1, Car c2)
{
    int speed1 = c1.CalculateSpeed();
    int speed2 = c2.CalculateSpeed();

    if (speed1 > speed2)
    {
        Console.WriteLine($"\nWinner: {c1.Model}! Speed: {speed1}. Driver: {c1.Driver.Name}");
    }
    else if (speed2 > speed1)
    {
        Console.WriteLine($"\nWinner: {c2.Model}! Speed: {speed2}. Driver: {c2.Driver.Name}");
    }
    else
    {
        Console.WriteLine("\nIt's a tie!");
    }
}

static Car GetCarByChoice(int choice, Car car1, Car car2, Car car3, Car car4)
{
    switch (choice)
    {
        case 1: return car1;
        case 2: return car2;
        case 3: return car3;
        case 4: return car4;
        default:
            Console.WriteLine("Invalid selection! Please enter a number between 1 and 4:");
            if (int.TryParse(Console.ReadLine(), out int newChoice))
            {
                return GetCarByChoice(newChoice, car1, car2, car3, car4);
            }
            return GetCarByChoice(0, car1, car2, car3, car4);
    }
}

     static Driver GetDriverByChoice(int choice, Driver d1, Driver d2, Driver d3, Driver d4)
{
    switch (choice)
    {
        case 1: return d1;
        case 2: return d2;
        case 3: return d3;
        case 4: return d4;
        default:
            Console.WriteLine("Invalid selection! Please enter a number between 1 and 4:");
            if (int.TryParse(Console.ReadLine(), out int newChoice))
            {
                return GetDriverByChoice(newChoice, d1, d2, d3, d4);
            }
            return GetDriverByChoice(0, d1, d2, d3, d4);
    }
}
