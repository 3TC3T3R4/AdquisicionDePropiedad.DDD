using AdquisicionDePropiedad.DDD.Domain.Comunes;
using AquisicionDePropiedad.DDD.Domain.ClienteAggregate.ValueObjects.ObjetosDeValorCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.ClienteAggregate.Eventos
{
   public class DatosPersonalesAgregados : DomainEvent
    {
        public DatosPersonales DatosPersonales { get; set; }

        public DatosPersonalesAgregados(DatosPersonales datosPersonales) : base("datosPersonales.agregados")
        {

            DatosPersonales = datosPersonales;
        }


    }
}
