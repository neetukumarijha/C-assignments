using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee3
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSal { get; set; }
        public string EmpLoc { get; set; }


    }

    internal class ArrayListSample
    {
        static void Main(string[] args)
        {
            //object initilizer or collection initilizer
            //ArrayList e = new ArrayList();//non generic

            ArrayList e = new ArrayList()
            {
                    new Employee{EmpId=1,EmpName="Peter",EmpSal=20000,EmpLoc="Blore"},
                    new Employee{EmpId=2,EmpName="Johnny",EmpSal=25000,EmpLoc="Mysore"},
                    new Employee{EmpId=3,EmpName="Niharika",EmpSal=32000,EmpLoc="Delhi"},
                    new Employee{EmpId=4,EmpName="Radha",EmpSal=40000,EmpLoc="Pune"},
                    new Employee{ EmpId=5, EmpName="Vicky",EmpSal=40000,EmpLoc="Mumbai"},
                    new Employee{ EmpId=6, EmpName="Potter",EmpSal=90000,EmpLoc="Goa"}
            };
            Console.WriteLine(e.Count);
            foreach (Employee i in e)
            {
                Console.WriteLine(i.EmpId + " " + i.EmpName + " " + i.EmpSal + " " + i.EmpLoc);
            }
            Console.WriteLine("total number of employess" + ':' + e.Count);
            Console.WriteLine("enter person name:");
            string X = Console.ReadLine();
            if (e.Contains(X))
            {
                Console.WriteLine("yes " + X + " is an employee");
            }
            else
            {
                Console.WriteLine("no");
            }
            Console.ReadKey();
        }
    }
}


