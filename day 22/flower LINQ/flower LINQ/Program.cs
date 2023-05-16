using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flower_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] flowers = { "dalia", "rose", "lotus", "lilly", "hibiscus", "daffodil" };

            //var fquery =
            //    from flow in flowers
            //    where flow.StartsWith("d")
            //    select flow;
            //foreach( string f in fquery)
            //{
            //    Console.WriteLine(f);     
            //}

            var lquery= from flow in flowers
                        let len =flow.Length
                        where len >3 && len<5
                        select flow;

            foreach( var f in lquery)
            {
                Console.WriteLine(f);
            }
        }
    }
}
