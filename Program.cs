/*Perfect number is a positive number which sum of all positive divisors excluding*/
/*that number is equal to that number. For example 6 is perfect number since divisor of 6 are 1, 2 and 3.*/
/*Sum of its divisor is 1 + 2+ 3 = 6*/
using System;
public class Exercise28
{
    public static void Main()
    {
        int n, i, sum;
        int mn, mx;

        Console.Write("\n\n");
        Console.Write("Find perfect numbers within a given number of range:\n");
        Console.Write("------------------------------------------------------");
        Console.Write("\n\n");

        Console.Write("Input the starting range or number : ");
        mn = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the ending range of number : ");
        mx = Convert.ToInt32(Console.ReadLine());
        Console.Write("The Perfect numbers within the given range : ");sum = 0;
        for (n = mn; n <= mx; n++)
        {
            i = 1;
            
            while (i <= n/2)
            {
                if (n % i == 0)
                    sum = sum + i;
                i++;
            }
            if (sum == n)
                Console.Write("{0}  ", n);
        }
        Console.Write("\n");
    }
}
