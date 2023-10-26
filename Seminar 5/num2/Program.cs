/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */
int[] GenerateArray(int lengthmas)
{
    int[] array = new int[lengthmas];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-1000, 1000);
    }
    WriteArray(array);
    return array;

}

void Reverse(int[] mas)
{
    for(int i=0;i<mas.Length;i++)
    {
        mas[i]=-mas[i];
    }
    
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("");
}
Console.WriteLine("Введите размерность массива");
int length=Convert.ToInt32(Console.ReadLine());
int[] mas=GenerateArray(length);
Reverse(mas);
WriteArray(mas);

