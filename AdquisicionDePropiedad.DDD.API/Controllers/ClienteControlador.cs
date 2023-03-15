using AdquisicionDePropiedad.DDD.Domain.CasosDeUso.Entradas;
using AdquisicionDePropiedad.DDD.Domain.ClienteAggregate.Comandos;
using Microsoft.AspNetCore.Mvc;

namespace AdquisicionDePropiedad.DDD.API.Controllers
{


    [ApiController]
    [Route("[controller]")]
    public class ClienteControlador : ControllerBase
    {

        private readonly lClienteCasoDeUso _casoDeUso;

        public ClienteControlador(lClienteCasoDeUso CrearClienteCasoDeUso)
        {
            _casoDeUso = CrearClienteCasoDeUso;
        }

        [HttpPost]
        public async Task PostCliente(CrearClienteComando comando)
        {
            await _casoDeUso.CrearCliente(comando);
        }


        [HttpPost("agregarContacto")]
        public async Task agregarContactoParaCliente(AgregarContactoParaClienteComando comando)
        {
            await _casoDeUso.AgregarContactoParaCliente(comando);
        }

        [HttpPost("agregarSolicitud")]
        public async Task agregarSolicictudParaCliente(AgregarSolicitudParaClienteComando comando)
        {
            await _casoDeUso.AgregarSolicitudParaCliente(comando);
        }



    }
}
