// Задача: Написать программу, которая из имеющегося массива строк 
//формирует новый массив из строк, длина которых меньше, 
//либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется 
//пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] inputArr = { "Hello", "2", "world", ":-)" };

string[] resultArray = new string[inputArr.Length];
  int resultIndex = 0;

   foreach (string str in inputArr)
    {
           
            if (str.Length <= 3)
            {
          
                resultArray[resultIndex] = str;
                resultIndex++;
            }
        }

string[] finalResult = new string[resultIndex];
Array.Copy(resultArray, finalResult, resultIndex);

        Console.WriteLine("initial array:");
        PrintArray(inputArr);

         Console.WriteLine("New array with strings, which length less than 3 symbols:");
        PrintArray(finalResult);

        static void PrintArray(string[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"\"{arr[i]}\"");
            if (i < arr.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
