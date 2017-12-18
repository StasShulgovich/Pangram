using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangram
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT */
            //"We promptly judge dantique ivory buckles for the next prize";

            string input = Console.ReadLine();
            string myString = input.ToLower();          

            char[] MyChar = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
                'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            List<char> list = new List<char>();          

            foreach (var item in myString)
            {
                foreach (var item2 in MyChar)
                {
                    if (item != item2)
                    {
                        continue;
                    }
                    else
                    {
                        list.Add(item2);                       
                    }
                }
            }
            var distinct = list.Distinct().ToList();         
            
            string result = (distinct.Count == 26) ? "pangram" : "not pangram";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
