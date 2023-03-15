using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.ClienteAggregate.Comandos
{
   public class AgregarContactoParaClienteComando
    {

        public string ClienteId { get; set; }

        public string Email { get; set; }

        public AgregarContactoParaClienteComando(string clienteId, string email)
        {
            ClienteId = clienteId;
            Email = email;
        }
    }
}
