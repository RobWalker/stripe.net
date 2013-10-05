using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeTransferService
    {
        private string ApiKey { get; set; }

        public StripeTransferService(string apiKey = null)
        {
            ApiKey = apiKey;
        }

        /*
        public virtual StripeTransfer Get()
        {
            var url = string.Format("{0}", Urls.Transfer);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeTransfer>.MapFromJson(response);
        }
        */

        public virtual IEnumerable<StripeTransfer> List(int count = 10, int offset = 0)
        {
            var url = string.Format("{0}", Urls.Transfers);

            url = ParameterBuilder.ApplyParameterToUrl(url, "count", count.ToString());
            url = ParameterBuilder.ApplyParameterToUrl(url, "offset", offset.ToString());

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeTransfer>.MapCollectionFromJson(response);
        }
    }
}