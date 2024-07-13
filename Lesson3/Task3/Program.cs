//int[] arr={1,2,3,4,5,6};
int[] arr={1,2,3,4,5,6,7};
int[] newarr=new int[arr.Length/2];

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i]+" ");
}

for(int i=0; i<arr.Length/ 2; i++)
{
    newarr[i]=arr[i]*arr[arr.Length-1-i];
}

Console.WriteLine();

for (int i = 0; i < newarr.Length; i++)
{
    Console.Write(newarr[i]+ " " );
}