using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Korvi.Conekta.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Korvi.Conekta.Tests
{
    [TestClass]
    public class ApiTests
    {
        private static Api _conektaApi = new Api("key_e3L7HCRi7nUc4cPbqkKucg");

        [TestMethod]
        public void TestCreateCustomerAndOrder()
        {
            Customer customer = Customer.CreateCustomerObject("Fulanito Pérez", "fulanito@conekta.com", "+52181818181", "tok_test_visa_4242");
            CreateCustomerResponse response = _conektaApi.CreateCustomer(customer);

            Assert.IsFalse(string.IsNullOrEmpty(response.id));

            List<LineItem> items = new List<LineItem>();
            items.Add(new LineItem() { name = "Tacos", unit_price = 1000, quantity = 12 });

            Order order = Order.CreateOrderObject("MXN", response.id, items);
            var orderResponse = _conektaApi.CreateOrder(order);

            Assert.IsFalse(string.IsNullOrEmpty(orderResponse.id));
        }

        [TestMethod]
        public void TestError()
        {
            try
            {
                Customer customer = Customer.CreateCustomerObject("Fulanito Pérez", "fulanito@conekta.com", "+52181818181", "tok_test_visa_42");
                CreateCustomerResponse response = _conektaApi.CreateCustomer(customer);
            }
            catch(ConektaException ex)
            {
                string code = ex.ConektaErrorData.details.First().code;
                Assert.AreEqual(code, "conekta.errors.parameter_validation.payment_sources.token_id.nonexistent_token");
            }
        }
    }
}
