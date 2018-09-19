using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korvi.Conekta.Domain
{
    public class LineItem
    {
        /// <summary>
        /// Identificador único para el producto.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Nombre del producto.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Pequeña descripción del producto (maximo 250 chars) (opcional)
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// El precio por unidad expresado en centavos.
        /// </summary>
        public int unit_price { get; set; }

        /// <summary>
        /// Cantidad vendida del producto.
        /// </summary>
        public int quantity { get; set; }

        /// <summary>
        /// Indica el Storage Keeping Unit designado por la empresa (opcional)
        /// </summary>
        public string sku { get; set; }

        /// <summary>
        /// Arreglo que contiene las categorías a las que pertenece el producto. Debe tener al menos un elemento. (opcional)
        /// </summary>
        public string[] tags { get; set; }

        /// <summary>
        /// Marca del producto. (opcional)
        /// </summary>
        public string brand { get; set; }
    }
}
