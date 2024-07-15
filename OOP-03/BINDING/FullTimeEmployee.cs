using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03.BINDING
{
    internal class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(int _id, string _name,int _age,decimal salary):base(_id,_name,_age)
        {
            this.salary = salary;
        }

        public decimal salary {  get; set; }

        public override void GetEmployeeType()
        {
            Console.WriteLine("I am Full time Employee");
        }
        public override  void GetEmployeeData()
        {
            Console.WriteLine($"ID : {id}\nName : {name}\nAge : {age}\nSalary : {salary}");
        }
    }
}
