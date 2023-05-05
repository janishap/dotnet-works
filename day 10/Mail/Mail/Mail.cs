using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mail
{
   public class Mail
    {
       private long _id;
       private string _to;
       private  string _from;
       private  string _subject;
       private string _content;
       private DateTime _receivedDate;
       private double _size;

        public long Id
        {
            get { return _id; }
            set { _id = value; }    
        }
        public string To
        {
            get { return _to; }
            set { _to = value; }
        }
        public string From
        {
            get { return _from; }   
            set { _from = value; }
        }
        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        public DateTime ReceivedDate
        {
            get { return _receivedDate; }
            set { _receivedDate = value; }
        } 
        public double Size
        {
            get { return _size;}    
            set { _size = value; }
        }

        public Mail() 
        {
        
        
        }
        public Mail(long id,string to,string from,string subject,string content, DateTime receivedDate,double size)
        {
            _id = id;
            _to = to;
            _from = from;
            _subject = subject;
            _content = content;      
            _receivedDate = receivedDate;
            _size = size;

        }
        public override string ToString()
        {

            return string.Format("Id: {0}\n To:{1}\n From:{2}\nSubject:{3}\nContent:{4}\nReceivedDate:{5}\n Size:{6}\n", Id, To, From, Subject, Content, ReceivedDate.ToString("dd-mm-yyyy", null), Size.ToString("0.0"));


        }    
            
            public override bool Equals(object obj)
        {
            Mail m1 = obj as Mail;
            if (m1.To == To && m1.From == From && m1.Subject == Subject)
            {

                return true;
            }


            else
            {
                return false;
            }
        }
       public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }


     

 }

