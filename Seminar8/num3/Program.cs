/*
Задайте двумерный массив. Напишите программу, которая посчитает среднее арифметическое угловых элементов двумерного массива.
Пример:  (1 + 4 + 9 + 12) / 4 = 6.5	
1 	2 	3 	4
5 	6 	7 	8
9 	10 	11 	12


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

int sum(int[,] array2d)
{
    int sum=0;
    sum=array2d[0,0]+array2d[0,array2d.GetLength(1)-1]+array2d[array2d.GetLength(0)-1,0]+array2d[array2d.GetLength(0)-1,array2d.GetLength(1)-1];
    return sum/4;
}

Console.WriteLine("Введите количество строк m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2d = GenerateArray2d(m, n);
Console.WriteLine("Среднее арифметическое = "+sum(array2d));
