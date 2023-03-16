

namespace AquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorEstado
{
    public class FechaExpedicion
    {

        public DateTime Fecha { get; init; }


        public FechaExpedicion(DateTime fecha)
        {


           Fecha = fecha;

        }

        public static FechaExpedicion Crear(DateTime fecha)
        {

            validar(fecha);

            return new FechaExpedicion(fecha);

        }


        public static void validar(DateTime fecha)
        {

            if (fecha == null)
            {

                throw new ArgumentException("El valor no puede ser nulo");

            }

        }






    }
}
