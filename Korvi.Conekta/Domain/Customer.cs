using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korvi.Conekta.Domain
{
    public class Customer
    {
        /// <summary>
        /// Id del cliente.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Nombre del cliente.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Correo electrónico del cliente.
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// Teléfono del cliente (formato internacional) (opcional).
        /// </summary>
        public string phone { get; set; }


        public List<PaymentSource> payment_sources { get; set; }

        public static Customer CreateCustomerObject(string name, string email, string phone, string token)
        {
            var customer = new Customer()
            {
                name = name,
                email = email,
                phone = phone
            };

            customer.payment_sources = new List<PaymentSource>();
            customer.payment_sources.Add(new PaymentSource() { token_id = token });

            return customer;
        }
    }
}
