
//Write a C# program to create a new string from a given string where the first and last characters will change their positions


using System;

namespace acscending_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string name = Console.ReadLine();
            Console.WriteLine("before rversing first and last letter :" + name);

            string value= name.Substring(name.Length-1)+name.Substring(1,name.Length-2)+name.Substring(0,1);
            Console.WriteLine("AFTER RVERSING first and letter  is : " + value);

         
   }
    }
}
