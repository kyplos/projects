Console.WriteLine("what is your age?");

int age = Convert.ToInt32(Console.ReadLine());

bool isChild = age <= 13;
bool isTeenager = age >= 14 && age <= 17;
bool isAdult = age >= 18;

Console.WriteLine($"you are a child:{isChild}");
Console.WriteLine($"you are a teenager:{isTeenager}");
Console.WriteLine($"you are a adult:{isAdult}");