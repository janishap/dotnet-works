using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            member mr=new member();
            try { 
                //List<member> li=new List<member>();
                int num = 0;
                Console.WriteLine("Enter the number of Members:");
                num = int.Parse(Console.ReadLine());
                ArrayList al = new ArrayList();

                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("Enter the member {0} details:", i + 1);
                    string[] s = Console.ReadLine().Split(',');

                    member m1 = new member(long.Parse(s[0]), s[1], s[2], s[3], s[4], s[5], DateTime.ParseExact(s[6], "dd-mm-yyyy", null), DateTime.ParseExact(s[7], "dd-mm-yyyy", null));
                    al.Add(m1);

                }


                Console.WriteLine();
                int j = 1;
                foreach (var i in al)
                {
                    Console.WriteLine("member {0} :", j);
                    Console.WriteLine(i.ToString());
                    j++;
                }
                foreach (member m in al)
                {

                    if (!member.Display(m.Email))
                    {
                        throw new InvalidEmailException("InvalidEmailException: Invalid Email for the use");
                    }
                }

            }
            catch (InvalidEmailException e)
            {
                Console.WriteLine(e.Message);
            }




           
        }
    }
}
