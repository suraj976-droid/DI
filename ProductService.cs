using DI.Data;
using DI.Models;
using DI.Repository;
using Microsoft.EntityFrameworkCore;

namespace DI.Service
{
    public class ProductService : IProduct
    {
        private readonly ApplicationDbContext db;

        public ProductService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public void AddProduct(Product p)
        {
           db.Products.Add(p);
           db.SaveChanges();
        }
        public void Delete(int id)
        {
            var data = db.Products.Find(id);
            if (data != null)
            {
                db.Products.Remove(data);
                db.SaveChanges();
            }
        }

        public List<Product> FetchProduct()
        {
            //var data = db.Products.ToList();

            //var data = db.Products.FromSqlRaw("Select * from Products").ToList();

            var data = db.Products.FromSqlInterpolated($"Select * from Products").ToList();


            return data;
        }

    

        public void UpdateProduct(Product p)
        {
           
            db.Products.Update(p);
            db.SaveChanges();
        }

        public Product FetchUpdate(int id)
        {
            var data = db.Products.Find(id);
            if (data != null)
            {
                return data;
            }
            return null;
        }


        public List<Product> IndexSearch(string str)
        {
            //var data = db.Products.FromSqlInterpolated($"Select * from Products where Name like '%{str}%'").ToList();

            // what to seacrh by Name and Category and Price without using sql query

            var data = db.Products.Where(x => x.Name.Contains(str) || x.Category.Contains(str) || x.Price.ToString().Contains(str)).ToList();
            return data;
        }
    }
}
