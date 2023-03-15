using AdquisicionDePropiedad.DDD.Domain.Comunes;
using AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.ValueObjects.ObjetoDeValorSector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.ValueObjects.ObjetoDeValorBienes
{
    
        public class BienesId : Identity
    {

        //contructor
        internal BienesId(Guid id) : base(id) { } //internal para que solo se pueda crear desde la misma capa

        //factory method: crea y devuelve una instancia usando el contructor
        public static BienesId Of(Guid id)
        {
            return new BienesId(id);
        }

    }
    }

