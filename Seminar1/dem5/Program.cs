string numstr = Console.ReadLine();
int num = Convert.ToInt32(numstr);
//условие на отрицательность
if (num<0) 
{
    Console.WriteLine();
}
else
{
    int i=-num;
    while (i<=num) 
    {
        Console.Write(i+" ");
        i++;
    }
}