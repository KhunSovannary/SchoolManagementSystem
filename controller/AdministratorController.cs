using SchoolManagementSystem.model;
using SchoolManagementSystem.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.controller
{
    class AdministratorController
    {
        AdministratorRepository administratorRepository = new AdministratorRepository();
        public Administrator Check(string user, string pwd)
        {
            return administratorRepository.CheckUser(user, pwd);
        }
        public void Create(Administrator a)
        {
            administratorRepository.CreateUser(a);
        }
        public void Reset(string user, string email, string pwd)
        {
            administratorRepository.ResetUser(user, email, pwd);
        }
    }
        
}
