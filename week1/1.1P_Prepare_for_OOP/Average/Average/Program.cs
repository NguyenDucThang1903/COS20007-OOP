using System;
using System.Globalization;
public class Program
{
    public static double Average(double[] arr)
    {
        double sum = 0;
        for(int i=0; i< arr.Length; i++)
        {
            sum += arr[i];
        }
        double avg = sum / arr.Length;
        return avg;
    }
    public static void Main()
    {
        double[] arr = { 2.5, -1.4, -7.2, -11.7, -13.5, -13.5, -14.9, -15.2, -14.0, -9.7, -2.6, 2.1 };
        double avg=Average(arr);
        Console.WriteLine("Average value: " + avg);
        Console.WriteLine("Student name: Nguyen Duc Thang");
        Console.WriteLine("Student ID: 104776473");

        if (Math.Abs(avg)>=10)
        {
            Console.WriteLine("Multiple digits");
        }
        else
        {
            Console.WriteLine("Single digits");
        }

        if(avg<0)
        {
            Console.WriteLine("Average value negative");
        }
        string avg_digits = avg.ToString();
        char last_digit = avg_digits[avg_digits.Length-1];

        if ((double)last_digit-'0' > 3)
        {
            Console.WriteLine("Larger than my last digit");
        }
        else if ((double)last_digit-'0' == 3)
        {
            Console.WriteLine("Equal to my last digit");
        }
        else
        {
            Console.WriteLine("Smaller than my last digit");
        }

    }
}

