using AdquisicionDePropiedad.DDD.Domain.Comunes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.ValueObjects.ObjetoDeValorAgenteInmobiliario
{
   public class AgenteInmobiliarioId : Identity {

        
        //constructor
        public AgenteInmobiliarioId(Guid id) : base(id) { }

        //crear metodo
        public static AgenteInmobiliarioId Of(Guid id)
        {
            return new AgenteInmobiliarioId(id);
        }



    }
}
