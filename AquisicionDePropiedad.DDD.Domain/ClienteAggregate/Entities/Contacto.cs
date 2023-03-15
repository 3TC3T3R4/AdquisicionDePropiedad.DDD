using AdquisicionDePropiedad.DDD.Domain.Comunes;
using AquisicionDePropiedad.DDD.Domain.ClienteAggregate.ValueObjects.ObjetosDeValorContacto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Domain.ClienteAggregate.Entities
{
     public class Contacto  : Entity<ContactoId>
    {

        public Email Email { get; private set; }

        public Contacto(ContactoId id) : base(id) { }

        public void SetEmail(Email email)
        {

            this.Email = email;

        }



    }
}
