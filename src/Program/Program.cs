﻿Console.WriteLine(Addition.Add(7, 2));
Console.WriteLine(Substraction.Substract(10, 1));
Console.WriteLine(Multiplication.Multiply(3, 3));
Console.WriteLine(Division.Divide(18, 2));
public class Division
{
    public static double Divide(int a, int b)
    {
        return (double)a / b;
    }
}

public class Addition
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

public class Power
{
    public static int Squared(int a)
    {
        return a * a;
    }
}