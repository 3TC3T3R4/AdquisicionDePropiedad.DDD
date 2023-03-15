using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorEstado
{
    public record FechaExpedicion
    {

        public DateTime fechaExpedicion { get; init; }


        internal FechaExpedicion(DateTime fechaExpedicion)
        {

            this.fechaExpedicion = fechaExpedicion;


        }

        public static FechaExpedicion Crear(DateTime fechaExpedicion)
        {

            validar(fechaExpedicion);

            return new FechaExpedicion(fechaExpedicion);

        }


        public static void validar(DateTime fechaExpedicion)
        {

            if (fechaExpedicion == null)
            {

                throw new ArgumentException("El valor no puede ser nulo");

            }

        }





    }
}
