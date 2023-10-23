/*Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120*/

int NumberMult(int n)
{
int Multip=1;
for (int i=1;i<=n;i++)
{
    Multip=Multip*i;
}
return Multip;
}

int Cin(string str)
{
Console.WriteLine(str);
return Convert.ToInt32(Console.ReadLine());
}

int number=Cin("Введите число");
int Mult=NumberMult(number);
Console.WriteLine("Произведение: "+Mult);