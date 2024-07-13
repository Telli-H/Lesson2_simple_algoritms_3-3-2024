using System;

class Program
{
    static void Main()
    {
      
        string originalString = "level";
        
        
        string processedString = originalString.Replace(" ", "").ToLower();
        
        
        bool isPalindrome = IsPalindrome(processedString);
        
        
        if (isPalindrome)
        {
            Console.WriteLine("it is a palindrom");
        }
        else
        {
            Console.WriteLine("it is NOT a palindrom");
        }
    }

    static bool IsPalindrome(string str)
    {
        int length = str.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (str[i] != str[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}