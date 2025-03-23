using DI.Models;

namespace DI.Repository
{
    public interface IProduct
    {
        public List<Product> FetchProduct();
        public void AddProduct(Product p);

        public List<Product> IndexSearch(string str);

        public void Delete(int id);

        public Product FetchUpdate(int id);

        public void UpdateProduct(Product p);

    }
}
