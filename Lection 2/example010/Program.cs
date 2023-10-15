int[] array={781,672,356,434,456,636,34,736,456,664,465,534,23,657,89,342,546};
int n = array.Length;
int find = 342;
int i=0;
int flag=0;
while (i<n-1)
{
    if (array[i]==find)
    {
        Console.WriteLine("Нашёл это элемент "+i);
        flag=1;
        break;
    }
    i++;
}

if (flag==0)
{
    Console.WriteLine("Не нашёл");
}