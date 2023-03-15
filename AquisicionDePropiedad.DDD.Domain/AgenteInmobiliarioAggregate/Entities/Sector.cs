using AdquisicionDePropiedad.DDD.Domain.Comunes;
using AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.ValueObjects.ObjetoDeValorSector;

namespace AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Entities
{
    public class Sector : Entity<SectorId>
    {

        public PuntoCardinal PuntoCardinal { get; private set; }


        public Sector(SectorId id) : base(id) { }

     
        public void SetPuntoCardinal(PuntoCardinal punto)
        {

            this.PuntoCardinal = punto;

        }


    }
}
