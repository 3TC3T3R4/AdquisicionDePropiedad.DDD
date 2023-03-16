using AdquisicionDePropiedad.DDD.Domain.CasosDeUso.Entradas;
using AdquisicionDePropiedad.DDD.Domain.ContratoAggregate.Comandos;
using AquisicionDePropiedad.DDD.Domain.ContratoAggregate.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AdquisicionDePropiedad.DDD.API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ContratoControlador
    {


        private readonly lContratoCasoDeUso _casoDeUso;
        


        public ContratoControlador(lContratoCasoDeUso CrearContratoCasoDeUso)
        {
            _casoDeUso = CrearContratoCasoDeUso;
        }

        [HttpPost]
        public async Task PostContrato(CrearContratoComando comando)
        {
            await _casoDeUso.CrearContrato(comando);
        }


        [HttpPost("agregarFiador")]
        public async Task agregarFiadorParaContrato(AgregarFiadorParaContratoComando comando)
        {
            await _casoDeUso.AgregarFiadorParaContrato(comando);
        }

        [HttpPost("agregarEstado")]
        public async Task agregarEstadoParaContrato(AgregarEstadoParaContratoComando comando)
        {
            await _casoDeUso.AgregarEstadoParaContrato(comando);
        }

        [HttpGet("{id}")]
        public async Task<Contrato> ObtenerContratoPorId(string id)
        {
           var contrato = await _casoDeUso.ObtenerContratoPorId(id);
            return contrato;
        }


    }
}
