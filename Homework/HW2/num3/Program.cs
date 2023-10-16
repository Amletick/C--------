/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

string[] array = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота","Воскресенье"};
Console.WriteLine("Введите номер дня");   
string daystring = Console.ReadLine();
int daynumber = Convert.ToInt32(daystring);
if ((daynumber==6)||(daynumber==7))
{
Console.WriteLine(daynumber +" -> "+ "Да");
}
else
{
 if (1<=daynumber&&daynumber<=6)
 {
     Console.WriteLine(daynumber +" -> "+ "Нет");
 }
 else
 {
    Console.WriteLine(daynumber +" -> "+ "Нет такого дня");
 }

}

