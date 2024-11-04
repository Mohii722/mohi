using System;

Console.WriteLine("(n)را وارد کنید");
int n = int.Parse(Console.ReadLine());


Console.WriteLine("(m)را وارد کنید");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("اعداد ایینه ای بین {m} و {n} عبارت اند از");

for (int i = n; i <= m; i++)
{
    if (IsPalindrom(i, Console.WriteLine))
        Console.ReadKey();



#pragma warning disable CS8321 // Local function is declared but never used
    static bool IsPalindrom(int number, Action writeLine)
    {
        string strNum = number.ToString();
        var arr = strNum.ToCharArray();
        Array.Reverse(arr);
        string reversedStrNum = new string(arr);
        return strNum.Equals(reversedStrNum);
    }
#pragma warning restore CS8321 // Local function is declared but never used
}   