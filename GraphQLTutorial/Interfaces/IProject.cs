using GraphQLTutorial.Models;

namespace GraphQLTutorial.Interfaces
{
    public interface IProject
    {
        List<Product> GetAllProducts();
        Product AddProject(Product product);
        Product UpdateProject(int id, Product product);
        void DeleteProject(int id);
        Product GetProductByID(int id);
    }
}
