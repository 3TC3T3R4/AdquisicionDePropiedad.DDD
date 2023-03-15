using AdquisicionDePropiedad.DDD.Domain.Comunes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.ClienteAggregate.Eventos
{
    public  class ClienteCreado : DomainEvent
    {

        public string ClienteId { get; init; }
        public ClienteCreado(string clienteId) : base("cliete.creado")
        {
            ClienteId = clienteId;
        }




    }
}
