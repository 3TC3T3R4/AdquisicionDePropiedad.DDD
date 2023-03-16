using AdquisicionDePropiedad.DDD.Domain.ContratoAggregate.Comandos;
using AdquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorContrato;
using AquisicionDePropiedad.DDD.Domain.ContratoAggregate.Entities;
using AquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorContrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasPatronAAA.Builder
{
    public class CrearContratoComandoBuilder
    {

        private string _AgenteInmobiliarioId;
        private string _ClienteId;
    

        public CrearContratoComandoBuilder ConIdAgente(string agenteId)
        {
            _AgenteInmobiliarioId = agenteId;
            return this;
       
        }

        public CrearContratoComandoBuilder ConIdCliente(string clienteId)
        {
            _ClienteId = clienteId;
            return this;

        }
       

        public CrearContratoComando Build()
        {
            return new CrearContratoComando(_AgenteInmobiliarioId, _ClienteId);
            
        }
    }
}
