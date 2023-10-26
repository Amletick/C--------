/*Задайте массив из N случайных целых чисел (N вводится с клавиатуры). 
Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.
Пример
[1 5 11 21 81 4 0 91 2 3]
=> 2*/
/*int[] GenerateArray(int lengthmas)
{
    int[] array = new int[lengthmas];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    WriteArray(array);
    return array;
}*/

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("");
}

int Find(int[] array)
{
int count=0;
    for (int i=0;i<array.Length;i++)
    {
        if(array[i]%10==1 && array[i]%7==0)
        {
            count++;
        }
    }
    return count;
}
//Console.WriteLine("Введите длину массива");
//int l= Convert.ToInt32(Console.ReadLine());
//int[] array=GenerateArray(l);
int[] array={1,5,11,21,81,4,0,91,2,3};
Console.WriteLine(Find(array));