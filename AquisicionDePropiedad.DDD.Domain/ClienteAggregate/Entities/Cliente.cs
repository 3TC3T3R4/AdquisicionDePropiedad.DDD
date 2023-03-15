using AdquisicionDePropiedad.DDD.Domain.Comunes;
using AdquisicionDePropiedad.DDD.Domain.ClienteAggregate.Eventos;
using AquisicionDePropiedad.DDD.Domain.ClienteAggregate.ValueObjects.ObjetosDeValorCliente;
using System.Text.Json.Serialization;

namespace AquisicionDePropiedad.DDD.Domain.ClienteAggregate.Entities
{
    public class Cliente : AggregateEvent<ClienteId>
    {

        public ClienteId ClienteId { get; init; }

        public DatosPersonales DatosPersonales { get; private set; }

        public virtual Solicitud Solicitud { get; private set; }

        public virtual Contacto Contacto { get; private set; }


        public Cliente(ClienteId clienteID) : base(clienteID)
        {
            this.ClienteId = clienteID;
        }


        public void SetClienteId(ClienteId clienteID)
        {
            AppendChange(new ClienteCreado(clienteID.ToString()));
        }

        public void SetDatosPersonales(DatosPersonales datosPersonales)
        {

            AppendChange(new DatosPersonalesAgregados(datosPersonales));

        }
        public void SetDatosPersonalesAgregado(DatosPersonales datosPersonales)
        {

            this.DatosPersonales = datosPersonales;

        }

        public void SetAgregarContactoParaCliente(Contacto contacto)
        {

            AppendChange(new ContactoParaClienteAgregado(contacto));

        }

        public void SetContactoAgregado(Contacto contacto)
        {

            this.Contacto = contacto;

        }

        public void SetAgregarSolicitudParaCliente(Solicitud solicitud)
        {

            AppendChange(new SolicitudParaClienteAgregado(solicitud));

        }
        public void SetSolicitudAgregado(Solicitud solicitud)
        {

            this.Solicitud = solicitud;

        }


    }
}
