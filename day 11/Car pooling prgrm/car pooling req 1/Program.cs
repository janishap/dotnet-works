using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_pooling_req_1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Console.WriteLine("Member 1:");


            List<member> li = new List<member>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Member: {0}", i + 1);
                Console.WriteLine("Id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("First name");
                string firstname = Console.ReadLine();
                Console.WriteLine("last name");
                string lastname = Console.ReadLine();
                Console.WriteLine("email");
                string email = Console.ReadLine();
                Console.WriteLine("contact number");
                string contactnumber = Console.ReadLine();
                Console.WriteLine("License number");
                string licensenumber = Console.ReadLine();
                Console.WriteLine("license start date");
                DateTime licensestart = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("License end date");
                DateTime licenseend = DateTime.Parse(Console.ReadLine());
                member mr = new member(id, firstname, lastname, email, contactnumber, licensenumber, licensestart, licenseend);
                li.Add(mr);
            }
                //string[] s = Console.ReadLine().Split(',');

                //   member mb = new member(long.Parse(s[0]), s[1], s[2], s[3], s[4], s[5], DateTime.ParseExact(s[6], "dd-mm-yyyy", null), DateTime.ParseExact(s[7], "dd-mm-yyyy", null));
                ////    //li.Add(mb);

                // Console.WriteLine(mr);


                //Console.WriteLine("Member 2:");
                //string[] s2 = Console.ReadLine().Split(',');

                //member mr = new member(long.Parse(s2[0]), s2[1], s2[2], s2[3], s2[4], s2[5], DateTime.ParseExact(s2[6], "dd-mm-yyyy", null), DateTime.ParseExact(s2[7], "dd-mm-yyyy", null));


                //Console.WriteLine(mr);





                //}

                    int j = 1;

                foreach (member item in li)

                {
                    Console.WriteLine(item.ToString());
                j++;
                
                }

                if (li[0].Equals(li[1]))
                {
                    Console.WriteLine("Member 1 is same as Member 2");
                }
                else
                {
                    Console.WriteLine("Member 1 and Member 2 are different");
                }



                //Console.WriteLine("First name {0}\n,last name{1}\n email{2}\n contact number{3}\n license number{4}\n license start date:{5}\n" +
                //    " license  expiry date{6}\n, _firstname, _lastname, _email, _contact,_licenseNumber,_licenseStartDate _licenseExpiryDate");





            }


        }
    }


