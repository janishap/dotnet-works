using System;

namespace circle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 0.0, area;

            Console.WriteLine("Enter the radius:");
            radius = double.Parse(Console.ReadLine());
            area= calcarea(radius);
            Console.WriteLine("area of the circle having radius {0} is {1}",radius, area);
             
            
                
         }
       static double calcarea(double radius)
        {
            double a = 3.14 * radius * radius;
            return a;
            }
    }
}
