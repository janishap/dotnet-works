//print mulitplication table


using System;


namespace basic_program_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter the number:");
            int num = int.Parse(Console.ReadLine());

            for(int i=0; i<=10; i++)
            {
                int mul = num * i;
                Console.WriteLine("{0}*{1} = {2} ", num, i, mul);
            }
       
           
        }
    }
}
