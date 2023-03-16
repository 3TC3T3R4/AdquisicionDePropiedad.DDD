using AdquisicionDePropiedad.DDD.Domain.Comunes;
using AquisicionDePropiedad.DDD.Domain.ContratoAggregate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.ContratoAggregate.Eventos
{
    public class FiadorParaContratoAgregado : DomainEvent
    {
        public Fiador Fiador { get; set; }

        public FiadorParaContratoAgregado(Fiador  fiador) : base("contrato.fiador.agregado")
        {
            Fiador = fiador;
        }


    }
}
