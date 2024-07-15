using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03.BINDING
{
    public class Employee
    {
        public Employee()
        {
           
        }
        public Employee(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public int id {  get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public virtual void GetEmployeeType()
        {
            Console.WriteLine("I am Employee");
        }

        public virtual void GetEmployeeData()
        {
            Console.WriteLine($"ID : {id}\nName : {name}\nAge : {age}");
        }
    }
}
