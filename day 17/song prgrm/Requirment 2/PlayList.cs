using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirment_2
{
    internal class PlayList
    {
        string _name;
        List<Song> _SongList;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public List<Song> SongList
        { get { return _SongList; }
            set { _SongList = value; }  
          
        }

        public PlayList() 
        
        { 
        
        }

        public PlayList(string name, List<Song> songList)
        {
            _name = name;
            _SongList = songList;
           
        }

        public void AddSongToPlaylist(Song song)
        {

            _SongList.Add(song);

        }

        public bool RemoveSongFromPlaylist(String name)
        {

            int count = 0;
            foreach(var item in _SongList) 
            
            {
                if (item.Name == name)

                {
                    _SongList.Remove(item);
                    count++;
                }
                
                
                
            }
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;   
            }
        }

        public void DisplaySongs()
        {
            Console.WriteLine("Songs in {0} \n  Name\tArtist\tSongType\tRating\t No of Download\t Date Downloaded",Name);

            foreach(var song in _SongList) 
            
            {
            Console.WriteLine($"{song.Name} {song.Artist} {song.SongType}{song.Rating }{song.NumberOfDownloads}{song.DateDownloaded}");
            }



        }


    }
}
