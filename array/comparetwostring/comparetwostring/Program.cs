//Write a program in C# Sharp to compare two strings without using a string library


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparetwostring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entre the first string");
            string name1=Console.ReadLine();

            Console.WriteLine("Enter the second string");

            string name2=Console.ReadLine();
            int count = 0;
            

            if (name1.Length == name2.Length) 
           
            {
                for (int i = 0; i < name1.Length; i++)
                {

                    if (name1[i] == name2[i])
                    {
                        count++;
                        
                        
                    }
                    //else
                    //{
                     
                    //    Console.WriteLine("two strings are of same length but it is  different");
                    //    break;

                    //}
                }

            }
            else
            {
                Console.WriteLine("two string are of different length");
            }
            if(count==name2.Length)
            {
                Console.WriteLine("two strings are same");
            }
            else
            {
                Console.WriteLine("two strings are of same length but it is  different");
            }
        }
    }
}
