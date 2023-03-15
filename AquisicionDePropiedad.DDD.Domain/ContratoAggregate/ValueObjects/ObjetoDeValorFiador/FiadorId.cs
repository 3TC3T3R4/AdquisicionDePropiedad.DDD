using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorFiador
{
    public record FiadorId
    {

        public Guid value { get; set; }

        internal FiadorId(Guid value_)
        {
            this.value = value_;
        }
        public static FiadorId Crear(Guid value)
        {
            return new FiadorId(value);
        }

        public static implicit operator Guid(FiadorId fiadorId)
        {

            return fiadorId.value;

        }

    }
}
