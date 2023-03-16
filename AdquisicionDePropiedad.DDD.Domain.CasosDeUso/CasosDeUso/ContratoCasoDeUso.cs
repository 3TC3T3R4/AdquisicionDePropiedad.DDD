using AdquisicionDePropiedad.DDD.Domain.CasosDeUso.Entradas;
using AdquisicionDePropiedad.DDD.Domain.Comunes;
using AdquisicionDePropiedad.DDD.Domain.ContratoAggregate.Comandos;
using AdquisicionDePropiedad.DDD.Domain.ContratoAggregate.Entities;
using AdquisicionDePropiedad.DDD.Domain.ContratoAggregate.Eventos;
using AdquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorContrato;
using AdquisicionDePropiedad.DDD.Domain.Genericos;
using AquisicionDePropiedad.DDD.Domain.ContratoAggregate.Entities;
using AquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorContrato;
using AquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorEstado;
using AquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorFiador;
using Newtonsoft.Json;


namespace AdquisicionDePropiedad.DDD.Domain.CasosDeUso.CasosDeUso
{
    public class ContratoCasoDeUso : lContratoCasoDeUso
    {

        private readonly IStoredEventRepository<StoredEvent> _storedEventRepository;
        public ContratoCasoDeUso(IStoredEventRepository<StoredEvent> contratoRepository)
        {
            _storedEventRepository = contratoRepository;
        }


        public async Task CrearContrato(CrearContratoComando comando)
        {

            var contrato = new Contrato(ContratoId.Of(Guid.NewGuid()));
            contrato.SetContratoId(contrato.ContratoId);

            var idsAgregados = IdsAgregados.Crear(
                comando.AgenteInmobiliarioId,
                comando.ClienteId
                );

            contrato.SetIdsDeAgregados(idsAgregados);

            List<DomainEvent> listDomain = contrato.getUncommittedChanges();
            await SaveEvents(listDomain);

        }

        public async Task AgregarFiadorParaContrato(AgregarFiadorParaContratoComando comando)
        {

            var contratoChange = new ContratoChangeApply();
            var listDomainEvents = await GetEventsByAggregateID(comando.ContratoId);
            var contratoId = ContratoId.Of(Guid.Parse(comando.ContratoId));
            var contratoGenerado = contratoChange.CreateAggregate(listDomainEvents, contratoId);

            Fiador nuevoFiador = new Fiador(FiadorId.Of(Guid.NewGuid()));
            var datosPersonales = DatosPersonales.Crear(
                        comando.Nombre,
                        comando.Telefono
                     );

            nuevoFiador.SetDatosPersonales(datosPersonales);

            contratoGenerado.SetAgregarFiadorParaContrato(nuevoFiador);
            List<DomainEvent> domainEvents = contratoGenerado.getUncommittedChanges();
            await SaveEvents(domainEvents);

        }

        public async Task AgregarEstadoParaContrato(AgregarEstadoParaContratoComando comando)
        {


         var contratoChange = new ContratoChangeApply();
            var listDomainEvents = await GetEventsByAggregateID(comando.ContratoId);
            var contratoId = ContratoId.Of(Guid.Parse(comando.ContratoId));
            var contratoGenerado = contratoChange.CreateAggregate(listDomainEvents, contratoId);

            Estado nuevoEstado = new Estado(EstadoId.Of(Guid.NewGuid()));
            var aprobado = Aprobado.Crear(
                        comando.Aprobado
                     );
            var fecha = FechaExpedicion.Crear(
                        comando.FechaExpiracion
                     );


            nuevoEstado.SetAprobado(aprobado);
            nuevoEstado.SetFechaExpedicion(fecha);


            contratoGenerado.SetAgregarEstadoParaContrato(nuevoEstado);
            List<DomainEvent> domainEvents = contratoGenerado.getUncommittedChanges();
            await SaveEvents(domainEvents);


        }

         public async Task<Contrato> ObtenerContratoPorId(string contratoId)
        {
            var contratoChangeApply = new ContratoChangeApply();
            var listDomainEvents = await GetEventsByAggregateID(contratoId);
            var contratoID = ContratoId.Of(Guid.Parse(contratoId));
            var contratoChangeApplyt = contratoChangeApply.CreateAggregate(listDomainEvents, contratoID);

            return contratoChangeApplyt;
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

                  

                    case ContratoCreado contratoCreado:
                        stored.EventBody = JsonConvert.SerializeObject(contratoCreado);
                        break;

                    case IdsDeAgregadosAgregados contratoCreado:
                        stored.EventBody = JsonConvert.SerializeObject(contratoCreado);
                        break;

                    case FiadorParaContratoAgregado fiadorParaContratoAgregado:
                        stored.EventBody = JsonConvert.SerializeObject(fiadorParaContratoAgregado);
                        break;


                    case EstadoParaContratoAgregado estadoParaContratoAgregado:
                        stored.EventBody = JsonConvert.SerializeObject(estadoParaContratoAgregado);
                        break;


                }
                await _storedEventRepository.AddAsync(stored);

            }

            await _storedEventRepository.SaveChangesAsync();

        }

        public async Task<List<DomainEvent>> GetEventsByAggregateID(string aggregateId)
        {
            var listadoStoredEvents = await _storedEventRepository.GetEventsByAggregateId(aggregateId);

            if (listadoStoredEvents == null)
                throw new ArgumentException("No existe el Id del agregado en la base de datos");

            return listadoStoredEvents.Select(ev =>
            {
                string nombre = $"AdquisicionDePropiedad.DDD.Domain.ContratoAggregate.Eventos.{ev.StoredName},  AdquisicionDePropiedad.DDD.Domain";
                Type tipo = Type.GetType(nombre);
                DomainEvent eventoParseado = (DomainEvent)JsonConvert.DeserializeObject(ev.EventBody, tipo);
                return eventoParseado;

            }).ToList();
        }

       
    }
}
