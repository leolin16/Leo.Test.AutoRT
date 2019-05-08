using GraphQL.Types;

namespace Leo.Test.AutoRT.Types
{
    public class MatchFilterEnumType : EnumerationGraphType<Enums.MatchFilter> // has scalar type as its base class
    {
        public MatchFilterEnumType()
        {
            Name = "MatchFilter";
            Description = "The type of MatchFilter for browsers and screens";
        }
    }
}