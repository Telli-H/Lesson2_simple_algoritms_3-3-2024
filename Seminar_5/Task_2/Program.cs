// Двумерный массив. Найти сумму элементов по главной диоганали (0,0)+(1,1)+(2,2)
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

int SummMainDiagonal(int[,] matrix)
{
    int sum=0;
    int min=matrix.GetLength(0);
    if (matrix.GetLength(1)<min)
    {
        min = matrix.GetLength(1);

    }
    for(int i=0; i<min; i++)
    {
sum += matrix[i,i];
    }
    return sum;
}


int[,] matr = CreateMatrixRndInt(5,3,0,10);

PrintMatrix(matr);

Console.WriteLine();
Console.WriteLine(SummMainDiagonal(matr));

