using System;

namespace speed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distance, time, speed,velocity;

            Console.WriteLine("Enter the distance:");
            distance = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the time:");
            time = double.Parse(Console.ReadLine());
            speed = calcspeed(distance, time);
            velocity = calcvelocity(distance, time);
            Console.WriteLine("speed in kilometre per hour is :"+ speed);
            Console.WriteLine("speed in  miles per hour is  "+ velocity);

        }

        static double calcspeed(double d,double t)
        {
            double kph = d/t;
            
            return kph;
               

        }
        static double calcvelocity(double d, double t)
        {
            double mph = (d / t) * 0.62;
           
            return mph;
        }
    }
}
