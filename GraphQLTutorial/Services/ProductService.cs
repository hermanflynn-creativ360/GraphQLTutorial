using GraphQLTutorial.Interfaces;
using GraphQLTutorial.Models;

namespace GraphQLTutorial.Services
{
    public class ProductService : IProject
    {

        private static List<Product> products = new List<Product>() 
        {
            new Product(){ Id = 0, Name = "sfdgfsd", Price = 0 },
            new Product(){ Id = 1, Name = "xvcbbxc", Price = 1 },
            new Product(){ Id = 2, Name = "wqrtert", Price = 2 },
            new Product(){ Id = 3, Name = "adsfdsn", Price = 3 },
            new Product(){ Id = 4, Name = "hgfjgfh", Price = 4 },
            new Product(){ Id = 5, Name = "kjlhkjn", Price = 5 },
            new Product(){ Id = 6, Name = "cvnbcvn", Price = 6 },
        };

        public List<Product> GetAllProducts() 
        {
            return products;
        }

        public Product AddProject(Product product) 
        {
            products.Add(product);
            return product;
        }

        public Product UpdateProject(int id, Product product) 
        {
            products[id] = product;
            return product;
        }

        public void DeleteProject(int id)
        {
            products.RemoveAt(id);
        }

        public Product GetProductByID(int id)
        {
            return products.Find(x => x.Id == id);
        }
    }
}
