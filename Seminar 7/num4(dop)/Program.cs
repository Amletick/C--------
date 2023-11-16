/* Задайте двумерный массив из целых чисел. 
Сформируйте новый одномерный массив, состоящий из средних арифметических значений по строкам двумерного массива.
2 3 4 3   
 4 3 4 1    =>  [3 3 5]
 2 9 5 4
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

void PrintArray(int[] array, string message)
{
    Console.WriteLine(message);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


int [] NewArrayGen (int[,] array2d)
{
    int[] array = new int[array2d.GetLength(0)];
    int rowsum=0;
   for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++) 
        {
            rowsum += array2d[i,j];
        }
        array[i]=rowsum/array2d.GetLength(1);
        rowsum=0;
    }
    PrintArray(array,"Переделанный массив");
    return array;
}

Console.WriteLine("Введите количество строк m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2d = GenerateArray2d(m, n);
NewArrayGen(array2d);