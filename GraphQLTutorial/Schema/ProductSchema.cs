using GraphQLTutorial.Mutation;
using GraphQLTutorial.Query;

namespace GraphQLTutorial.Schema
{
    public class ProductSchema : GraphQL.Types.Schema
    {
        public ProductSchema(ProductQuery productQuery, ProductMutation productMutation) 
        {
            Query = productQuery;
            Mutation = productMutation;
        }
    }
}
