string numstr = Console.ReadLine();
if (numstr.Length!=3) 
{
    Console.WriteLine("Число не трехзначное");
}
else
{
       Console.Write(numstr[2]);//нумерация с 0 3-1=2
}