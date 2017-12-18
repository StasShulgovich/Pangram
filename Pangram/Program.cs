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
            //"wepromptlyjudgedantiqueivorybucklesforthenextprize";

            string MyString = Console.ReadLine();

            char[] MyChar = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            List<char> list = new List<char>();          

            foreach (var item in MyString)
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
           
            Console.WriteLine();
            if (distinct.Count == 26)
            {
                Console.WriteLine("This is paragms");
            }
            else
            {
                Console.WriteLine("This is not paragms");
            }         
            
            Console.ReadLine();
        }
    }
}
