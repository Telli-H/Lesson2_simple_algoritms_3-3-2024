// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Threading.Channels;

Console.WriteLine("Input 1 number");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input 2 number");
int num2 = Convert.ToInt32(Console.ReadLine());


string result = num1 == num2*num2 ? "yes":"no";
Console.WriteLine($"a={num1}, b={num2} => {result}");


