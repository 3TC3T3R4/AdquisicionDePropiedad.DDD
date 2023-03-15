using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorEstado
{
    public record EstadoId
    {

        public Guid value { get; set; }

        internal EstadoId(Guid value_)
        {
            this.value = value_;
        }
        public static EstadoId Crear(Guid value)
        {
            return new EstadoId(value);
        }

        public static implicit operator Guid(EstadoId estadoId)
        {

            return estadoId.value;

        }

    }
}
