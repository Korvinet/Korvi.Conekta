using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korvi.Conekta.Domain
{
    public class CreateOrderResponse
    {
        public bool livemode { get; set; }

        public int amount { get; set; }

        public string currency { get; set; }

        public string payment_status { get; set; }

        public int amount_refunded { get; set; }

        public string id { get; set; }

        public long created_at { get; set; }

        public long updated_at { get; set; }
    }
}
