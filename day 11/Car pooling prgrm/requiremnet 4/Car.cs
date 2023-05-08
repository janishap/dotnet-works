using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace requiremnet_4
{
    public abstract class Car
    {
        public abstract double CalculateDriveCost(double km);

        long _id;
        string _name;
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
    }
    public class HatchBack : Car
    {
       public bool PowerWindowsEnabled
        {
            get; set;
        }

            public bool AutomaticGear
        { 
            
            get; 
            
            set; 
        }

        public HatchBack()
        {

        }


        public HatchBack(long id, string name, bool powerWindows, bool automaticGear)

        {

            Id = id;

            Name = name;

            PowerWindowsEnabled = powerWindows;

            AutomaticGear = automaticGear;

        }

        public override double CalculateDriveCost(double km)
        {
            double cost = 0;

            if (AutomaticGear)

                cost = 12;

            else

                cost = 10;

            return cost * km;
        }
    }

    public class Sedan : Car
    {
        bool _absEnabled;
        int _bootSpace;

        public bool Absenabled
        {
            get { return _absEnabled; }
            set { _absEnabled = value; }
           
            
        }

        public int BootSpace
        {
            get { return _bootSpace; }
            set { _bootSpace = value; }
        }

        public Sedan() { }
        public Sedan(long id, string name,bool absEnabled, int bootSpace)
        {
            Id = id;
            Name = name;
            _absEnabled = absEnabled;
            _bootSpace = bootSpace;
            
        }

        public override double CalculateDriveCost(double km)
        {
            double cost = 0;

            if (BootSpace > 600)

                cost = 15 + (15 * 0.20);

            else

                cost = 15;

            return cost * km;
        }

    }

    public class UtilityCar : Car
    {

        bool _rearCoolingVents;

        public bool RearCoolingVents
        {
            get { return _rearCoolingVents; }
            set { _rearCoolingVents = value; }

        }

        public UtilityCar() { }
        public UtilityCar(long id,string name,bool rearcoolingevents) 
        
        {
        Id=id;
            Name=name;
            _rearCoolingVents=rearcoolingevents;
        
        }

        public override double CalculateDriveCost(double km)
        {

            return 18 * km;


        }
      }

    
}
