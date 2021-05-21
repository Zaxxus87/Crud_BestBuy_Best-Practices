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

            //var repo1 = new DepartmentRepo(conn);
            //var departments = repo.GetAllDepartments();
            //foreach(var d in departments)
            //    Console.WriteLine($"{d.DepartmentID} - {d.Name}");
            //Console.WriteLine(repo1.GetDepartment(2).Name);

            //repo1.InsertDepartment("New Department");
            //repo1.UpdateDepartment(6, "Renamed Dept");
            //repo1.DeleteDepartment(6);

            var repo2 = new ProductRepo(conn);
            var products = repo2.GetAllProducts();
            foreach (var p in products)
            {
                Console.WriteLine($"{p.ProductID} - {p.Name}: {p.Price}/{p.StockLevel}");
                if (p.OnSale == 1)
                    Console.WriteLine("This product is on sale");
                Console.WriteLine();
            }

            Console.WriteLine(repo2.GetProduct(41).Name);
            //repo2.InsertProduct("TestProduct A", 10.99, 1);
            //repo2.UpdateProduct(943, "TestProduct B", 15.99, 2, 1, "10");
            //repo2.UpdateProduct(944, "TestProduct c", 99.99, 6, 1, "100");
            //repo2.UpdateProductPrice(942, 18.99);
            //repo2.UpdateProductPrice("TestProduct B", 30.00);
            //repo2.DeleteProduct(944);
        }
    }
}
