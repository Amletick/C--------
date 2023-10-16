/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

string numstr= Console.ReadLine();
int num= Convert.ToInt32(numstr);
if (num>=100||num<=-100)
{
    while (num>999||num<-999)
    {
        num=num/10;
    }
    int second=num%10;
    Console.WriteLine(second); 
}
else Console.WriteLine("Третьей цифры нет");