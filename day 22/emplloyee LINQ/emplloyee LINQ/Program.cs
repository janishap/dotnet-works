using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace emplloyee_LINQ
{


    internal class Program
    {
        static void Main(string[] args)
        {

            List<Employee> list = new List<Employee>();
            list.Add(new Employee("keerthana", "kerala"));
            list.Add(new Employee("Janisha", "banglore"));
            list.Add(new Employee("varsha", "karnatka"));
             list.Add(new Employee("uthara", "chennai"));


            var lquery =
               from Employee empl in list
               orderby empl._city
               group empl by empl._city;


            foreach (var f in lquery)
            {
               Console.WriteLine("Employee with " +f.Key+ "City");

                foreach (var e in f)
                {
                    Console.WriteLine(e._name);
                }
            }











        }
    }
}
