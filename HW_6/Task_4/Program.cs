// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, 
//в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

using System;

class Program
{
    static void Main()
    {
        
        string originalString = "this is a test";
        
       
        string[] words = originalString.Split(' ');
        
        
        string reversedString = string.Join(' ', ReverseArray(words));
        
      
        Console.WriteLine("initial string: " + originalString);
        Console.WriteLine("reversed string: " + reversedString);
    }

    
    static string[] ReverseArray(string[] arr)
    {
        string[] reversedArray = new string[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            reversedArray[i] = arr[arr.Length - 1 - i];
        }
        return reversedArray;
    }
}