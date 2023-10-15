int Max(int arg1, int arg2, int arg3)
{
    int result= arg1;
    if (arg2>result)
    {
        result=arg2;
    }
        if (arg3>result)
    {
        result=arg3;
    }
    return result;
}
int a1=10;
int b1=245641;
int c1=3359;
int a2=16572;
int b2=23;
int c2=36573;
int a3=-45645613;
int b3=-24563;
int c3=45633;
int max=Max(Max(a1,b1,c1),
            Max(a2,b2,c2),
            Max(a3,b3,c3));
Console.WriteLine(max);