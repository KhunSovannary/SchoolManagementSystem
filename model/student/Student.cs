using SchoolManagementSystem.model.student;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.model.student
{   
   public class Student:Person,IObserver
    {
     
        private string class_id, department_id, startDate, graduateDate, dropPeriod, year;
        public IStudentState studentState;
        Classroom _classroom = new Classroom();
       
        public string Year
        {
            get { return year; }
            set
            {
                year = value;
                if (year == "1")
                {
                    studentState = new Freshman(this);
                }
                else if (year == "2")
                {
                    studentState = new Sophomore(this);
                }
                else if (year == "3")
                {
                    studentState = new Junior(this);
                }
                else if (year == "4")
                {
                    studentState = new Senior(this);
                }
              /*  else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Invalid year");
                }*/
            }
        }
            
        public string ClassId
        {
            get { return class_id; }
            set { class_id = value; }
        }
        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public string GraduateDate
        {
            get { return graduateDate; }
            set { graduateDate = value; }
        }
        public string DropPeriod { 
            get { return dropPeriod; }
            set { dropPeriod = value; }
        }
        public string DepartmentId
        { 
            get { return department_id; }
            set { department_id = value; }
        }

        public Student() { }
        public Student(string stuId, string stuName, string gender, string dob,string address,string phnNum,
                    string classId, string depId, string grade, string sD, string gD, string pD,Byte[] photo):base(stuId,stuName,gender,dob,phnNum,address,photo)
        {
            class_id = classId;
            department_id = depId;
            year = grade;
            startDate = sD;
            graduateDate = gD;
            dropPeriod = pD;
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
            return new Student(Id, Name,Gender,Dob,Address,PhoneNumber,ClassId,DepartmentId, Year,StartDate, graduateDate,dropPeriod,Photo);
        }
        public static Student CreateStudent(string stuId, string stuName, string gender, string dob, string address, string phnNum,
                    string classId, string depId, string grade, string sD, string gD, string pD, Byte[] photo)
        {
            return new Student(stuId, stuName, gender, dob, address, phnNum, classId, depId, grade,sD,gD,pD, photo);
        }
        public void Update()
        {
            Console.WriteLine($"{name}, you have been enrolled in {_classroom.ClassName}");
        }

        public void LeaveClassroom()
        {
            _classroom.Detach(this);
            _classroom = null;
            Console.WriteLine($"{name}, you have left the classroom");
        }

    }
  
}
