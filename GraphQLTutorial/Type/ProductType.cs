using GraphQL.Types;
using GraphQLTutorial.Models;

namespace GraphQLTutorial.Type
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType() 
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Price);
        }
    }
}
