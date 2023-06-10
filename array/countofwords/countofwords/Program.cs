using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countofwords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENter the string");
                string sentnce = Console.ReadLine();
            string[] value = sentnce.Split(' ', '.','\t');
            int count = 0; 
            foreach(string s in value)
            {
                count++;
            }
            Console.WriteLine(count);
            
          



;        }


    }
}
