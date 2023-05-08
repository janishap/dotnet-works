using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement_5
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
        public member()
        {

        }
        public member(long id, string fname, string lname, string Email, string Contact, string linum, DateTime lstdate, DateTime lexdate)

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
            return string.Format("Id:{0}\nFirstName:{1}\nLastName:{2}\nEmail{3}\nContact:{4}License Number:{5}\nLicense start Date{6}\nLicense Expiry Date:{7}",Id,FirstName,LastName,Email,ContactNumber, LicenseNumebr,LicenseStartDate.ToString("dd-mm-yyyy",null),LicenseExpiryDate.ToString("dd-mm-yyyy",null));
        }

        public static bool  Display (string _email)
       
        {

            if ((_email.Contains("@")) && (_email.EndsWith(".com")) && (_email.EndsWith(".org")))
            {
                //throw new InvalidEmailException("InvalidEmailException: Invalid Email for the use");

                return true;
            }
            return false;

        }




    }
}
