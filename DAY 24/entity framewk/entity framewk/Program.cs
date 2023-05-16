using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_framewk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INSERT


            //using (var context = new Assignment1Entities())
            //{
            //    var std = new client_master()
            //    {
            //        NAME = "Bill",
            //        CITY = "Gates",
            //        CLIENTNO = "C10009",
            //        ADDRESS1 = null,
            //        ADDRESS2 = null,
            //        STATE = "GUJARAT",
            //        BALDUE = 1300000,
            //        Phone_no = null,

            //    };
            //    context.client_master.Add(std);

            //    context.SaveChanges();
            //}



            //UPDATE
            //using (var context = new Assignment1Entities())

            //{
            //    var CTD = context.client_master.First<client_master>();
            //    CTD.NAME = "Steve";
            //    context.SaveChanges();
            //}


            //DELETE
            using (var context = new Assignment1Entities())
            {
                var xtd = context.client_master.Where(S=>S.CLIENTNO == "C00002").First<client_master>();
                    context.client_master.Remove(xtd);
                    context.SaveChanges();
            }
            }
        }
    }

