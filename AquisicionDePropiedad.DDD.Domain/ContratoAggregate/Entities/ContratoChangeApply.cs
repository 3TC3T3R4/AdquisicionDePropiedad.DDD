using AdquisicionDePropiedad.DDD.Domain.ContratoAggregate.Eventos;
using AdquisicionDePropiedad.DDD.Domain.Comunes;
using AquisicionDePropiedad.DDD.Domain.ContratoAggregate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorContrato;

namespace AdquisicionDePropiedad.DDD.Domain.ContratoAggregate.Entities
{
    public class ContratoChangeApply
    {
        public Contrato CreateAggregate(List<DomainEvent> ev, ContratoId id)
        {
            Contrato contrato = new Contrato(id);
            ev.ForEach(evento =>
            {
                switch (evento)
                {

                    case IdsDeAgregadosAgregados   idsDeAgregadosAgregados :
                        contrato.SetIdsDeAgregadosFinal(idsDeAgregadosAgregados.IdsAgregados);
                        break;

                    case FiadorParaContratoAgregado fiadorParaContratoAgregado:
                       contrato.SetFiadorAgregado(fiadorParaContratoAgregado.Fiador);
                        break;

                    case EstadoParaContratoAgregado estadoParaContratoAgregado:
                        contrato.SetEstadoAgregado(estadoParaContratoAgregado.Estado);
                        break;


                }

            });
            return contrato;
        }




    }
}
