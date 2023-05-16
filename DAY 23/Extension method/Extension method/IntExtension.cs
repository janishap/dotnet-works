using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_method
{
   public static class IntExtension
    {

        public static bool greaterthan(this int a, int value) 
        {
        return a > value;
        
        }
    }
}
