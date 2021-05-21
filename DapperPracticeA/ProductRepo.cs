using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperPracticeA
{
    class ProductRepo : IProductRepository
    {
        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertProduct(string name, double price, int catID)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(int id, string newName, double newPrice, int newCatID, int newOnSale, string newSL)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductPrice(int id, double newPrice)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductPrice(string name, double newPrice)
        {
            throw new NotImplementedException();
        }
    }
}
