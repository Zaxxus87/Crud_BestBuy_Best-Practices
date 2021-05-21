using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DapperPracticeA
{
    class ProductRepo : IProductRepository
    {
        private readonly IDbConnection _connection;

        public ProductRepo(IDbConnection connection)
        {
            _connection = connection;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _connection.Query<Product>("SELECT * FROM products;");
        }
        public Product GetProduct(int id)
        {
            return _connection.QuerySingle<Product>("SELECT * FROM products WHERE ProductID = @id;",
                new {id = id});
        }

        public void InsertProduct(string name, double price, int catID)
        {
            _connection.Execute("INSERT INTO products (Name, Price, CategoryID, OnSale, StockLevel)" +
                "VALUES (@name, @price, @categoryID, @onSale, @stockLevel);", 
                new {name = name, price = price, categoryID = catID, OnSale = 0, stockLevel = '0'  });
        }

        public void UpdateProduct(int id, string newName, double newPrice, int newCatID, int newOnSale, string newSL)
        {
            _connection.Execute("UPDATE products SET Name = @newName, Price = @newPrice, " +
                "CategoryID = @newCatID, OnSale = @newOnSale, StockLevel = @newSL WHERE ProductID = @id;",
                new {newName = newName, newPrice = newPrice, newCatID = newCatID, newOnSale = newOnSale, newSL = newSL, id = id });
        }

        public void UpdateProductPrice(int id, double newPrice)
        {
            _connection.Execute("UPDATE products SET Price = @newPrice WHERE ProductID = @id;", 
                new {id = id, newPrice = newPrice });
        }

        public void UpdateProductPrice(string name, double newPrice)
        {
            _connection.Execute("UPDATE products SET Price = @newPrice WHERE Name = @name;",
                new { name = name, newPrice = newPrice });
        }
        public void DeleteProduct(int id)
        {
            _connection.Execute("DELETE FROM products WHERE ProductID = @id;", 
                new {id = id});
        }
    }
}
