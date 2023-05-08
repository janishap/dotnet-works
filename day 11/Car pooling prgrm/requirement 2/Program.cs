using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace requirement_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1) Add a Member");
            Console.WriteLine("2) Add a Car");
            Console.WriteLine("3) Assign Car to Member");
            Console.WriteLine("4) Cars Owned");
            Console.WriteLine("5) Exit");
            int ch = int.Parse(Console.ReadLine());

            
            switch (ch)
            {
                case 1:
                    addmember();
                    
                    break;
                    case 2:

                    addcar();
                    break;
                    case 3:
                    AssignCarToMember();

                    break;
                    case 4:
                    //DisplayCarsOwned();
                    break;
                case 5:

                    break;
                default:
                    Console.WriteLine("wrong choice");
                    break;
            }
            

           
            
        }

        static void addmember()
        {
            Console.WriteLine("Id:");
            int id = int.Parse(Console.ReadLine());
            
            Console.WriteLine("first name:");
            string fname = Console.ReadLine();

            Console.WriteLine("Last name:");
            string lname = Console.ReadLine();

            Console.WriteLine("Email:");
            string email = Console.ReadLine();

            Console.WriteLine("Contact number");
            string cnumber = Console.ReadLine();

            Console.WriteLine("License number:");
            string lnumber = Console.ReadLine();

            Console.WriteLine("License start date:");
            DateTime lstdate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("License end date:");
            DateTime lsenddate = DateTime.Parse(Console.ReadLine());
            Member member = new Member(id,fname,lname,email,cnumber,lnumber,lstdate,lsenddate);
           




        }
        static void addcar()
        {
            Console.WriteLine("Id:");
            int id=int.Parse(Console.ReadLine());
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Model:");
            string modelname=Console.ReadLine();
            Console.WriteLine("Make year:");
            int makeyear=int.Parse(Console.ReadLine());
            Console.WriteLine("Company:");
            string company=Console.ReadLine();
            Console.WriteLine("comfort level:");
            int clevel=int.Parse(Console.ReadLine());

            Car car= new Car(id,name,modelname,makeyear,company,clevel);

        }
        static void AssignCarToMember()
        {

            ArrayList allMembers = new ArrayList();
            ArrayList allcars = new ArrayList();

            Console.WriteLine("member car id: ");
            long memberCarId = int.Parse(Console.ReadLine());

            Console.WriteLine("member id: ");
            long memberId = int.Parse(Console.ReadLine());

            


            Console.WriteLine("car id:");
            long carId = long.Parse(Console.ReadLine());

            

            Console.WriteLine("car registration:");
            string carRegistration = Console.ReadLine();

            Console.WriteLine("color:");
            string color = Console.ReadLine();



            Member member = Member.FindMember(allMembers, memberId);
            Car car = Car.FindCar(allcars, carId);

            if (member != null && car != null)
            {
                MemberCar memberCar = new MemberCar(memberCarId, member, car, carRegistration, color);
                member.allcars.Add(memberCar);
                Console.WriteLine("\nCar assigned to member successfully.\n");
            }
            else
            {
                Console.WriteLine("\nInvalid member or car id. Try again.\n");
            }



        }
    }
}
