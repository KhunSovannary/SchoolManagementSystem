using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.controller
{
   public abstract class Controller<T>
    {
        public abstract void Insert(T t);
        public abstract void Update(T s);
        public abstract List<T> GetData();
        public abstract List<T> GetDataByID(string id);
        public abstract void Delete(string id);
      
    }
}

