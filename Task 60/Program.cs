void Print(int[,,]arr)
{
    for(int i=0;i<arr.GetLength(0);i++)
    {
        for(int j=0;j<arr.GetLength(1);j++)
        {
            for(int k=0;k<arr.GetLength(2);k++)
            {
                Console.Write($"{arr[i,j,k]} ({i},{j},{k}) ");
            }
        Console.WriteLine();
        }
    }
Console.WriteLine();
}
void Fill(int[,,]arr)
{
    for(int i=0;i<arr.GetLength(0);i++)
    {
        for(int j=0;j<arr.GetLength(1);j++)
        {
            for(int k=0;k<arr.GetLength(2);k++)
            {
                arr[i,j,k]= new Random().Next(10,99);
            }
        }
    }
Console.WriteLine();
}
int[,,]cube=new int[2,2,2];
Fill(cube);
Print(cube);