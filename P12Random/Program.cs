Console.WriteLine("please pass me a seed (integer)");
int seed = Convert.ToInt32(Console.ReadLine());
Random specificrandomseed = new Random(seed);

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(specificrandomseed.Next(0, 6));
}
Console.WriteLine("three numbers between 0.0 and 0.5");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(specificrandomseed.NextDouble()* (0.5));
}
Console.WriteLine("three numbers between 0.0 and 0.7");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(specificrandomseed.NextDouble()*(0.7-0.2)+0.2);
}
Random rand  = new Random();
Console.WriteLine("give me a crit chance between 0,0 (0%) and 1.0 (100%)");
double chanceOfSuccess = Convert.ToDouble(Console.ReadLine());

for (int i = 0; i < 10; i++)
{ 
    double roll = rand.NextDouble();

    if (chanceOfSuccess > roll)
    {
        Console.WriteLine("Success");
    }
    else
    {
        Console.WriteLine("Failure");
    }
}
