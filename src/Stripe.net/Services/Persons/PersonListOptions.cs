namespace Stripe
{
    using Newtonsoft.Json;

    public class PersonListOptions : ListOptions
    {
        [JsonProperty("relationship")]
        public PersonRelationshipListOptions Relationship { get; set; }
    }
}
