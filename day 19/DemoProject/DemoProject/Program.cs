using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    public class Program
    {
       
            public string Login(string UserId, string Password)
            {
                if (string.IsNullOrEmpty(UserId) || string.IsNullOrEmpty(Password))
                {
                    return "Userid or password could not be Empty.";
                }
                else
                {
                    if (UserId == "Admin" && Password == "Admin")
                    {
                        return "Welcome Admin.";
                    }
                    return "Incorrect UserId or Password.";
                }
            }
            public List<EmployeeDetails1> AllUsers()
            {
                List<EmployeeDetails1> li = new List<EmployeeDetails1>();
                li.Add(new EmployeeDetails1
                {
                    id = 100,
                    Name = "Bharat",
                    Geneder = "male",
                    salary = 40000
                });
                li.Add(new EmployeeDetails1
                {
                    id = 101,
                    Name = "sunita",
                    Geneder = "Female",
                    salary = 50000
                });
                li.Add(new EmployeeDetails1
                {
                    id = 103,
                    Name = "Karan",
                    Geneder = "male",
                    salary = 40000
                });
                li.Add(new EmployeeDetails1
                {
                    id = 104,
                    Name = "Jeetu",
                    Geneder = "male",
                    salary = 23000
                });
                li.Add(new EmployeeDetails1
                {
                    id = 105,
                    Name = "Manasi",
                    Geneder = "Female",
                    salary = 80000
                });
                li.Add(new EmployeeDetails1
                {
                    id = 106,
                    Name = "Ranjit",
                    Geneder = "male",
                    salary = 670000
                });
                return li;
            }
            public List<EmployeeDetails1> getDetails(int id)
            {
                List<EmployeeDetails1> li1 = new List<EmployeeDetails1>();
                Program p = new Program();
                var li = p.AllUsers();
                foreach (var x in li)
                {
                    if (x.id == id)
                    {
                        li1.Add(x);
                    }
                }
                return li1;
            }
            static void Main(string[] args) { }
        }


    }
    

