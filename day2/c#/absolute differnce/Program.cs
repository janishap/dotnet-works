


using System;

namespace absolute_differnce
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double n , b=51, diffrence ;
            Console.WriteLine("Enter the number:");
            n= double.Parse(Console.ReadLine());
            diffrence = absolute(n, b);
            Console.WriteLine("triple of absolute differnce is :{0} ", diffrence);



        }

        static double absolute(double n, double b)
        {
          if(n>b)
            {
                double answer = (n - b) * 3;
                return answer;
            }
            else
            {
               double Value = b - n;
                return Value;
            }
            
        
        
        }
    }
}
