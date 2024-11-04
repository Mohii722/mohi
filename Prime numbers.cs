
Console.Write("Enter the lower bound(m):");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the upper bound(n):");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Prime Numbers betweer{m}and{n}:");
for (int i = m; i <= n; i++)
{
    if (IsPrime(i))
    {
        Console.WriteLine(i + "");
    }
}
    
     
static bool IsPrime(int n)
{


    //Write your Logic here
    return false;
}