using Newtonsoft.Json.Linq;

public class GraphQLRequest
{
    public string Query { get; set; }
    public JObject Variables { get; set; }
}