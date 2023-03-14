using SchoolManagementSystem.model;
using SchoolManagementSystem.repository.employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.controller.employee
{
    class TeacherController: Controller<Teacher>
    {
        TeacherRepository teacherRepository = new TeacherRepository();
        public override void Insert(Teacher t)
        {
            teacherRepository.Create(t);

        }
        public override void Update(Teacher t)
        {
            teacherRepository.Update(t);
        }
        public override List<Teacher> GetData()
        {
            return teacherRepository.Read();
        }
        public override List<Teacher> GetDataByID(string id)
        {
            return teacherRepository.ReadByID(id);
        }
        public override void Delete(string id)
        {
            teacherRepository.Delete(id);
        }
    
}
}
