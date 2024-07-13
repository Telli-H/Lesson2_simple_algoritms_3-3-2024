//Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

using System;

class Program
{
    static void Main()
    {
       
        string originalString = "This Is A Test String WITH Mixed Case LETTERS";
        
        
        string lowerCaseString = originalString.ToLower();
        
        
        Console.WriteLine(lowerCaseString);
    }
}