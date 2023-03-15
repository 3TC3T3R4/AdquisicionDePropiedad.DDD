using AdquisicionDePropiedad.DDD.Domain.Comunes;
using AdquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Eventos;
using AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.ValueObjects.ObjetoDeValorAgenteInmobiliario;
using System.Text.Json.Serialization;

namespace AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Entities
{
    public  class AgenteInmobiliario : AggregateEvent<AgenteInmobiliarioId>
    {

        public AgenteInmobiliarioId AgenteInmobiliarioId { get; init; }

        public DatosPersonales DatosPersonales { get; private set; }

        public virtual Sector Sector { get; private set; }
        public virtual Bienes Bienes { get; private set; }

        public AgenteInmobiliario(AgenteInmobiliarioId agenteInmobiliarioID) : base(agenteInmobiliarioID)
        {
            this.AgenteInmobiliarioId = agenteInmobiliarioID;
        }

   
        
        // #region Metodos del agregado como manejador de eventos
        //Administrar el agregado
        public void SetAgenteInmobiliarioId(AgenteInmobiliarioId agenteInmobiliarioID)
        {
            AppendChange(new AgenteInmobiliarioCreado(agenteInmobiliarioID.ToString())); 
        }

        public void SetDatosPersonales(DatosPersonales datosPersonales)
        {

            AppendChange(new DatosPersonalesAgregados(datosPersonales));

        }
        public void SetAgregarSectorParaAgenteInmobiliario(Sector sector)
        {
            AppendChange(new SectorParaAgenteInmobiliarioAgregado(sector));
        }

        public void SetAgregarBieneParaAgenteInmobiliario(Bienes bienes)
        {
            AppendChange(new BienParaAgenteInmobiliarioAgregado(bienes));
        }


        public void SetDatosPersonalesDelAgregado(DatosPersonales datosPersonales) {

            this.DatosPersonales = datosPersonales;

        }

        public void SetBienDelAgregado(Bienes bienes)
        {
            this.Bienes = bienes;


        }


        public void SetSectorDelAgregado(Sector sector)
        {

            this.Sector = sector;

        }



    }
}
