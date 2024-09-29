Console.WriteLine("give me a number of seconds");
string Seconds = Console.ReadLine();

int Second = int.Parse(Seconds);

if(Second < 0){
    Console.WriteLine("please input a valid number");
}
else
{
    int Days = Second / (24 * 3600);
    Console.WriteLine("Days:"+ Days);    
    int Remaningseconds = Second % (24 * 3600);
        
    int hours = Remaningseconds / 3600;
    Console.WriteLine("Hours:"+ hours);    
    Remaningseconds %= 3600;    
        
    int Minutes = Remaningseconds / 60;
    Console.WriteLine("Minutes:"+ Minutes);    
    
    int rSeconds = Remaningseconds % 60;
    Console.WriteLine("Seconds:"+ rSeconds);
    
        
}