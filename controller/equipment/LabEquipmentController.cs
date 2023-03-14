using SchoolManagementSystem.model;
using SchoolManagementSystem.repository.equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.controller.equipment
{
    class LabEquipmentController:Controller<LabEquipments>
    {
        LabEquipmentRepository labEquipmentRepository = new LabEquipmentRepository();
        public override void Insert(LabEquipments cEquip)
        {
            labEquipmentRepository.Create(cEquip);
        }
        public override void Update(LabEquipments cEquip)
        {
            labEquipmentRepository.Update(cEquip);
        }
        public override List<LabEquipments> GetData()
        {
            return labEquipmentRepository.Read();
        }
        public override List<LabEquipments> GetDataByID(string id)
        {
            return labEquipmentRepository.ReadByID(id);
        }
        public override void Delete(string id)
        {
            labEquipmentRepository.Delete(id);
        }
    
}
}
