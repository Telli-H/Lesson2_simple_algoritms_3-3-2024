
    // Задайте двумерный массив символов (тип char [,]). 
    // Создать строку из символов этого массива.


    static string GetStringFrom2DCharArray(char[,] chars)
    {
        string str = string.Empty;
        for (int i = 0; i < chars.GetLength(0); i++) 
        {
            for (int j = 0; j < chars.GetLength(1); j++)
            {
                str += chars[i, j];
            }
        }
        return str;
    }


    
        char[,] charsArray = 
        {
            { 'a', 'b', 'c' },
            { 'd', 'e', 'f' },
            { 'g', 'h', 'i' }
        };

        Console.WriteLine(GetStringFrom2DCharArray(charsArray));
    