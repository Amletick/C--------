// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

//1. Создать массив
//1.1 Получение его длины
//1.2 Заполнить массив
//2. Выводим массив
//3. Перевернуть массив
//???

int[] GenerateArray(int length)
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();

    foreach (int number in array)
    {
        Console.Write(number + " ");
    }

    Console.WriteLine();

    string str = String.Join(" ", array);
    Console.Write(str);

    Console.WriteLine();
}

void ReverseArray(int[] array)
{
    int lastIndex = array.Length - 1;
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[lastIndex - i];
        array[lastIndex - i] = temp;
    }
}

int[] array = GenerateArray(5);
PrintArray(array);
ReverseArray(array);
PrintArray(array);