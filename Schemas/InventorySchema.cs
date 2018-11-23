using GraphQL.Types;
using Leo.Test.AutoRT.Mutations;
using Leo.Test.AutoRT.Queries;

namespace Leo.Test.AutoRT.Schemas
{

    public class InventorySchema : Schema
    {
        public InventorySchema(InventoryQuery query, InventoryMutation mutation)
        {
            Query = query;
            Mutation = mutation;
        }
    }
}
