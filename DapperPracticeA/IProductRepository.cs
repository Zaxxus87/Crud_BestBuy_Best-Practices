using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperPracticeA
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
        public void InsertProduct(string name, double price, int catID);
        public void UpdateProduct(int id, string newName, double newPrice, int newCatID, int newOnSale, string newSL);
        public void UpdateProductPrice(int id, double newPrice);
        public void UpdateProductPrice(string name, double newPrice);
        public void DeleteProduct(int id);
    }
}
