using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Figure fig = new Square();
            fig.dimension = 10;

        Console.WriteLine(fig.Area());
            Console.WriteLine(fig.Perimeter());
        }
    }

    abstract class Figure
    {
        public int dimension;
            public abstract double  Area();
        public abstract double Perimeter();    

    }

    class Square :Figure
    {
        public override double Area()
        {
            return dimension * dimension;
        }
        public override double Perimeter() 
        {
            return 4* dimension;
           
        }
    }


    class circle : Figure
    {
        public override double Area ()
        {
            return Math.PI * dimension * dimension;
        }

        public override double perimeter()
        {
            return 2*Math.PI * dimension;
        }
    }
}
