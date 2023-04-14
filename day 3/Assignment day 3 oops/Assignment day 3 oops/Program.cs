
using System;


 namespace oops_prgrm_1
 {





        public class program
        {
            static void Main(string[] args)
            {


            


                Console.WriteLine("Enter your id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your age");
                int age = int.Parse(Console.ReadLine());


                 Employee emp = new Employee(id,name,age);




        }
        }







    
        
}
