using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement_3
{
    internal class Song
    {
        string _name;
        string _artist;
        string _songType;
        double _rating;
        int _numberOfDownloads;
        DateTime _datetimeDownloaded;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Artist
        {

            get { return _artist; }

            set { _artist = value; }

        }
        public double Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }

        public int NumberOfDownloads
        {
            get { return _numberOfDownloads; }
            set
            {
                _numberOfDownloads = value;
            }
        }
        public DateTime DateTimeDownloaded
        {
            get { return _datetimeDownloaded; }
            set
            {
                _datetimeDownloaded = value;
            }
        }

        public Song()
        {

        }
        public Song(string name, string artist, string songType, double rating, int numberofdownloads, DateTime datedownloaded)
        {
            _name = name;
            _artist = artist;
            _songType = songType;
            _rating = rating;
            _numberOfDownloads = numberofdownloads;
            _datetimeDownloaded = datedownloaded;

        }

        //public List<Song> songs = new List<Song> 

        //{
        //    new Song() 

        //};

        public override string ToString()
        {
            return string.Format("name:{0}\n  artist: {1}\n  songtype:{2}\n rating:{3}\n" , _name ,_artist,_songType,_rating);
        }


    }
}
