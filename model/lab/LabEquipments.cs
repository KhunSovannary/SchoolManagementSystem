using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.model
{
    class LabEquipments: Equipment
    {
        private string equipment_name; private int equipment_count;

         
        public string EquipmentName
        {
            get { return equipment_name; }
            set { equipment_name = value; }
        }
        public int EquipmentCount
        {
            get { return equipment_count; }
            set { equipment_count = value; }
        }
        public LabEquipments()
        {

        }
        public LabEquipments(string eId, double cost, string equipName, int equipCount):base(eId,cost)
        {
            EquipmentName = equipName;
            EquipmentCount = equipCount;
        }
        public LabEquipments Clone()
        {
            return new LabEquipments(EquipmentId, Cost, EquipmentName,EquipmentCount);
        }
        
    }
}
