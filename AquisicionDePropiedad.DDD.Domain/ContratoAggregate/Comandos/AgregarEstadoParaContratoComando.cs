using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.ContratoAggregate.Comandos
{
    public class AgregarEstadoParaContratoComando
    {
        public string ContratoId { get; set; }
        public bool Aprobado { get; set; }
        public DateTime FechaExpiracion { get; set; }


        public AgregarEstadoParaContratoComando(string contratoId, bool aprobado,DateTime fechaExpiracion) {

            ContratoId = contratoId;
            Aprobado = aprobado;
            FechaExpiracion = fechaExpiracion;



        }



    }
}
