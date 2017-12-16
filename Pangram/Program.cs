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
            //"wepromptlyjudgedantiqueivorybucklesforthenextprie";

            string MyString = Console.ReadLine();

            char[] MyChar = { ' ','a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            string output = MyString;
            int count = 0;

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
                        output = output.Trim(item2);
                        count += 1;
                       
                    }
                }
            }
            if (output == String.Empty && count > 25)
            {
                Console.WriteLine("This is params");
            }
            else
            {
                Console.WriteLine("No params");
            }




            //if (alphabet.Count() == 0)
            //{
            //    Console.WriteLine("This is paragms");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}



            Console.ReadLine();
        }
    }
}
