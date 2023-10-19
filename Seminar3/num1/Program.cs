/*Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y). */
int num;

while (true)
{
    Console.Write("Введите номер четверти от 1 до 4: ");
    num = Convert.ToInt32(Console.ReadLine());

    if (num > 0 && num < 5)
    {
            break;
    }
    else
    {
        Console.WriteLine("Введен некорректный параметр");
    }

}

switch (num)
{
    case 1:
        Console.WriteLine("X > 0, Y > 0");
        break;

    case 2:
        Console.WriteLine("X < 0, Y > 0");
        break;

    case 3:
        Console.WriteLine("X < 0, Y < 0");
        break;

    default:
        Console.WriteLine("X > 0, Y < 0");
        break;        
}