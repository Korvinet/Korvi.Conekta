using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korvi.Conekta.Domain
{
    public class DiscountLine
    {
        /// <summary>
        /// Identificador único del descuento, asignado al azar.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Código del descuento.
        /// </summary>
        public string code { get; set; }

        /// <summary>
        /// Puede ser 'loyalty', 'campaign', 'coupon' o 'sign'
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// La cantidad a descontar de la suma total de todos los pagos, en centavos.
        /// </summary>
        public int amount { get; set; }
    }
}
