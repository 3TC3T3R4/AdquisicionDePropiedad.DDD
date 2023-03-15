using AdquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Comandos;
using AdquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Eventos;
using AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Entities;
using AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.ValueObjects.ObjetoDeValorAgenteInmobiliario;
using AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.ValueObjects.ObjetoDeValorSector;
using AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.ValueObjects.ObjetoDeValorBienes;
using AdquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Entities;
using AdquisicionDePropiedad.DDD.Domain.Comunes;
using Newtonsoft.Json;
using AdquisicionDePropiedad.DDD.Domain.CasosDeUso.Entradas;
using AdquisicionDePropiedad.DDD.Domain.Genericos;

namespace AdquisicionDePropiedad.DDD.Domain.CasosDeUso.CasosDeUso
{

    public class AgenteInmobiliarioCasoDeUso : lAgenteInmobiliarioCasoDeUso
    {

        private readonly IStoredEventRepository<StoredEvent> _storedEventRepository;
        public AgenteInmobiliarioCasoDeUso(IStoredEventRepository<StoredEvent> agenteInmobiliarioRepository)
        {
            _storedEventRepository = agenteInmobiliarioRepository;
        }

        public async Task AgregarSectorParaAgenteInmobiliario(AgregarSectorParaAgenteInmobiliarioComando comando)
        {
            var agenteInmobiliarioChange = new AgenteInmobiliarioChangeApply();
            var listDomainEvents = await GetEventsByAggregateID(comando.AgenteInmobiliarioId);

            var agenteInmobiliarioId = AgenteInmobiliarioId.Of(Guid.Parse(comando.AgenteInmobiliarioId));
            var agenteInmobiliarioGenerado = agenteInmobiliarioChange.CreateAggregate(listDomainEvents, agenteInmobiliarioId);

             Sector  nuevoSector = new Sector(SectorId.Of(Guid.NewGuid()));
            var puntoCardinal = PuntoCardinal.Crear(
                comando.Sentido
            );

            nuevoSector.SetPuntoCardinal(puntoCardinal);
        
            agenteInmobiliarioGenerado.SetAgregarSectorParaAgenteInmobiliario(nuevoSector);
            List<DomainEvent> domainEvents = agenteInmobiliarioGenerado.getUncommittedChanges();
            await SaveEvents(domainEvents);
        }


        public async Task AgregarBienParaAgenteInmobiliario(AgregarBienParaAgenteInmobiliarioComando comando)
        {
            var agenteInmobiliarioChange = new AgenteInmobiliarioChangeApply();
            var listDomainEvents = await GetEventsByAggregateID(comando.AgenteInmobiliarioId);

            var agenteInmobiliarioId = AgenteInmobiliarioId.Of(Guid.Parse(comando.AgenteInmobiliarioId));
            var agenteInmobiliarioGenerado = agenteInmobiliarioChange.CreateAggregate(listDomainEvents, agenteInmobiliarioId);

            Bienes nuevoBien = new Bienes(BienesId.Of(Guid.NewGuid()));
            var descripcion = Descripcion.Crear(
                comando.Descripcion
            );
            var tipo = Tipo.Crear(
               comando.Tipo
           ); 
            var precio = Precio.Crear(
                comando.Precio
            );

            nuevoBien.SetDescripcion(descripcion);
            nuevoBien.SetPrecio(precio);
            nuevoBien.SetTipo(tipo);

            agenteInmobiliarioGenerado.SetAgregarBieneParaAgenteInmobiliario(nuevoBien);
            List<DomainEvent> domainEvents = agenteInmobiliarioGenerado.getUncommittedChanges();
            await SaveEvents(domainEvents);
        }



        public async Task CrearAgenteInmobiliario(CrearAgenteInmobiliarioComando comando)
        {

            var agenteInmobiliario = new AgenteInmobiliario(AgenteInmobiliarioId.Of(Guid.NewGuid()));
            agenteInmobiliario.SetAgenteInmobiliarioId(agenteInmobiliario.AgenteInmobiliarioId);
            var datosPersonales = DatosPersonales.Crear(
                       comando.Nombre,
                       comando.Apellido,
                       comando.Edad,
                       comando.Genero
                    );

            agenteInmobiliario.SetDatosPersonales(datosPersonales); 
            List<DomainEvent> listDomain = agenteInmobiliario.getUncommittedChanges();
            await SaveEvents(listDomain);

         
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

                    case AgenteInmobiliarioCreado agenteInmobiliarioCreado:
                        stored.EventBody = JsonConvert.SerializeObject(agenteInmobiliarioCreado);
                        break;

                    case SectorParaAgenteInmobiliarioAgregado sectorParaAgenteInmobiliarioAgregado:
                        stored.EventBody = JsonConvert.SerializeObject(sectorParaAgenteInmobiliarioAgregado);
                        break;


                    case BienParaAgenteInmobiliarioAgregado bienParaAgenteInmobiliarioAgregado:
                        stored.EventBody = JsonConvert.SerializeObject(bienParaAgenteInmobiliarioAgregado);
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
                string nombre = $"AdquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Eventos.{ev.StoredName},  AdquisicionDePropiedad.DDD.Domain";
                Type tipo = Type.GetType(nombre);
                DomainEvent eventoParseado = (DomainEvent)JsonConvert.DeserializeObject(ev.EventBody, tipo);
                return eventoParseado;

            }).ToList();
        }


    }
}
