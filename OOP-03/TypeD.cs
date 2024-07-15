using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03
{
    internal class TypeD:TypeC
    {
        public int d {  get; set; }

        public TypeD(int _a, int _b, int _c , int _d):base(_a,_b,_c)
        {
            d = _d;
        }
        public new void MyFun1()
        {
            Console.WriteLine("I am Derived [ Child Grand Child]");
        }
        public new virtual void MyFun2()
        {
            Console.WriteLine($"TypeB :A = {A} , B : {B} , C : {c} , D : {d}");
        }
    }
}
