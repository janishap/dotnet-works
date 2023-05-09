using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement_3
{
    internal class Classrepo
    {
        static List<Song> songs = new List<Song>

        {


            new Song("Shape of you" , "Edsheeran" ,"Pop" ,4.8,12000,DateTime.Parse("12-04-2017")),
            new Song("Perfect", "Edsheeran" ,"Pop",4.5,120500,DateTime.Parse("06-08-2017")),
            new Song("Mercy" ,"Shawn Mendes" ,"Jazz" ,4.6,50000,DateTime.Parse("03-09-2016"))

        };
        public static List<Song> Getallsong()
        {
            return songs;
        }

        
    }
}
