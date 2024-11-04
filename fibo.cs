using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("لطفاً عددی وارد کنید: ");
        int n = int.Parse(Console.ReadLine());

        if (IsFibonacci(n))
        {
            Console.WriteLine($"{n} در سری فیبوناچی است.");
        }
        else
        {
            Console.WriteLine($"{n} در سری فیبوناچی نیست.");
        }
    }

    static bool IsFibonacci(int n)
    {
        int a = 0, b = 1, temp;

        if (n == 0 || n == 1)
            return true;

        while (b < n)
        {
            temp = b;
            b += a;
            a = temp;
        }

        return b == n;
    }
}