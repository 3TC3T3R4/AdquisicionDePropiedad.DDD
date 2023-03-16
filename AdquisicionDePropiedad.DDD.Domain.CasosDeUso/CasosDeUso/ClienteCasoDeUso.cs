using AdquisicionDePropiedad.DDD.Domain.CasosDeUso.Entradas;
using AdquisicionDePropiedad.DDD.Domain.ClienteAggregate.Comandos;
using AdquisicionDePropiedad.DDD.Domain.ClienteAggregate.Entities;
using AdquisicionDePropiedad.DDD.Domain.ClienteAggregate.Eventos;
using AdquisicionDePropiedad.DDD.Domain.Comunes;
using AdquisicionDePropiedad.DDD.Domain.Genericos;
using AquisicionDePropiedad.DDD.Domain.ClienteAggregate.Entities;
using AquisicionDePropiedad.DDD.Domain.ClienteAggregate.ValueObjects.ObjetosDeValorCliente;
using AquisicionDePropiedad.DDD.Domain.ClienteAggregate.ValueObjects.ObjetosDeValorContacto;
using AquisicionDePropiedad.DDD.Domain.ClienteAggregate.ValueObjects.ObjetosDeValorSolicitud;
using Newtonsoft.Json;


namespace AdquisicionDePropiedad.DDD.Domain.CasosDeUso.CasosDeUso
{
    public class ClienteCasoDeUso : lClienteCasoDeUso
    {

        private readonly IStoredEventRepository<StoredEvent> _storedEventRepository;
        public ClienteCasoDeUso(IStoredEventRepository<StoredEvent> clienteRepository)
        {
            _storedEventRepository = clienteRepository;
        }

        public async Task CrearCliente(CrearClienteComando comando)
        {

            var cliente = new Cliente(ClienteId.Of(Guid.NewGuid()));
            cliente.SetClienteId(cliente.ClienteId);
            var datosPersonales = DatosPersonales.Crear(
                       comando.Nombre,
                       comando.Apellido,
                       comando.Edad,
                       comando.Genero
                    );

            cliente.SetDatosPersonales(datosPersonales);
            List<DomainEvent> listDomain = cliente.getUncommittedChanges();
            await SaveEvents(listDomain);


        }

        public async Task AgregarContactoParaCliente(AgregarContactoParaClienteComando comando)
        {

            var clienteChange = new ClienteChangeApply();
            var listDomainEvents = await GetEventsByAggregateID(comando.ClienteId);
            var clienteId = ClienteId.Of(Guid.Parse(comando.ClienteId));
            var clienteGenerado = clienteChange.CreateAggregate(listDomainEvents, clienteId);

            Contacto nuevoContacto = new Contacto(ContactoId.Of(Guid.NewGuid()));
            var email = Email.Crear(
                comando.Email
             
            );

            nuevoContacto.SetEmail(email);

            clienteGenerado.SetAgregarContactoParaCliente(nuevoContacto);
            List<DomainEvent> domainEvents = clienteGenerado.getUncommittedChanges();
            await SaveEvents(domainEvents);


        }

        public async Task AgregarSolicitudParaCliente(AgregarSolicitudParaClienteComando comando)
        {

            var clienteChange = new ClienteChangeApply();
            var listDomainEvents = await GetEventsByAggregateID(comando.ClienteId);

            var clienteId = ClienteId.Of(Guid.Parse(comando.ClienteId));
            var clienteGenerado = clienteChange.CreateAggregate(listDomainEvents, clienteId);

            Solicitud nuevoSolicitud = new Solicitud(SolicitudId.Of(Guid.NewGuid()));
            var motivo = Motivo.Crear(
                comando.Motivo
            );

            nuevoSolicitud.SetMotivo(motivo);

            clienteGenerado.SetAgregarSolicitudParaCliente(nuevoSolicitud);
            List<DomainEvent> domainEvents = clienteGenerado.getUncommittedChanges();
            await SaveEvents(domainEvents);

        }


        private async Task SaveEvents(List<DomainEvent> list)
        {
            var array = list.ToArray();
            for (var index = 0; index < array.Length; index++)
            {
                var stored = new StoredEvent();
                stored.AggregateId = array[index].GetAggregateId();
                stored.StoredName = array[index].GetAggregate();
                switch (array[index])
                {

                    case DatosPersonalesAgregados datosPersonalesAgregados:
                        stored.EventBody = JsonConvert.SerializeObject(datosPersonalesAgregados);
                        break;

                    case ClienteCreado clienteCreado:
                        stored.EventBody = JsonConvert.SerializeObject(clienteCreado);
                        break;

                    case ContactoParaClienteAgregado contactoParaClienteAgregado:
                        stored.EventBody = JsonConvert.SerializeObject(contactoParaClienteAgregado);
                        break;


                    case SolicitudParaClienteAgregado solicitudParaClienteAgregado:
                        stored.EventBody = JsonConvert.SerializeObject(solicitudParaClienteAgregado);
                        break;


                }
                await _storedEventRepository.AddAsync(stored);

            }

            await _storedEventRepository.SaveChangesAsync();

        }

        private async Task<List<DomainEvent>> GetEventsByAggregateID(string aggregateId)
        {
            var listadoStoredEvents = await _storedEventRepository.GetEventsByAggregateId(aggregateId);

            if (listadoStoredEvents == null)
                throw new ArgumentException("No existe el Id del agregado en la base de datos");

            return listadoStoredEvents.Select(ev =>
            {
                string nombre = $"AdquisicionDePropiedad.DDD.Domain.ClienteAggregate.Eventos.{ev.StoredName},  AdquisicionDePropiedad.DDD.Domain";
                Type tipo = Type.GetType(nombre);
                DomainEvent eventoParseado = (DomainEvent)JsonConvert.DeserializeObject(ev.EventBody, tipo);
                return eventoParseado;

            }).ToList();
        }


    }
}