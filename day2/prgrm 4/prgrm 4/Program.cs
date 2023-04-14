//Write a C# Sharp program to convert from celsius degrees to Kelvin and Fahrenheit.
//kelvin = celsius + 273
//fahrenheit = celsius x 18 / 10 + 32


using System;


namespace prgrm_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter the celcius:");
            int celcius = int.Parse(Console.ReadLine());
            int kelvin = celcius + 273;
            int fh = celcius * 18 / 10+32;
            Console.WriteLine("celcius  is" + celcius);
            Console.WriteLine("kelvin of this celcius is : "+kelvin);
            Console.WriteLine("farein heat of this celcius is : " + fh);

                
        }
    }
}
