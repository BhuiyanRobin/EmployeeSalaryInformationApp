using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryInformationApp
{
    public partial class EmployeeInformationUI : Form
    {
        public EmployeeInformationUI()
        {
            InitializeComponent();
        }

        private Employee aEmployee;
        private int count = 0;
        
        //public aEmployeeSalaryCounter aSalaryCounter;

            private void saveButton_Click(object sender, EventArgs e)
            {
                SalaryCounter aSalaryCounter=new SalaryCounter();
                aSalaryCounter = new SalaryCounter(Convert.ToDouble(basicTextBox.Text),Convert.ToDouble( medicalTextBox.Text),
                    Convert.ToDouble(conveyanceTextBox.Text));
                aEmployee=new Employee(nameTextBox.Text,idTextBox.Text,emailTextBox.Text,aSalaryCounter);

                MessageBox.Show("account Created");
            }

            private void incrementButton_Click(object sender, EventArgs e)
            {
                count++;
                double amount = Convert.ToDouble(increaseTextBox.Text);

                aEmployee.ASalaryCounter.GetBasic(amount);

            }

            private void showButton_Click(object sender, EventArgs e)
            {
                basicDisplayTextBox.Text = aEmployee.ASalaryCounter.Basic.ToString();
                medicalDisplayTexBox.Text = aEmployee.ASalaryCounter.Medical.ToString();
                conveyanceDisplayTextBox.Text = aEmployee.ASalaryCounter.Conveyaence.ToString();
                noOfIncrementsTextBox.Text = count.ToString();
                totalTextBox.Text = aEmployee.ASalaryCounter.GetTotalAmount().ToString();
            }
    }
}
