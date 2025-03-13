using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("metni daxil edin:");
        string text = Console.ReadLine();
        string reversedtext = ReverseText(text);
        Console.WriteLine($"tersine cevrilmis metn:{reversedtext}");
    }
    static string ReverseText(string input)
    {
        string reverse = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reverse += input[i];
            
        }
        return reverse;
    }
}