using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.model
{
    public class Teacher: Employee
    {
         
        public Teacher()
        {

        }
        public Teacher(string tId, string tName, string Dob, string gender,
            string phnnum, string address, double salary, string depId, Byte[] photo) : base(tId, tName, Dob, gender, phnnum, address,salary, depId,photo)
        {

            
        }
        public Teacher Clone()
        {
            return new Teacher(Id, Name, Dob, Gender, PhoneNumber, Address, Salary, DepartmentId, Photo);
        }
       

    }
    }


