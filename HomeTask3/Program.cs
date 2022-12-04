// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int [,] matA = new int [,]
{
    {2,4},
    {3,2}
};
int [,] matB = new int[,]
{
    {3,4},
    {3,3}
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


 int[,] MatrixXMatrix(int[,] matrixA, int[,] matrixB)
    {       
      int [,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                matrixC[i, j] = 0;

                for (int k = 0; k < matrixA.GetLength(1); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
        return matrixC;
    }

    Print (MatrixXMatrix(matA,matB));