using GraphQL.Types;

namespace Leo.Test.AutoRT.Types
{
    public class ScreenType : ObjectGraphType<Screen>
    {
        public ScreenType()
        {
            Field(i => i.Id);
            Field(i => i.Category);
            Field(i => i.ScreenName).Description("The name of the screen");
            Field(i => i.ScreenJpName);
            Field<MatchFilterEnumType>("MatchFilter", "The type of MatchFilter for browsers and screens");
        }
    }
}