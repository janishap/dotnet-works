using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace emplloyee_LINQ
{
    internal class Employee
    {
       


        public string _name;
        public string _city;

         public string Name { get; set; }
        public string City { get; set; }

        public Employee() { }   
        public Employee(string name, string city) 
        
        { 

            _name = name;
            _city = city;
        
        }
    
    }





}
   
