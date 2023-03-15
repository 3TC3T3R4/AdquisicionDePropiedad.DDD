using AdquisicionDePropiedad.DDD.Domain.ClienteAggregate.Eventos;
using AdquisicionDePropiedad.DDD.Domain.Comunes;
using AquisicionDePropiedad.DDD.Domain.ClienteAggregate.Entities;
using AquisicionDePropiedad.DDD.Domain.ClienteAggregate.ValueObjects.ObjetosDeValorCliente;


namespace AdquisicionDePropiedad.DDD.Domain.ClienteAggregate.Entities
{
    public class ClienteChangeApply
    {

        public Cliente CreateAggregate(List<DomainEvent> ev, ClienteId id)
        {
            Cliente cliente = new Cliente(id);
            ev.ForEach(evento =>
            {
                switch (evento)
                {

                    case DatosPersonalesAgregados datosPersonalesAgregados:
                        cliente.SetDatosPersonalesAgregado(datosPersonalesAgregados.DatosPersonales);
                        break;

                    case ContactoParaClienteAgregado contactoParaClienteAgregado:
                        cliente.SetContactoAgregado(contactoParaClienteAgregado.Contacto);
                        break;

                    case SolicitudParaClienteAgregado solicitudParaClienteAgregado:
                        cliente.SetSolicitudAgregado(solicitudParaClienteAgregado.Solicitud);
                        break;


                }

            });
            return cliente;
        }







    }
}
