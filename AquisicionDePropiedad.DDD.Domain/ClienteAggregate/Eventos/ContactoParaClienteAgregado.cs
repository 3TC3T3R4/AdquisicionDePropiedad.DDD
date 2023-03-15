using AdquisicionDePropiedad.DDD.Domain.Comunes;
using AquisicionDePropiedad.DDD.Domain.ClienteAggregate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.ClienteAggregate.Eventos
{
    public class ContactoParaClienteAgregado : DomainEvent
    {
        public Contacto Contacto { get; set; }

        public ContactoParaClienteAgregado(Contacto contacto) : base("cliente.contacto.agregado")
        {
            Contacto = contacto;
        }


    }
}
