// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine("input 3-digit number");

int num = Convert.ToInt32(Console.ReadLine());

int numCheck = num;
if (num<0) numCheck=-num;

if ( numCheck>=100 && numCheck <= 999 )
{
int digitsSum= numCheck/100 + numCheck % 10;
Console.WriteLine($"{num} = {digitsSum}");
}
else 
{
    Console.WriteLine("incorect input");
}