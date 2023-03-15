using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorEstado
{
    public record Aprobado
    {

        public bool aprobado { get; init; }


        internal Aprobado(bool aprobado)
        {

            this.aprobado = aprobado;


        }

        public static Aprobado Crear(bool aprobado)
        {

            validar(aprobado);

            return new Aprobado(aprobado);

        }


        public static void validar(bool aprobado)
        {

            if (aprobado == null)
            {

                throw new ArgumentException("El valor no puede ser nulo");

            }

        }





    }
}
