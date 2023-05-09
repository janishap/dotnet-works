using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Song> li = new List<Song>();
            Console.WriteLine("Enter the number of songs");

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] arr = Console.ReadLine().Split(',');

                Song s = new Song(arr[0], arr[1], arr[2], DateTime.ParseExact(arr[3],"dd-mm-yyyy",null), double.Parse(arr[4]), int.Parse(arr[5]));

                li.Add(s);
            }

            SortedDictionary<string, int> sdl=new SortedDictionary<string, int>();

            sdl = Song.CalculateTypeCount(li);

            Console.WriteLine("SongType \t Count");

            foreach (var item  in sdl)
            {
                Console.WriteLine(item.Key + "\t\t" + item.Value);    
            }
            
            
        
        }

            
       



        }
    }

