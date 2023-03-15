using AdquisicionDePropiedad.DDD.Domain.Comunes;
using AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.ValueObjects.ObjetoDeValorSector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Domain.ClienteAggregate.ValueObjects.ObjetosDeValorContacto
{
    public class ContactoId : Identity
    {

        //contructor
        public ContactoId(Guid id) : base(id) { } //internal para que solo se pueda crear desde la misma capa

        //factory method: crea y devuelve una instancia usando el contructor
        public static ContactoId Of(Guid id)
        {
            return new ContactoId(id);
        }

    }
}
