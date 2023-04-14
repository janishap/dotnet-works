using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            shape s1 = new shape();
            s1.Drawshape();
            
            circle s2= new circle();
            s2.Drawshape();

            shape s3= new circle();
            s3.Drawshape();


            // array of refernces of base class containing 
            //dervide class object(upcasting)


            shape[] p =
            {
                new circle(),
                new Rectangle(),
                new circle(),
                new Rectangle(),
                new circle(),
            };


            for(int i =0; i < p.Length; i++)
            {
                p[i] = Drawshape();
            }

            shape t = null;
            Console.WriteLine("Enter a shape");

            string shape = Console.ReadLine();

            if(shape.ToLower() =="circle")
            {
                t = new circle();
            }
            else(shape.ToLower() =="rectangle")
            {
                t = new Rectangle();
            }
            

        }
    }

    
}
