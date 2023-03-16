using AdquisicionDePropiedad.DDD.Domain.CasosDeUso.CasosDeUso;
using AdquisicionDePropiedad.DDD.Domain.CasosDeUso.Entradas;
using AdquisicionDePropiedad.DDD.Domain.ClienteAggregate.Comandos;
using AdquisicionDePropiedad.DDD.Domain.ContratoAggregate.Comandos;
using AdquisicionDePropiedad.DDD.Domain.Genericos;
using Moq;
using PruebasPatronAAA.Builder;

namespace PruebasPatronAAA
{

    public class ClienteCasoDeUsoTest
    {

        private readonly Mock<IStoredEventRepository<StoredEvent>> _mockClienteRepositorio;

        public ClienteCasoDeUsoTest()
        {
            _mockClienteRepositorio = new();
        }


        [Fact]
        public async Task Crear_Cliente()
        {
            //Arrange
            _mockClienteRepositorio.Setup(repo => repo.AddAsync(It.IsAny<StoredEvent>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(GetStoredEvent());

            _mockClienteRepositorio.Setup(repo => repo.SaveChangesAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult<int>(200));

            //Act
            var useCase = new ClienteCasoDeUso(_mockClienteRepositorio.Object);

            await useCase.CrearCliente (GetClienteComando());

            //Assert
            _mockClienteRepositorio.Verify(r => r.AddAsync(It.IsAny<StoredEvent>(), It.IsAny<CancellationToken>()), Times.Exactly(2));

            _mockClienteRepositorio.Verify(r => r.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Exactly(1));
        }
        private CrearClienteComando GetClienteComando() =>
           new CrearClienteComandoBuilder()
               .ConNombre("John")
                .ConApellido("Doe")
                .ConEdad(25)
                .ConGenero("Male")
               .Build();


        [Fact]
        public async Task AgregarSolicitudACliente()
        {
            _mockClienteRepositorio.Setup(repo => repo.GetEventsByAggregateId(It.IsAny<string>()))
                .Returns(Task.FromResult(GetListStoredEvent()));

            _mockClienteRepositorio.Setup(repo => repo.AddAsync(It.IsAny<StoredEvent>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(GetStoredEvent());

            _mockClienteRepositorio.Setup(repo => repo.SaveChangesAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(200));

            var useCase = new ClienteCasoDeUso(_mockClienteRepositorio.Object);

            await useCase.AgregarSolicitudParaCliente(GetClienteAgregadoComando());

            _mockClienteRepositorio.Verify(r => r.AddAsync(It.IsAny<StoredEvent>(), It.IsAny<CancellationToken>()), Times.Exactly(2));

            _mockClienteRepositorio.Verify(r => r.GetEventsByAggregateId(It.IsAny<string>()), Times.Once);

            _mockClienteRepositorio.Verify(r => r.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Exactly(1));
        }

        private StoredEvent GetStoredEvent() =>
            new StoredEventBuilder()
                .WithStoredId(88)
                .WithStoredName("ClienteCreado")
                .WithAggregateId("aec3ba9d-8ce2-44e1-92b1-22d06763b092")
               .WithEventBody("{\"Type\":\"datosPersonales.agregados\",\"DatosPersonales\":{\"Nombre\":\"string\",\"Apellido\":\"string\",\"Edad\":0,\"Genero\":\"string\"}}")
                .Build();


        //agregar entidad hija solicitud
        private List<StoredEvent> GetListStoredEvent() =>
           new()
           {
                new StoredEventBuilder()
               .WithStoredId(1)
                .WithStoredName("ClienteCreado")
                .WithAggregateId("aec3ba9d-8ce2-44e1-92b1-22d06763b092")
               .WithEventBody("{\"Type\":\"datosPersonales.agregados\",\"DatosPersonales\":{\"Nombre\":\"string\",\"Apellido\":\"string\",\"Edad\":0,\"Genero\":\"string\"}}")
                .Build(),

                 new StoredEventBuilder()
               .WithStoredId(2)
                .WithStoredName("DatosPersonalesAgregados")
                .WithAggregateId("aec3ba9d-8ce2-44e1-92b1-22d06763b092")
               .WithEventBody("{\"Type\":\"datosPersonales.agregados\",\"DatosPersonales\":{\"Nombre\":\"string\",\"Apellido\":\"string\",\"Edad\":0,\"Genero\":\"string\"}}")
                .Build(),

                new StoredEventBuilder()
                .WithStoredId(3)
                .WithStoredName("SolicitudParaClienteAgregado")
                .WithAggregateId("aec3ba9d-8ce2-44e1-92b1-22d06763b092")
                .WithEventBody("{\"Type\":\"cliente.solicitud.agregado\",\"Solicitud\":{\"Motivo\":{\"motivo\":\"Negocio\"}}}")
                .Build()
           };

        private AgregarSolicitudParaClienteComando GetClienteAgregadoComando() =>
        new AgregarSolicitudComandoBuilder()
                .conClienteId("c11d7c42-10d5-4e77-ac50-f1ec4dc8d388")
                .ConMotivo("MontarNegocio")
                .Build();


    }
}
