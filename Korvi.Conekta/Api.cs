using Korvi.Conekta.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Korvi.Conekta
{
    public class Api
    {
        #region Constants 

        private const string API_URL = "https://api.conekta.io/";

        #endregion

        #region Fields 

        private string _privateKey;

        #endregion

        /// <summary>
        /// Genera una nueva clase para empezar a ejecutar las llamadas.
        /// </summary>
        /// <param name="privateKey"></param>
        public Api(string privateKey)
        {
            _privateKey = privateKey;
        }

        /// <summary>
        /// Crea un nuevo cliente en Conekta.
        /// </summary>
        /// <param name="createCustomer"></param>
        /// <returns></returns>
        public CreateCustomerResponse CreateCustomer(Customer customer)
        {
            string url = $"{API_URL}customers";
            return Post<CreateCustomerResponse>(url, customer);
        }

        /// <summary>
        /// Crea una nueva orden en conekta.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public CreateOrderResponse CreateOrder(Order order)
        {
            string url = $"{API_URL}orders";
            return Post<CreateOrderResponse>(url, order);
        }

        #region Private methods 

        private T Post<T>(string url, object data)
        {
            HttpWebResponse response = Post(url, data);
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            T result = JsonConvert.DeserializeObject<T>(responseString);
            return result;
        }

        private HttpWebResponse Post(string url, object data)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            request.ContentType = "application/json";
            request.Accept = "application/vnd.conekta-v2.0.0+json";
            request.UserAgent = "Conekta/v1 DotNetBindings10/Conekta::2.0.0";
            request.Method = "POST";

            var uname = Environment.OSVersion;
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(_privateKey);
            var userAgent = (@"{
				  ""bindings_version"":""2.0.0"",
				  ""lang"":"".net"",
				  ""lang_version"":""" + typeof(string).Assembly.ImageRuntimeVersion + @""",
				  ""publisher"":""conekta"",
				  ""uname"":""" + uname + @"""
				}");

            string encoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes($"{_privateKey}:"));
            request.Headers.Add("Authorization", $"Basic {encoded}");
            request.Headers.Add("Accept-Language", "es");
            request.Headers.Add("X-Conekta-Client-User-Agent", userAgent);

            JsonSerializerSettings settings = new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            string parsedContent = JsonConvert.SerializeObject(data, settings);
            byte[] bytes = Encoding.UTF8.GetBytes(parsedContent);

            Stream stream = request.GetRequestStream();
            stream.Write(bytes, 0, bytes.Length);
            stream.Close();

            return (HttpWebResponse)request.GetResponse();
        }

        #endregion
    }
}
