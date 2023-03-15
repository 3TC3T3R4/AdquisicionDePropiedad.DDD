using AdquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Eventos;
using AdquisicionDePropiedad.DDD.Domain.Comunes;
using AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Entities;
using AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.ValueObjects.ObjetoDeValorAgenteInmobiliario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Entities
{
    public class AgenteInmobiliarioChangeApply
    {

        public AgenteInmobiliario CreateAggregate(List<DomainEvent> ev, AgenteInmobiliarioId id)
        {
            AgenteInmobiliario agente = new AgenteInmobiliario(id);
            ev.ForEach(evento =>
            {
                switch (evento)
                {

                    case DatosPersonalesAgregados datosPersonalesAgregados:
                        agente.SetDatosPersonalesDelAgregado(datosPersonalesAgregados.DatosPersonales);
                        break;

                    case SectorParaAgenteInmobiliarioAgregado sectorParaAgenteInmobiliarioAgregado:
                        agente.SetSectorDelAgregado(sectorParaAgenteInmobiliarioAgregado.Sector);
                        break;
                    
                    case BienParaAgenteInmobiliarioAgregado bienParaAgenteInmobiliarioAgregado:
                        agente.SetBienDelAgregado(bienParaAgenteInmobiliarioAgregado.Bienes);
                        break;

                    //case SectorParaAgenteInmobiliarioAgregado sectorParaAgenteInmobiliarioAgregado:
                    //    agente.SetSectorDelAgregado(sectorParaAgenteInmobiliarioAgregado.Sector);
                    //    break;


                }

            });
            return agente;
        }



    }
}
