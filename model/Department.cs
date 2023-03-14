using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.model
{
   public class Department: Employee
    {
        private List<Employee> employees = new List<Employee>();
        static DatabaseConnection dataBaseConnection = DatabaseConnection.uniqueDatabaseConnection;
        private string department_id, department_name;
        public string DepartmentId {
            get { return department_id; }
            set { department_id = value; }
        }
        public string DepartmentName {
            get { return department_name; }
            set { department_name = value; }
        }
       
        
        public Department()
        {

        }
        public Department(string depId, string depName)
        {
            department_id = depId;
            department_name = depName;
         
        }
        public string DepartmentDetails()
        {
            return "";
        }
        public Department Clone()
        {
            return new Department(DepartmentId, DepartmentName);
        }
        public void add(Employee employee)
        {
            employees.Add(employee);
        }

        public void remove(Employee employee)
        {
            employees.Remove(employee);
        }

        
    }
}
