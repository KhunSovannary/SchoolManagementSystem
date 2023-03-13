using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.model
{
    public class SupportStaff : Employee
    {
       private string job_title;
       public string JobTitle
        {
            get { return job_title; }
            set { job_title = value; }
        }
        public SupportStaff() { }
        public SupportStaff(string ssId, string ssName, string Dob, string gender,
                string phnnum, string address, double salary, string depId, string job, Byte[] photo) : base(ssId, ssName, Dob, gender, phnnum, address, salary, depId, photo)
        {
            job_title = job;
        }
        public SupportStaff Clone()
        {
            return new SupportStaff(Id, Name, Dob, Gender, PhoneNumber, Address, Salary, DepartmentId, JobTitle,Photo);
        }
       
     
    }
}
