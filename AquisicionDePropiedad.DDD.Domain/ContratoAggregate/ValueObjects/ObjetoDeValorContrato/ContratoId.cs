using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorContrato
{
    public record ContratoId
    {

        public Guid value { get; set; }

        internal ContratoId(Guid value_)
        {
            this.value = value_;
        }
        public static ContratoId Crear(Guid value)
        {
            return new ContratoId(value);
        }

        public static implicit operator Guid(ContratoId contratoId)
        {

            return contratoId.value;

        }

    }
}
