using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korvi.Conekta.Domain
{
    public class CreateCustomerResponse
    {
        public bool livemode { get; set; }

        public string name { get; set; }

        public string email { get; set; }

        public string phone { get; set; }

        public string id { get; set; }

        public string @object { get; set; }

        public long created_at { get; set; }

        public bool corporate { get; set; }

        public string custom_id { get; set; }

        public string default_payment_source_id { get; set; }

        public PaymentSourcesCustomerResponse payment_sources { get; set; }
    }

    public class PaymentSourcesCustomerResponse
    {
        public string @object { get; set; }

        public bool has_more { get; set; }

        public int total { get; set; }

        public List<PaymentSource> data { get; set; }
    }
}
