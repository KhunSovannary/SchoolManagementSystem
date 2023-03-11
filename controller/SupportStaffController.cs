using SchoolManagementSystem.model;
using SchoolManagementSystem.repository.employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.controller
{
    public class SupportStaffController: Controller<SupportStaff>
    {
        SupportStaffRepository supportStaffRepository = new SupportStaffRepository();
        public override void Insert(SupportStaff sp)
        {
            supportStaffRepository.Create(sp);
        }
        public override void Update(SupportStaff sp)
        {
            supportStaffRepository.Update(sp);
        }
        public override List<SupportStaff> GetData()
        {
            var supportStaff  = supportStaffRepository.Read();
            return supportStaff ;
        }
        public override List<SupportStaff> GetDataByID(string id)
        {
            var supportStaff  = supportStaffRepository.ReadByID(id);
            return supportStaff;
        }
        public override void Delete(string id)
        {
            supportStaffRepository.Delete(id);
        }
    }
}

