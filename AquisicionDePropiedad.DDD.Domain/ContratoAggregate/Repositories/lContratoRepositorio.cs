using AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Entities;
using AquisicionDePropiedad.DDD.Domain.ClienteAggregate.Entities;
using AquisicionDePropiedad.DDD.Domain.ClienteAggregate.ValueObjects.ObjetosDeValorSolicitud;
using AquisicionDePropiedad.DDD.Domain.ContratoAggregate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Domain.ContratoAggregate.Repositories
{
    public interface lContratoRepositorio
    {
        Task agregarContrato(Contrato contrato);
        //Task actualizarAngenteInmobilario(AgenteInmobilario agenteInmobilario);
        Task actualizarCliente(Cliente cliente);
        Task eliminarContrato(Contrato Id);




    }
}
