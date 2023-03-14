using SchoolManagementSystem.model;
using SchoolManagementSystem.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.controller
{
    class ClassroomController : Controller<Classroom>
    {
        ClassroomRepository classroomRepository = new ClassroomRepository();
        public override void Insert(Classroom c)
        {
            classroomRepository.Create(c);
        }
        public override void Update(Classroom c) {
            classroomRepository.Update(c);
        }
        public override List<Classroom> GetData() {
           return classroomRepository.Read();
        }
        public override List<Classroom> GetDataByID(string id) {
            return classroomRepository.ReadByID(id);
        }
        public override void Delete(string id) {
             classroomRepository.Delete(id);
        }
    }
}
