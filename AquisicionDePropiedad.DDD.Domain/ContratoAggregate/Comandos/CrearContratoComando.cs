using AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.ContratoAggregate.Comandos
{
    public class CrearContratoComando
    {
        public string AgenteInmobiliarioId { get; init; }
        public string ClienteId { get; init; }
       

        public CrearContratoComando(string agenteInmobiliarioId, string clienteId)
        {
            AgenteInmobiliarioId = agenteInmobiliarioId;
            ClienteId = clienteId;
           
        }


    }
}
