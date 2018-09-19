using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Employee:Person, Interface
    {
        private string Department;
        private decimal Salary;

        public Employee(string Address, int Age, string City, string Name, string Department2, decimal Salary2) :
         base(Address,Age,Name,City)
        {
            Department = Department2;
            Salary = Salary2;
        }
        public string DoSomeWork()
        {
            string EmployeeDetails;
            EmployeeDetails = Address + "\r\n" + Age + "\r\n" + City + "\r\n" + Name + Department + "\r\n"
               + Salary;
            return EmployeeDetails;
        }
}
}
