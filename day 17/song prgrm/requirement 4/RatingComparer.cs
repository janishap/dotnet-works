using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace requirement_4
{
    internal class RatingComparer
    {

        public class RatingComparer : IComparer<Song>

        {

            int IComparer<Song>.Compare(Song x, Song y)

            {

                return y.Rating.CompareTo(x.Rating);

            }

        }

    }
}

