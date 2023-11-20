/*
Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

20:48
1, 2, 3 
4, 6, 1 
2, 1, 6

20:48
1 встречается 3 раза 
2 встречается 2 раз 
3 встречается 1 раз 
4 встречается 1 раз 
6 встречается 2 раза

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

Dictionary<int, int> Slovar(int[,] array2d)

{
        Dictionary<int, int> frequencyDictionary = new Dictionary<int, int>();

        for (int i = 0; i < array2d.GetLength(0); i++)
        {
            for (int j = 0; j < array2d.GetLength(1); j++)
            {
                int element = array2d[i, j];

                if (frequencyDictionary.ContainsKey(element))
                {
                    frequencyDictionary[element]++;
                }
                else
                {
                    frequencyDictionary.Add(element, 1);
                }
            }
        }
    PrintSlovar(frequencyDictionary);
    return frequencyDictionary;
}

void PrintSlovar(Dictionary<int, int> frequencyDictionary)
{
    
    for (int i = 0; i < frequencyDictionary.Count; i++)
        {
            KeyValuePair<int, int> kvp = frequencyDictionary.ElementAt(i);
            Console.WriteLine($"Элемент {kvp.Key}: {kvp.Value} раз(а)");
        }
}

Console.WriteLine("Введите количество строк m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2d = GenerateArray2d(m, n);
Slovar(array2d);


