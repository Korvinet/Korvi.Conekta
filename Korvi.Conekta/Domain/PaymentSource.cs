using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korvi.Conekta.Domain
{
    public class PaymentSource
    {
        /// <summary>
        /// Identificador único asignado al azar.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Tipo del método de pago. Por el momento el único tipo permitido es "card".
        /// </summary>
        public string type { get; set; } = "card";

        /// <summary>
        /// Token id generado para la tarjeta.
        /// </summary>
        public string token_id { get; set; }

        public long? created_at { get; set; } = null;

        public string last4 { get; set; }

        public string bin { get; set; }

        public string exp_month { get; set; }

        public string exp_year { get; set; }

        public string brand { get; set; }

        public string name { get; set; }

        public string parent_id { get; set; }

        public bool? @default { get; set; } = null;
    }
}
