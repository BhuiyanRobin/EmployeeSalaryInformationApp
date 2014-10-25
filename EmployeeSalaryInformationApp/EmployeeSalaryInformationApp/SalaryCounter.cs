using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryInformationApp
{
    class SalaryCounter
    {
        private double basic;
        private double medical;
        private double conveyaence;

        public SalaryCounter()
        {
            this.basic = 0;
            this.medical = 0;
            this.conveyaence = 0;

        }
        public SalaryCounter(double basic, double medical, double conveyaence):this()
        {
            this.basic = basic;
            this.medical = medical;
            this.conveyaence = conveyaence;

        }

        public double Basic
        {
            get { return basic; }
        }

        public double Medical
        {
            get { return medical; }
        }

        public double Conveyaence
        {
            get { return conveyaence; }
        }


        public double GetSalary()
        {

            return 0;
        }

        public double GetBasic(double amount)
        {
            this.medical += (this.medical*amount)/100;
            this.conveyaence += (this.conveyaence * amount) / 100;
            this.basic += (this.basic*amount)/100;
            return this.basic;
        }

        public double GetTotalAmount()
        {
            
            return basic + (this.medical )+(this.medical);
        }
    }
}
