using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03.BINDING
{
    internal class PartTimeEmployee :Employee
    {
        public int countOfHOurs {  get; set; }
        public decimal HourRate {  get; set; }

        public override void GetEmployeeType()
        {
            Console.WriteLine("I am part time Employee");
        }
        public override void GetEmployeeData()
        {
            Console.WriteLine($"ID : {id}\nName : {name}\nAge : {age}\nCount of Hours : {countOfHOurs}\nHourRate : {HourRate}");
        }
    }
}
