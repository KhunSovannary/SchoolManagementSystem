using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.model
{   
   public class Student:Person
    {
     
        private string class_id, department_id; 
        public string ClassId
        {
            get { return class_id; }
            set { class_id = value; }
        }
        public string DepartmentId
        {
            get { return department_id; }
            set { department_id = value; }
        }


        public Student() { }
        public Student(string stuId, string stuName, string gender, string dob,string address,string phnNum,
                    string classId, string depId, Byte[] photo):base(stuId,stuName,gender,dob,phnNum,address,photo)
        {
            class_id = classId;
            department_id = depId;
        
          
        }
        public string StudentDetails()
        {
            return "";
        }
        public void PayFees()
        {

        }
        
        public Student Clone()
        {
            return new Student(Id, Name,Gender,Dob,Address,PhoneNumber,ClassId,DepartmentId,Photo);
        }
        public static Student CreateStudent(string stuId, string stuName, string gender, string dob, string address, string phnNum,
                    string classId, string depId, Byte[] photo)
        {
            return new Student(stuId, stuName, gender, dob, address, phnNum, classId, depId, photo);
        }
        public void SetData()
        {
        }
       
    }
  
}
