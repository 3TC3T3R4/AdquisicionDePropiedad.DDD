using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.ValueObjects.ObjetoDeValorBienes
{
    public class Precio
    {

        public int Valor { get; init; }


        internal Precio(int valor)
        {

            Valor = valor;


        }

        public static Precio Crear(int valor)
        {

            validar(valor);

            return new Precio(valor);

        }


        public static void validar(int valor)
        {

            if (valor == null)
            {

                throw new ArgumentException("El valor no puede ser nulo");

            }

        }



    }
}
