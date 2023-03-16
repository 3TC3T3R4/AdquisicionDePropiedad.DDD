using AdquisicionDePropiedad.DDD.Domain.Comunes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.ContratoAggregate.Eventos
{
    public  class ContratoCreado : DomainEvent
    {

        public string ContratoId { get; init; }
        public ContratoCreado(string contratoId) : base("contrato.creado")
        {
            ContratoId = contratoId;
        }

    }
}
