using GraphQL.Types;
using Leo.Test.AutoRT.Queries;

namespace Leo.Test.AutoRT.Schemas
{

    public class HelloWorldSchema : Schema
    {
        public HelloWorldSchema(HelloWorldQuery query)
        {
            Query = query;
        }
    }
}
