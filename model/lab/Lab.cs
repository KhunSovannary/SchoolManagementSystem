using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.model
{
    public class Lab
    {
         
        private string lab_id, lab_name, equipment_id;
        public string LabId
        {
            get { return lab_id; }
            set { lab_id = value; }
        }

        public string LabName
        {
            get { return lab_name; }
            set { lab_name = value; }
        }
        public string EquipmentId
        {
            get { return equipment_id; }
            set { equipment_id = value; }
        }

        public Lab()
        {

        }
        public Lab(string labId,  string labName, string equipId)
        {
            LabId = labId;
            LabName = labName;
            EquipmentId = equipId;
        }

        public string LabDetails()
        {
            return "";

        }
        public bool IsOccupied()
        {
            return true;
        }

        public string PayFine()
        {
            return "";
        }
        public Lab Clone()
        {
            return new Lab(LabId,  LabName, EquipmentId);
        }
        
    }
}
