using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combinestring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = { "hello", "janisha" };
            string []j = { "World" };
            string[] arr = s.Union(j).ToArray();
            foreach (string s2 in arr) 
            {
            Console.WriteLine(s2);
            }
        }
    }
}
