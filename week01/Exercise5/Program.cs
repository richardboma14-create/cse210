void DisplayWelcome()
{
    Console.WriteLine("Welcome to the Program!");
}

string PromptUserName()
{
    Console.Write("Please enter your name: ");
    string name = Console.ReadLine();
    return name;
}

int PromptUserNumber()
{
    Console.Write("Please enter your favorite number: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SquareNumber(int number)
{
    int square = number * number;
    return square;
}

void DisplayResult(string name, int square)
{
    Console.WriteLine($"{name}, the square of your number is {square}");
}

DisplayWelcome();

string userName = PromptUserName();
int favoriteNumber = PromptUserNumber();

int squaredNumber = SquareNumber(favoriteNumber);

DisplayResult(userName, squaredNumber);