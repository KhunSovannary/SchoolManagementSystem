using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.model.student
{
    public interface IStudentState
    {
        
        void RegisterForClasses(string classID,string date);
        void AddDropPeriod(string date);
        void Graduate(string date);
        string getState();
    }
    public class Freshman: IStudentState
    {
        private Student student;
        public Freshman (Student s)
        {
            student = s;
        }
        public  void  RegisterForClasses(string classID, string date) {
            student.ClassId = classID;
            student.StartDate = date;
        }
        public  void  AddDropPeriod(string date) {
            student.DropPeriod = date;
         }
        public void Graduate(string date) {
            student.GraduateDate = date;
        }
        public string getState()
        {
            return "Freshman";
        }
    }
    public class Sophomore : IStudentState
    {
        private Student student;
        public Sophomore(Student s)
        {
            student = s;
        }
        public void RegisterForClasses(string classID, string date)
        {
            student.ClassId = classID;
            student.StartDate = date;
        }
        public void AddDropPeriod(string date)
        {
            student.DropPeriod = date;
        }
        public void Graduate(string date)
        {
            student.GraduateDate = date;
        }
        public string getState()
        {
            return "Sophomore";
        }
    }
    public class Junior : IStudentState
    {
        private Student student;
        public Junior(Student s)
        {
            student = s;
        }
        public void RegisterForClasses(string classID, string date)
        {
            student.ClassId = classID;
            student.StartDate = date;
        }
        public void AddDropPeriod(string date)
        {
            student.DropPeriod = date;
        }
        public void Graduate(string date)
        {
            student.GraduateDate = date;
        }
        public string getState()
        {
            return "Junior";
        }
    }
    public class Senior : IStudentState
    {
        private Student student;
        public Senior(Student s)
        {
            student = s;
        }
        public void RegisterForClasses(string classID, string date)
        {
            student.ClassId = classID;
            student.StartDate = date;
        }
        public void AddDropPeriod(string date)
        {
            student.DropPeriod = date;
        }
        public void Graduate(string date)
        {
            student.GraduateDate = date;
        }
        public string getState()
        {
            return "Senior";
        }
    }
}
