using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int k = 10;
                int i = 0;
                k = k / i;
                
            }
            catch
            {
                Console.WriteLine("Hello");
            }
        }
    }
}
