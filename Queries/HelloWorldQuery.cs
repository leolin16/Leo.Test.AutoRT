using GraphQL.Types;
using Leo.Test.AutoRT.Data;
using Leo.Test.AutoRT.Types;

namespace Leo.Test.AutoRT.Queries
{
    public class HelloWorldQuery: ObjectGraphType
    {
        public HelloWorldQuery()
        {
            Field<StringGraphType>(
                name: "hello",
                resolve: context => "world"
            );
            Field<StringGraphType>(
                name: "howdy",
                resolve: context => "universe"
            );
            Field<ScreenType>(
                "screen",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "screenName" }),
                resolve: context =>
                {
                    // return new Screen {
                    //     Category = "Eface_Core",
                    //     ScreenName = "EC_UW_MF",
                    //     ScreenJpName = "引受照会マイタスク_MainFrame"
                    // };
                    var screenName = context.GetArgument<string>("screenName");
                    return new DataSource().GetScreenByScreenName(screenName);
                }
            );
        }
    }
}