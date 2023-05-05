using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mail_2_req
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Mail> ls = new List< Mail > ();
            Console.WriteLine("Enter the name of the folder:");
            string name = Console.ReadLine();
            MailFolder mf= new MailFolder (name,ls);   
            Mail m = new Mail ();

            while (true) 
            
            
            {
                Console.WriteLine("1.Add mail\n 2.Delete Mail\n 3.Display Mail\n 4.Exit");
                Console.WriteLine("Enter your choice");
                int ch=int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:

                        Console.WriteLine("Enter the details of mail in CSV format:");
                        string[] s = Console.ReadLine().Split(',');
                        long _id = long.Parse(s[0]);
                        string _from = s[1];
                        string _to = s[2];
                        string _subject = s[3];
                        string _content = s[4];
                        DateTime _ReceivedDate = DateTime.Parse(s[5]);
                        double _size = double.Parse(s[6]);
                        Mail mail= new Mail (_id,_from,_to,_subject,_content,_ReceivedDate,_size);
                        mf.AddMailToFolder (mail);
                        break;


                   case 2:
                        Console.WriteLine("Enter the id of the mail to be deleted:");
                        long mailId = long.Parse(Console.ReadLine());
                        mf.RemoveMailFromFolder(mailId);
                        break;


                     case 3:
                        mf.DisplayMails();
                        break;


                     case 4:
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                      
                      

                }
            
            
            
            
            }


        }
    }

    
}
