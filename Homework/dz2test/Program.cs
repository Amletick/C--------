   /*num1
    static bool IsPalindrome(int number)
    {
      // Введите свое решение ниже
      if (number<10000||number>99999)
      {
        Console.WriteLine("Число не пятизначное");
        return false;
      }
      else if(number/10000==number%10&&number/1000%10==number%100/10)
      {
        return true;
      }
      else {
        return false;
      }
    }
  
 
  int number = 234322;

        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
        */

using System;
public class Answer
{
    private static double Length(int[] pointA, int[] pointB)
    {
      // Введите свое решение ниже
    return Math.Sqrt(Math.Pow((pointB[0]-pointA[0]),2)+Math.Pow((pointB[1]-pointA[1]),2)+Math.Pow((pointB[2]-pointA[2]),2));
    }

  // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args) {
        int x1, x2, x3, y1, y2, y3;

        if (args.Length >= 6) {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            x3 = int.Parse(args[2]);
            y1 = int.Parse(args[3]);
            y2 = int.Parse(args[4]);
            y3 = int.Parse(args[5]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            x1 = 3;
            x2 = 6;
            x3 = 8;
            y1 = 2;
            y2 = 1;
            y3 = -7;
        }

        // Не удаляйте строки ниже
        double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
        Console.WriteLine($"{result:F2}");
    }
}