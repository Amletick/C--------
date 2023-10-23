/*Решение в группах задач:
Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/

int[] MasGen(int[] mas,string msg)
{
    for (int i=0;i<8;i++)
    {
        Random r= new Random();
        mas[i]=r.Next(0,2);
    }
    return mas;
}

void MasWrite(int[] mas)
{
Console.Write("[ ");
    for (int i=0;i<8;i++)
    {
        Console.Write(mas[i] + " ");
    }
Console.Write("]");
}
int[] mas= new int[8];
mas=MasGen(mas,"Сгенерированный массив");
MasWrite(mas);