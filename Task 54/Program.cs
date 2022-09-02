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
void Decrease(int[,]arr)
{
    for(int i=0; i<arr.GetLength(0); i++)
    {
        for(int j=0; j<arr.GetLength(1)-1; j++)
        {
            if(arr[i,j]<arr[i,j+1])
            {
                int temp = arr[i,j];
                arr[i,j]=arr[i,j+1];
                arr[i,j+1]= temp;
            }   
        }
    }
}
Console.Write("Введите высоту массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину массива: ");
int y = Convert.ToInt32(Console.ReadLine());
int[,]array=new int[x,y];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int c=1;
while(c<=y)
{
    Decrease(array);
    c++;
}
PrintArray(array);