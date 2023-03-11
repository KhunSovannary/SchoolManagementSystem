using SchoolManagementSystem.model;
using SchoolManagementSystem.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.controller
{
   public class StudentController: Controller<Student>
    {
        StudentRepository studentRepository = new StudentRepository();
        public override void Insert(Student s)
        {
            studentRepository.Create(s);
        }
        public override void Update(Student s)
        {
            studentRepository.Update(s);
        }
        public override List<Student> GetData()
        {
            var students = studentRepository.Read();
            return students;
        }
        public override List<Student> GetDataByID(string id)
        {
            var students = studentRepository.ReadByID(id);
            return students;
        }
        public override void Delete(string id)
        {
            studentRepository.Delete(id);
        }
    }
}
