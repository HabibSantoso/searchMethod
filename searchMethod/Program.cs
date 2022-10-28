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

        public void input()
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

        public void BinarySearch()
        {
            char ch;
            do
            {
                Console.Write("\nEnter element want you to search : ");
                int item = Convert.ToInt32(Console.ReadLine());

                int lowerbound = 0;
                int upperbound = n - 1;

                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                while ((item != arr[mid]) && (lowerbound <= upperbound))
                {
                    if (item > arr[mid])
                    {
                        lowerbound = mid + 1;
                    }
                    else
                    {
                        upperbound = mid - 1;
                    }

                }
                if (item == arr[mid])
                {
                    Console.WriteLine("\n" + item.ToString() + " found at position " + (mid + 1).ToString());
                }
                else
                {
                    Console.WriteLine("\n" + item.ToString() + " not found in the array\n");
                }
                Console.WriteLine("\nNumber of comparation : " + ctr);

                Console.Write("\nContinue search (y/n): ");
                ch = char.Parse(Console.ReadLine());
            } while ((ch == 'y') || (ch == 'Y'));
        }

        public void LinearSearch()
        {
            char ch;
            int ctr;
            do
            {
                Console.Write("\nEnter element want you to search : ");
                int item = Convert.ToInt32(Console.ReadLine());

                ctr = 0;
                for (i = 0; i < n; i++)
                {
                    ctr++;
                    if (arr[i] == item)
                    {
                        Console.WriteLine("\n" + item.ToString() + " found at position " + (i + 1).ToString());
                        break;
                    }
                }
                if (i == n)
                {
                    Console.WriteLine("\n" + item.ToString() + " not found in the array\n"); 
                }
                Console.WriteLine("\nNumber of comparation : " + ctr);

                Console.Write("\nContinue search (y/n): ");
                ch = char.Parse(Console.ReadLine());
            } while ((ch == 'y') || (ch == 'Y'));
        }


        static void Main(string[] args)
        {
            Program myList = new Program();
            int pilihanmenu;
            char ch;

            Console.WriteLine("Menu OPtion");
            Console.WriteLine("================");
            Console.WriteLine("1. Linear Search");
            Console.WriteLine("2. Binary search");
            Console.WriteLine(" Enter your choice (1,2,3) : ");
            pilihanmenu = Convert.ToInt32(Console.ReadLine());

            switch (pilihanmenu)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Linear Search");
                    Console.WriteLine("-----------------");
                    myList.input();
                    myList.LinearSearch();
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Binary search");
                    Console.WriteLine("-----------------");
                    myList.input();
                    myList.BinarySearch();
                    break;
                case 3:
                    break;
                default:
                    break;

            }
        }
    }
}
