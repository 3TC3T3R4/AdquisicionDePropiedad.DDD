using AdquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.CasosDeUso.Entradas
{
    public interface lAgenteInmobiliarioCasoDeUso
    {
        Task CrearAgenteInmobiliario(CrearAgenteInmobiliarioComando comando);

        Task AgregarSectorParaAgenteInmobiliario(AgregarSectorParaAgenteInmobiliarioComando comando);

        Task AgregarBienParaAgenteInmobiliario(AgregarBienParaAgenteInmobiliarioComando comando);


    }
}
