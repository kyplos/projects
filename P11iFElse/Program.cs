Console.WriteLine("what´s your age?");

int age = Convert.ToInt32(Console.ReadLine());

if (age <= 13)
{
    Console.WriteLine("you are a child");
}
else if (age >= 14 && age <= 17)
{
    Console.WriteLine("you are a teenager");
}
else if (age >= 18)
{
    Console.WriteLine("you are a adult");
}
Console.WriteLine("give me another number");
