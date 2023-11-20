/*
Задача 53: Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую и последнюю строку массива.
*/
int[,] GenerateArray2d(int m, int n)
{
    int[,] array2d = new int[m, n];

    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            array2d[i, j] = new Random().Next(0, 7);
        }
    }
    PrintArray2d(array2d,"Изначальный массив");
    return array2d;
}

void PrintArray2d(int[,] array2d, string message)
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

int[,] SwapRows(int[,] array2d)
{
    int temp=0;
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            temp=array2d[0, j];
            array2d[0, j] =array2d[array2d.GetLength(0)-1,j];
            array2d[array2d.GetLength(0)-1,j]=temp;
        }
    PrintArray2d(array2d,"Измененный массив");
    return array2d;
}

Console.WriteLine("Введите количество строк m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2d = GenerateArray2d(m, n);
SwapRows(array2d);
