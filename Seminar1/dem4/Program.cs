string[] array = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота","Воскресенье"};
Console.WriteLine("Введите номер дня");   
string daystring = Console.ReadLine();
int daynumber = Convert.ToInt32(daystring);
if ((daynumber>=1)&&(daynumber<8))
{
Console.WriteLine(daynumber +" -> "+ array[daynumber-1]);
}
else
{
 Console.WriteLine("Нет такого номера дня");   
}
