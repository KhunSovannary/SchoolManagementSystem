using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.model
{
    class ClassEquipments: Equipment
    {
   static DatabaseConnection DatabaseConnection = DatabaseConnection.uniqueDatabaseConnection;
        private string class_id; private int chairCount, fanCount, lightCount;
        public string ClassId
        {
            get { return class_id; }
            set { class_id = value; }
        }
        public int ChairCount
        {
            get { return chairCount; }
            set { chairCount = value; }
        }
        public int FanCount
        {
            get { return fanCount; }
            set { fanCount = value; }
        }
        public int LightCount
        {
            get { return lightCount; }
            set { lightCount = value; }
        }
        public ClassEquipments()
        {

        }
        public ClassEquipments(string eId, double cost, string cId, int cCount, int fCount, int lCount) : base(eId, cost)
        {
            chairCount = cCount;
            class_id = cId;
            fanCount = fCount;
            lightCount = lCount;

        }
       
        public ClassEquipments Clone()
        {
            return new ClassEquipments(EquipmentId, Cost, ClassId,ChairCount, FanCount,LightCount);
        }
        
    }
    }





