using AdquisicionDePropiedad.DDD.Domain.ClienteAggregate.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasPatronAAA.Builder
{
    public class AgregarSolicitudComandoBuilder
    {
        private string _ClienteId { get; set; }
        private string _Motivo { get; set; }

        public AgregarSolicitudComandoBuilder conClienteId(string clienteId)
        {
            _ClienteId = clienteId;
            return this;
        }

        public AgregarSolicitudComandoBuilder ConMotivo(string motivo)
        {
            _Motivo = motivo;
            return this;
        }

        public AgregarSolicitudParaClienteComando Build()
        {
            return new AgregarSolicitudParaClienteComando(_ClienteId, _Motivo );
        }




    }
}
