using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.model
{
    class Administrator
    {
         
        private string user_id, user_name, pwd, eml;
        public string userID {
            get { return user_id; }
            set { user_id = value; }
        }
        public string userName {
            get { return user_name; }
            set { user_name = value; }
}
        public string password
        {
            get { return pwd; }
            set { pwd = value; }
        }
        public string email
        {
            get { return eml; }
            set { eml = value; }
        }

        public Administrator() { }
        public Administrator(string uID, string uName, string e, string pwd)
        {
            user_id = uID;
            user_name = uName;
            this.pwd = pwd;
            eml = e;
        }

       
    }
}
