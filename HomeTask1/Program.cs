// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int [,] array =new int [,]
{
    {1,4,7,2,9},
    {5,9,2,3,1},
    {8,4,2,4,9}
};

void Print (int [,] arr)
{

    for (int i =0; i<arr.GetLength(0);i++)
    {
        for (int j=0;j<arr.GetLength(1);j++)
            {
                Console.Write($"{arr[i,j]} ");
            }
            Console.WriteLine();
    }
}

void Sort (int[,] arr)
{
    
    for (int i=0;i<arr.GetLength(0); i++)
    {
        for (int j =0; j<arr.GetLength(1)-1;j++)
        {
            int max = j;
            for (int k =j+1; k<arr.GetLength(1);k++)
            {
                if (arr[i,max]<arr[i,k]) max = k;
            }
            int temp= arr[i,j];
            arr[i,j]=arr[i,max];
            arr[i,max]=temp;
           

        }

        Console.WriteLine();
    }
}
Sort(array);
Print (array);
