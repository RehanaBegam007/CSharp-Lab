using System;

class Number
{
    public int value;

    public Number(int value)
    {
        this.value = value;
    }

    public static Number operator +(Number n1, Number n2)
    {
        return new Number(n1.value + n2.value);
    }

    public static Number operator -(Number n1, Number n2)
    {
        return new Number(n1.value - n2.value);
    }

    public static Number operator *(Number n1, Number n2)
    {
        return new Number(n1.value * n2.value);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Number num1 = new Number(a);
        Number num2 = new Number(b);

        Number addition = num1 + num2;
        Number subtraction = num1 - num2;
        Number multiplication = num1 * num2;

        Console.WriteLine("Addition = " + addition.value);
        Console.WriteLine("Subtraction = " + subtraction.value);
        Console.WriteLine("Multiplication = " + multiplication.value);
    }
}
