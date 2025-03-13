//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("metni daxil edin:");
//        string text = Console.ReadLine();
//        string reversedtext = ReverseText(text);
//        Console.WriteLine($"tersine cevrilmis metn:{reversedtext}");
//    }
//    static string ReverseText(string input)
//    {
//        string reverse = "";

//        for (int i = input.Length - 1; i >= 0; i--)
//        {
//            reverse += input[i];

//        }
//        return reverse;
//    }
//}




using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("ay sayini daxil edin:");
        int ay = Convert.ToInt32(Console.ReadLine());
        string netice = AyVeIleCevir(ay);
        Console.WriteLine(netice);
    }

    static string AyVeIleCevir(int ay)
    {
        int il = ay / 12;
        int qaliqAy = ay % 12;
        string netice = il + "il" + qaliqAy + "ay";
        if (il>0 && qaliqAy>0)
        {
            return netice;
        }
        else if(il>0)
        {
            return il+"il" ;
        }
        else
        {
            return  ay+"ay";
        }
    }
}