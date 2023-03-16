
using AdquisicionDePropiedad.DDD.Domain.Comunes;

namespace AquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorFiador
{
    public class FiadorId :  Identity
    {
        //constructor
        public FiadorId(Guid id) : base(id) { }

        //crear metodo
        public static FiadorId Of(Guid id)
        {
            return new FiadorId(id);
        }

    }
}
