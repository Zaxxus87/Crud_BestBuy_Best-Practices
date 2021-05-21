using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;


namespace DapperPracticeA
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");
            IDbConnection conn = new MySqlConnection(connString);

            var repo = new DepartmentRepo(conn);
            //var departments = repo.GetAllDepartments();
            //foreach(var d in departments)
            //    Console.WriteLine($"{d.DepartmentID} - {d.Name}");
            //Console.WriteLine(repo.GetDepartment(2).Name);

            //repo.InsertDepartment("New Department");
            //repo.UpdateDepartment(6, "Renamed Dept");
            repo.DeleteDepartment(6);
        }
    }
}
