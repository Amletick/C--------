int[] pointA=new int[2];
int[] pointB=new int[2];
Console.WriteLine("Поочередно введите координаты первой точки");
int i=0;
while (i<2)
{
    pointA[i]=Convert.ToInt32(Console.ReadLine());
    i++;
};
Console.WriteLine("Поочередно введите координаты второй точки");
i=0;
while (i<2)
{
   pointB[i]=Convert.ToInt32(Console.ReadLine());
   i++;
}
double dist= Math.Sqrt(Math.Pow((pointB[0]-pointA[0]),2)+Math.Pow((pointB[1]-pointA[1]),2));
Console.WriteLine(dist);

