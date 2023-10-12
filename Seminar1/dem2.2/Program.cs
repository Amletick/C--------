Console.WriteLine("Введите число 1");
string num1str=Console.ReadLine();
int num1=Convert.ToInt32(num1str);
Console.WriteLine("Введите число 2");
string num2str=Console.ReadLine();
int num2=Convert.ToInt32(num2str);
if (num1==num2*num2)
{
    Console.Write("a = "+num1+", b = "+num2+"-> Да");
}
else
{
    Console.Write("a = "+num1+", b = "+num2+"-> нет");
}
