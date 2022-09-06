void Print(int[,]arr)
{
    for(int i=0;i<arr.GetLength(0);i++)
    {
        for(int j=0;j<arr.GetLength(1);j++)
        {
            if(j==0)
            {
                arr[i,j]=1;
                Console.Write($"{arr[i,j]} ".PadLeft(arr.GetLength(1)-i));
            }
            if(j>0 &&j<=i)
            {
                arr[i,j]=arr[i-1,j-1]+arr[i-1,j];
                if(arr[i,j]<10)
                {
                    Console.Write($" {arr[i,j]} ");
                }
                else Console.Write($"{arr[i,j]} ");
            }
        }
    Console.WriteLine();
    }
}

Console.Write("Введите высоту треугольника: ");
int x = Convert.ToInt32(Console.ReadLine());
int[,]PascalTriangle=new int[x,x*2];
Print(PascalTriangle);