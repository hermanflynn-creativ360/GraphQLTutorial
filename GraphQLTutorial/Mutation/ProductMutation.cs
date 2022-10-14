using GraphQL;
using GraphQL.Types;
using GraphQLTutorial.Interfaces;
using GraphQLTutorial.Models;
using GraphQLTutorial.Type;

namespace GraphQLTutorial.Mutation
{
    public class ProductMutation : ObjectGraphType
    {
        public ProductMutation(IProject productService)
        {
            // Create Mutation
            Field<ProductType>("createProduct", arguments: new QueryArguments(new QueryArgument<ProductInputType> 
            { 
                Name = "product" }), resolve: contex => 
                {
                    return productService.AddProject(contex.GetArgument<Product>("product")); 
                });

            // Update Mutation
            Field<ProductType>("updateProduct", arguments: new QueryArguments(new QueryArgument<IntGraphType>
            {
                Name = "id" }, new QueryArgument<ProductInputType>
                {
                    Name = "product"
                }
                ), resolve: contex => 
                { return productService.UpdateProject(contex.GetArgument<int>("id"),contex.GetArgument<Product>("product"));
            });

            // Delete Mutation
            Field<StringGraphType>("deleteProduct", arguments: new QueryArguments(new QueryArgument<IntGraphType>
            {
                Name = "id"
            }), resolve: contex =>
                {
                    var id = contex.GetArgument<int>("id");
                    productService.DeleteProject(id); 
                    return "Project: " + id + " has been deleted!";
                });
        }


    }
}
