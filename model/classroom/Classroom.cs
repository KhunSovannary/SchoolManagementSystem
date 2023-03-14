using SchoolManagementSystem.model.student;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.model
{
    public class Classroom:ISubject
    {
        private List<Student> _students = new List<Student>();
        static DatabaseConnection DatabaseConnection = DatabaseConnection.uniqueDatabaseConnection;
                private string class_id, class_name, teacher_id, equipment_id; 
                private int student_count;
                public string ClassId {
                get { return class_id; }
                set { class_id = value; }
        }
        public string ClassName {
            get { return class_name; }
            set { class_name = value; }
        }
        public string TeacherId {
            get { return teacher_id; }
            set { teacher_id = value; }
        }
        public int StudentCount
        {
            get { return student_count; }
            set { student_count = value; }
        }
            public string EquipmentId {
            get { return equipment_id; }
            set { equipment_id = value; }
        }

        public Classroom() { }
        public Classroom(string classId, string className, string empId, string equipId, int StudentCount)
        {
            class_id = classId;
            class_name = className;
            teacher_id = empId;
            equipment_id = equipId;
            student_count = StudentCount;
        }
        public void Attach(IObserver observer)
        {
            _students.Add((Student)observer);
        }

        public void Detach(IObserver observer)
        {
            _students.Remove((Student)observer);
        }

        public void Notify()
        {
            foreach (var student in _students)
            {
                student.Update();
            }
        }

        public void Enroll(Student student)
        {
            Console.WriteLine($"{student.Name}, you have been enrolled in {class_name}");
            Attach(student);
            Notify();
        }

        public void Disenroll(Student student)
        {
            Console.WriteLine($"{student.Name}, you have been disenrolled from {class_name}");
            Detach(student);
            Notify();
        }
        public string ClassDetails()
        {
            return ClassId + "\t" + ClassName + "\t" + TeacherId + "\t" + StudentCount.ToString() + "\t" + EquipmentId;
        }
        public Classroom Clone()
        {
            return new Classroom(ClassId, ClassName,TeacherId, EquipmentId,StudentCount);
        }

        
    }
}
