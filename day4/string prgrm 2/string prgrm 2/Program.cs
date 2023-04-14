//Write a program in C# Sharp to compare two string without using string library function

using System;


namespace string_prgrm_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string");
            string x = Console.ReadLine();
            Console.WriteLine("Enter the second string");
            string y = Console.ReadLine();
            int r = 0;

           int a = (x.Length);
            int b = (y.Length);
            if (a == b)
            {
                for (int i = 0; i < a; i++)
                {
                    if (x[i] == y[i])
                    {
                         r++;
                    }
                    else
                    {
                       r = 0; 
                    }


                }
                
            
            }
            else
            {
                Console.WriteLine("string  doesn't have  same length");
            }


            if (r==0)
            {
                Console.WriteLine("String having same length but not same word");
            }
            else
            {
                Console.WriteLine("string having same length and  it is the same word");
            }

        }

        

            
     }
}




    
