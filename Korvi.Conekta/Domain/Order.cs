using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korvi.Conekta.Domain
{
    public class Order
    {
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Divisa con la cual se realizará el cobro. Utiliza el código de 3 letras del 
        /// https://es.wikipedia.org/wiki/ISO_4217
        /// </summary>
        public string currency { get; set; }

        /// <summary>
        /// Lista de los productos que se venden en la orden. Debe tener al menos un producto.
        /// </summary>
        public List<LineItem> line_items { get; set; }

        /// <summary>
        /// Lista de los costos de envío. Si la tienda en línea ofrece productos digitales. (opcional)
        /// </summary>
        public List<ShippingLine> shipping_lines { get; set; }

        /// <summary>
        /// Lista de los impuestos que se pagan. (opcional)
        /// </summary>
        public List<TaxLine> tax_lines { get; set; }

        /// <summary>
        /// Lista de los descuentos que se aplican a la orden. (opcional)
        /// </summary>
        public List<DiscountLine> discount_lines { get; set; }

        /// <summary>
        /// Lista de los cargos que se generaron para cubrir el monto de la orden.
        /// </summary>
        public List<Charge> charges { get; set; }

        /// <summary>
        /// Indica si los cargos de la orden deben ser preautorizados.
        /// </summary>
        public bool? pre_authorize { get; set; } = null;

        /// <summary>
        /// Hash que contiene la información del cliente.
        /// </summary>
        public CustomerInfo customer_info { get; set; }

        public static Order CreateOrderObject(string currency, string customer_id,  List<LineItem> lineItems)
        {
            var order = new Order()
            {
                currency = currency,
                customer_info = new CustomerInfo() { customer_id = customer_id },
                line_items = lineItems
            };
            order.charges = new List<Charge>();
            order.charges.Add(new Charge() { payment_method = new PaymentMethod() });


            return order;
        }

    }

    public class CustomerInfo
    {
        public string customer_id { get; set; }
    }
}
