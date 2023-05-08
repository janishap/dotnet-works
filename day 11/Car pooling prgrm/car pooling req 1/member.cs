using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace car_pooling_req_1
{
    internal class member
    {


        long _id;
        string _firstName;
        string _lastName;
        string _email;
        string _contactNumber;
        string _licenseNumebr;
        DateTime _licenseStartDate;
        DateTime _licenseExpiryDate;

        public long Id 
        
        { 
            get { return _id; } 
            set { _id = value; } 
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
            }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string ContactNumber
        {
            get { return _contactNumber; }
            set { _contactNumber = value; }
        }
        public string LicenseNumebr
        {
            get { return _licenseNumebr; }
            set { _licenseNumebr = value; }
        }
        public DateTime LicenseStartDate
        {
            get { return _licenseStartDate; }
            set
            {
                _licenseStartDate = value;
            }
        }
        public DateTime LicenseExpiryDate
        {
            get { return _licenseExpiryDate; }
            set
            {
                _licenseExpiryDate = value;
            }
        }
        public  member()
        {

        }
        public member(long id,string fname,string lname,string Email ,string Contact,string linum,DateTime lstdate,DateTime lexdate)

        {
            _id = id;
             _firstName = fname;
            _lastName = lname;
            _email = Email;
            _contactNumber = Contact;
            _licenseNumebr = linum;
            _licenseStartDate = lstdate;
            _licenseExpiryDate = lexdate;
        }

        public override string ToString()
        {
            int i = 1;
    
            return string.Format($"Member:{0} \n Name:\n {_firstName},{_lastName}\n Member Contact Details:\n{_contactNumber},{_email}", i++);

            

        }


        public override bool Equals(object obj)
        {
          member me = obj as member;
            if(me.Email==Email && me.ContactNumber==ContactNumber)
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
