﻿// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,90].

// Начальные условия:

// int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива

int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};
int numbers=0;

for (int i = 0; i < array.Length; i++)
{
   if (array[i]<= 90 && array[i] >= 10)
   {
    numbers++;
   }
   
}
 Console.Write(numbers);