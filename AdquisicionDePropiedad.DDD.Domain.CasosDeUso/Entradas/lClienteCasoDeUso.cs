using AdquisicionDePropiedad.DDD.Domain.ClienteAggregate.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.CasosDeUso.Entradas
{
   public interface lClienteCasoDeUso
    {
        Task CrearCliente(CrearClienteComando comando);

        Task AgregarContactoParaCliente(AgregarContactoParaClienteComando comando);

        Task AgregarSolicitudParaCliente(AgregarSolicitudParaClienteComando comando);



    }
}
