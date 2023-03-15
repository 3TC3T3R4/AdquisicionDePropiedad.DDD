using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.ValueObjects.ObjetoDeValorBienes
{
    public class Descripcion
    {

        public string DescripcionDelBien { get; init; }


        internal Descripcion(string descripcion)
        {

            DescripcionDelBien = descripcion;


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
