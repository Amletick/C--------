/*Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36*/

int Prompt(string str)
{
    Console.WriteLine(str);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumToN(int num)
{
int sum=0;
for (int i=0;i<=num;i++)
{
sum+=i;
}
return sum;
}


int A = Prompt("Введите положительное число a");
int summa=SumToN(A);
Console.WriteLine("Сумма чисел от 1 до "+A+" равна "+ summa);

