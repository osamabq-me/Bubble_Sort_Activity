using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort_Activity
{
    class Program
    {
        private int[] a = new int[20];

        private int n;

        public void read()
        {
            while (true)
            {
                Console.Write(" Enter your wanted number pf elements");
                String s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("the maximam number of element is 20.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Enter elements to the array");
            Console.WriteLine("---------------------------");

            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }

        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Arrenged array Elements");
            Console.WriteLine("---------------------------");
            for(int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }

        public void BubblesortArray()
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp;
                        temp = a[j];
                        a[j] = a[j +1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
