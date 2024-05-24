using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCompute_Click(object sender, EventArgs e)
        {
            string first_name = textBoxFirstName.Text;
            string last_name = textBoxLastName.Text;
            string department = textBoxDepartment.Text;
            string job_title = textBoxJobTitle.Text;
            double ratePerHour = Convert.ToDouble(textBoxRatePerHour.Text);
            int basic_salary = Convert.ToInt32(textBoxTotalHours.Text);

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee(first_name, last_name, department, job_title);
            partTimeEmployee.computeSalary(basic_salary, ratePerHour);

            labelName.Text = partTimeEmployee.FirstName;
            labelLast.Text = partTimeEmployee.LastName;
            labelSalary.Text = partTimeEmployee.getSalary().ToString();
            
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }
}
