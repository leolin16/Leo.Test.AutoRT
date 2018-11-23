using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leo.Test.AutoRT.Types
{
    public class ScreenInputType : InputObjectGraphType
    {
        public ScreenInputType()
        {
            Name = "ScreenInput";
            Field<NonNullGraphType<StringGraphType>>("Category");
            Field<NonNullGraphType<StringGraphType>>("ScreenName");
            Field<NonNullGraphType<StringGraphType>>("ScreenJpName");
        }
    }
}