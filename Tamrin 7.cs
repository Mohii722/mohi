using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "09123456789 09123456788 09111111111 09122222222";
        List<string> validNumbers = ExtractPhoneNumbers(input);

        Console.WriteLine("Valid Phone Numbers:");
        foreach (var number in validNumbers)
        {
            Console.WriteLine(number);
        }
    }

    static List<string> ExtractPhoneNumbers(string input)
    {
        List<string> validNumbers = new List<string>();
        string pattern = @"\b0\d{9}\b"; // شماره تلفن‌ها که با صفر شروع و 10 رقم دارند
        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (Match match in matches)
        {
            string number = match.Value;

            // چک کردن اینکه آیا حداقل دو عدد متفاوت دارد
            if (HasAtLeastTwoDifferentDigits(number))
            {
                validNumbers.Add(number);
            }
        }

        return validNumbers;
    }

    static bool HasAtLeastTwoDifferentDigits(string number)
    {
        HashSet<char> uniqueDigits = new HashSet<char>(number);
        return uniqueDigits.Count >= 2;
    }
}