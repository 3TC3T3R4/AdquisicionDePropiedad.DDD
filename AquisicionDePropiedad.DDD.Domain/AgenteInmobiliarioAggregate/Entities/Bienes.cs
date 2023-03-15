using AdquisicionDePropiedad.DDD.Domain.Comunes;
using AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.ValueObjects.ObjetoDeValorBienes;
using AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.ValueObjects.ObjetoDeValorSector;


namespace AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Entities
{
    public class Bienes : Entity<BienesId>
    {


        public Tipo Tipo { get; private set; }

        public Descripcion Descripcion { get; private set; }


        public Precio Precio { get; private set; }


        public Bienes(BienesId id) : base(id) { }

        public void SetTipo(Tipo tipo)
        {

           this.Tipo = tipo;

        }

        public void SetDescripcion(Descripcion descripcion)
        {

           this.Descripcion = descripcion;

        }



        public void SetPrecio(Precio precio)
        {

            this.Precio = precio;

        }



    }
}
