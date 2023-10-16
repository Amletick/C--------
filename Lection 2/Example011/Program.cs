void FillArray(int[] collection)
{
    int length=collection.Length
    int i=0;
    while (i<length)
    {
        collection[i]=new Random().Next(1,10);
        i++;
    }
}
void PrintArray(int[] colout)
{
    int count=colout.Length;
    int position=0;
    while (position<count)
    {
        Console.WriteLine(colout[position]);
        position++;
    }
}
int IndexFinder(int[] collection, int find)
{
    int length=collection.Length;
    int i=0;
    int position=-1;
     while (i<length)
    {
        if (collection[i]==find)
    {
        position=i;
        break;
    }
    i++;
    }
    return position;
}

int[] array=new int[10];
FillArray(array);
PrintArray(array);
int f=6;
int pos=IndexFinder(array,f);
Console.WriteLine("Число "+f+" находилось на позиции "+pos);