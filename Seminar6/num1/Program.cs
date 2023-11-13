/*Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.*/


int[] sidesgen()
{
Console.WriteLine("Поочередно введите 3 стороны треугольника");
int[] array= new int[3];
for (int i=0;i<3;i++)
{
    array[i]=Convert.ToInt32(Console.ReadLine());
}
return array;
}
void PossibleCheck(int[] array)
{
if ((array[0]+array[1]>array[2])&&(array[2]+array[1]>array[0])&&(array[0]+array[2]>array[1]))
{
    Console.WriteLine("Есть треугольник с такими сторонами");
}
else Console.WriteLine("Треугольника с такими сторонами нет");
}

PossibleCheck(sidesgen());