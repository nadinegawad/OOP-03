using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03
{
    internal class TypeE :TypeD
    {
        public int e {  get; set; }

        public TypeE(int _a, int _b, int _c ,int _d ,int _e):base (_a,_b,_c,_d)
        {
            e = _e;
        }
        public override void MyFun2()
        {
            Console.WriteLine($"TypeB :A = {A} , B : {B} , C : {c} , D : {d} , E : {e}");
        }
    }
}
