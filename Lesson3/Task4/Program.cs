Console.WriteLine("input natural 3-digit number:");
int num= Convert.ToInt32(Console.ReadLine());
int[] arr=new int[3];
int i=0;
if (num<0)
{
    Console.Write("number is not natural");
    return;
}

if (num<100 || num>999)
{
    Console.Write("number is not 3-digit");
    return;
}
while (num>0)
{
    arr[i]=num%10;
    i=i+1;
    num=num/10;
}
for (int j = 0; j < arr.Length; j++)
{
    Console.Write($"{arr[j]}"  );
}
