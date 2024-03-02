// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

/*Console.WriteLine("Input integer number=");
int num=Convert.ToInt32(Console.ReadLine());
if (num%7==0 && num%23==00)
{
    Console.WriteLine($"{num} is a divisible of both 7 and 23");
}
else
{
    Console.WriteLine($"{num} is NOT a divisible of both 7 and 23");
}
*/

//Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// Console.WriteLine("_enter a number other than zero_ input (X and Y):");
         
// // Считываем значения X и Y с консоли
// Console.Write("X = ");
// int x = Convert.ToInt32(Console.ReadLine());
            
//  Console.Write("Y = ");
// int y = Convert.ToInt32(Console.ReadLine());
            
// // Выводим результат напрямую 
// if (x > 0 && y > 0)
//  {
//    Console.WriteLine("The point is in the 1st coordinate quarter");
//  }
// else if (x < 0 && y > 0)
// {
//    Console.WriteLine("The point is in the 2nd coordinate quarter.");
//  }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("The point is in the 3rd coordinate quarter");
// }
// else if (x > 0 && y < 0)
// {   
//      Console.WriteLine("The point is in the 4th coordinate quarter");
//  }
//   else
//   {
//     Console.WriteLine("The point is on the axis or at the origin");
//  }


//Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
//и показывает наибольшую цифру число

// Console.WriteLine("input 2-digits number=");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num >= 10 && num <= 99)
// {
//     if (num / 10 > num % 10)
//     {
//         Console.WriteLine(num / 10);
//     }
//     else
//     {
//         Console.WriteLine(num % 10);
//     }
// }
// else
// {
//     Console.WriteLine("Incorrect input");
// }

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

// Console.WriteLine("input natural N");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num <= 0)
// {
//     Console.WriteLine("Error: Enter a natural number that is greater than  0.");
//     return;
// }
// string digitsString = num.ToString();

// for (int i = 0; i < digitsString.Length; i++)
// {
//     Console.Write(digitsString[i]);

//     if (i < digitsString.Length - 1)
//     {
//         Console.Write(", ");
//     }
// }

