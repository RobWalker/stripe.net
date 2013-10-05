using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeBalanceService
    {
        private string ApiKey { get; set; }

        public StripeBalanceService(string apiKey = null)
        {
            ApiKey = apiKey;
        }

        /*
        public virtual StripeBalance Get()
        {
            var url = string.Format("{0}", Urls.Balance);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeBalance>.MapFromJson(response);
        }
        */

        public virtual IEnumerable<StripeBalance> List(int count = 10, int offset = 0, string type = null)
        {
            var url = string.Format("{0}/history", Urls.Balance);

            url = ParameterBuilder.ApplyParameterToUrl(url, "count", count.ToString());
            url = ParameterBuilder.ApplyParameterToUrl(url, "offset", offset.ToString());

            if (!string.IsNullOrEmpty(type))
                url = ParameterBuilder.ApplyParameterToUrl(url, "type", type);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeBalance>.MapCollectionFromJson(response);
        }
    }
}