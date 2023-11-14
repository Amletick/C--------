/*Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
x=(b2-b1)/(k1-k2) , y=k1(b2-b1)/(k1-k2)+b1 - точка пересечения
*/

double[] ArrayGen()
{
    double[] array= new double[4];
    Console.WriteLine($"По порядку введите значения b1, k1, b2 и k2 через 1 пробел");
    while(true)
    {
        array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        if (array.Length!=4)
        {
            Console.WriteLine($"Вы ввели не 4 числа, введите 4 числа через 1 пробел");
        }
        else 
        {
        return array; 
        WriteArray(array);  
        break; 
        }
    }
}

void WriteArray(double[] array)
{
    Console.Write("Уравнения:y=" + array[1] + "*x+" + array[0] + " , y=" + array[3] + "*x+" + array[2]);
    Console.WriteLine("");
}

void CrossPoint(double[] array)
{
    double xcross=(array[2]-array[0])/(array[1]-array[3]);
    double ycross=array[1]*(array[2]-array[0])/(array[1]-array[3])+array[0];
    Console.Write($"Точка пересечения: ({xcross};{ycross})");
}
CrossPoint(ArrayGen());
