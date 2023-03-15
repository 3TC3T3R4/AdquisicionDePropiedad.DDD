using AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.ValueObjects.ObjetoDeValorBienes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Domain.ContratoAggregate.Entities
{
    public class Contrato
    {

        public Guid Id { get; init; }
        public Guid FiadorId { get; private set; }
        public Guid EstadoId { get; private set; }
        public Guid ClienteId { get; private set; }
        public Guid AgenteInmobilarioId { get; private set; }
        //public Descripcion Descripcion { get; private set; }


        //public virtual AgenteInmobilario AgenteInmobilario { get; private set; }
        //public virtual Cliente Cliente { get; private set; }


        public Contrato(Guid id) => this.Id = id;

        //public void SetDescripcion(Descripcion descripcion)
        //{

        //    Descripcion = descripcion;

        //}
        public void SetFiadorId(Guid fiadorId)
        {

            FiadorId = fiadorId;

        }
        public void SetEstadoId(Guid estadoId)
        {

            EstadoId = estadoId;

        }
        public void SetClienteId(Guid clienteId)
        {

           ClienteId = clienteId;

        }
        public void SetAgenteInmobilarioId(Guid agenteInmobilarioId)
        {

            AgenteInmobilarioId = agenteInmobilarioId;

        }

    }
}
