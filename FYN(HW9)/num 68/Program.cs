/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
      int Ackermann(int n, int m)
    {     
       if (n == 0)//И проверка исключения в самом начале и завершение рекурсии
            return m + 1;
        else if (m == 0)
            return Ackermann(n - 1, 1);
        else
            return Ackermann(n - 1, Ackermann(n, m - 1));
    }

Console.WriteLine("Введите число M:");
if(int.TryParse(Console.ReadLine(), out int M))//Просто чтобы сразу выкидывало если пишем дроби\текст
{
    Console.WriteLine("Введите число N:");
    if (int.TryParse(Console.ReadLine(), out int N))
            {
                if (N >= 0 || M>=0)// проверка что будет хотя бы 1 натуральное число в промежутке
                {
                    Console.WriteLine($"M = {M} N= {N} {Ackermann(N,M)}");
                }
                else
                {
                    Console.WriteLine("Вы ввели число меньше 0, введите числа >=0");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целые числа.(желательно хотя бы 1 натуральное)");
            }
}
    