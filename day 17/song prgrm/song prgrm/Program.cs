using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace song_prgrm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> list = new List<Song>();

            
                Console.WriteLine("Enter song 1 detail: ");

                string[] song1 = Console.ReadLine().Split(',');

                Song s1 = new Song(song1[0], song1[1], song1[2], double.Parse(song1[3]), int.Parse(song1[4]), DateTime.ParseExact(song1[5], "dd-mm-yyyy", null));
                list.Add(s1);

             Console.WriteLine("Enter song 2 detail:");
             string[] song2 = Console.ReadLine().Split(',');
             Song s2 = new Song(song2[0], song2[1], song2[2], double.Parse(song2[3]), int.Parse(song2[4]), DateTime.ParseExact(song2[5], "dd-mm-yyyy", null));
             list.Add(s2);

            Console.WriteLine("Song 1:\n"+s1);
            Console.WriteLine("Song 2:\n"+s2); 

            //foreach(Song s in list)

            //{
            //    Console.WriteLine(s);
            //}

            if (list[0].Equals(list[1]))
            {
                Console.WriteLine("Song 1 is same as Song 2");
            }
            else
            {
                Console.WriteLine("Song 1 and Song 2 are different");
            }

            


        }
    }
}
