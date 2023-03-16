using AdquisicionDePropiedad.DDD.Domain.Comunes;
using AquisicionDePropiedad.DDD.Domain.ContratoAggregate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.ContratoAggregate.Eventos
{
    public class EstadoParaContratoAgregado : DomainEvent
    {
        public Estado Estado { get; set; }

        public EstadoParaContratoAgregado(Estado estado) : base("contrato.Estado.agregado")
        {
            Estado = estado;
        }


    }
}
