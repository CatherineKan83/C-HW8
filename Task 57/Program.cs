void PrintArray(int[,]arr)
{
    for(int i=0; i<arr.GetLength(0); i++)
    {
        for(int j=0; j<arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i,j]} ");
        }
    Console.WriteLine();
    }
}
void FillArray(int[,]arr)
{
    for(int i=0; i<arr.GetLength(0); i++)
    {
        for(int j=0; j<arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(0,9);
        }
    }
    Console.WriteLine();
}
Console.Write("Введите высоту массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину массива: ");
int y = Convert.ToInt32(Console.ReadLine());
int[,]array=new int[x,y];
int[]check=new int[x*y];
FillArray(array);
PrintArray(array);
int count=0;
int k=0;
foreach (int n in array)
{
    if(check.Contains(n))
    {
        continue;
    }
    else
    {
        for(int i=0;i<array.GetLength(0); i++)
        {
            for(int j=0;j<array.GetLength(1);j++)
            {
                if(n.Equals(array[i,j]))
                {
                    count++;
                }   
            }
        }
        if(count>1&&count<5)
        { 
            Console.WriteLine($"{n} встречается {count} раза.");
        }
        else 
        { 
            Console.WriteLine($"{n} встречается {count} раз.");
        }
        count=0;
        check[k]=n;
        k++;
    }
}