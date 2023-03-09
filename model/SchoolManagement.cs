using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.model
{
    class SchoolManagement
    {
        private string school_name, address, contact_number, medium_of_study;
        public string SchoolName
        {
            get { return school_name; }
            set { school_name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string ContactNumber
        {
            get { return contact_number; }
            set { contact_number = value; }
        }
        public string MediumofStudy
        {
            get { return medium_of_study; }
            set { medium_of_study = value; }
        }


        public SchoolManagement()
        {

        }
        public SchoolManagement(string schoolName, string address,string contNum, string mediumofstudy)
        {
            school_name = schoolName;
            this.address = address;
            contact_number = contNum;
            medium_of_study = mediumofstudy;
        }
        public bool isOpen()
        {   
            return true;
        }

        public string SchoolDetails()
        {
            return SchoolName + "\t" + Address + "\t" + ContactNumber + "\t" + MediumofStudy;
        }
    }
}
