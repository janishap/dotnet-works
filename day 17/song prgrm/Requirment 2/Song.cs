using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirment_2
{
    internal class Song
    {

        string _name;
        string _artist;
        string _songType;
        double _rating;
        int _numberOfDownloads;
        DateTime _dateDownloaded;

        public string Name
        { get { return _name; } set { _name = value; } }

        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }


        }
        public string SongType
        {
            get { return _songType; }
            set { _songType = value; }
        }
        public double Rating
        { get { return _rating; } set { _rating = value; } }

        public int NumberOfDownloads
        {
            get { return _numberOfDownloads; }
            set
            {
                _numberOfDownloads = value;
            }
        }
        public DateTime DateDownloaded
        {
            get { return _dateDownloaded; }
            set
            {
                _dateDownloaded = value;
            }
        }

        public Song()
        { }

        public Song(string name, string artist, string songType, double
rating, int numberOfDownloads, DateTime dateDownloaded)
        {
            _name = name;
            _artist = artist;
            _songType = songType;
            _rating = rating;
            _numberOfDownloads = numberOfDownloads;
            _dateDownloaded = dateDownloaded;


        }
        public static Song CreateSong(string song)
        { 
               
                string[] arr = song.Split(',');
                Song s = new Song(arr[0], arr[1], arr[2], double.Parse(arr[3]), int.Parse(arr[4]), DateTime.Parse(arr[5]));

                return s;

        }
       



    }
}

