using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    class Program
    {
        public static int HammingDistance(string str1, string str2)
        {
            int count = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    count++;
                }
            }
            return count;
        }
        public static void Main(string[] args)
        {
            String str1 = "PatrickNg";
            String str2 = "gNkcirtaP";
            Console.WriteLine("This program calculates the Hamming Distance between two strings.\n");
            Console.WriteLine("The Hamming Distance is the number of different symbols\n of characters" +
                " between two strings.\n");
            Console.WriteLine("The Hamming Distance of given strings is: " + HammingDistance(str1, str2));
        }
    }
}
