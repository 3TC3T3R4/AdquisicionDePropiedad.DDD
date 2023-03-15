using AdquisicionDePropiedad.DDD.Domain.Comunes;


namespace AquisicionDePropiedad.DDD.Domain.ClienteAggregate.ValueObjects.ObjetosDeValorSolicitud
{
    public class SolicitudId : Identity
    {

        //contructor
        internal SolicitudId(Guid id) : base(id) { } //internal para que solo se pueda crear desde la misma capa

        //factory method: crea y devuelve una instancia usando el contructor
        public static SolicitudId Of(Guid id)
        {
            return new SolicitudId(id);
        }

    }
}
