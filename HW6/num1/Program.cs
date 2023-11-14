/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int[] ArrayGen(int M)
{
    int[] array= new int[M];
    Console.WriteLine($"Введите{M} чисел через 1 пробел");
    while(true)
    {
        array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        if (array.Length!=M)
        {
            Console.WriteLine($"Вы ввели не {M} чисел, введите{M} чисел через 1 пробел");
        }
        else break;
    }
    WriteArray(array);
    return array; 
}

void WriteArray(int[] array)
{
    foreach (int i in array)
    {
        Console.Write(i+" ");
    }
    Console.WriteLine("")
}

int PosCount(int[] array)
{
    int n=0;
    foreach (int i in array)
    {
        if (i>0)
        {
            n++;
        }
    }
    return n;
}

Console.WriteLine("Введите количество чисел M");
int M=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PosCount(ArrayGen(M)));
