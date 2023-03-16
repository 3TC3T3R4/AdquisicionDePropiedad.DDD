using AdquisicionDePropiedad.DDD.Domain.Comunes;
using AquisicionDePropiedad.DDD.Domain.ClienteAggregate.ValueObjects.ObjetosDeValorCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorEstado
{
    public class EstadoId : Identity
    {
        //constructor
        public EstadoId(Guid id) : base(id) { }

        //crear metodo
        public static EstadoId Of(Guid id)
        {
            return new EstadoId(id);
        }

    }
}
