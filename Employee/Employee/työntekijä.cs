using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        string name;
        int id;
        string position;
        int salary;

        public Employee(string Name = "no name", int Id = 0, string Position = "no position", int Salary = 0)
        {
            name = Name;
            position = Position;
            id = Id;
            salary = Salary;
        }
        public string CompareSalary(Employee employee)
        {
            if (this.salary > employee.salary)
                return $"Työntekijän {this.name} palkka on suurempi kuin työntekijän {employee.name} palkka";

            if(this.salary < employee.salary)
                return $"Työntekijän {employee.name} palkka on suurempi kuin työntekijän {this.name} palkka";
            if (this.salary == employee.salary)
                return $"Työntekijöiden {employee.name} ja {this.name} palkat ovat samansuuruiset";
            else
                return $"Tapahtui odottamaton virhe";
        }
        public void Askdata()
        {
            Console.WriteLine("Nimi");
            name = Console.ReadLine();
            Console.WriteLine("Asema:");
            position = Console.ReadLine();
            Console.WriteLine("id:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Palkka");
            salary = Convert.ToInt32(Console.ReadLine());
        }
            public void Printemployeeinfo()
        {
            Console.WriteLine($"{id} - {name} - {position} - {salary}e");

        }
        
    }
}
