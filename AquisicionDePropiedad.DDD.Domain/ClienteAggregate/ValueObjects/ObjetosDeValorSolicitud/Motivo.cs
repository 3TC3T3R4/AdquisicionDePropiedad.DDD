using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Domain.ClienteAggregate.ValueObjects.ObjetosDeValorSolicitud
{
    public class Motivo
    {

        public string motivo { get; init; }


        public Motivo(string motivo)
        {


            this.motivo = motivo;

        }

        public static Motivo Crear(string motivo)
        {

            validar(motivo);

            return new Motivo(motivo);

        }


        public static void validar(string motivo)
        {

            if (motivo == null)
            {

                throw new ArgumentException("El valor no puede ser nulo");

            }

        }


    }
}
