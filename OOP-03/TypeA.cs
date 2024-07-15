using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03
{
    internal class TypeA
    {
        public int A {  get; set; }

        public TypeA(int _a)
        {
            A = _a;
        }

        public void MyFun1()
        {
            Console.WriteLine("I am Base [Parent]");
        }

        public virtual void MyFun2()
        {
            Console.WriteLine($"TypeA :A = {A}");
        }
    }
}
