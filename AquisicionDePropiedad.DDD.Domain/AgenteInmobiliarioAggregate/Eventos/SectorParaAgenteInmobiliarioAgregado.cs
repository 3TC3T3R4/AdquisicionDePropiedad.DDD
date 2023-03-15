using AdquisicionDePropiedad.DDD.Domain.Comunes;
using AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Eventos
{
    public class SectorParaAgenteInmobiliarioAgregado : DomainEvent
    {
        public Sector Sector { get; set; }

    public SectorParaAgenteInmobiliarioAgregado(Sector sector) : base("angenteInmobiliario.sector.agregado")
    {
        Sector = sector;
    }


}
}
