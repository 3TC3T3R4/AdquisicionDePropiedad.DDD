using AdquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Comandos;
using AdquisicionDePropiedad.DDD.Domain.CasosDeUso.Entradas;
using Microsoft.AspNetCore.Mvc;

namespace AdquisicionDePropiedad.DDD.API.Controllers
{


    [ApiController]
    [Route("[controller]")]
    public class AgenteInmobiliarioControlador : ControllerBase
    {


         private readonly lAgenteInmobiliarioCasoDeUso _casoDeUso;

        public AgenteInmobiliarioControlador(lAgenteInmobiliarioCasoDeUso CrearAgenteInmobiliarioCasoDeUso)
        {
            _casoDeUso = CrearAgenteInmobiliarioCasoDeUso;
        }

        [HttpPost]
        public async Task Post(CrearAgenteInmobiliarioComando comando)
        {
            await _casoDeUso.CrearAgenteInmobiliario(comando);    
        }


        [HttpPost("agregarSector")]
        public async Task agregarSectorParaAgenteInmobiliario(AgregarSectorParaAgenteInmobiliarioComando comando)
        {
            await _casoDeUso.AgregarSectorParaAgenteInmobiliario(comando);
        }

        [HttpPost("agregarBien")]
        public async Task agregarBienParaAgenteInmobiliario(AgregarBienParaAgenteInmobiliarioComando comando)
        {
            await _casoDeUso.AgregarBienParaAgenteInmobiliario(comando);
        }




    }
}
