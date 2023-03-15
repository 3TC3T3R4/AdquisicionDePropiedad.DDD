using AdquisicionDePropiedad.DDD.Domain.Comunes;
using AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Eventos
{
    public class BienParaAgenteInmobiliarioAgregado : DomainEvent
    {

       public  Bienes Bienes { get; set; }


        public BienParaAgenteInmobiliarioAgregado(Bienes bienes) : base("angenteInmobiliario.bienes.agregado")
        {
            Bienes = bienes;
        }



    }
}
