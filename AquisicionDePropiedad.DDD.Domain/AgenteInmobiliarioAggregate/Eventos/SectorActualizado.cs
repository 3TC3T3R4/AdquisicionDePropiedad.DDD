using AdquisicionDePropiedad.DDD.Domain.Comunes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Eventos
{
    public class SectorActualizado : DomainEvent
    {

        //public PuntoCardinal PuntoCardinal { get; set; }

        //public SectorActualizado(SectorActualizado accountDetail) : base("detalledecuenta.agregado")
        //{
        //    AccountDetail = accountDetail;
        //}
        public SectorActualizado(string type) : base(type)
        {
        }
    }
}
