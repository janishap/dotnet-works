using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telephone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectronicPhone myphone = new ElectronicPhone();
            myphone.Ring();
        }
    }

    public class Telephone
    {
        protected string phonetype;


        private int phoneno;

        public int Phoneno
        {
            get { return phoneno; }
            set { phoneno = value; }
        }





        public string Phonetype
        {
            get { return phonetype; } 
            set {  if(phonetype != null) phonetype = value; }
        }
        public Telephone()
        {

        }
        public Telephone(string Ponetype)
        {
            phonetype = Ponetype;
        }
        public void Ring()
        {
            Console.WriteLine("Ringing the {0}", phonetype);
        }


    }


    public class ElectronicPhone : Telephone
    {
        public ElectronicPhone():
        {
            phonetype = "Digital";
      }
    }
}
