Random random = new Random();
int Mynumber = random.Next(1, 101);
Console.WriteLine("i have picked a number (1-100).it´s your turn to guess it!");

bool running = true;
while (running)
{
    int userinput = Convert.ToInt32(Console.ReadLine());
    
    if (Mynumber < userinput)
    {
        Console.WriteLine("your turn is too high!");
    }
    if (Mynumber > userinput)
    {
        Console.WriteLine("your turn is too low!");
    }
    if (Mynumber == userinput)
    {
        Console.WriteLine("your got the number!");
        break;
    }
}