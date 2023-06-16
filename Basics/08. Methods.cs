using System;
public class MethodTeacher
{

    // simple method with 2 argument and a return type
    public double Sum(double firstNum, double secondNum)
    {
        return firstNum + secondNum;
    }

    // return a sum of even numbers from supplied 6 integer number
    // public int SumEvens(int a, int b, int c, int d, int e, int f)
    // {
    //     int sum = 0;
    //     if (a % 2 == 0)
    //         sum = sum + a;
    //     if (b % 2 == 0)
    //         sum = sum + b;
    //     if (c % 2 == 0)
    //         sum = sum + c;
    //     if (d % 2 == 0)
    //         sum = sum + d;
    //     if (e % 2 == 0)
    //         sum = sum + e;
    //     if (f % 2 == 0)
    //         sum = sum + f;
    //     return sum;
    // }

    // instead of above whole code of SumEvens() method, C# allows us to perform same thing in 
    // following few line of code

    public int SumEvens(params int[] numbers)  // variable number of arguments are supported
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            if (num % 2 == 0)
                sum += num;
        }

        return sum;
    }

    static void Main6()
    {
        MethodTeacher methodTeacher = new MethodTeacher();
        double sum = methodTeacher.Sum(2345.56, 4573.98);
        Console.WriteLine($"Sum is {sum}");
        Console.WriteLine($"Sum is {methodTeacher.SumEvens(2, 45, 4, 744, 94, 12, 40)}");
        Console.WriteLine($"Sum is {methodTeacher.SumEvens(4, 45, 6, 755, 94, 33, 40)}");
        Console.WriteLine($"Sum is {methodTeacher.SumEvens(10, 45, 4, 79, 100, 12, 41)}");
    }
}