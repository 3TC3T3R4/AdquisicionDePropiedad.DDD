using AdquisicionDePropiedad.DDD.Domain.Comunes;
using AquisicionDePropiedad.DDD.Domain.ClienteAggregate.ValueObjects.ObjetosDeValorContacto;
using AquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorEstado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Domain.ContratoAggregate.Entities
{
    public class Estado : Entity<EstadoId>
    {


        public Aprobado Aprobado { get; private set; }
        public FechaExpedicion FechaExpedicion{ get; private set; }


        public Estado(EstadoId id) : base(id) { }

        public void SetAprobado(Aprobado aprobado)
        {

            this.Aprobado = aprobado;

        }
        public void SetFechaExpedicion(FechaExpedicion fechaExpedicion)
        {

           this.FechaExpedicion = fechaExpedicion;

        }

    }
}
