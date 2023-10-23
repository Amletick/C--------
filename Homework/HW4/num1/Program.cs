/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int Input(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
double pow_for_poor(int a, int b)
{
    double temppow=Convert.ToDouble(a);
    for (int i=2;i<=b;i++)
    {
        temppow=temppow*a;
    }
    return temppow;
}

void Output(double result,string message)
{
    Console.Write(message);
    Console.WriteLine(result);
}
int a=Input("Введите число А");
int b=Input("Введите число B");
double result=pow_for_poor(a,b);
Output(result,"Результат: ");
