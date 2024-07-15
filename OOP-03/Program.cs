using OOP_03.BINDING;

namespace OOP_03
{
    internal class Program
    {

        #region Overloading
        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static double Sum(double x, double y)
        {
            return x + y;
        }

        public static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }

        public static double Sum(int x, double y)
        {
            return x + y;
        }

        public static double Sum(double x, int y)
        {
            return x + y;
        }
        #endregion

        public static void ProcessEmployee(Employee employee)
        {
            employee.GetEmployeeType();
            employee.GetEmployeeData();
        }
        static void Main(string[] args)
        {
            #region overloading
            //overloading
            //Console.WriteLine(Sum(1, 4));
            //Console.WriteLine(Sum(1, 4 , 7));
            //Console.WriteLine(Sum(3.5, 4)); 
            #endregion

            #region overridding
            //overridding
            //using new keyword
            //using overrid keyword

            //TypeA typeA = new TypeA(9);
            //typeA.MyFun1();
            //typeA.MyFun2();
            //Console.WriteLine("-----------------------------------------");
            //TypeB typeB = new TypeB(7, 9);
            //typeB.MyFun1();
            //typeB.MyFun2(); 
            #endregion

            #region binding
            //TypeA refBase;
            //refBase = new TypeB(1,2);
            //refBase.A = 10;
            //refBase.MyFun1();
            //refBase.MyFun2();

            //TypeA typeA = new TypeB(1,2);
            //TypeB typeB = (TypeB) typeA;

            //typeB.MyFun1();
            //typeB.MyFun2(); 
            #endregion

            #region binding ex01
            //Employee employee = new Employee(1,"amr",25);
            //employee.GetEmployeeData();
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(2, "ahmed", 27, 3000);
            //ProcessEmployee(fullTimeEmployee);

            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            //{
            //    id = 3,
            //    name = "mohamed",
            //    age = 30,
            //    countOfHOurs = 20,
            //    HourRate = 2.5M
            //};
            //ProcessEmployee(partTimeEmployee); 
            #endregion


            #region binding ex02
            //TypeA typeA = new TypeC(1, 2, 3);
            //typeA.A = 10;
            //typeA.MyFun1();
            //typeA.MyFun2();

            //TypeB typeB = new TypeC(1, 2, 3);
            //typeB.MyFun1();
            //typeB.MyFun2();

            //TypeA typeA = new TypeE(1, 2, 3, 4, 5);
            //TypeB typeB = new TypeE(1, 2, 3, 4, 5);
            //TypeC typeC = new TypeE(1, 2, 3, 4, 5);

            //typeA.MyFun2();
            //typeB.MyFun2();
            //typeC.MyFun2();


            //TypeD typeD = new TypeE(1, 2, 3, 4, 5);
            //typeD.MyFun2(); 
            #endregion

        }
    }
}
