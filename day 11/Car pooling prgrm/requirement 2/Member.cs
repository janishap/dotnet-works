using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace requirement_2
{
    internal class Member
    {
        long _id;
        string _firstName;
        string _lastName;
        string _email;
        string _contactNumber;
        string _licenseNumebr;
        DateTime _licenseStartDate;
        DateTime _licenseExpiryDate;
        public ArrayList _carList;

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
        public ArrayList CarList
        {
            get { return _carList; }
            set { _carList = value; }
        }
        public Member()
        {

        }
        public Member(long id, string fname, string lname, string Email, string Contact, string linum, DateTime lstdate, DateTime lexdate)

        {
            _id = id;
            _firstName = fname;
            _lastName = lname;
            _email = Email;
            _contactNumber = Contact;
            _licenseNumebr = linum;
            _licenseStartDate = lstdate;
            _licenseExpiryDate = lexdate;
            _carList = new ArrayList();
        }

        public static  Member FindMember(int id)
        {
            
                // Assume members are stored in a static ArrayList called "allMembers"
                foreach (Member member in allMembers)
                {
                    if (member.Id == id)
                    {
                        return member;
                    }
                }
                return null;

        }

    }
}
