using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryInformationApp
{
    class Employee
    {
        private string name;
        private string id;
        private string email;
        private SalaryCounter aSalaryCounter;

        public Employee()
        {
            this.name = null;
            this.id = null;
            this.email = null;
        }
        public Employee(string name,string id,string email,SalaryCounter aSalaryCounter): this()
        {
            this.name = name;
            this.id = id;
            this.email = email;
            this.ASalaryCounter = aSalaryCounter;


        }
        public string Name
        {
            get { return name; }
        }

        public string Id
        {
            get { return id; }
        }

        public string Email
        {
            get { return email; }
        }

        public SalaryCounter ASalaryCounter
        {
            get { return aSalaryCounter; }
            set { aSalaryCounter = value; }
        }
    }
}
