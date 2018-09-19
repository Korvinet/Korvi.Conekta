using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korvi.Conekta.Domain
{
    public class ShippingLine
    {
        /// <summary>
        /// Identificador único, asignado al azar.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// El precio del envío en centavos.
        /// </summary>
        public int amount { get; set; }

        /// <summary>
        /// Número de rastreo que el proveedor de envios proporciona. (opcional)
        /// </summary>
        public string tracking_number { get; set; }

        /// <summary>
        /// Nombre del proveedor de envío.
        /// </summary>
        public string carrier { get; set; }

        /// <summary>
        /// Método de envío. (opcional)
        /// </summary>
        public string method { get; set; }
    }
}
