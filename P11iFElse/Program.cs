Console.WriteLine("what´s your age?");

int age = Convert.ToInt32(Console.ReadLine());



if (age <= 13)//this checks if it´s a child,teenager or an adult
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
int oddoreven = Convert.ToInt32(Console.ReadLine());



if (oddoreven > age)//rules out which of the numbers is bigger
{
    Console.WriteLine($"the maximum is:{oddoreven}");
}
else
{
    Console.WriteLine($"the maximum is {age}");
}



if (oddoreven % 2 == 0)// it rules out if the number is odd or even by deviding it until there is nothing left or only 1
{
    Console.WriteLine("the number is even");
}
else
{
    Console.WriteLine("the number is odd");
}