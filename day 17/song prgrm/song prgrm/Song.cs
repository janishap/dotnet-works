using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace song_prgrm
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

        public override string ToString()
        {
            return string.Format("Name: {0}\n Artist:{1}\n SongType:{2}\n Rating:{3}\n NumberOfDownloads:{4}\n Dateofdownloaded:{5}\n", _name, _artist, _songType, _rating, _numberOfDownloads, _dateDownloaded);
        }
        public override bool Equals(object obj)
        {
            Song sn = obj as Song;

            if(sn._name==_name && sn._artist==_artist && sn._songType==_songType)

            { return true; }

            else
            {
                return false;
            }

           
            //this.Equals(obj as Song);
            //return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
}
