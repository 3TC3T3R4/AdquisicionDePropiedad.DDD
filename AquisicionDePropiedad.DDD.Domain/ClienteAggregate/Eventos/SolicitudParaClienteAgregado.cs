using AdquisicionDePropiedad.DDD.Domain.Comunes;
using AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Entities;
using AquisicionDePropiedad.DDD.Domain.ClienteAggregate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.ClienteAggregate.Eventos
{
    public class SolicitudParaClienteAgregado : DomainEvent
    {
        public Solicitud Solicitud { get; set; }

        public SolicitudParaClienteAgregado(Solicitud solicitud) : base("cliente.solicitud.agregado")
        {
            Solicitud = solicitud;
        }


    }
}
