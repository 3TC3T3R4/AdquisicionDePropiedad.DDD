using AdquisicionDePropiedad.DDD.Domain.Comunes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Eventos
{
    //polimorfismo en los agregados 
    public class AgenteInmobiliarioCreado : DomainEvent
    {
        public string AgenteInmobiliarioId { get; init; }
        public AgenteInmobiliarioCreado(string agenteInmobiliarioId) : base("agenteInmobiliario.creado")
        {
            AgenteInmobiliarioId = agenteInmobiliarioId;
        }



    }
}
