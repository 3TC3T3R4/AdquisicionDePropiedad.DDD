using AquisicionDePropiedad.DDD.Domain.ClienteAggregate.ValueObjects.ObjetosDeValorContacto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorEstado
{
    public class Aprobado
    {
        public bool AprobadoFinal { get; init; }


        public Aprobado(bool aprobado)
        {


            AprobadoFinal = aprobado;

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
