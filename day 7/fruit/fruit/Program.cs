using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            orange o1 = new orange(101,"nagpur orange","mumbai");
            o1.display();
        }
    }

    public class fruit
    {
        int fruitId;
        string fruitName;


        public int FruitId
        {
            get { return fruitId; }

            set { if (fruitId != 0) fruitId = value;

                else Console.WriteLine("invalid id");

            }
        }

        public string FruitName

        {
            get { return fruitName; }

            set { if(fruitName != null) fruitName = value;
            else { Console.WriteLine("invalid name"); }
            }
                    
        }
        public fruit()
        {

        }


        public fruit(int  id,string name) 
        { 
        fruitId= id;
           fruitName= name;
        
        }
        public void display ()
        {
            Console.WriteLine("fruit no:" + fruitId);
            Console.WriteLine("fruit name:" + fruitName);
        }

       
    }


    public class orange : fruit 
    {

        string orgin;

        static string[] places = { "tamilnadu", "mumbai", "thelungana" };
        public string Orgin
        {
            get { return orgin; }
            set
            {

                if (Array.BinarySearch(places, value) >= 0) orgin = value;
                else Console.WriteLine("Invalid");
            }
        }
        public  orange()
        {

        }
        public orange(int id,string name,string Orgin):base (id,name)
        {
            orgin =Orgin;
        }
        public new void  display()
        {
            base.display();
            Console.WriteLine("orgin of fruit : "+orgin);
        }

       
    
    
    }

    
}
