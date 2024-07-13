int[] array= new int[10] {2, 7, -4, -5, -8, -9, -10, 6, 11, -12};
for (int i=0; i<array.Length; i++)
{
    Console.Write($"{array[i]} ");
}

Console.WriteLine();

for(int i=0; i<array.Length; i++)
{
    array[i] *=-1;
}
for (int i=0; i<array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();