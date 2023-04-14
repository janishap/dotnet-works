using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace note_program
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount : ");
            int num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                int note1 = num / 2000;
                num = num % 2000;
                int note2 = num / 500;
                num = num % 500;
                int note3 = num / 200;
                num = num % 200;
                int note4 = num / 100;
                num = num % 100;
                int note5 = num/ 50;
                num = num % 50;
                int note6 = num /20;
                num = num % 20;
                int note7 = num / 10;
                num = num % 10;
                int note8 = num / 5;
                num = num % 5;


                Console.WriteLine(note1+ "   2000 notes");
                Console.WriteLine(note2 + "   500 notes");
                Console.WriteLine(note3 + "   200 notes");
                Console.WriteLine(note4 + "   100 notes");
                Console.WriteLine(note5 + "   50 notes");
                Console.WriteLine(note6 + "   20 notes"); 
                Console.WriteLine(note7 + "   10 notes");
                Console.WriteLine(note8 + "   5 notes");





            }


           

           
        }
    }
}
