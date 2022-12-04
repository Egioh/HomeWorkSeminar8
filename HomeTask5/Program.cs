

int[,] Spiral(int n) 
{
    int[,] result = new int[n, n];

    int pos = 0;
    int count = n;
    int value = -n;
    int sum = -1;

    do {
        value = -1 * value / n;
        for (int i = 0; i < count; i++) {
            sum += value;
            result[sum / n, sum % n] = pos++;
        }
        value *= n;
        count--;
        for (int i = 0; i < count; i++) {
            sum += value;
            result[sum / n, sum % n] = pos++;
        }
    } while (count > 0);

    return result;
}

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
Print (Spiral(4));//в аргументе к спирали указываем размер массива