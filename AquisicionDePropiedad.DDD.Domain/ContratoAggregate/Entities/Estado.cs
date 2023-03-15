using AquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorEstado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Domain.ContratoAggregate.Entities
{
    public class Estado
    {

        public Guid Id { get; init; }

        public Aprobado Aprobado { get; private set; }
        public FechaExpedicion FechaExpedicion{ get; private set; }


        public void SetAprobado(Aprobado aprobado)
        {

            Aprobado = aprobado;

        }
        public void SetFechaExpedicion(FechaExpedicion fechaExpedicion)
        {

           FechaExpedicion = fechaExpedicion;

        }

    }
}
