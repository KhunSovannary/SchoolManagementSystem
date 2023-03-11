using SchoolManagementSystem.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.repository
{
    public abstract class Repository<T>
    {
        protected static DatabaseConnection dbCon = DatabaseConnection.uniqueDatabaseConnection;
        public abstract void Create(T type);
        public abstract List<T> Read();
        public abstract List<T> ReadByID(string id);
        public abstract void Update(T type);
        public abstract void Delete(string id);
    }
}
