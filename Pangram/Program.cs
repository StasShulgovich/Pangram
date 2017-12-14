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
            //"Wepromptlyjudgedantiqueivorybucklesforthenextprize";
            
            string alphabet = "abcdefghijklmnopqrstuvwxyz";       

            string userInput = "Wepromptlyjudgedantiqueivorybucklesforthenextprize";
          

            int count = 0;
            
            Console.WriteLine(userInput);
                      
                foreach (var item in userInput)
                {                   
                    foreach (var item2 in alphabet)
                    {
                        if (item != item2)
                        {
                        continue;
                        }
                         else
                        {                        
                        
                        break;
                        }                    
                    }
                }
            if (count >= 26)
            {
                Console.WriteLine("This is paragms");
            }
            else
            {
                Console.WriteLine("No");
            }
                              
                


            Console.ReadLine();
        }
    }
}
