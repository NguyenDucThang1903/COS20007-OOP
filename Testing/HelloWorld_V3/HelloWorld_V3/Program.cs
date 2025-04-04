using System;

public class Program
{
    static int x = 10;
    
    static void Main()
    {
        Console.WriteLine(x);
        DifferentFunc();
    }

    static void DifferentFunc()
    {
        Console.WriteLine(x);
    }
}
