using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedlist
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SortedList s = new SortedList();
            {
                s.Add("Maharashtra ", "mumbai");
                s.Add("Karntaka", "Banglore");
                s.Add("Tamilnadu", "chennai");

                foreach(var item in s.Keys)
                {
                    Console.WriteLine(item);
                }
                foreach(var item in s.Values)
                {
                    Console.WriteLine(item);
                }
               
            }
        }
    }
}
