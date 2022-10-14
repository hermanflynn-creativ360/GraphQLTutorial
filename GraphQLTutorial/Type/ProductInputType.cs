using GraphQL.Types;

namespace GraphQLTutorial.Type
{
    public class ProductInputType : InputObjectGraphType
    {
        public ProductInputType() 
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<FloatGraphType>("price");
        }
    }
}
