using AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Entities;
using AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.ValueObjects.ObjetoDeValorBienes;
using AquisicionDePropiedad.DDD.Domain.ClienteAggregate.Entities;
using AquisicionDePropiedad.DDD.Domain.ClienteAggregate.ValueObjects.ObjetosDeValorSolicitud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Domain.ClienteAggregate.Repositories
{
    public interface lClienteRepositorio
    {

        Task agregarCliente(Cliente cliente);

        Task agregarContacto(Contacto contacto);

        Task agregarSolicitud(Solicitud solicitud);

        Task actualizarSolicitud(Solicitud Id);

        Task actualizarSolicitudMotivo(Motivo motivo);



    }
}
