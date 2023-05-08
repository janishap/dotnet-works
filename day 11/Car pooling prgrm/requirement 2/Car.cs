using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace requirement_2
{
    internal class Car
    {
        long _id;
        string _name;
        string _model;
        int _makeYear;
        string _company;
        int _comfortLevel;
        public static ArrayList allcars=new ArrayList();

        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public string Model
        {

            get { return _model; }
            set { _model = value; }
        }

        public int MakeYear
        {
            get { return _makeYear; }
            set
            {
                _makeYear = value;
            }
        }
        public string Company
        {

            get { return _company; }
            set { _company = value; }
        }

        public int comfortLevel
        {
            get { return _comfortLevel; }
            set
            {
                _comfortLevel = value;
            }
        }

        public Car()
            {

            }
        public Car(long id,string name,string model,int makeyear,string company,int comfrolevel)
        {
            _id = id;
             _name = name;
            _model = model;    
            _makeYear = makeyear;
            _company = company;
            _comfortLevel = comfrolevel;

        }

        public static Car FindCar(int Id,allcars)
        {
            foreach(Car car in allcars)
            {
                if (car.Id == Id)
                    return car;
            }
            return null;
        }
        
    }
}
