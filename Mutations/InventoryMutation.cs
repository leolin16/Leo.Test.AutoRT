using GraphQL.Types;
using Leo.Test.AutoRT.Interfaces;
using Leo.Test.AutoRT.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leo.Test.AutoRT.Mutations
{
    public class InventoryMutation : ObjectGraphType
    {
        public InventoryMutation(IDataStore dataStore)
        {
            Field<ScreenType>(
                "createScreen",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<ScreenInputType>> { Name = "screen" }
                ),
                resolve: context =>
                {
                    var screen = context.GetArgument<Screen>("screen");
                    return dataStore.AddScreen(screen);
                });
        }
    }
}