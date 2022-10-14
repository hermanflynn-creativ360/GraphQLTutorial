using GraphQL;
using GraphQL.Types;
using GraphQLTutorial.Interfaces;
using GraphQLTutorial.Type;

namespace GraphQLTutorial.Query
{
    public class ProductQuery : ObjectGraphType
    {
        public ProductQuery(IProject productService) 
        {
            Field<ListGraphType<ProductType>>("products", resolve: contex=> { return productService.GetAllProducts(); });

            Field<ProductType>("product", arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: contex => { return productService.GetProductByID(contex.GetArgument<int>("id")); });
        }
    }
}
