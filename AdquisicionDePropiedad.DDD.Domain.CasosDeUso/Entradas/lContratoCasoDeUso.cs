using AdquisicionDePropiedad.DDD.Domain.ClienteAggregate.Comandos;
using AdquisicionDePropiedad.DDD.Domain.ContratoAggregate.Comandos;
using AquisicionDePropiedad.DDD.Domain.ContratoAggregate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.CasosDeUso.Entradas
{
    public interface lContratoCasoDeUso
    {
        Task CrearContrato(CrearContratoComando comando);

        Task AgregarFiadorParaContrato(AgregarFiadorParaContratoComando comando);

        Task AgregarEstadoParaContrato(AgregarEstadoParaContratoComando comando);

        Task<Contrato> ObtenerContratoPorId(string contratoId);



    }
}
