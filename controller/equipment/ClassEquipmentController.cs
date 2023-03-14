using SchoolManagementSystem.model;
using SchoolManagementSystem.repository.equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.controller.equipment
{
    class ClassEquipmentController: Controller<ClassEquipments>
    {
        ClassEquipmentRepository classEquipmentRepository = new ClassEquipmentRepository();
        public override void Insert(ClassEquipments cEquip)
        {
            classEquipmentRepository.Create(cEquip);
        }
        public override void Update(ClassEquipments cEquip)
        {
            classEquipmentRepository.Update(cEquip);
        }
        public override List<ClassEquipments> GetData()
        {
            return classEquipmentRepository.Read();
        }
        public override List<ClassEquipments> GetDataByID(string id)
        {
            return classEquipmentRepository.ReadByID(id);
        }
        public override void Delete(string id)
        {
            classEquipmentRepository.Delete(id);
        }
    }
}
