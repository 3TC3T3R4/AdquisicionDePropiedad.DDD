using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Comandos
{
   public class ActualizarSectorComando
    {

        public string AgenteInmobiliarioId { get; set; }
        public string Sentido { get; set; }



    }
}
