using AdquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Comandos;
using AdquisicionDePropiedad.DDD.Domain.CasosDeUso.CasosDeUso;
using AdquisicionDePropiedad.DDD.Domain.CasosDeUso.Entradas;
using AdquisicionDePropiedad.DDD.Domain.Genericos;
using Moq;
using PruebasPatronAAA.Builder;


namespace PruebasPatronAAA
{
    public class AgenteInmobiliarioCasoDeUsoTest
    {

        private readonly Mock<IStoredEventRepository<StoredEvent>> _mockAgenteInmobiliarioRepositorio;

        public AgenteInmobiliarioCasoDeUsoTest()
        {
            _mockAgenteInmobiliarioRepositorio = new();
        }


        [Fact]
        public async Task Crear_Cliente()
        {
            //Arrange
            _mockAgenteInmobiliarioRepositorio.Setup(repo => repo.AddAsync(It.IsAny<StoredEvent>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(GetStoredEvent());

            _mockAgenteInmobiliarioRepositorio.Setup(repo => repo.SaveChangesAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult<int>(200));

            //Act
            var useCase = new AgenteInmobiliarioCasoDeUso(_mockAgenteInmobiliarioRepositorio.Object);

            await useCase.CrearAgenteInmobiliario(GetAgenteInmobiliarioComando());

            //Assert
            _mockAgenteInmobiliarioRepositorio.Verify(r => r.AddAsync(It.IsAny<StoredEvent>(), It.IsAny<CancellationToken>()), Times.Exactly(2));

            _mockAgenteInmobiliarioRepositorio.Verify(r => r.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Exactly(1));
        }


        private StoredEvent GetStoredEvent() =>
            new StoredEventBuilder()
                .WithStoredId(898)
                .WithStoredName("AgenteCreado")
                .WithAggregateId("Aggregate3")
               .WithEventBody("{\"Type\":\"datosPersonales.agregados\",\"DatosPersonales\":{\"Nombre\":\"string\",\"Apellido\":\"string\",\"Edad\":0,\"Genero\":\"string\"}}")
                .Build();


        private CrearAgenteInmobiliarioComando GetAgenteInmobiliarioComando() =>
           new CrearAgenteInmobiliarioComandoBuilder()
               .ConNombre("Estevan")
                .ConApellido("Doe")
                .ConEdad(25)
                .ConGenero("Male")
               .Build();


    }
}
