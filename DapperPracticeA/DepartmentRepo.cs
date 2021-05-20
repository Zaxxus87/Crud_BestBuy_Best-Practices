using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace DapperPracticeA
{
    public class DepartmentRepo : IDepartmentRepository
    {
        private readonly IDbConnection _connection;
        public DepartmentRepo(IDbConnection connection)
        {
            _connection = connection;
        }
        public IEnumerable<Department> GetAllDepartments()
        {
            return _connection.Query<Department>("SELECT * FROM departments");
        }
        public Department GetDepartment(int id)
        {
            throw new NotImplementedException();
        }
        public void InsertDepartment(string name)
        {
            throw new NotImplementedException();
        }
        public void DeleteDepartment(int id)
        {
            throw new NotImplementedException();
        }
        public void UpdateDepartment(int id, string newName)
        {
            throw new NotImplementedException();
        }




    }
}
