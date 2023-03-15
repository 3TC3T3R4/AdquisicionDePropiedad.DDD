using AdquisicionDePropiedad.DDD.Domain.Comunes;


namespace AquisicionDePropiedad.DDD.Domain.ClienteAggregate.ValueObjects.ObjetosDeValorCliente
{
    public class ClienteId : Identity
    {
        //constructor
        public ClienteId(Guid id) : base(id) { }

        //crear metodo
        public static ClienteId Of(Guid id)
        {
            return new ClienteId(id);
        }


    }
}
