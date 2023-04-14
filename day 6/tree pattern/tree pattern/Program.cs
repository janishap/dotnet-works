using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {


            for(int i = 0; i <6;i++)
            {
                for(int j=0; j<i;j++)

                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int k = 0; k < 6; k++)
            {
                for (int l = 0; l <= 6 - k; l++)

                {
                    Console.WriteLine(" ");


                    for (int m = 1; m <= k; m++)
                    {
                        Console.Write("*");
                    }
                }
                
                Console.WriteLine(" ");
            }
        }
    }
}
