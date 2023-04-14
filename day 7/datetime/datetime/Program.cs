using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime Currentdate=DateTime.Now;

            Console.WriteLine(Currentdate);

            DateTime d1 = new DateTime(2000, 4 ,30);
            Console.WriteLine(d1);

            DateTime today = DateTime.Today;
            Console.WriteLine(today);


            DateTime d2 = new DateTime();
                Console.WriteLine(d2);


            DateTime maxvalue= DateTime.MaxValue;
            Console.WriteLine(maxvalue);


            DateTime minvalue= DateTime.MinValue;
            Console.WriteLine(minvalue);

        }
    }
}
