using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    internal class PartTimeEmployee : IEmployee
    {
        private string first_name, last_name, department, job_title;
        private double basic_salary;

        public PartTimeEmployee(string FName, string LName, string dept, string job)
        {
            first_name = FName;
            last_name = LName;
            department = dept;
            job_title = job;
        }
        public string FirstName
        {
            get {
                return this.first_name;
            }
            set {
                this.first_name = value;
            }
        }
        public string LastName 
        {
            get { 
                return this.last_name;
            }
            set { 
                this.last_name = value;  
            }
        }
        public string Department 
        {
            get { 
                return this.department;
            }
            set { 
                this.department = value;
            }
        }
        public string JobTitle
        {
            get { 
                return this.job_title;
            }
            set { 
                this.job_title = value;
            }
        }
        public double BasicSalary
        {
            get { 
                return this.basic_salary;
            }
            set { 
                this.basic_salary = value;
            }    
        }
        public void computeSalary(int hoursWorkerd, double ratePerHour)
        {
            basic_salary = ratePerHour * hoursWorkerd;
        }
        public double getSalary()
        {
            return BasicSalary;

        }


    }     
    
}
