using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anuprblm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size");
            int size = int.Parse(Console.ReadLine());
            string[] arr = new string[size];
            Console.WriteLine("Enter the name");
            for(int i=0; i<size; i++)

            {
                arr[i] = Console.ReadLine();
            }

            for (int j = 0; j < arr.Length; j++)
                {

                Console.Write(arr[j] + arr[j+1]);
                break;

                
            }
            
          

        }
    }
}
