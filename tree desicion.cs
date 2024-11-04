using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(" ایا ساز میزنی؟ (بله)");
        string answer1 = Console.ReadLine();

        if (answer1 == "بله")
        {
            Console.WriteLine("آیا دوست داری ساز دیگری یاد بگیری؟ (بله/خیر)");
            string answer2 = Console.ReadLine();

            if (answer2 == "بله")
            {
                Console.WriteLine("گیتار");
            }
            else
            {
                Console.WriteLine(":ویالون ");
            }
        }
        else
        {
            Console.WriteLine("آیا فعالیتت به  نیاز تلاش داره؟ (بله/خیر)");
            string answer3 = Console.ReadLine();

            if (answer3 == "بله")
            {
                Console.WriteLine("ایا دوست دارم ک گیتار را ادامه دهم)");
                string answer4 = Console.ReadLine();

                if (answer4 == "بله")
                {
                    Console.WriteLine(" بتونم راحت کیتار بزنم ");
                }
                else
                {
                    Console.WriteLine("در جمعیت  گیتار بزنم");
                }
            }
            else
            {
                Console.WriteLine("گزینه دوم");
            }
        }
    }
}