using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static String_Builder.Employee;

namespace String_Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Employee1 emp1 = new Employee1("aaa", 20000, Dept.Sales);
                emp1.CalculateSalary();
                Console.WriteLine(emp1.PrintEmpSalary());
                Console.WriteLine(emp1);

                Employee1 emp2 = new Employee1("Ab", 39000, Dept.Testing);
                emp2.CalculateSalary();
                Console.WriteLine(emp2.PrintEmpSalary());
                Console.WriteLine(emp2);

                Student s1 = new Student("zzz", 12345, 80, 92, 95, Streams.CS);
                s1.Calculate();
                Console.WriteLine(s1.ToString());

            }

        }
    }
}
