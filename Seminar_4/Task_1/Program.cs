










// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();

//     for(int i=0; i<array.Length; i++)
//     {
//         array[i]=rnd.Next(min,max);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for(int i=0; i<array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// int primeCount = CountPrimeNumbers(array)
// {
//     int count=0;
//     for(int i=0; i<array.Length; i++)
//     {
//         int num = array [i];
//         if (isPrimeNumber(num)) count++;
//     }
//     return count;
// }

// static bool isPrimeNumber(int num)
// {
//     for(int i=2;i<Math.Sqrt(num); i++)
//     {
//         if(num% i ==0)
//         {
//             return false;
//         }
//     }
//     return true;
// }

// int count=10;
// int minimum = 1;
// int maximum = 100;

// int[] array=CreateArrayRndInt(count,minimum,maximum);
// PrintArray(array);

// Console.WriteLine();

// int CountPrimeNumbers=CountPrimeNumbers(array);
// Console.WriteLine(countPrimeNumbers);


using System;

class Program
{
    static void Main(string[] args)
    {
        int count = 10;
        int minimum = 1;
        int maximum = 100;

        int[] array = CreateArrayRndInt(count, minimum, maximum);
        PrintArray(array);

        Console.WriteLine();

        int primeCount = CountPrimeNumbers(array); // Переменная primeCount вместо CountPrimeNumbers
        Console.WriteLine(primeCount);  
    }

    static int[] CreateArrayRndInt(int size, int min, int max)
    {
        int[] array = new int[size];
        Random rnd = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(min, max);
        }
        return array;
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
    }

    static int CountPrimeNumbers(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            int num = array[i];
            if (isPrimeNumber(num)) count++;
        }
        return count;
    }

    static bool isPrimeNumber(int num)
    {
        if (num <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(num) + 1; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}