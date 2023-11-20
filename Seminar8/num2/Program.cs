/*
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
 В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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

int[,] SwapT(int[,] array2d)
{
    int[,] arrayT = new int[array2d.GetLength(1),array2d.GetLength(0)];
    for (int i = 0; i < arrayT.GetLength(0); i++)
    {
        for (int j = 0; j < arrayT.GetLength(1); j++)
        {
            arrayT[i,j]=array2d[j,i];

            /*
            1 2 3 4    1 5 9 
            5 6 7 8    2 . . 
            9 1 3 5    . . . 
                       . . .
            */
        }
    }         
    PrintArray2d(arrayT,"Измененный массив");
    return arrayT;
}

Console.WriteLine("Введите количество строк m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2d = GenerateArray2d(m, n);
SwapT(array2d);
