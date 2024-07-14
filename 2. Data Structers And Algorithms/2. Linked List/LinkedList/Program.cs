using list.LinkedList.Double;

using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Int32.Parse(Console.ReadLine());
            int[] a = new int[n];
            for(int i = 0;i < n;i++)
            {
                a[i] = Int32.Parse(Console.ReadLine()); 
            }
            int[] k = new int[n];
            k[0] = 0;
            for(int i = 1;i < n;i++)
            {
                for(int j = i-1;j >= 0; j--)
                {
                    if (a[j] > a[i]) k[i]++;
                }
            }
            for(int i = 0;i < n;i++)
            {
                Console.Write(k[i] + " ");
            }
        }
    }
}
