using GraphQL.Types;

namespace Leo.Test.AutoRT.Types
{
    class ScreenType : ObjectGraphType<Screen>
    {
        public ScreenType()
        {
            Field(i => i.Id);
            Field(i => i.Category);
            Field(i => i.ScreenName);
            Field(i => i.ScreenJpName);
        }
    }
}