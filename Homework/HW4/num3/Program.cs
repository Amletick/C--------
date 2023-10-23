/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] MasGen(int[] mas,string msg)
{
    Console.WriteLine(msg);
    for (int i=0;i<8;i++)
    {
        mas[i]=Convert.ToInt32(Console.ReadLine());
    }
    return mas;
}

void MasWrite(int[] mas,string msg)
{
Console.WriteLine(msg);
Console.Write("[ ");
    for (int i=0;i<8;i++)
    {
        Console.Write(mas[i] + " ");
    }
Console.Write("]");
}
int N=8;
int[] mas= new int[N];
mas=MasGen(mas,"Введите массив");
MasWrite(mas,"Сгенерированный массив");