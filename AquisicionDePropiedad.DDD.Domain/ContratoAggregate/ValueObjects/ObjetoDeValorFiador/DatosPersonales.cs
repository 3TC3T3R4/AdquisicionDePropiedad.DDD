
namespace AquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorFiador
{
   public class DatosPersonales{

        public string Nombre { get; init; }
        public int Telefono { get; init; }



        public DatosPersonales(string nombre, int telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
        }

        public DatosPersonales() { }
        //create method
        public static DatosPersonales Crear(string nombre,int telefono)
        {
            Validate(nombre, telefono);
            return new DatosPersonales(nombre,telefono);
        }
        //validate method 
        public static void Validate(string nombre,  int telefono)
        {
            if (nombre.Equals(null))
            {
                throw new ArgumentNullException("Name cannot be null");
            }
            if (telefono.Equals(null))
            {
                throw new ArgumentNullException("Last name cannot be null");
            }
           
        }
    }
}
