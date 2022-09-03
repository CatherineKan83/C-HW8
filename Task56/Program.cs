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
void FindSum(int[,]arr,int[]arry)
{
    int sum = 0;
    int i=0;
    while(i < arr.GetLength(0))
    {
        for(int j =0; j<arr.GetLength(1); j++)
        {
            sum=sum+ arr[i, j];
        }
    arry[i]=sum;
    i++; 
    sum=0;
    }
    Console.WriteLine();
} 
void FindMinLine(int[]arr)
{
    for(int i=0;i<arr.GetLength(0);i++)
    {
        if(arr[i]==arr.Min())
        {
            Console.WriteLine($"Строка с наименьшей суммой элементов-> {i+1}");
        }
    }    
    Console.WriteLine();
}
Console.Write("Введите высоту массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину массива: ");
int y = Convert.ToInt32(Console.ReadLine());
int[,]array=new int[x,y];
int[]lines=new int[x];
FillArray(array);
PrintArray(array);
FindSum(array,lines);
FindMinLine(lines);
