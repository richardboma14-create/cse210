List<int> numbers = new List<int>();

Console.WriteLine("Enter a list of numbers, type 0 when finished.");

int number = -1;

while (number != 0)
{
    Console.Write("Enter number: ");
    number = int.Parse(Console.ReadLine());

    if (number != 0)
    {
        numbers.Add(number);
    }
}

Console.WriteLine("You entered:");

foreach (int item in numbers)
{
    Console.WriteLine(item);
}


