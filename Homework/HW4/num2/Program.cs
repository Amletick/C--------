/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int Input(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
double LengthCountMath(int a)
{
    int sum=0;
    while(a!=0)
    {
            sum=sum+a%10;
            a=a/10;            
    }
    return sum;
}

void Output(double result,string message)
{
    Console.Write(message);
    Console.WriteLine(result);
}
int a=Input("Введите число А");
double result=LengthCountMath(a);
Output(result,"Результат: ");