using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;
using System.Collections.Generic;

namespace Stripe
{
	public class StripeBalance
	{
		[JsonProperty("amount")]
		public int? AmountInCents { get; set; }

        [JsonProperty("available_on")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime AvailableOn { get; set; }
        
        [JsonProperty("created")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime Created { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("net")]
		public int? NetInCents { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fee")]
        public int? Fee { get; set; }

		[JsonProperty("failure_message")]
		public string FailureMessage { get; private set; }
	}
}