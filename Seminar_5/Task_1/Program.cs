﻿// // Задайте двумерный массив. Найдите чётные элементы и замените эти элементы на их квадраты.

// using System.ComponentModel.DataAnnotations;
// using System.Security.Cryptography;

// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max);
//         }

//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for(int i=0; i < matrix.GetLength(0); i++)
//     {
//         for (int j=0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{ matrix[i,j], 5}");
//         }
//         Console.WriteLine();
//     }
// }

// void ReplaceEvenIdxElenToSquare(int[,] matrix)
// {
//      for (int i=0; i < matrix.GetLength(0); i+=2)
//      {
//         for (int j=0; j < matrix.GetLength(1); j++)
//         {
//             if(matrix[i,j] % 2 == 0)
//             {
//                 matrix[i,j] *= matrix[i,j];
//             }
                
//         }
//      }
// }

// int[,] array2d = CreateMatrixRndInt(3,4,0,100);
// PrintMatrix(array2d);

// Console.WriteLine();

// ReplaceEvenIdxElenToSquare(array2d);
// PrintMatrix(array2d);

// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i=0; i < matrix.GetLength(0); i++)
    {
        for (int j=0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{ matrix[i,j], 5}");
        }
        Console.WriteLine();
    }
}

void ReplaceEvenIdxElenToSquare(int[,] matrix)
{
     for (int i=0; i < matrix.GetLength(0); i+=2)
     {
        for (int j=0; j < matrix.GetLength(1); j+=2)
        {
            
                matrix[i,j] *= matrix[i,j];
        }
                
        }
}


int[,] array2d = CreateMatrixRndInt(3,4,0,100);
PrintMatrix(array2d);

Console.WriteLine();

ReplaceEvenIdxElenToSquare(array2d);
PrintMatrix(array2d);