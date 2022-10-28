using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searchMethod
{
    class Program
    {
        int[] arr = new int[20];
        int n;
        int i;

        void input()
        {
            while (true)
            {
                Console.Write("Enter the number of element in the array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                {
                    Console.WriteLine("");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("Masukan elemen array");
                    Console.WriteLine("----------------------------");

                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("<" + (i + 1) + "> ");
                        string s1 = Console.ReadLine();
                        arr[i] = Int32.Parse(s1);
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("\nArray should have minimum 1 and maximum 20 elements \n");
                }


            }
        }
        static void Main(string[] args)
        {
        }
    }
}
