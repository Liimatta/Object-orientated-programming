using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Työntekijät");

            Employee[] employees = new Employee[3];
            employees[0] = new Employee();
            employees[0].Askdata();
            Console.Clear();
            Console.WriteLine("Työntekijät");
            employees[1] = new Employee();
            employees[1].Askdata();
            Console.Clear();
            Console.WriteLine("Työntekijät");
            employees[2] = new Employee();
            employees[2].Askdata();
            Console.Clear();

            Console.WriteLine("Id - Nimi - Asema - Palkka");
            employees[0].Printemployeeinfo();
            employees[1].Printemployeeinfo();
            employees[2].Printemployeeinfo();

            
            Console.WriteLine($"\n{employees[1].CompareSalary(employees[2])}");
            Console.WriteLine(employees[2].CompareSalary(employees[0]));
            Console.WriteLine(employees[0].CompareSalary(employees[1]));


            Console.ReadLine();
        }
    }
}
