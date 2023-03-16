using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.ClienteAggregate.Comandos
{
    public class AgregarSolicitudParaClienteComando
    {

        public string ClienteId { get; set; }
        public string Motivo { get; set; }

        public AgregarSolicitudParaClienteComando(string clienteId, string motivo)
        {
            ClienteId = clienteId;
            Motivo = motivo;
        }
    }
}
