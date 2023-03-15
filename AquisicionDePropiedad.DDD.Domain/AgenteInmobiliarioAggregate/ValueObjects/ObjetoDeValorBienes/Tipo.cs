using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.ValueObjects.ObjetoDeValorBienes
{
    public class Tipo
    {

        public string TipoDeBien { get; init; }


        internal Tipo(string tipo)
        {


            TipoDeBien = tipo;


        }

        public static Tipo Crear( string tipo)
        {

            validar(tipo);

            return new Tipo(tipo);

        }


        public static void validar(string tipo)
        {

            if (tipo == null)
            {

                throw new ArgumentException("El valor no puede ser nulo");

            }

        }



    }
}
