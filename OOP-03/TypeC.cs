using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03
{
    internal class TypeC :TypeB
    {
        public int c {  get; set; }

        public TypeC(int _a, int _b, int _c) :base(_a,_b)
        {
            c= _c;  
        }

        public new void MyFun1()
        {
            Console.WriteLine("I am Derived [Grand Child]");
        }
        public override void MyFun2()
        {
            Console.WriteLine($"TypeB :A = {A} , B : {B} , C : {c}");
        }
    }
}
