using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorContrato
{
    public record Descripcion
    {

        public string descripcion { get; init; }


        internal Descripcion(string descripcion)
        {

            this.descripcion = descripcion;


        }

        public static Descripcion Crear(string descripcion)
        {

            validar(descripcion);

            return new Descripcion(descripcion);

        }


        public static void validar(string descripcion)
        {

            if (descripcion == null)
            {

                throw new ArgumentException("El valor no puede ser nulo");

            }

        }



    }
}
