int[] GenerateArray()
{
    int[] array = new int[12];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
        Console.Write(array[i] + " ");
    }
    return array;
}

int SumPositive(int[] array)
{
    int sumPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumPositive += array[i];
        }
    }
    return sumPositive;
}

int SumNegative(int[] array)
{
    int sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sumNegative += array[i];
        }
    }
    return sumNegative;
}

int Sum(int[] array, bool isPositive)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (isPositive)
        {
            if (array[i] > 0)
            {
                sum += array[i];
            }
        }
        else
        {
            if (array[i] < 0)
            {
                sum += array[i];
            }
        }
    }
    return sum;
}

int[] array = GenerateArray();
int sumPositive = Sum(array, true);
int sumNegative = Sum(array, false);
Console.WriteLine($"Сумма положительных: {sumPositive}, сумма отрицательных: {sumNegative}");

int sumPositive1 = SumPositive(array);
int sumNegative1 = SumNegative(array);
Console.WriteLine($"Сумма положительных: {sumPositive1}, сумма отрицательных: {sumNegative1}");