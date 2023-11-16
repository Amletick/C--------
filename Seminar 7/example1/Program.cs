/* Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1*/
int[,] GenerateArray2d(int row, int column)
{
    int[,] array2d = new int[row, column];

    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {

            Console.Write(array2d[i, j] + " ");
        }

        Console.WriteLine();
    }

    return array2d;
}

void PrintArray(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array2d = GenerateArray2d(4, 4);
// PrintArray(array2d);