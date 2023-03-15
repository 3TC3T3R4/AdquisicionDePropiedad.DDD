using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.ValueObjects.ObjetoDeValorSector
{
    public class PuntoCardinal{

        public string Sentido { get; init; }

        [JsonConstructor]
        public PuntoCardinal(string sentido)
        {

            Sentido = sentido;

        }
        [JsonConstructor]
        public PuntoCardinal()
        {
        }

        public static PuntoCardinal Crear(string sentido)
        {

            validar(sentido);
            return new PuntoCardinal(sentido);

        }


        public static void validar(string sentido)
        {

            if (sentido == null)
            {

                throw new ArgumentException("El valor no puede ser nulo");

            }

        }



    }
}
