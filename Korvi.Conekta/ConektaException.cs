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
    public class ConektaException : Exception
    {
        public ConektaErrorResponse ConektaErrorData { get; set; }

        public ConektaException(WebException ex)
        {
            var responseString = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
            ConektaErrorData = JsonConvert.DeserializeObject<ConektaErrorResponse>(responseString);
        }
    }

    public class ConektaErrorResponse
    {
        /// <summary>
        /// Contiene el tipo de error y el código de error.
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// El id del log de la petición http registrando este error.
        /// </summary>
        public string log_id { get; set; }

        /// <summary>
        /// Lista detallada de los errores.
        /// </summary>
        public List<ConektaErrorResponseDetails> details { get; set; }
    }

    public class ConektaErrorResponseDetails
    {
        public string debug_message { get; set; }

        public string message { get; set; }

        public string param { get; set; }

        public string code { get; set; }
    }
}
