using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stream_writer_and_stream_reader
{
    internal class Program
    {
        static string file = "D:\\c#\\day13\\stream writer and stream reader";
        static void Main(string[] args)
        {
            Write();
            Read();

        }
        static void write()
        {
            StreamWriter fileStream= new StreamWriter(file);    
            fileStream.WriteLine("what is this life is")
        }
    }
}
