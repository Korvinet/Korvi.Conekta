using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korvi.Conekta.Domain
{
    public class TaxLine
    {
        /// <summary>
        /// Identificador único para el cobro de impuesto.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Código del impuesto.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// La cantidad a cobrar por impuesto en centavos.
        /// </summary>
        public int amount { get; set; }
    }
}
