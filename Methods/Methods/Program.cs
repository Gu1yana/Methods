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




//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("ay sayini daxil edin:");
//        int ay = Convert.ToInt32(Console.ReadLine());
//        string netice = AyVeIleCevir(ay);
//        Console.WriteLine(netice);
//    }

//    static string AyVeIleCevir(int ay)
//    {
//        int il = ay / 12;
//        int qaliqAy = ay % 12;
//        string netice = il + "il" + qaliqAy + "ay";
//        if (il>0 && qaliqAy>0)
//        {
//            return netice;
//        }
//        else if(il>0)
//        {
//            return il+"il" ;
//        }
//        else
//        {
//            return  ay+"ay";
//        }
//    }
//}


using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("ededi daxil edin:");
        int eded = Convert.ToInt32(Console.ReadLine());
        int netice = FaktoriyalTap(eded);
        Console.WriteLine("daxil etdiyiniz ededin faktoriyali:");
        Console.WriteLine(netice);
    }
    static int FaktoriyalTap(int eded)
    {
        int hasil = 1;

        for (int i = 1; i <= eded; i++)
        {
            hasil *= i;

        }
        return hasil;
    }
}