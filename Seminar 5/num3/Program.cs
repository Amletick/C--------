/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, -3] -> да*/

int[] GenerateArray(int lengthmas)
{
    int[] array = new int[lengthmas];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива {i} ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    WriteArray(array);
    return array;

}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("");
}

void Find(int[] mas,int num)
{
    string yesno= "Нет";
    for (int i=0;i<mas.Length;i++)
    {
        if (mas[i]==num)
        {
            yesno="Да";
            break;
        }
    }
    Console.WriteLine(yesno);
}
Console.WriteLine("Введите длину массива");
int l= Convert.ToInt32(Console.ReadLine());
int[] array=GenerateArray(l);
Console.WriteLine("Введите число для поиска");
int findnum=Convert.ToInt32(Console.ReadLine());
Find(array,findnum);

