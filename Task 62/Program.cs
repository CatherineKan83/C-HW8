void Fill(int[,]arr)
{
    int i=0;
    int j=0;
    int value=1;
    while(value<= arr.GetLength(0)*arr.GetLength(1))
    {
        arr[i,j]=value;
        value++;
        if(i<=j+1&&i+j<arr.GetLength(1)-1)
        {    
            j++;
        }
        else if(i<j&& i+j>=arr.GetLength(0)-1)
        {
            i++;
        }
        else if(i>=j&&i+j>arr.GetLength(1)-1)
        {
            j--;
        }
        else
        {
            i--;
        }
    }
}
void Print(int[,]arr)
{
    for(int i=0;i<arr.GetLength(0); i++)
    {
        for(int j=0;j<arr.GetLength(1);j++)
        {
            Console.Write($" {arr[i,j].ToString("00")} ");
        }
        Console.WriteLine();
    }
} 

int[,]spiral=new int[4,4]; 

Fill(spiral);
Print(spiral);