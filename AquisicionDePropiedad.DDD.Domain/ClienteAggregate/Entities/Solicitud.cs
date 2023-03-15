using AdquisicionDePropiedad.DDD.Domain.Comunes;
using AquisicionDePropiedad.DDD.Domain.ClienteAggregate.ValueObjects.ObjetosDeValorSolicitud;


namespace AquisicionDePropiedad.DDD.Domain.ClienteAggregate.Entities
{
    public class Solicitud : Entity<SolicitudId>
    
    {

        public Motivo Motivo{ get; private set; }

        public Solicitud(SolicitudId id) : base(id) { }

        public void SetMotivo(Motivo motivo)
        {

            this.Motivo = motivo;

        }




    }
}
