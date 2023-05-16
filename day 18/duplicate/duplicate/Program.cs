using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 2, 1, 5, };
            int[] dupl=arr.Distinct().ToArray();
            foreach(int i in dupl)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
