using System;

namespace decimaltobinary
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string answer, result;

            Console.WriteLine("Enter a number");
            answer = Console.ReadLine();

            int num=int.Parse(answer);
            result = "";
            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;

                num /= 2;
            }




            result = Convert.ToString(num) + result;

            Console.WriteLine("Binary   {0} ", result);

                Console.ReadKey();
            
            
            }
                




        }
    }

