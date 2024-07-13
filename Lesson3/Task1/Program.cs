// int[] array1 = new int[8];
// int[] array2 = new int[8]{1, 2, 3, 4, 5, 6, 7 , 8};
// int[] array3 = new int[]{1, 2, 4, 3, 4, 5, 7, 6, 8}

Console.WriteLine("Input number: ");
int targetNum = Convert.ToInt32(Console.ReadLine());
int[] array = {1, 2, 3, 4, 5, 6, 7, 8};
bool res = false;

for (int i = 0; i < array.Length; i++)
{
    if (array[i]==targetNum)
    {
       
        res = true;
        break;
    }
    
}
  Console.WriteLine(res ?"yes": "no");