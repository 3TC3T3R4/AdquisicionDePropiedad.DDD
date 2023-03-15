using AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.ValueObjects.ObjetoDeValorBienes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Comandos
{
    public  class AgregarBienParaAgenteInmobiliarioComando
    {

        public string AgenteInmobiliarioId { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }

        public AgregarBienParaAgenteInmobiliarioComando(string agenteInmobiliarioId, string tipo, string descripcion, int precio)
        {
            AgenteInmobiliarioId = agenteInmobiliarioId;
            Tipo = tipo;
            Descripcion = descripcion;
            Precio = precio;
        }
    }
}
