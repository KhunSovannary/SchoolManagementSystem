using SchoolManagementSystem.model;
using SchoolManagementSystem.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.controller
{
    public class LabController: Controller<Lab>
    {
        LabRepository labRepository = new LabRepository();
        public override void Insert(Lab l)
        {
            labRepository.Create(l);

        }
        public override void Update(Lab l)
        {
            labRepository.Update(l);
        }
        public override List<Lab> GetData()
        {
            return labRepository.Read();
        }
        public override List<Lab> GetDataByID(string id)
        {
            return labRepository.ReadByID(id);
        }
        public override void Delete(string id)
        {
            labRepository.Delete(id);
        }
    }
}
