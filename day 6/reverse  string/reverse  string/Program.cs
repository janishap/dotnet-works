using System;

namespace reverse__string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string :");
            string name = Console.ReadLine();
            Console.WriteLine("string before reversing :  "+name);   
            
            string value= name.Substring(name.Length-1)+name.Substring(1,name.Length-2)+name.Substring(0,1);
            Console.WriteLine("after reversing : " + value);





        }
    }
}
