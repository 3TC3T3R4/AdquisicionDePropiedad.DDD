using AdquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Eventos;
using AdquisicionDePropiedad.DDD.Domain.Comunes;
using AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Entities;
using AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.ValueObjects.ObjetoDeValorAgenteInmobiliario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Entities.Reebuild
{
    public class AgenteInmobiliarioRebuild
    {
        public AgenteInmobiliario CreateAggregate(List<DomainEvent> ev, AgenteInmobiliarioId agenteInmobiliarioId)
        {
           AgenteInmobiliario agenteInmobiliario = new(agenteInmobiliarioId);
           
            //Add sector to set your VOs
            //if (ev.Find(e => e.GetType() == typeof(SectorParaAgenteInmobiliarioAgregado)) is SectorParaAgenteInmobiliarioAgregado sectorAgregadoEvento)
            //{
            //    agenteInmobiliario.SetAgregarSectorParaAgenteInmobiliario(sectorAgregadoEvento.Sector);
            //}
            //Add classroom registration to set your VOs
            //if (ev.Find(e => e.GetType() == typeof(ClassroomRegistrationAdded)) is ClassroomRegistrationAdded classroomRegistrationAddedEvent)
            //{
            //    student.SetClassroomRegistrationAggregate(classroomRegistrationAddedEvent.ClassroomRegistration);
            //}
            ev.ForEach(evento =>
            {
                switch (evento)
                {
                    //Agente
                    case DatosPersonalesAgregados datosPersonalesAgregados:
                        agenteInmobiliario.SetDatosPersonales(datosPersonalesAgregados.DatosPersonales);
                        break;
                    //account
                    //case SectorParaAgenteInmobiliarioAgregado sectorParaAgenteInmobiliarioAgregado:
                    //    agenteInmobiliario.Sector.SetPuntoCardinal(sectorParaAgenteInmobiliarioAgregado.PuntoCardinal);
                    //    break;
            
                }
            });
            return agenteInmobiliario;
        }



    }
}
