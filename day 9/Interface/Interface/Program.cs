using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Ifigure fig = null;
           Console.WriteLine("Enter 'C' for Circle or 'S' for Square");
            string ch=Console.ReadLine();
            if (ch == "S")
                fig = new Square();
            else if (ch == "C")
                fig = new circle();
            fig.Dimension = 10;
            Console.WriteLine(fig.Area());
            Console.WriteLine(fig.Perimeter());


               

        
        
        
        
        
        }
    }

    interface Ifigure
    {
        int Dimension { get; set; }
        double Area();
        double Perimeter();
    }

    class circle : Ifigure
    {
        private int Radius;
        public int Dimension
        {
            get { return Radius; }
            set { Radius = value; }
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;


        }
        public double Perimeter()
        {
            return 2 * Math.PI * Radius;

        }
    }

    class Square :Ifigure
    { 

    private int Radius;

    public int Dimension
        {
            get { return Radius; }      
            set { Radius = value; }
        }

        public double Area()
        {
            return Radius * Radius;
            
        }
        public double Perimeter()
        {
            return 4* Radius;
        }
    
    }
}
