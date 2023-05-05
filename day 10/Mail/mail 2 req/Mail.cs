using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace mail_2_req
{
    
    
        class Mail
        {
            private long _id;
            private string _from;
            private string _to;
            private string _subject;
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
                get { return _size; }
                set { _size = value; }
            }


            public Mail()
            {


            }
            public Mail(long id, string to, string from, string subject, string content, DateTime receivedDate, double size)
            {
                _id = id;
                _to = to;
                _from = from;
                _subject = subject;
                _content = content;
                _receivedDate = receivedDate;
                _size = size;

            }

            public static Mail CreateMail(string detail)
            {

            string[]md= detail.Split(',');
            DateTime dt = DateTime.ParseExact(md[5], "dd-mm-yy", null);
            Mail ml = new Mail(long.Parse(md[0]),md[1],md[2],md[3],md[4],dt,double.Parse(md[6]));
            return ml;

            }
        public override string ToString()
        {
            return String.Format("{0} {1,15} {2,15} {3,15} {4,15} {5,15:dd-mm-yyyy} {6,15:0.0}", Id, From, To, Subject, Content, ReceivedDate, Size);
        }


    }
    
}
;