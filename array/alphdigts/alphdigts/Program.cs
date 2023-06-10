
//Write a program in C# Sharp to count the number of alphabets, digits and special characters in a string.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alphdigts
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the elements");
            string senetence = Console.ReadLine();
            int alph = 0;
            int digit = 0;
            int spclch = 0;
            for (int i = 0; i < senetence.Length; i++) 
            {

                if ((senetence[i] >= 'a' && senetence[i] <= 'z') || (senetence[i] >= 'A' && senetence[i] <= 'Z')) 
                {
                    alph++;
                }
               else if (senetence[i] >= '0' && senetence[i]<='9' )
                {
                    digit++;
                }
                else
                {
                    spclch++;
                }
            
                        
                        
            }
            Console.WriteLine("no of alpabhets in the senetence " + alph);
            Console.WriteLine("no of digits " + digit);
            Console.WriteLine("no of special character " + spclch);
        }
    }
}
