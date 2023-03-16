using AdquisicionDePropiedad.DDD.Domain.Comunes;
using AquisicionDePropiedad.DDD.Domain.ClienteAggregate.ValueObjects.ObjetosDeValorContacto;
using AquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorFiador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Domain.ContratoAggregate.Entities
{
    public class Fiador : Entity<FiadorId>
    {

        public DatosPersonales DatosPersonales { get; private set; }

        public Fiador(FiadorId id) : base(id) { }

        public void SetDatosPersonales(DatosPersonales datosPersonales)
        {

            DatosPersonales = datosPersonales;

        }
    }
}
