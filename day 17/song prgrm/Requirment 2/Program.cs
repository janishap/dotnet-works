using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Requirment_2
{
    internal class Program
    {
        static void Main(string[] args)
        { 
        
        do{

            Console.WriteLine("Enter PlayList Name");
            string PLname = Console.ReadLine();
            Console.WriteLine("1.Add song");
            Console.WriteLine("2.Remove Song");
            Console.WriteLine("3.Display");
            Console.WriteLine("4.Exit");
            Console.WriteLine("Enter your choice");
            int ch = int.Parse(Console.ReadLine());
                bool a = true;

                switch (ch)
                {
                    case 1:

                        Console.WriteLine("Enter number of songs");
                        int num = int.Parse(Console.ReadLine());
                        for (int i = 0; i < num; i++)
                        {
                            List<Song> list = new List<Song>();
                            Console.WriteLine("Enter song {0} details", i + 1);
                            string details = Console.ReadLine();
                            Song.CreateSong(details);

                        }
                        break;

                    case 2:

                        Console.WriteLine("Enter the song to be deleted");
                        string songname = Console.ReadLine();

                        PlayList pl = new PlayList();
                        bool a = pl.RemoveSongFromPlaylist(songname);
                        if (a)
                        {
                            Console.WriteLine("Song successfully deleted ");
                        }
                        else
                        {
                            Console.WriteLine("Song not deleted");
                        }
                        break;

                    case 3:


                        pl.DisplaySongs();


                        break;

                    case 4:
                        a = false;
                        break;
                }
         

         }
        while(a)
       
            
            
        }








            
           

              


        }
    }
}
