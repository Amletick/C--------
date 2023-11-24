/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
      static void PrintNaturalsReverse(int n)
    {
        if (n > 1)
        {
            Console.Write($"{n}, ");
            PrintNaturalsReverse(n - 1);
        }
        else if (n == 1)
        {
            Console.Write(n);
        }
    }

Console.WriteLine("Введите число N:");
if (int.TryParse(Console.ReadLine(), out int N))
        {
            if (N >= 1)
            {
                PrintNaturalsReverse(N);
            }
            else
            {
                Console.WriteLine("Вы ввели число меньше 1, натуральных чисел меньше 1 нет.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
        }
