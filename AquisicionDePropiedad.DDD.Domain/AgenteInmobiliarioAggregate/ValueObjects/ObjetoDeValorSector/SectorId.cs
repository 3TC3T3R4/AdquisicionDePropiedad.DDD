using AdquisicionDePropiedad.DDD.Domain.Comunes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.ValueObjects.ObjetoDeValorSector
{
    public class SectorId : Identity
    {
        //contructor
        internal SectorId(Guid id) : base(id) { } //internal para que solo se pueda crear desde la misma capa

        //factory method: crea y devuelve una instancia usando el contructor
        public static SectorId Of(Guid id)
        {
            return new SectorId(id);
        }
    }
}
