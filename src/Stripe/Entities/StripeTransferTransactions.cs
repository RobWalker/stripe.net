using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;
using System.Collections.Generic;

namespace Stripe
{
    public class StripeTransferTransaction
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("amount")]
        public int? AmountInCents { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("net")]
        public int? Net { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fee")]
        public int? Fee { get; set; }
    }

	public class StripeTransferTransactions
	{
		[JsonProperty("count")]
		public int? Count { get; set; }
        
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("data")]
        public List<StripeTransferTransaction> Data { get; set; }
	}
}