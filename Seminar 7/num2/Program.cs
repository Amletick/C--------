/* Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
1 4 7 2
5 9 2 3
8 4 2 4

1 4 7 2
5 81 2 9 
8 4 2 4

 */
int[,] GenerateArray2d(int row, int column)
{
    int[,] array2d = new int[row, column];

    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            array2d[i, j] = new Random().Next(0, 100);
        }
    }
    PrintArray(array2d,"Изначальный массив");
    return array2d;
}

void PrintArray(int[,] array2d, string message)
{
    Console.WriteLine(message);
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine();
    }
}


int[,] ArrayCheck (int[,] array2d)
{
    for (int i =1; i < array2d.GetLength(0); i=i+2)
    {
        for (int j = 1; j < array2d.GetLength(1); j=j+2)
        {
            array2d[i, j] = array2d[i, j]*array2d[i, j];
        }
    }
    PrintArray(array2d,"Переделанный массив");
    return array2d;
}

Console.WriteLine("Введите количество строк m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2d = GenerateArray2d(m, n);
ArrayCheck(array2d);

