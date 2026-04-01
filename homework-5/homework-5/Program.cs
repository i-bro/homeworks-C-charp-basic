// See https://aka.ms/new-console-template for more information
using homework_5;


var custumers = new Customer[2];
custumers[0] =  new Customer("John Doe", "1234", "1111", 500.00m);
custumers[1] =  new Customer("Jane Smith", "5678", "2222", 1200.50m);

while (true)
{
    Console.WriteLine("\n--- Welcome to the TechBank ATM ---");
    Console.WriteLine("1. Login");
    Console.WriteLine("2. Register New Card");
    Console.WriteLine("3. Exit");
    string choice = Console.ReadLine();

    if (choice == "1") Login(custumers);
    else if (choice == "2") custumers =  RegisterCard(custumers);
    else break;
}

static void Login(Customer[] customers)
{
    Console.Write("Enter Card Number: ");
    string card = Console.ReadLine();
    Console.Write("Enter PIN: ");
    string pin = Console.ReadLine();
    Customer currentCustomer = null;


    foreach (Customer c in customers)
    {
        if (c != null)
        {
            if (c.CardNumber == card && c.VerifyPin(pin))
            {
                currentCustomer = c;
                break;
                }
        }
    }

    if (currentCustomer != null)
    {
        Console.WriteLine($"\nHello, {currentCustomer.FullName}!");
        RunATMMenu(currentCustomer);
    }
    else
    {
        Console.WriteLine("Invalid card number or PIN.");
    }

}

static void RunATMMenu(Customer customer)
{
    bool sessionActive = true;
    while (sessionActive)
    {
        Console.WriteLine("\nChoose an option:");
        Console.WriteLine("1. Balance Check\n2. Cash Withdrawal\n3. Cash Deposition\n4. Logout");
        string action = Console.ReadLine();

        switch (action)
        {
            case "1":
                Console.WriteLine($"Current Balance: ${customer.GetBalance()}");
                break;
            case "2":
                PerformWithdrawal(customer);
                break;
            case "3":
                PerformDeposit(customer);
                break;
            case "4":
                sessionActive = false;
                Console.WriteLine("Logged out successfully.");
                continue;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }

       
        Console.Write("\nWould you like to perform another transaction? (y/n): ");
        if (Console.ReadLine().ToLower() != "y") sessionActive = false;
    }
}

static void PerformWithdrawal(Customer c)
{
    Console.Write("Enter amount to withdraw: ");
    if (decimal.TryParse(Console.ReadLine(), out decimal amount))
    {
        if (c.Withdraw(amount)) Console.WriteLine("Withdrawal successful!");
        else Console.WriteLine("Insufficient funds.");
    }
}

static void PerformDeposit(Customer c)
{
    Console.Write("Enter amount to deposit: ");
    if (decimal.TryParse(Console.ReadLine(), out decimal amount))
    {
        c.Deposit(amount);
        Console.WriteLine("Deposit successful!");
    }
}

static Customer[] RegisterCard(Customer[] customers)
{
    Console.Write("Enter Full Name: ");
    string fullName = Console.ReadLine();
    Console.Write("Enter New Card Number: ");
    string card = Console.ReadLine();
    Console.Write("Set a PIN: ");
    string pin = Console.ReadLine();

    foreach (var c in customers)
    {
        if (c != null && c.CardNumber == card)
        {
            Console.WriteLine("Error: This card number is already in use.");
            return customers;
        }
    }

 
    Console.WriteLine($"Card registered successfully! {fullName}. You can now login.\"");
    var newCustomer = new Customer( fullName, card, pin, 0);
    Array.Resize(ref customers, customers.Length + 1);
    customers[customers.Length - 1] = newCustomer;
    
    return customers;
}

