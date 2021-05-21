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
        public Department GetDepartment(int p_id)
        {
            return _connection.QuerySingle<Department>("SELECT * FROM departments Where DepartmentID = @id;",
                new {id = p_id });
        }
        public void InsertDepartment(string p_name)
        {
            _connection.Execute("INSERT INTO departments (Name) VALUES (@name);",
                new { name = p_name });
        }
        public void UpdateDepartment(int p_id, string p_newName)
        {
            _connection.Execute("UPDATE departments SET Name = @newName WHERE DepartmentID = @id;",
                new {newName = p_newName, id = p_id });
        }
        public void DeleteDepartment(int p_id)
        {
            _connection.Execute("DELETE FROM departments WHERE DepartmentID = @id;",
                new {id = p_id });
        }




    }
}
