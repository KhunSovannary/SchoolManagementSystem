using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.model
{
    public abstract class Employee:Person
    {
        
        protected double salary; protected string department_id;
        public double Salary {
            get { return salary; }
            set { salary = value; }
        }
        public string DepartmentId {
            get { return department_id; }
            set { department_id = value; }
        }
      
        
        public Employee()
        {

        }
        public Employee(string empId, string empName,string empDob, string gender,
            string phnnum, string address, double salary, string depId,Byte[] photo):base(empId,empName,empDob,gender,phnnum, address,photo)
        {
          
            this.salary = salary;
            department_id = depId;
            
        }
        public void EmployeeDetails()
        {

        }
        public bool CheckIn()
        {
            return true;
        }

        public void ReceiveSalary()
        {

        }
      
       
    }
}
