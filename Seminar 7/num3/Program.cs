/*Задача 51: Задайте двумерный массив. Найдите сумму элементов,
 находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.*/

int[,] GenerateArray2d(int row, int column)
{
    int[,] array2d = new int[row, column];

    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            array2d[i, j] = new Random().Next(0, 10);
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


int ArrayDiagSum (int[,] array2d)
{
    int sum=0;
    for (int i =0; i < array2d.GetLength(0)&& i<array2d.GetLength(1); i++)
    {
        sum+=array2d[i,i];
    }
    //PrintArray(array2d,"Переделанный массив");
    return sum;
}

Console.WriteLine("Введите количество строк m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n");
int n = Convert.ToInt32(Console.ReadLine());
if (m!=n)
{
    Console.WriteLine("Матрица не квадратная, нельзя найти сумму элементов диагонали");
}
else{
int[,] array2d = GenerateArray2d(m, n);
Console.WriteLine(ArrayDiagSum(array2d));
}


