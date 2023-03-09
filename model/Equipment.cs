using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.model
{
    class Equipment

    {
        protected string equipment_id; protected double cost;
        public string EquipmentId {
            get { return equipment_id; }
            set { equipment_id = value; }
        }
       
        public double Cost {
            get { return cost; }
            set { cost = value; }
        }
        public Equipment(string equipId,  double cost)
        {
            equipment_id = equipId;
           
            this.cost = cost;
        }
        public Equipment()
        {

        }
        public void EquipmentDetails()
        {

        }

        public void PurchaseEquipment()
        {

        }
        public void Repair()
        {

        }
        
       
    }
}
