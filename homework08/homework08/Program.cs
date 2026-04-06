// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Queue<int> numbersQueue = new Queue<int>();
bool keepAdding = true;

while (keepAdding)
{
    Console.WriteLine("Enter a number");
    if(int.TryParse(Console.ReadLine(), out int result))
    {
        numbersQueue.Enqueue(result);
    }
    else
    {
        Console.WriteLine("That wasn't a valid number");
    }
    Console.Write("Do you want to enter anouther number> Y/N :");
    string response = Console.ReadLine().ToUpper();

    if (response != "Y")
    {
        keepAdding = false;
    }
}


while(numbersQueue.Count > 0)
{
    int currentNumber = numbersQueue.Dequeue();
    Console.WriteLine(currentNumber);
}