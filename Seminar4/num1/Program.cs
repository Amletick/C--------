/*Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/
int NumberCount(int n)
{
int i=0;
int tempnum=n;
while (tempnum!=0)
{
   tempnum=tempnum/10;
   i++;
}
return i;
}

int Cin(string str)
{
Console.WriteLine(str);
return Convert.ToInt32(Console.ReadLine());
}

int number=Cin("Введите число");
int Count=NumberCount(number);
Console.WriteLine("Количество цифр: "+Count);