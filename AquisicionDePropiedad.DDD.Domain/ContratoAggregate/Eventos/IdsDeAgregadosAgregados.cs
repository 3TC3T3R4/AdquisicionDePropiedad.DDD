using AdquisicionDePropiedad.DDD.Domain.Comunes;
using AdquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorContrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.ContratoAggregate.Eventos
{
    public class IdsDeAgregadosAgregados : DomainEvent
    {
        public IdsAgregados IdsAgregados { get; set; }

        public IdsDeAgregadosAgregados(IdsAgregados idsAgregados) : base("IdsDeAgregadosHijos.agregados")
        {

            IdsAgregados = idsAgregados;
        }


    }
}
