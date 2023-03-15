using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorFiador
{
   public record DatosPersonales{

        public string nombreCompleto { get; init; }

        public string direccion { get; init; }

        internal DatosPersonales(string nombreCompleto, string direccion)
        {

            this.nombreCompleto = nombreCompleto;
            this.direccion = direccion;

        }

        public static DatosPersonales Crear(string nombreCompleto, string direccion)
        {

            validar(nombreCompleto, direccion);

            return new DatosPersonales(nombreCompleto, direccion);

        }


        public static void validar(string nombreCompleto, string direccion)
        {

            if (nombreCompleto == null || direccion == null)
            {

                throw new ArgumentException("El valor no puede ser nulo");

            }

        }


    
}
}
