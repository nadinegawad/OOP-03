using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int _a, int _b) : base(_a)
        {
            this.B = _b;
        }

        public new void MyFun1()
        {
            Console.WriteLine("I am Derived [Child]");
        }
        public override void MyFun2()
        {
            Console.WriteLine($"TypeB :A = {A} , B : {B}");
        }
    }
}
