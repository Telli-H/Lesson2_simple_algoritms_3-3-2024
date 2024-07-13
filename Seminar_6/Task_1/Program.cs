﻿// Задайте массив символов (тип char[])
// Создайте строку из символов этого массива 
// Пример [a, b, c, d] => "abcd"



using System;

class Program
{
    static string GetStringFromCharArray(char[] chars)
    {
        string str = string.Empty;
        for (int i = 0; i < chars.Length; i++)
        {
            str += chars[i];
        }
        return str;
    }

    static void Main()
    {
        char[] charsArray = { 'a', 'b', 'c', 'd' };
        Console.WriteLine(GetStringFromCharArray(charsArray));
    }
}