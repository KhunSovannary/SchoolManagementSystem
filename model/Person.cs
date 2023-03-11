using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.model
{
   public class Person
    {
        protected string id, name, dob, gender, phone_number, address; 
        protected byte[] photo;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string PhoneNumber
        {
            get { return phone_number; }
            set { phone_number = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public Byte[] Photo
        {
            get { return photo; }
            set { photo = value; }
        }

        public Person()
        {

        }
       public Person(string id, string name, string gender,string dob,string phNum, string address, Byte[] photo)
        {
            this.id = id;
            this.name = name;
            this.dob = dob;
            phone_number = phNum;
            this.gender = gender;
            this.address = address;
            this.photo = photo;
        }
  
       
    }
}
