void Print(int[,]matrA,int[,]matrB)
{  
    int t=0;
    for(int i=0; i<matrA.GetLength(0); i++)
    {
        for(int j=0; j<matrA.GetLength(1); j++)
        {
            Console.Write($" {matrA[i,j]} ");
        }
        Console.Write("|");
	    for(int f=0;f<matrB.GetLength(1);f++)
        {
            Console.Write($" {matrB[t,f]} ");
        }
    t++;
    Console.WriteLine();
    }
    
}
void PrintMatrix(int[,]matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i,j]} ");
        }
    Console.WriteLine();
    }
}
void Fill(int[,]matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0,9);
        }
    }
Console.WriteLine();
}
void FillMatrC(int[,]matrA,int[,]matrB,int[,]matrC)
{   
    for(int i =0;i<matrA.GetLength(0);i++)
    {
        int k=i;
        for(int n=0;n<matrB.GetLength(1);n++)
        {
            int l=n;
            int m=0;
            for(int j=0;j<matrA.GetLength(1);j++)
            {
                if(m<matrB.GetLength(0))
                {
                    int Product=matrA[i,j]*matrB[m,n];
                    matrC[k,l] +=Product;
                    m++;
                }
            }
        }
    }
Console.WriteLine();
}

Console.WriteLine("Введите параметры первой матрицы.");
Console.Write("Ширина матрицы: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Высота матрицы: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите параметры второй матрицы.");
Console.Write("Ширина матрицы: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Высота матрицы: ");
int y1 = Convert.ToInt32(Console.ReadLine());
if(y!=x1 | x!=y1)
{
	Console.WriteLine("Параметры матриц не совпадают.");	
}
else 
{int[,]matrixA=new int[x,y]; 
int[,]matrixB=new int[x1,y1]; 
int[,]matrixC=new int[x,y1];
Fill(matrixA); Fill(matrixB);
Console.WriteLine("   A       B");
Print(matrixA, matrixB);
FillMatrC(matrixA,matrixB,matrixC);
Console.WriteLine("   C");
PrintMatrix(matrixC);
}
