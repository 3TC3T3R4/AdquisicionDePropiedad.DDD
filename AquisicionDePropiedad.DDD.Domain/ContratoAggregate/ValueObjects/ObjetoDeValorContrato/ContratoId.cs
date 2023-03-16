using AdquisicionDePropiedad.DDD.Domain.Comunes;

namespace AquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorContrato
{
    public class ContratoId : Identity
    {
        //constructor
        public ContratoId(Guid id) : base(id) { }

        //crear metodo
        public static ContratoId Of(Guid id)
        {
            return new ContratoId(id);
        }

    }
}
