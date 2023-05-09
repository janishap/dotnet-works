using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement_3
{
    internal class  program
    {
        static void Main(string[] args)
        {
            List<Song> ls= Classrepo.Getallsong();
            foreach(Song s in ls) 
            {
                Console.WriteLine(s.ToString());
            }

        }
    }
}
