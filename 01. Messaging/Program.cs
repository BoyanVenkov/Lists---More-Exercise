using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        foreach (var n in Console.ReadLine().Split())
        {
            numbers.Add(int.Parse(n));
        }

        List<char> text = new List<char>(Console.ReadLine().ToCharArray());
        string result = "";

        foreach (int num in numbers)
        {
            int sum = SumDigits(num);

            int index = sum % text.Count;

            result += text[index];

            text.RemoveAt(index);
        }

        Console.WriteLine(result);
    }

    static int SumDigits(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }
}