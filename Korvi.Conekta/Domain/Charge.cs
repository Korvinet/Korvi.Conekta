using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korvi.Conekta.Domain
{
    public class Charge
    {
        public PaymentMethod payment_method { get; set; }
    }

    public class PaymentMethod
    {
        public string type { get; set; } = "default";
    }
}
