using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mail_2_req
{


    internal class MailFolder
    {

        private string _name;
        private List<Mail> _MailList;

        public string Name

        {
            get { return _name; }
            set { _name = value; }


        }
        public List<Mail> MailList
        {
            get { return _MailList; }
            set { _MailList = value; }
        }

        public MailFolder()

        { }

        public MailFolder(string name, List<Mail> mailist)
        {
            _name = name;
            _MailList = mailist;
        }
        public void AddMailToFolder(Mail mail)
        {
            _MailList.Add(mail);
            Console.WriteLine("Mail successfully added");
        }
        public bool RemoveMailFromFolder(long id)
        {

            int count = 0;
            foreach (var item in _MailList)
            {

                if (item.Id == id)
                {
                    _MailList.Remove(item);
                    count = 1;
                    break;

                }
            }

                if (count == 1)
                {
                Console.WriteLine("Mail successfully deleted");
                    return true;
                }
                else
                {

                Console.WriteLine("Mail not found in the folder");
                    return false;
                }

            
        }
        public void DisplayMails()
        {

            Console.WriteLine();
            if (_MailList.Count == 0)

            {
                Console.WriteLine("No Mails to show");
            }
            else
            {
                Console.WriteLine("Mail in {0}\n", _MailList);
                Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15} {5,15} {6,15}", "Id", "From", "To", "Subject", "Content", "Received Date", "Size");
              
                
                foreach (Mail mail in _MailList)
                {
                    Console.WriteLine(mail);
                }

            }

        }


    }
}

