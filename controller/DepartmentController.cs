using SchoolManagementSystem.model;
using SchoolManagementSystem.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.controller
{
    class DepartmentController:Controller<Department>
    {
        DepartmentRepository departmentRepository = new DepartmentRepository();
        public override void Insert(Department d)
        {
            departmentRepository.Create(d);
        }
        public override void Update(Department d)
        {
            departmentRepository.Update(d);
        }
        public override List<Department> GetData()
        {
           return departmentRepository.Read();
        }
        public override List<Department> GetDataByID(string id)
        {
            return departmentRepository.ReadByID(id);
        }
        public  override void Delete(string id)
        {
            departmentRepository.Delete(id);
        }
    }
}
