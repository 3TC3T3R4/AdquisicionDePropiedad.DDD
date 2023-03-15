using AquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorFiador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Domain.ContratoAggregate.Entities
{
    public class Fiador
    {
        public Guid Id { get; init; }

        public DatosPersonales DatosPersonales { get; private set; }

        public Fiador(Guid id) => this.Id = id;

        public void SetDatosPersonales(DatosPersonales datosPersonales)
        {

            DatosPersonales = datosPersonales;

        }
    }
}
