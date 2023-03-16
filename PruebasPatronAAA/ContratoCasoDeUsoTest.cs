using AdquisicionDePropiedad.DDD.Domain.CasosDeUso.CasosDeUso;
using AdquisicionDePropiedad.DDD.Domain.CasosDeUso.Entradas;
using AdquisicionDePropiedad.DDD.Domain.ContratoAggregate.Comandos;
using AdquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorContrato;
using AdquisicionDePropiedad.DDD.Domain.Genericos;
using AquisicionDePropiedad.DDD.Domain.ContratoAggregate.Entities;
using AquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorContrato;
using Moq;
using PruebasPatronAAA.Builder;

namespace PruebasPatronAAA
{
    public class ContratoCasoDeUsoTest
    {
        private readonly Mock<IStoredEventRepository<StoredEvent>> _mockContratoRepositorio;
        public ContratoCasoDeUsoTest() {
            _mockContratoRepositorio = new();
        }

        [Fact]
        public async Task Crear_Contrato()
        {
            //Arrange
            _mockContratoRepositorio.Setup(repo => repo.AddAsync(It.IsAny<StoredEvent>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(GetStoredEvent());

            _mockContratoRepositorio.Setup(repo => repo.SaveChangesAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult<int>(200));

            //Act
            var useCase = new ContratoCasoDeUso(_mockContratoRepositorio.Object);

            await useCase.CrearContrato(GetContratoComando());

            //Assert
            _mockContratoRepositorio.Verify(r => r.AddAsync(It.IsAny<StoredEvent>(), It.IsAny<CancellationToken>()), Times.Exactly(2));

            _mockContratoRepositorio.Verify(r => r.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Exactly(1));
        }

        //[Fact]
        //public async Task AgregarFiadorAContrato()
        //{
        //    _mockContratoRepositorio.Setup(repo => repo.GetEventsByAggregateId(It.IsAny<string>()))
        //        .Returns(Task.FromResult(GetListStoredEvent()));

        //    _mockContratoRepositorio.Setup(repo => repo.AddAsync(It.IsAny<StoredEvent>(), It.IsAny<CancellationToken>()))
        //        .ReturnsAsync(GetStoredEvent());

        //    _mockContratoRepositorio.Setup(repo => repo.SaveChangesAsync(It.IsAny<CancellationToken>()))
        //        .Returns(Task.FromResult(200));

        //    var useCase = new ContratoCasoDeUso(_mockContratoRepositorio.Object);

        //    await useCase.AgregarFiadorParaContrato(GetFiadorAgregadoComando());

        //    _mockContratoRepositorio.Verify(r => r.AddAsync(It.IsAny<StoredEvent>(), It.IsAny<CancellationToken>()), Times.Exactly(2));

        //    _mockContratoRepositorio.Verify(r => r.GetEventsByAggregateId(It.IsAny<string>()), Times.Once);

        //    _mockContratoRepositorio.Verify(r => r.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Exactly(1));
        //}


        //crear contrato

        private StoredEvent GetStoredEvent() =>
            new StoredEventBuilder()
                .WithStoredId(777)
                .WithStoredName("ContratoCreado")
                .WithAggregateId("Aggregate1")
                .WithEventBody("{\"Type\":\"contrato.creado\",\"IdsAgregados\":{\"IdAgente\":\"string\",\"IdCliente\":\"string\"}}")
                .Build();
        private CrearContratoComando GetContratoComando() =>
           new CrearContratoComandoBuilder()
               .ConIdAgente("8asdfasd8f4as5")
               .ConIdCliente("94dsaf4s5d4f5")
               .Build();


        ////agregar entidad hija fiador
        //private List<StoredEvent> GetListStoredEvent() =>
        //   new()
        //   {
        //        new StoredEventBuilder()
        //        .WithStoredId(565)
        //        .WithStoredName("FiadorAgregado")
        //        .WithAggregateId("c11d7c42-10d5-4e77-ac50-f1ec4dc8d388")
        //        .WithEventBody("{\"Type\":\"contrato.fiador.agregado\",\"DatosPersonales\":{\"Nombre\":\"string\",\"Apellido\":\"string\",\"Edad\":0,\"Genero\":\"string\"}}")
        //        .Build()

        //   };

        //private AgregarFiadorParaContratoComando GetFiadorAgregadoComando() =>
        //new AgregarFiadorComandoBuilder()
        //        .ConId("445")
        //        .ConNombre("Andres")
        //        .ConTelefono(564789)
        //        .Build();

    }


    //agregar entidad hija Estado
//    private List<StoredEvent> GetListStoredEvent() =>
//       new()
//       {
//                new StoredEventBuilder()
//                .WithStoredId(565)
//                .WithStoredName("EstadoAgregado")
//                .WithAggregateId("c11d7c42-10d5-4e77-ac50-f1ec4dc8d388")
//                .WithEventBody("{\"Type\":\"contrato.estado.agregado\",\"DatosPersonales\":{\"Nombre\":\"string\",\"Apellido\":\"string\",\"Edad\":0,\"Genero\":\"string\"}}")
//                .Build()

//       };

//    private AgregarFiadorParaContratoComando GetFiadorAgregadoComando() =>
//    new AgregarFiadorComandoBuilder()
//            .ConId("445")
//            .ConNombre("Andres")
//            .ConTelefono(564789)
//            .Build();

//}







}


