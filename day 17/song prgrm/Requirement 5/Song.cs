using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement_5
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

            public Song(string name, string artist, string songType, DateTime dateDownloaded, double
    rating, int numberOfDownloads)
            {
                _name = name;
                _artist = artist;
                _songType = songType;
                _rating = rating;
                _numberOfDownloads = numberOfDownloads;
                _dateDownloaded = dateDownloaded;


            }


       public static SortedDictionary<string, int> CalculateTypeCount(List<Song> list)
        {

            SortedDictionary<string, int> sd = new SortedDictionary<string, int>();

           foreach(var item in list)
            {
                if(sd.ContainsKey(item._songType))
                {
                    sd[item._songType]++;
                }
                else
                {
                    sd.Add(item._songType, 1);
                }
            }


            return sd;

        }

        }
}
