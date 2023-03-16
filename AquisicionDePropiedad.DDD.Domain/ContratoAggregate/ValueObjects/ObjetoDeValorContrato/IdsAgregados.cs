using AquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorEstado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorContrato
{
    public class IdsAgregados
    {
        public string AgenteInmobiliarioId { get; init; }
        public string ClienteId { get; init; }

        public IdsAgregados(string agenteInmobiliarioId, string clienteId)
        {

            AgenteInmobiliarioId = agenteInmobiliarioId;
            ClienteId = clienteId;
        }


        public static IdsAgregados Crear(string agenteInmobilarioId, string clienteId)
        {

            validar(agenteInmobilarioId, clienteId);

            return new IdsAgregados(agenteInmobilarioId, clienteId);

        }


        public static void validar(string agenteInmobilarioId, string clienteId)
        {

            if (agenteInmobilarioId == null)
            {

                throw new ArgumentException("El valor no puede ser nulo");

            }
            else if (clienteId == null)
            {

                throw new ArgumentException("El valor no puede ser nulo");

            }


        }
    }

}
