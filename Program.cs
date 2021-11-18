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
            Console.WriteLine("Introduceti n:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr); 
            Console.WriteLine("Sirul introdus este:");
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
            int[] copyArr = (int[])arr.Clone();
            Console.WriteLine("Sirul copiat e:");
            foreach(int elem in copyArr)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
