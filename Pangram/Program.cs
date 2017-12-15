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
                      
            
            Console.WriteLine(userInput);
                      
                foreach (var item in userInput)
                {                   
                    foreach (var item2 in alphabet)
                    {
                    alphabet.ToCharArray();
                        if (item != item2)
                        {
                        continue;
                        }
                         else
                         {
                        //alphabet.Remove(item2);                  
                        break;
                          }                    
                    }
                }
            if (alphabet.Count()==0)
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
