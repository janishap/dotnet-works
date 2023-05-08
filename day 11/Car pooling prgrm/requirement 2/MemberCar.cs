using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace requirement_2
{
    internal class MemberCar
    {

        long _id;
        private Member _member;
        private Car _car;
        string _carRegistrationNumber;
        string _carColor;

        public long Id
        {
            get { return _id; }
            set { _id = value; }

        }
        public Member member
        {
            get { return _member; }
            set { _member = value; }
        }

        public Car car
        {
            get { return _car; }
            set
            {
                _car = value;
            }
        }
        public string CarRegistrationNumber
        {
            get { return _carRegistrationNumber; }
            set
            {
                _carRegistrationNumber = value;
            }
        }

        public string CarColor
        {
            get { return _carColor; }
            set
            {
                _carColor = value;
            }
        }
        public MemberCar()
        {

        }
        public MemberCar(long id,Member member,Car car,string carregistration,string carcolor)
        {
            _id = id;
            _member = member;
            _car = car;
                _carRegistrationNumber = carregistration;
            _carColor = carcolor;
        }

        



    }




}
