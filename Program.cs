using System;

namespace dotNET_1
{
    class Program
    {
        static void Main(string[] args)
        {   
            int? a = 5;  //value type
            string b = "5";//reference type
            int c = Convert.ToInt32(b);
            Console.WriteLine("Exemplu conversie explicita - unboxing" + c);
            int x = 6;
            long d = x;
            Console.WriteLine("Exemplu conversie implicita - boxing " + d);
            b = null;
            a = null;
            Console.WriteLine("Exemplu nullable string vs int " + b + " " + a);
        }
    }
}
