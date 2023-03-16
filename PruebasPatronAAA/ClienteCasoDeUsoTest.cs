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


        private StoredEvent GetStoredEvent() =>
            new StoredEventBuilder()
                .WithStoredId(88)
                .WithStoredName("ClienteCreado")
                .WithAggregateId("Aggregate2")
               .WithEventBody("{\"Type\":\"datosPersonales.agregados\",\"DatosPersonales\":{\"Nombre\":\"string\",\"Apellido\":\"string\",\"Edad\":0,\"Genero\":\"string\"}}")
                .Build();


        private CrearClienteComando GetClienteComando() =>
           new CrearClienteComandoBuilder()
               .ConNombre("John")
                .ConApellido("Doe")
                .ConEdad(25)
                .ConGenero("Male")
               .Build();

    }
}
